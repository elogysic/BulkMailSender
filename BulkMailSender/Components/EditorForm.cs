using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BulkMailSender.Components;
using BulkMailSender.Dialogs;
using mshtml;

namespace BulkMailSender.Components
{
  public partial class EditorForm : UserControl
  {
    private string _filename = null;

    public EditorForm()
    {
      InitializeComponent();
      editor.Tick += new Editor.TickDelegate(editor_Tick);
    }

    #region interface

    public void New()
    {
      newToolStripMenuItem_Click(this, EventArgs.Empty);
    }

    public void SetHtmlText(string html)
    {
      editor.Html = html;
      Text = editor.DocumentTitle;
    }


    public string GetHtmlText()
    {
      return editor.DocumentText;
    }

    public string GetPlainText()
    {
      return editor.BodyText;
    }
    #endregion

    private void editor_Tick()
    {
      undoToolStripMenuItem.Enabled = editor.CanUndo();
      redoToolStripMenuItem.Enabled = editor.CanRedo();
      cutToolStripMenuItem.Enabled = editor.CanCut();
      copyToolStripMenuItem.Enabled = editor.CanCopy();
      pasteToolStripMenuItem.Enabled = editor.CanPaste();
      imageToolStripMenuItem.Enabled = editor.CanInsertLink();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //            Close();
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _filename = null;
      Text = null;
      editor.BodyHtml = string.Empty;
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (_filename == null)
      {
        if (!SaveFileDialog())
          return;
      }
      SaveFile(_filename);
    }

    private bool SaveFileDialog()
    {
      using (SaveFileDialog dlg = new SaveFileDialog())
      {
        dlg.AddExtension = true;
        dlg.DefaultExt = "htm";
        dlg.Filter = "HTML files (*.html;*.htm)|*.html;*.htm";
        DialogResult res = dlg.ShowDialog(this);
        if (res == DialogResult.OK)
        {
          _filename = dlg.FileName;
          return true;
        }
        else
          return false;
      }
    }

    private void SaveFile(string filename)
    {
      using (StreamWriter writer = File.CreateText(filename))
      {
        writer.Write(editor.DocumentText);
        writer.Flush();
        writer.Close();
      }
    }

    private void LoadFile(string filename)
    {
      using (StreamReader reader = File.OpenText(filename))
      {
        editor.Html = reader.ReadToEnd();
        Text = editor.DocumentTitle;
      }
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog dlg = new OpenFileDialog())
      {
        dlg.Filter = "HTML files (*.html;*.htm)|*.html;*.htm";
        DialogResult res = dlg.ShowDialog(this);
        if (res == DialogResult.OK)
        {
          _filename = dlg.FileName;
        }
        else
          return;
      }
      LoadFile(_filename);
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (SaveFileDialog())
        SaveFile(_filename);
    }

    private void findToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (SearchDialog dlg = new SearchDialog(editor))
      {
        dlg.ShowDialog(this);
      }
    }

    private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      editor.SelectAll();
    }

    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      editor.Cut();
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      editor.Copy();
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      editor.Paste();
    }

    private void undoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      editor.Undo();
    }

    private void redoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      editor.Redo();
    }

    private void textToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //MessageBox.Show(this, editor.BodyText);***
      var dlg = new EditText();
      var s = editor.BodyText;
      if (dlg.Execute(this, true, ref s))
      {
        editor.Html = s;
      }
    }

    private void htmlToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //MessageBox.Show(this, editor.BodyHtml);
      var dlg = new EditText();
      var s = editor.Html;
      if (dlg.Execute(this, false, ref s))
      {
        editor.Html = s;
      }
    }

    private void printToolStripMenuItem_Click(object sender, EventArgs e)
    {
      editor.Print();
    }

    private void breakToolStripMenuItem_Click(object sender, EventArgs e)
    {
      editor.InsertBreak();
    }

    private void textToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      using (TextInsertForm form = new TextInsertForm(editor.BodyHtml))
      {
        form.ShowDialog(this);
        if (form.Accepted)
        {
          editor.BodyHtml = form.HTML;
        }
      }
    }

    private void paragraphToolStripMenuItem_Click(object sender, EventArgs e)
    {
      editor.InsertParagraph();
    }

    private void imageToolStripMenuItem_Click(object sender, EventArgs e)
    {
      editor.InsertImage();
    }

    private void emailToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //var form = new ConfigureSMTPForm(null, 25, SMTPAuthenticationType.UsernamePassword, null, null, true, editor.ToMailMessage());
      //form.ShowDialog();
    }

  }
}