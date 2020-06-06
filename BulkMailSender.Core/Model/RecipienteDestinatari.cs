using System.Collections.Generic;
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
    public string Mail { get; set; }
  }


  public enum EMailState
  {
    DaInviare,
    InviataConSuccesso,
    ErroreInInvio,
    Archiviata,
  }
}
