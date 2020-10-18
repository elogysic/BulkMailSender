using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace BulkMailSender.Core.Model
{
  public class RecipienteDestinatari
  {
    public string Id { get; set; }
    public string Nome { get; set; }
  }

  public class Destinatario
  {
    public string Id { get; set; }
    public string IdRecipiente { get; set; }

    public string Nome { get; set; }
    public string Address { get; set; }
  }


  public enum EMailState
  {
    [Description("Da inviare")]
    DaInviare,
    [Description("Inviata con successo")]
    InviataConSuccesso,
    [Description("Errore in invio")]
    ErroreInInvio,
    [Description("Archiviata")]
    Archiviata,
  }
}
