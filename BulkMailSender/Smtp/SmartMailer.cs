using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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


    public void SendEmail(string recipientEmail, string recipientName, string subject, string bodyHtml, string bodyPlainText)
    {
      var msg = new MailMessage
      {
        From = new MailAddress(_cfg.SenderAddress, _cfg.SenderDisplayName),
        //IsBodyHtml = true,
        //Body = bodyHtml,
        //BodyEncoding = Encoding.UTF8,
        //SubjectEncoding = Encoding.UTF8,
        //HeadersEncoding = Encoding.UTF8,
        Subject = subject
      };
      if (string.IsNullOrWhiteSpace(recipientName) || recipientName?.ToLower() == recipientEmail?.ToLower())
        msg.To.Add(recipientEmail);
      else
        msg.To.Add(new MailAddress(recipientEmail, recipientName));

      var plainView = AlternateView.CreateAlternateViewFromString(bodyPlainText, null, MediaTypeNames.Text.Plain/* "text/plain"*/);
      msg.AlternateViews.Add(plainView);

      var htmlView = AlternateView.CreateAlternateViewFromString(bodyHtml, null, MediaTypeNames.Text.Html);
      msg.AlternateViews.Add(htmlView);

      SmtpClient.Send(msg);
    }

}
}
