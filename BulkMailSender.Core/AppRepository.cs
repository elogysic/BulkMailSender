using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using BulkMailSender.Core.Model;
using LiteDB;

namespace BulkMailSender.Core
{
  public class AppRepository : IAppRepository
  {
    private readonly string _dbPath;

    public AppRepository(string dbPath)
    {
      _dbPath = Path.Combine(dbPath, "BulkMailSender.db");
    }

    #region SMTP
    public SmtpConfig LoadSmtpConfig()
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<SmtpConfig>(nameof(SmtpConfig));
        return col.FindAll().FirstOrDefault();
      }
    }

    public void SaveSmtpConfig(SmtpConfig cfg)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<SmtpConfig>(nameof(SmtpConfig));
        col.DeleteAll();
        cfg.Id = ObjectId.NewObjectId();
        col.Insert(cfg);
      }
    }
    #endregion

    #region RECIPIENTI

    public IEnumerable<RecipienteDestinatari> GetRecipienti()
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<RecipienteDestinatari>(nameof(RecipienteDestinatari));
        return col.FindAll().OrderBy(x => x.Nome).ToList();
      }
    }

    public RecipienteDestinatari AddRecipiente(string nome)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<RecipienteDestinatari>(nameof(RecipienteDestinatari));
        var rec = new RecipienteDestinatari() { Nome = nome };
        rec.Id = Guid.NewGuid().ToString("N");
        col.Insert(rec);
        return rec;
      }
    }

    public void RemoveRecipiente(string idRecipiente)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var colrecipienti = db.GetCollection<RecipienteDestinatari>(nameof(RecipienteDestinatari));
        var col = db.GetCollection<Destinatario>(nameof(Destinatario));
        var n = col.DeleteMany(x => x.IdRecipiente == idRecipiente);
        colrecipienti.Delete(idRecipiente);
      }
    }

    public void UpdateRecipienteNome(string id, string nome)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<RecipienteDestinatari>(nameof(RecipienteDestinatari));
        var r = col.FindById(id);
        if (r != null)
        {
          r.Nome = nome;
          col.Update(r);
        }
      }
    }

    public IEnumerable<Destinatario> GetDestinatari(string idRecipiente)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<Destinatario>(nameof(Destinatario));
        return col.Query().Where(x => x.IdRecipiente == idRecipiente).OrderBy(x => x.Mail.ToLower()).ToList();
      }
    }

    public void AddDestinatario(Destinatario dest)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var colrecipienti = db.GetCollection<RecipienteDestinatari>(nameof(RecipienteDestinatari));
        var rec = colrecipienti.FindById(dest.IdRecipiente);
        if (rec == null)
          throw new ApplicationException("Recipiente non trovato");
        var col = db.GetCollection<Destinatario>(nameof(Destinatario));
        col.Insert(dest);
      }
    }

    public void UpdateDestinatario(Destinatario destinatario)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<Destinatario>(nameof(Destinatario));
        col.Update(destinatario.Id, destinatario);
      }
    }

    public void RemoveDestinatario(string id)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<Destinatario>(nameof(Destinatario));
        col.Delete(id);
      }
    }

    #endregion

    #region MAIL

    public IEnumerable<Mail> GetMails()
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<Mail>(nameof(Mail));
        return col.FindAll().ToList();
      }
    }

    public Mail AddMail(string nome)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<Mail>(nameof(Mail));
        var rec = new Mail { Nome = nome, Subject = ".....", Id = Guid.NewGuid().ToString("N") };
        col.Insert(rec);
        return rec;
      }
    }

    public void RemoveMail(string idMail)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<Mail>(nameof(Mail));
        var n = col.Delete(idMail);
      }
    }

    public Mail GetMailById(string id)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<Mail>(nameof(Mail));
        return col.FindById(id);
      }
    }

    public void UpdateMailNome(string idMail, string nome)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<Mail>(nameof(Mail));
        var theMail = col.FindById(idMail);
        if (theMail != null)
        {
          theMail.Nome = nome;
          col.Update(theMail);
        }
      }
    }

    public void UpdateMail(string idMail, string subj, string html)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<Mail>(nameof(Mail));
        var mail = col.FindById(idMail);
        if (mail != null)
        {
          mail.Subject = subj;
          mail.HtmlBody = html;
          col.Update(mail);
        }
      }
    }

    #endregion

    #region JOB

    public IEnumerable<SenderJob> GetJobs()
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<SenderJob>(nameof(SenderJob));
        return col.FindAll().ToList();
      }
    }

    public SenderJob AddSenderJob(string nome)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<SenderJob>(nameof(SenderJob));
        var job = new SenderJob() { Nome = nome };
        job.Id = Guid.NewGuid().ToString("N");
        col.Insert(job);
        return job;
      }
    }

    public void UpdateSenderJobNome(string jobId, string nome)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<SenderJob>(nameof(SenderJob));
        var r = col.FindById(jobId);
        if (r != null)
        {
          r.Nome = nome;
          col.Update(r);
        }
      }
    }

    public List<MailToSend> GetMailsDelJob(string jobId)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<MailToSend>(nameof(MailToSend));
        return col.Query().Where(x => x.IdJob == jobId).OrderBy(x => x.Mail.ToLower()).ToList();
      }
    }

    public List<MailToSend> GetMailsDelJob(string jobId, EMailState state)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<MailToSend>(nameof(MailToSend));
        return col.Query().Where(x => x.IdJob == jobId && x.State == state)
          .OrderBy(x => x.Mail.ToLower()).ToList();
      }
    }

    public void UpdateMailsToSendOfJob(string idJob, IEnumerable<MailToSend> elencoMailInInvio)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<MailToSend>(nameof(MailToSend));
        col.DeleteMany(x => x.IdJob == idJob);
        foreach (var mailToSend in elencoMailInInvio)
          col.Insert(mailToSend);
      }
    }

    public void ChangeMailState(MailToSend mail)
    {
      using (var db = new LiteDatabase(_dbPath))
      {
        var col = db.GetCollection<MailToSend>(nameof(MailToSend));
        var m = col.FindById(mail.Id);
        if (m != null)
        {
          m.State = mail.State;
          if (mail.UltimoTentativoInvio.HasValue)
            m.UltimoTentativoInvio = mail.UltimoTentativoInvio;
          if (m.State == EMailState.ErroreInInvio)
            m.MessaggioErrore = mail.MessaggioErrore;
          col.Update(m);
        }
      }
    }

    #endregion
  }
}