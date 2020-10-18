using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulkMailSender.Components;
using BulkMailSender.Core.Model;
using BulkMailSender.Dialogs;
using BulkMailSender.Helpers;

namespace BulkMailSender.Views
{
  public partial class JobsView : ViewBase
  {
    private IJobsScheduler _scheduler;
    //private BindingList<MailToSend> _elencoMailInInvio;
    private ObservableCollection<MailToSend> _elencoMailInInvio;

    public JobsView()
    {
      InitializeComponent();
      timer1.Enabled = true;
      dataGridView1.AutoGenerateColumns = false;
    }

    public override void OnClosing()
    {
      base.OnClosing();
      _scheduler.Dispose();
      _scheduler = null;
    }

    protected override void AfterInitialized()
    {
      base.AfterInitialized();

      cbStati.Items.Clear();
      foreach (EMailState v in Enum.GetValues(typeof(EMailState)))
        cbStati.Items.Add(new ComboboxItem<EMailState>(v,v.DescriptionAttr()));

      cbStati.SelectedIndex = 0;

      SetNodeSelectionEvidenceIntreeview(treeView1);

      _scheduler = new JobsScheduler(AppRepo,AppSvc);
      _scheduler.OnSentMailEvent += OnSentMailEvent;

      var jobs = AppRepo.GetJobs().OrderBy(x => x.Nome.ToLower());
      AddNodes(jobs);
      if (treeView1.Nodes.Count > 0)
        treeView1.SelectedNode = treeView1.Nodes[0];
      else
        treeView1_AfterSelect(this, null);
    }

    private void OnSentMailEvent(object sender, SentMailEventArgs args)
    {
      if (this.InvokeRequired)
      {
        Invoke((MethodInvoker)delegate
        {
          var m = _elencoMailInInvio.FirstOrDefault(x => x.Id == args.MailSend.Id);
          if (m != null)
          {
            m.UltimoTentativoInvio = args.MailSend.UltimoTentativoInvio;
            m.State = args.MailSend.State;
            dataGridView1.Refresh();
          }
          tbLog.AppendText($"{DateTime.Now:T} - inviata a [{args.MailSend.Address}] - "+args.MailSend.State.DescriptionAttr()
                           + Environment.NewLine);
        });
      }
    }

    private void AddNodes(IEnumerable<SenderJob> jobs)
    {
      treeView1.BeginUpdate();
      try
      {
        foreach (var job in jobs)
        {
          var node = new TreeNode(job.Nome) { Tag = job.Id };
          treeView1.Nodes.Add(node);
        }
      }
      finally
      {
        treeView1.EndUpdate();
      }
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (treeView1.SelectedNode == null)
      {
        _elencoMailInInvio = new ObservableCollection<MailToSend>(new List<MailToSend>());
        dataGridView1.DataSource = _elencoMailInInvio;
      }
      else
      {
        var list = AppRepo.GetMailsDelJob(CurrentJobId).OrderBy(x => x.Address?.ToLower()).ToList();

        var destinatari = AppSvc.GetDestinatariDelRecipienteCorrente();
        list.AddRange(destinatari.Select(x => new MailToSend()
        {
          Id = Guid.NewGuid().ToString("N"),
          Address = x.Address,
          Nome = x.Nome,
          IdJob = CurrentJobId
        }));

        var lookup = list.ToLookup(x => x.Address?.ToLower());
        lookup.Where(x => x.Count() > 1)
          .ToList()
          .ForEach(x =>
          {
            foreach (var m in x.Where(ss => ss.State == null))
              list.RemoveAll(k => k.Id == m.Id);
          });

        _elencoMailInInvio = new ObservableCollection<MailToSend>(list);
        dataGridView1.DataSource = _elencoMailInInvio;
      }
    }

    private void btnEliminaNonPresenti_Click(object sender, EventArgs e)
    {
      var destinatari = AppSvc.GetDestinatariDelRecipienteCorrente();
      List<MailToSend> toRemove = new List<MailToSend>();
      foreach (var mailToSend in _elencoMailInInvio)
      {
        if (!destinatari.Any(x => x.Address?.ToLower() == mailToSend.Address?.ToLower()))
          toRemove.Add(mailToSend);
      }

      foreach (var m in toRemove)
      {
        AppRepo.RemoveMailOfJob(m.Id);
        _elencoMailInInvio.Remove(m);
      }

      dataGridView1.DataSource = null;
      dataGridView1.DataSource = _elencoMailInInvio;
      //dataGridView1.Refresh();
    }


    private void btnNuovo_Click(object sender, EventArgs e)
    {
      var inp = new InputBox();
      var res = inp.Execute(this, "Immettere il nome del nuovo job di invio:", "", true);
      if (res)
      {
        var node = CreaNuovoSenderJob(inp.InputText);
        treeView1.SelectedNode = node;
      }
    }

    private TreeNode CreaNuovoSenderJob(string nome)
    {
      var job = AppRepo.AddSenderJob(nome);
      AddNodes(new[] { job });
      return treeView1.Nodes.OfType<TreeNode>().Single(x => x.Tag == job.Id);
    }

    private void btnEliminaJob_Click(object sender, EventArgs e)
    {
      var id = CurrentJobId;
      if (!string.IsNullOrWhiteSpace(id))
      {
        if (ConfirmBox.Execute("Sicuro di voler eliminare il job?", "Conferma"))
        {

          AppRepo.RemoveJob(id);
          var n = treeView1.SelectedNode;
          treeView1.SelectedNode = n.NextNode ?? n.PrevNode;
          n.Remove();
          if (treeView1.SelectedNode == null)
            treeView1_AfterSelect(this, null);
        }
      }
    }

