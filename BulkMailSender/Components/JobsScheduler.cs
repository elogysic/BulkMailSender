
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Web;
using System.Web.UI.WebControls;
using BulkMailSender.Core;
using BulkMailSender.Core.Model;
using Timer = System.Timers.Timer;

namespace BulkMailSender.Components
{
  public class JobsScheduler : IJobsScheduler,IDisposable
  {
    private readonly IAppRepository _repo;
    private readonly IAppService _appSvc;
    private JobDescriptor _job;
    private Timer _timer;
    private static DateTime? _lastSendTime;
    private SmtpConfig _smtpCfg;
    const double DELTA = 1000;

    public JobsScheduler(IAppRepository repo, IAppService appSvc)
    {
      _repo = repo;
      _appSvc = appSvc;
    }

    public ESchedulerState State { get; private set; }

    public string CurrentJobId => _job?.JobId;

    public void StartJob(string jobId, SmtpConfig cfg)
    {
      _smtpCfg = cfg;
      if (_job != null)
        StopJob();

      var timeout = DateTime.Now.AddSeconds(15);
      while (_timer != null && _timer.Enabled)
      {
        if (timeout <= DateTime.Now)
          break;
        Thread.Sleep(200);
      }

      _timer?.Dispose();
      _timer = null;

      try
      {
        _job = new JobDescriptor() {JobId = jobId, IsRunning = true};
        _timer = new Timer(DELTA);
        _timer.Elapsed += (sender, e) => OnTimedEvent(sender, e, this);
        _timer.Start();
        State = ESchedulerState.Running;
      }
      catch (Exception exc)
      {
        State = ESchedulerState.Stopped;
        _timer?.Dispose();
        _timer = null;
        throw;
      }
    }

    public void StopJob()
    {
      State = ESchedulerState.Stopping;
      if (_job != null)
        _job.IsRunning = false;

      if (!_timer?.Enabled == false)
        State = ESchedulerState.Stopped;
    }

    public event SentMailEventHandler OnSentMailEvent;

    private static void OnTimedEvent(object source, ElapsedEventArgs e, JobsScheduler scheduler)
    {
      if (!scheduler._job.IsRunning)
      {
        scheduler._timer.Stop();
        scheduler.State = ESchedulerState.Stopped;
      }
      else
      {
        scheduler.SendNextMail();
      }
    }

    private void SendNextMail()
    {
      if (_smtpCfg.RitardoSecondiInvio > 0 
          && _lastSendTime.HasValue 
          && _lastSendTime.Value.AddSeconds(_smtpCfg.RitardoSecondiInvio) > DateTime.Now)
        return;

      var mail = _appSvc.GeNextMailToSend(_job.JobId);
      if (mail == null)
      {
        StopJob();
      }
      else
      {
        mail.UltimoTentativoInvio = DateTime.Now;
        try
        {
          //todo: send
          mail.State = EMailState.InviataConSuccesso;
        }
        catch (Exception exc)
        {
          mail.State = EMailState.ErroreInInvio;
          mail.MessaggioErrore = exc.Message;
        }
        _appSvc.ChangeMailState(mail);
        OnSentMailEvent?.Invoke(this, new SentMailEventArgs() { MailSend = mail });
        _lastSendTime = DateTime.Now;
      }
    }


    public void Dispose()
    {
      StopJob();
      _timer?.Dispose();
    }
  }
}
