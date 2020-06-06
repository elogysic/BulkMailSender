using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkMailSender.Dialogs
{
  public partial class EditText : Form
  {
    public EditText()
    {
      InitializeComponent();
      cbWordWrap_CheckedChanged(this,EventArgs.Empty);
    }


    public bool Execute(IWin32Window owner, bool readOnly, ref string html)
    {
      btnSalva.Visible = !readOnly;
      tbText.ReadOnly = readOnly;
      tbText.Text = html;
      var dr = ShowDialog(owner);
      if (dr == DialogResult.OK)
        html = tbText.Text;
      return (dr == DialogResult.OK);
    }

    private void cbWordWrap_CheckedChanged(object sender, EventArgs e)
    {
      tbText.WordWrap = cbWordWrap.Checked;
      tbText.ScrollBars = tbText.WordWrap ? ScrollBars.Vertical : ScrollBars.Both;
    }

    private void btnSalva_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;
    }

    private void btnAnnulla_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
    }
  }
}
