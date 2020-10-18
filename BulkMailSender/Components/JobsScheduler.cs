
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Web;
using System.Web.UI.WebControls;
using BulkMailSender.Core;
using BulkMailSender.Core.Model;
using BulkMailSender.Smtp;
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
    private SmartMailer _mailer;
    private Mail _mailToSend;
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
      _mailer = new SmartMailer();
      _mailer.Configure(_smtpCfg);
      if (_job != null)
        StopJob();

      _mailToSend = _appSvc.GetMailCorrente();
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

    static readonly object _object = new object();

    private static void OnTimedEvent(object source, ElapsedEventArgs e, JobsScheduler scheduler)
    {

      if (!Monitor.TryEnter(_object))
        return;
      try
      {
        if (!scheduler._job.IsRunning)
        {
          scheduler._timer.Stop();
          scheduler.State = ESchedulerState.Stopped;
        }
        else
        {
          scheduler.SendNextMail();
          if (scheduler.MailTerminate())
          {
            scheduler.StopJob();
          }
        }
      }
      finally
      {
        Monitor.Exit(_object);
      }
    }


    private bool MailTerminate()
    {
      var mail = _appSvc.GeNextMailToSend(_job.JobId);
      return mail == null;
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
          _mailer.SendEmail(mail.Address, mail.Nome,_mailToSend.Subject,_mailToSend.HtmlBody, _mailToSend.PlaintTextBody);
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
