using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using BulkMailSender.Core.Model;

namespace BulkMailSender.Core
{
  public interface IAppRepository
  {
    SmtpConfig LoadSmtpConfig();
    void SaveSmtpConfig(SmtpConfig cfg);
    IEnumerable<RecipienteDestinatari> GetRecipienti();
    RecipienteDestinatari AddRecipiente(string nome);
    IEnumerable<Destinatario> GetDestinatari(string idRecipiente);
    void AddDestinatario(Destinatario dest);
    void RemoveDestinatario(string dId);
    void UpdateDestinatario(Destinatario destinatario);
    void RemoveRecipiente(string id);
    void RemoveMail(string id);
    IEnumerable<Mail> GetMails();
    Mail AddMail(string nome);
    Mail GetMailById(string selectedNodeTag);
    void UpdateMail(string idMail, string subj, string html, string plainText);
    void UpdateRecipienteNome(string currentRecipientId, string eLabel);
    void UpdateMailNome(string idMail, string eLabel);
    IEnumerable<SenderJob> GetJobs();
    SenderJob AddSenderJob(string nome);
    void UpdateSenderJobNome(string currentJobId, string eLabel);
    List<MailToSend> GetMailsDelJob(string currentJobId);
    List<MailToSend> GetMailsDelJob(string currentJobId,EMailState state);
    void UpdateMailsToSendOfJob(string idJob, IEnumerable<MailToSend> mails);
    void ChangeMailState(MailToSend mail);
    void RemoveJob(string id);
    void RemoveMailOfJob(string mId);
  }
}
