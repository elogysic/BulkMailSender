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
  public partial class InputBox : Form
  {
    private bool _required;

    public InputBox()
    {
      InitializeComponent();
    }

    public string InputText => tbText.Text;
    public bool Execute(IWin32Window owner, string label, string caption = "", bool required = false, string defaultText = "")
    {
      _required = required;
      Text = caption;
      lbTitle.Text = label;
      tbText.Text = defaultText;
      var dr = ShowDialog(owner);
      if (dr != DialogResult.OK)
        tbText.Text = "";
      return dr == DialogResult.OK;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (_required && string.IsNullOrWhiteSpace(tbText.Text))
        MessageBox.Show("Testo obbligatorio.","Avvertimento",MessageBoxButtons.OK,MessageBoxIcon.Warning);
      else
        DialogResult = DialogResult.OK;
    }
  }
}
