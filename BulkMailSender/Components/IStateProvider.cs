namespace BulkMailSender.Components
{
  public interface IStateProvider
  {
    string GetCurrentMailId();
    string GetCurrentRecipientId();
  }
}