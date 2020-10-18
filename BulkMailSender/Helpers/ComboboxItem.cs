namespace BulkMailSender.Helpers
{
  public class ComboboxItem<T>
  {
    public ComboboxItem()
    {
    }

    public ComboboxItem(T value, string text)
    {
      Text = text;
      Value = value;
    }

    public string Text { get; set; }
    public T Value { get; set; }

    public override string ToString()
    {
      return Text;
    }
  }
}