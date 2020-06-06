using LiteDB;

namespace BulkMailSender.Core.Model
{
    public class SmtpConfig
    {
      public ObjectId Id { get; set; }
      
      public string SmtpHost { get; set; }
      public int Port { get; set; }
      public string Username { get; set; }
      public string Password { get; set; }
      public bool UseCredential { get; set; }
      public int RitardoSecondiInvio { get; set; }
      public string SenderAddress { get; set; }
      public string SenderDisplayName { get; set; }
    }
}
