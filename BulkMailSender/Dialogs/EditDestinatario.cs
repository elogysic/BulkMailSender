using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulkMailSender.Core.Model;

namespace BulkMailSender.Dialogs
{
  public partial class EditDestinatario : Form
  {
    public EditDestinatario()
    {
      InitializeComponent();
    }


    public bool Execute(IWin32Window owner, ref Destinatario dest)
    {
      tbNome.Text = dest.Nome;
      tbMail.Text = dest.Address;
      tbMail.Focus();
      var dr = ShowDialog(owner);
      if (dr == DialogResult.OK)
      {
        dest.Nome = tbNome.Text.Trim();
        dest.Address = tbMail.Text.Trim();
      }

      return dr == DialogResult.OK;
    }

    private void btnSalva_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(tbMail.Text))
        MessageBox.Show("Mail obbligatoria.");
      else
        DialogResult = DialogResult.OK;
    }

    private void btnAnnulla_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
    }
  }
}
