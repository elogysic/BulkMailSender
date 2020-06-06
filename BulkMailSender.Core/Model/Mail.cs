using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace BulkMailSender.Core.Model
{
  public class Mail
  {
    public string Id{ get; set; }

    public string Nome { get; set; }
    public string Subject { get; set; }
    public string HtmlBody { get; set; }
    public string PlaintTextBody { get; set; }
    public DateTime DataCreazione { get; set; }
  }
}
