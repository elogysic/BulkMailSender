using System;

namespace BulkMailSender.Core.Model
{
  public class MailToSend
  {
    public string Id { get; set; }
    public string IdJob { get; set; }
    public string Nome { get; set; }
    public string Mail { get; set; }
    public DateTime? UltimoTentativoInvio{ get; set; }

    public string UltimoTentativoInvioStr => UltimoTentativoInvio == null
      ? "---"
      : UltimoTentativoInvio.Value.ToString("dd/MMM/yyyy HH:mm:ss");

    public string MessaggioErrore { get; set; }
    public EMailState? State { get; set; }
    public bool Selezionato { get; set; }

    public string StatoStr
    {
      get
      {
        switch (State)
        {
          case EMailState.DaInviare:
            return "da inviare";
          case EMailState.InviataConSuccesso:
            return "Inviata";
          case EMailState.ErroreInInvio:
            return "Errore";
          case EMailState.Archiviata:
            return "Archiviata";
            break;
          case null:
            return "";
          default:
            throw new ArgumentOutOfRangeException();
        }
      }
    }
  }
}