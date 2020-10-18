namespace BulkMailSender
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.panel1 = new System.Windows.Forms.Panel();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.smtpView = new BulkMailSender.Views.SmptView();
      this.recipientiView1 = new BulkMailSender.Views.RecipientiView();
      this.mailsView1 = new BulkMailSender.Views.MailsView();
      this.jobsView1 = new BulkMailSender.Views.JobsView();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.tabPage4.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1229, 68);
      this.panel1.TabIndex = 0;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Controls.Add(this.tabPage4);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 68);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(1229, 591);
      this.tabControl1.TabIndex = 1;
      this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.smtpView);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(1221, 565);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "SMTP Settings";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.recipientiView1);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(1221, 617);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Recipienti";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.mailsView1);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(1221, 617);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Mail";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.jobsView1);
      this.tabPage4.Location = new System.Drawing.Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage4.Size = new System.Drawing.Size(1221, 617);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "Jobs";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // smtpView
      // 
      this.smtpView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.smtpView.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.smtpView.Location = new System.Drawing.Point(3, 3);
      this.smtpView.Name = "smtpView";
      this.smtpView.Size = new System.Drawing.Size(1215, 559);
      this.smtpView.TabIndex = 0;
      // 
      // recipientiView1
      // 
      this.recipientiView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.recipientiView1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.recipientiView1.Location = new System.Drawing.Point(3, 3);
      this.recipientiView1.Name = "recipientiView1";
      this.recipientiView1.Size = new System.Drawing.Size(1215, 611);
      this.recipientiView1.TabIndex = 0;
      // 
      // mailsView1
      // 
      this.mailsView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mailsView1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mailsView1.Location = new System.Drawing.Point(3, 3);
      this.mailsView1.Name = "mailsView1";
      this.mailsView1.Size = new System.Drawing.Size(1215, 611);
      this.mailsView1.TabIndex = 0;
      // 
      // jobsView1
      // 
      this.jobsView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.jobsView1.Location = new System.Drawing.Point(3, 3);
      this.jobsView1.Name = "jobsView1";
      this.jobsView1.Size = new System.Drawing.Size(1215, 611);
      this.jobsView1.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1229, 659);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      this.tabPage4.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.TabPage tabPage4;
    private Views.SmptView smtpView;
    private Views.RecipientiView recipientiView1;
    private Views.MailsView mailsView1;
    private Views.JobsView jobsView1;
  }
}

