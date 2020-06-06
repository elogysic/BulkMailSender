using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulkMailSender.Core;
using BulkMailSender.Core.Model;
using BulkMailSender.Dialogs;
using BulkMailSender.Smtp;
using mshtml;

namespace BulkMailSender.Views
{
  public partial class SmptView : ViewBase
  {
    private SmtpConfig _smtpCfg;

    public SmptView()
    {
      InitializeComponent();
    }

    protected override void AfterInitialized()
    {
      base.AfterInitialized();

      _smtpCfg = AppRepo.LoadSmtpConfig();
      if (_smtpCfg == null)
      {
        _smtpCfg = new SmtpConfig()
        {
          Port = 25
        };
      }

      tbSender.Text = _smtpCfg.SenderAddress;
      tbSmtpHost.Text = _smtpCfg.SmtpHost;
      nbPort.Value = _smtpCfg.Port;
      tbUsername.Text = _smtpCfg.Username;
      tbPassword.Text = _smtpCfg.Password;
      cbUseCredential.Checked = _smtpCfg.UseCredential;
      nbRitardoSecondi.Value = _smtpCfg.RitardoSecondiInvio;
    }

    private void btnSalva_Click(object sender, EventArgs e)
    {
      CtrlToModel();
      AppRepo.SaveSmtpConfig(_smtpCfg);
    }

    private void CtrlToModel()
    {
      _smtpCfg.SenderAddress = tbSender.Text;
      _smtpCfg.SmtpHost = tbSmtpHost.Text;
      _smtpCfg.Port = (int) nbPort.Value;
      _smtpCfg.Username = tbUsername.Text;
      _smtpCfg.Password = tbPassword.Text;
      _smtpCfg.UseCredential = cbUseCredential.Checked;
      _smtpCfg.RitardoSecondiInvio = (int) nbRitardoSecondi.Value;
    }

    private void btnTestConnection_Click(object sender, EventArgs e)
    {
      //https://stackoverflow.com/questions/1633391/testing-smtp-server-is-running-via-c-sharp

      var res = ValidateCredentials(tbUsername.Text, tbPassword.Text, tbSmtpHost.Text, _smtpCfg.Port, false);
      if (res)
        MessageBox.Show("Connessione avvenuta con successo.", "Esito", MessageBoxButtons.OK,
          MessageBoxIcon.Information);
      else
        MessageBox.Show("Connessione fallita.", "Esito", MessageBoxButtons.OK,
          MessageBoxIcon.Error);
    }

    private void btnTestMail_Click(object sender, EventArgs e)
    {
      var dlg = new InputBox();
      var res = dlg.Execute(this, "Immetti un destinatario", "Test send mail", true);
      if (res)
      {
        CtrlToModel();
        var mailer = new SmartMailer();
        mailer.Configure(_smtpCfg);
        try
        {
          mailer.SendEmail(dlg.InputText,"Mail di test","Questo è un <b>esempio</b> di corpo mail html.</br>Inviato con BulkMailSender application.");
        }
        catch (Exception exception)
        {
          MessageBox.Show(exception.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    public static bool ValidateCredentials(string login, string password, string server, int port, bool enableSsl)
    {
      SmtpConnectorBase connector;
      if (enableSsl)
        connector = new SmtpConnectorWithSsl(server, port);
      else
        connector = new SmtpConnectorWithoutSsl(server, port);

      if (!connector.CheckResponse(220))
        return false;

      connector.SendData($"HELO {Dns.GetHostName()}{SmtpConnectorBase.EOF}");
      if (!connector.CheckResponse(250))
        return false;

      connector.SendData($"AUTH LOGIN{SmtpConnectorBase.EOF}");
      if (!connector.CheckResponse(334))
        return false;

      connector.SendData(Convert.ToBase64String(Encoding.UTF8.GetBytes($"{login}")) + SmtpConnectorBase.EOF);
      if (!connector.CheckResponse(334))
        return false;

      connector.SendData(Convert.ToBase64String(Encoding.UTF8.GetBytes($"{password}")) + SmtpConnectorBase.EOF);
      if (!connector.CheckResponse(235))
        return false;

      return true;
    }
  }
}
