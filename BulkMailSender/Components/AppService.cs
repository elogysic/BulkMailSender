using System;
using System.Collections.Generic;
using System.Linq;
using BulkMailSender.Core;
using BulkMailSender.Core.Model;

namespace BulkMailSender.Components
{
  public class AppService : IAppService
  {
    private readonly IAppRepository _appRepo;
    private IStateProvider _stateProvider;

    public AppService(IAppRepository appRepo)
    {
      _appRepo = appRepo;
    }

    public void SetStateProvider(IStateProvider stateProvider)
    {
      _stateProvider = stateProvider;
    }

    public void AddSelectedRecipient(string currentJobId)
    {
      var currentRecipient = _stateProvider.GetCurrentRecipientId();
      if (string.IsNullOrWhiteSpace(currentRecipient))
        return ;
      throw new NotImplementedException();
    }

    public IEnumerable<Destinatario> GetDestinatariDelRecipienteCorrente()
    {
      var idRecipiente = _stateProvider.GetCurrentRecipientId();
      if (string.IsNullOrWhiteSpace(idRecipiente))
        return new List<Destinatario>();

      return _appRepo.GetDestinatari(idRecipiente);
    }

    public MailToSend GeNextMailToSend(string jobJobId)
    {
      return _appRepo.GetMailsDelJob(jobJobId, EMailState.DaInviare).FirstOrDefault();
    }

    public void ChangeMailState(MailToSend mail)
    {
      _appRepo.ChangeMailState(mail);
    }
  }
}