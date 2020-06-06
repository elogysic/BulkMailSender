using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkMailSender.Helpers
{
  public static class ConfirmBox
  {
    public static  bool Execute(string text, string caption)
    {
      var dr = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
      return dr == DialogResult.Yes;
    }
  }
}
