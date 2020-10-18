using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulkMailSender.Core.Model;

namespace BulkMailSender.Components
{
  public interface IAppService
  {
  //  GetSelectedRecipientId();
    void SetStateProvider(IStateProvider stateProvider);
    void AddSelectedRecipient(string currentJobId);
    IEnumerable<Destinatario> GetDestinatariDelRecipienteCorrente();
    MailToSend GeNextMailToSend(string jobJobId);
    void ChangeMailState(MailToSend mail);

    Mail GetMailCorrente();
  }
}
