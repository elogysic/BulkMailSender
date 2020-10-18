using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulkMailSender.Core.Model;
using BulkMailSender.Dialogs;
using BulkMailSender.Helpers;

namespace BulkMailSender.Views
{
  public partial class RecipientiView : ViewBase
  {
    private BindingList<Destinatario> _elencoDestintari;

    public RecipientiView()
    {
      InitializeComponent();
      dataGridView1.AutoGenerateColumns = false;

      treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
      treeView1.HideSelection = false;

      timer1.Interval = 500;
      timer1.Start();
    }

    protected override void AfterInitialized()
    {
      base.AfterInitialized();

      var recipienti = AppRepo.GetRecipienti().OrderBy(x => x.Nome.ToLower());
      AddNodes(recipienti);
      if (treeView1.Nodes.Count > 0)
        treeView1.SelectedNode = treeView1.Nodes[0];
      else
        treeView1_AfterSelect(this, null);

    }

    private void btnNuova_Click(object sender, EventArgs e)
    {
      var inp = new InputBox();
      var res = inp.Execute(this, "Immettere il nome del nuovo recpiente di destinatari:","",true);
      if (res)
      {
        var node = CreaNuovoRecipiente(inp.InputText);
        treeView1.SelectedNode = node;
      }

    }

    private TreeNode CreaNuovoRecipiente(string nome)
    {
      var recipiente = AppRepo.AddRecipiente(nome);
      AddNodes(new[] {recipiente});
      return treeView1.Nodes.OfType<TreeNode>().Single(x => x.Tag == recipiente.Id);
    }

