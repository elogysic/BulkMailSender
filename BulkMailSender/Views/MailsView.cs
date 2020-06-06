using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulkMailSender.Core.Model;
using BulkMailSender.Dialogs;
using BulkMailSender.Helpers;

namespace BulkMailSender.Views
{
  public partial class MailsView : ViewBase
  {
    private Components.EditorForm editorForm1;
    public MailsView()
    {
      InitializeComponent();
      treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
      treeView1.HideSelection = false;
    }

    protected override void AfterInitialized()
    {
      this.editorForm1 = new BulkMailSender.Components.EditorForm();
      panel3.Controls.Add(this.editorForm1);
      this.editorForm1.BackColor = System.Drawing.SystemColors.Control;
      this.editorForm1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.editorForm1.Location = new System.Drawing.Point(0, 0);
      this.editorForm1.Size = new System.Drawing.Size(500, 400);

      base.AfterInitialized();

      var mails = AppRepo.GetMails().OrderBy(x => x.Nome.ToLower());
      //var recipienti = AppRepo.GetRecipienti().OrderBy(x => x.Nome.ToLower());
      AddNodes(mails);
      if (treeView1.Nodes.Count > 0)
        treeView1.SelectedNode = treeView1.Nodes[0];
      else
        treeView1_AfterSelect(this, null);
    }

    private void AddNodes(IEnumerable<Mail> mails)
    {
      treeView1.BeginUpdate();
      try
      {
        foreach (var mail in mails)
        {
          var node = new TreeNode(mail.Nome) { Tag = mail.Id };
          treeView1.Nodes.Add(node);
        }
      }
      finally
      {
        treeView1.EndUpdate();
      }
    }

    private void btnNuova_Click(object sender, EventArgs e)
    {
      var inp = new InputBox();
      var res = inp.Execute(this, "Immettere il nome della nuova mail:","",true);
      if (res)
      {
        var node = CreaNuovaMail(inp.InputText);
        treeView1.SelectedNode = node;
      }
    }

    private TreeNode CreaNuovaMail(string nome)
    {
      var mail = AppRepo.AddMail(nome);
      AddNodes(new[] { mail });
      return treeView1.Nodes.OfType<TreeNode>().Single(x => x.Tag == mail.Id);
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

    private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
    {
      btnSalva_Click(this, EventArgs.Empty);
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (treeView1.SelectedNode == null)
      {
        editorForm1.New();
        btnSalva.Enabled = false;
        btnClear.Enabled = false;
        editorForm1.Enabled = false;
      }
      else
      {
        editorForm1.Enabled = true;
        btnSalva.Enabled = true;
        btnClear.Enabled = true;
        var mail = AppRepo.GetMailById(CurrentMailId);
        editorForm1.SetHtmlText(mail.HtmlBody);
        tbSubject.Text = mail.Subject;
      }
    }

    public string CurrentMailId
    {
      get
      {
        if (treeView1.SelectedNode == null)
          return null;
        return (string)treeView1.SelectedNode.Tag;
      }
    }

    private void btnSalva_Click(object sender, EventArgs e)
    {
      var html = editorForm1.GetHtmlText();
      var subj = tbSubject.Text;
      if (!string.IsNullOrWhiteSpace(CurrentMailId))
        AppRepo.UpdateMail(CurrentMailId, subj, html);
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      editorForm1.New();
    }

    private void btnEliminaMail_Click(object sender, EventArgs e)
    {
      var idMail = (string)treeView1.SelectedNode?.Tag;
      if (!string.IsNullOrWhiteSpace(idMail))
      {
        if (ConfirmBox.Execute("Sicuro di voler eliminare la mail?", "Conferma"))
        {
          AppRepo.RemoveMail(idMail);
          var n = treeView1.SelectedNode;
          treeView1.SelectedNode = n.NextNode ?? n.PrevNode;
          n.Remove();
          if (treeView1.SelectedNode == null)
          {
            treeView1_AfterSelect(this, null);
          }
        }
      }
    }

    private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
    {
      if (string.IsNullOrWhiteSpace(e.Label))
        e.CancelEdit = true;
      else
      {
        var idMail = (string)treeView1.SelectedNode?.Tag;
        if (!string.IsNullOrWhiteSpace(idMail))
          AppRepo.UpdateMailNome(idMail, e.Label);
      }
    }
  }
}
