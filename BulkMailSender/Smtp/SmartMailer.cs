using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using BulkMailSender.Core.Model;

namespace BulkMailSender.Smtp
{
  public class SmartMailer
  {
    private SmtpConfig _cfg;

    public SmartMailer()
    {
      
    }

    public SmtpClient SmtpClient { get; set; }

    public void Configure(SmtpConfig cfg)
    {
      _cfg = cfg;
      this.SmtpClient = new SmtpClient(cfg.SmtpHost)
      {
        UseDefaultCredentials = cfg.UseCredential,
        Credentials = new NetworkCredential(cfg.Username, cfg.Password)
      };
    }


    public void SendEmail(string recipientEmail, string subject, string bodyHtml)
    {
      var msg = new MailMessage
      {
        From = new MailAddress(_cfg.SenderAddress, _cfg.SenderDisplayName),
        IsBodyHtml = true,
        Body = bodyHtml,
        BodyEncoding = Encoding.UTF8,
        SubjectEncoding = Encoding.UTF8,
        HeadersEncoding = Encoding.UTF8,
        Subject = subject
      };
      msg.To.Add(recipientEmail);
      SmtpClient.Send(msg);
    }

}
}