    public string CurrentJobId
    {
      get
      {
        if (treeView1.SelectedNode == null)
          return null;
        return (string)treeView1.SelectedNode.Tag;
      }
    }

    private void btnStartStopJob_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrWhiteSpace(CurrentJobId))
      {
        if (_scheduler.State == ESchedulerState.Running)
        {
          _scheduler.StopJob();
        }
        else if (_scheduler.State == ESchedulerState.Stopped)
        {
          StartJob();
        }
      }

      btnStartStopJob.Enabled = false;
    }

    private void StartJob()
    {
      foreach (var mailToSend in _elencoMailInInvio.Where(x => !x.State.HasValue))
        mailToSend.State = EMailState.DaInviare;
      Update();
      tbLog.AppendText("Start job invio..."+Environment.NewLine);

      AppRepo.UpdateMailsToSendOfJob(CurrentJobId,_elencoMailInInvio);
      var cfg = AppRepo.LoadSmtpConfig();
      _scheduler.StartJob(CurrentJobId, cfg);
    }


    private void timer1_Tick(object sender, EventArgs e)
    {

      if (string.IsNullOrWhiteSpace(CurrentJobId))
      {
        label2.Text = "";
        btnStartStopJob.Text = "START";
        btnStartStopJob.Enabled = false;
        lbState.Text = "Nessun job selezionato";
        return;
      }

      if (_elencoMailInInvio != null)
      {
        label2.Text = $"Totale: {_elencoMailInInvio.Count}"
                      + $" - Da inviare: {_elencoMailInInvio.Count(x => x.State == EMailState.DaInviare)}"
                      + $" - Inviate: {_elencoMailInInvio.Count(x => x.State == EMailState.InviataConSuccesso)}"
                      + $" - Errore: {_elencoMailInInvio.Count(x => x.State == EMailState.ErroreInInvio)}"
                      + $" - Archiviate: {_elencoMailInInvio.Count(x => x.State == EMailState.Archiviata)}";
      }
      else
        label2.Text = "";

        var state = _scheduler.State;
      switch (state)
      {
        case ESchedulerState.Stopped:
          lbState.Text = "STOPPED";
          btnStartStopJob.Text = "START";
          btnStartStopJob.Enabled = true;
          break;
        case ESchedulerState.Running:
          lbState.Text = "RUNNING";
          btnStartStopJob.Text = "STOP";
          btnStartStopJob.Enabled = true;
          break;
        case ESchedulerState.Stopping:
          lbState.Text = "STOPPING";
          btnStartStopJob.Text = "STOPPING";
          btnStartStopJob.Enabled = false;
          break;
        default:
          throw new ArgumentOutOfRangeException();
      }
    }

    private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
    {

      if (string.IsNullOrWhiteSpace(e.Label))
        e.CancelEdit = true;
      else
      {
        if (!string.IsNullOrWhiteSpace(CurrentJobId))
          AppRepo.UpdateSenderJobNome(CurrentJobId, e.Label);
      }
    }

    #region Overrides of ViewBase

    public override void Selected()
    {
      base.Selected();
      treeView1_AfterSelect(this, null);
    }

    #endregion

    private void btnSetDaInviare_Click(object sender, EventArgs e)
    {
    }

    private void SetSelezionati(EMailState state)
    {
      foreach (var mailToSend in _elencoMailInInvio.Where(x => x.Selezionato))
      {
        mailToSend.State = state;
        AppSvc.ChangeMailState(mailToSend);
      }
      dataGridView1.Refresh();
    }

    private void btnSetState_Click(object sender, EventArgs e)
    {
      var o = (cbStati.SelectedItem as ComboboxItem<EMailState>).Value;
      SetSelezionati(o);

    }

    private void btnSelectAll_Click(object sender, EventArgs e)
    {
      foreach (var mailToSend in _elencoMailInInvio)
        mailToSend.Selezionato = true;
      dataGridView1.Refresh();
    }

    private void btnDeselectAll_Click(object sender, EventArgs e)
    {
      foreach (var mailToSend in _elencoMailInInvio)
        mailToSend.Selezionato = false;
      dataGridView1.Refresh();
    }

    private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      var mail = (dataGridView1.Rows[e.RowIndex].DataBoundItem as MailToSend);
      if (mail != null)
      {
        if (mail.State == EMailState.ErroreInInvio)
          MessageBox.Show("Errore: " + Environment.NewLine + mail.MessaggioErrore,"Info errore",
            MessageBoxButtons.OK,MessageBoxIcon.Error);
        else
          MessageBox.Show("Nessun errore riscontrato.","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
      }
    }

    private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (e.ColumnIndex == 3)
      {
        var s = (dataGridView1.Rows[e.RowIndex].DataBoundItem as MailToSend).State == EMailState.ErroreInInvio;
        var s2 = (dataGridView1.Rows[e.RowIndex].DataBoundItem as MailToSend).MessaggioErrore;
        if (s)
        {
          dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Bisque;
          dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
        }
        else
        {
          dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
          dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
        }
      }
    }

    private void btnClearLog_Click(object sender, EventArgs e)
    {
      tbLog.Clear();
    }
  }
}