    private void AddNodes(IEnumerable<RecipienteDestinatari> recipienti)
    {
      treeView1.BeginUpdate();
      try
      {
        foreach (var recipiente in recipienti)
        {
          var node = new TreeNode(recipiente.Nome) {Tag = recipiente.Id};
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
      btnAddDestinatario.Enabled = treeView1.SelectedNode != null;
      btnRimuoviDuplicati.Enabled = treeView1.SelectedNode != null;

      if (treeView1.SelectedNode == null)
      {
        _elencoDestintari = new BindingList<Destinatario>(new List<Destinatario>());
        dataGridView1.DataSource = _elencoDestintari;
      }
      else
      {
        var list = AppRepo.GetDestinatari((string) treeView1.SelectedNode.Tag).OrderBy(x => x.Address?.ToLower()).ToList();

        _elencoDestintari = new BindingList<Destinatario>(list);
        dataGridView1.DataSource = _elencoDestintari;
      }
    }

    private void btnAddDestinatario_Click(object sender, EventArgs e)
    {
      var dest = new Destinatario()
      {
        Id = Guid.NewGuid().ToString("N"),
        IdRecipiente = CurrentRecipientId,
        Nome = "",
        Address = ""
      };
      var dlg = new EditDestinatario();
      if (dlg.Execute(this, ref dest))
      {
        _elencoDestintari.Add(dest);
        AppRepo.AddDestinatario(dest);
      }
    }

    public string CurrentRecipientId
    {
      get
      {
        if (treeView1.SelectedNode == null)
          return null;
        return (string) treeView1.SelectedNode.Tag;
      }
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 2)
      {
        if (e.RowIndex >= 0)
        {
          var d = _elencoDestintari[e.RowIndex];
          AppRepo.RemoveDestinatario(d.Id);
          _elencoDestintari.RemoveAt(e.RowIndex);
        }
      }
    }

    private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
    {
      //MessageBox.Show("modificato: "+e.RowIndex);
    }


    private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
    {
      if (dataGridView1.IsCurrentRowDirty)
      {
        var d = _elencoDestintari[e.RowIndex];
        AppRepo.UpdateDestinatario(d);
        
      }
    }

    private void btnEliminaRecipiente_Click(object sender, EventArgs e)
    {
      var id = CurrentRecipientId;
      if (!string.IsNullOrWhiteSpace(id))
      {
        if (ConfirmBox.Execute("Sicuro di voler eliminar eil recipiente?", "Conferma"))
        {
          AppRepo.RemoveRecipiente(id);
          var n = treeView1.SelectedNode;
          treeView1.SelectedNode = n.NextNode ?? n.PrevNode;
          n.Remove();
          if (treeView1.SelectedNode == null)
            treeView1_AfterSelect(this,null);
        }
      }
    }

    private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
    {
      if (e.Node == null) return;

      // if treeview's HideSelection property is "True", 
      // this will always returns "False" on unfocused treeview
      var selected = (e.State & TreeNodeStates.Selected) == TreeNodeStates.Selected;
      var unfocused = !e.Node.TreeView.Focused;

      // we need to do owner drawing only on a selected node
      // and when the treeview is unfocused, else let the OS do it for us
      if (selected && unfocused)
      {
        var font = e.Node.NodeFont ?? e.Node.TreeView.Font;
        e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
        TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, SystemColors.HighlightText, TextFormatFlags.GlyphOverhangPadding);
      }
      else
      {
        e.DrawDefault = true;
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (_elencoDestintari == null || !_elencoDestintari.Any())
        lbNumero.Text = "Nessun destinatario";
      else
      {
        lbNumero.Text = $"In lista ci sono {_elencoDestintari.Count} destinatari.";
      }

      btnEliminaSelezionati.Enabled = dataGridView1.SelectedRows.Count > 0;
    }

    private void btnRimuoviDuplicati_Click(object sender, EventArgs e)
    {
      var gruppi = _elencoDestintari.GroupBy(x => x.Address.ToLower(), x => x);
      var gruppiDoppi = gruppi.Where(x => x.Count() > 1);
      if (!gruppiDoppi.Any())
        MessageBox.Show("Non ci sono duplicati.");
      else
      {
        var msg = $"Ci sono in tutto {gruppiDoppi.Sum(x => x.Count()-1)} duplicati." + Environment.NewLine +
                  "Procedere con l'eliminazione?";
        var res = ConfirmBox.Execute(msg, "COnferma eliminazione duplicati");
        if (res)
        {
          dataGridView1.SuspendLayout();
          try
          {
            foreach (var g in gruppiDoppi)
            {
              var daRimuovere = g.Skip(1).ToList();
              foreach (var d in daRimuovere)
              {
                _elencoDestintari.Remove(d);
                AppRepo.RemoveDestinatario(d.Id);
              }
            }
          }
          finally
          {
            dataGridView1.ResumeLayout();
          }
        }
      }
    }

    private void btnImporta_Click(object sender, EventArgs e)
    {
      var ofd = new OpenFileDialog();
      ofd.DefaultExt = "*.txt";
      ofd.CheckFileExists = true;
      ofd.Multiselect = false;
      var dr = ofd.ShowDialog(this);
      if (dr == DialogResult.OK)
      {
        var l = new List<Destinatario>();
        var lines = File.ReadAllLines(ofd.FileName);
        foreach (var line in lines)
        {
          if (string.IsNullOrWhiteSpace(line))
            continue;
          var fields = line.Split(';');
          if (string.IsNullOrWhiteSpace(fields[0]))
            continue;
          var d = new Destinatario()
          {
            IdRecipiente = CurrentRecipientId,
            Id = Guid.NewGuid().ToString("N"),
            Address = fields[0].Trim(),
          };
          if (fields.Length > 1)
            d.Nome = fields[1].Trim();
          AppRepo.AddDestinatario(d);
          l.Add(d);
        }
        List<Destinatario> list = _elencoDestintari.ToList();
        list.AddRange(l);
        _elencoDestintari = new BindingList<Destinatario>(list);
        dataGridView1.DataSource = _elencoDestintari;
      }
    }

    private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
    {
      var d = e.Row.DataBoundItem as Destinatario;
      if (d != null)
        MessageBox.Show("elimina " + d.Address);
    }

    private void btnEliminaSelezionati_Click(object sender, EventArgs e)
    {
      if (dataGridView1.SelectedRows.Count > 0)
      {
        if (!ConfirmBox.Execute("Si conferma l'eliminazione di " + dataGridView1.SelectedRows.Count + " email?",
          "Conferma"))
          return;
      }
      foreach (DataGridViewRow row in dataGridView1.SelectedRows)
      {
        var d = row.DataBoundItem as Destinatario;
        if (d != null)
        {
          AppRepo.RemoveDestinatario(d.Id);
          _elencoDestintari.Remove(d);
        }
      }
    }

    private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
    {
      if (string.IsNullOrWhiteSpace(e.Label))
        e.CancelEdit = true;
      else
      {
        if (!string.IsNullOrWhiteSpace(CurrentRecipientId))
          AppRepo.UpdateRecipienteNome(CurrentRecipientId,e.Label);
      }
    }
  }
}