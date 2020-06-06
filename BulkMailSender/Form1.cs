using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulkMailSender.Components;
using BulkMailSender.Core;
using BulkMailSender.Views;

namespace BulkMailSender
{
  public partial class Form1 : Form,IStateProvider
  {
    private readonly IAppRepository _appRepo;
    private IAppService _appSvc;

    public Form1(IAppRepository appRepo,IAppService appSvc)
    {
      _appRepo = appRepo;
      _appSvc = appSvc;
      _appSvc.SetStateProvider(this);
      InitializeComponent();

      smtpView.Initialize(appRepo, appSvc);
      recipientiView1.Initialize(appRepo, appSvc);
      mailsView1.Initialize(appRepo, appSvc);
      jobsView1.Initialize(appRepo, appSvc);
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      smtpView.OnClosing();
      recipientiView1.OnClosing();
      mailsView1.OnClosing();
      jobsView1.OnClosing();
    }

    public string GetCurrentMailId()
    {
      return mailsView1.CurrentMailId;
    }

    public string GetCurrentRecipientId()
    {
      return recipientiView1.CurrentRecipientId;
    }

    private void tabControl1_Selected(object sender, TabControlEventArgs e)
    {
     ViewBase t =  e.TabPage.Controls.OfType<ViewBase>().FirstOrDefault();
     t.Selected();
    }
  }
}
