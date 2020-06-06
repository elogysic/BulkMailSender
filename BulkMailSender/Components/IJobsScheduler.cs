using System;
using BulkMailSender.Core.Model;

namespace BulkMailSender.Components
{
  public class SentMailEventArgs
  {
    public MailToSend MailSend { get; set; }
  }
  public delegate void SentMailEventHandler(object sender, SentMailEventArgs args);

  public interface IJobsScheduler:IDisposable
  {
    string CurrentJobId { get; }
    ESchedulerState State { get;  }

    void StartJob(string jobId, SmtpConfig cfg);
    void StopJob();

    event SentMailEventHandler OnSentMailEvent;
  }

}