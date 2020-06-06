namespace BulkMailSender.Views
{
  partial class SmptView
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.tbSender = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tbSmtpHost = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tbUsername = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.cbUseCredential = new System.Windows.Forms.CheckBox();
      this.label5 = new System.Windows.Forms.Label();
      this.nbPort = new System.Windows.Forms.NumericUpDown();
      this.label6 = new System.Windows.Forms.Label();
      this.nbRitardoSecondi = new System.Windows.Forms.NumericUpDown();
      this.button1 = new System.Windows.Forms.Button();
      this.btnTestMail = new System.Windows.Forms.Button();
      this.btnSalva = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.nbPort)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nbRitardoSecondi)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Calibri", 10F);
      this.label1.Location = new System.Drawing.Point(23, 76);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(51, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Sender:";
      // 
      // tbSender
      // 
      this.tbSender.Font = new System.Drawing.Font("Calibri", 10F);
      this.tbSender.Location = new System.Drawing.Point(26, 96);
      this.tbSender.Name = "tbSender";
      this.tbSender.Size = new System.Drawing.Size(192, 24);
      this.tbSender.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Calibri", 10F);
      this.label2.Location = new System.Drawing.Point(23, 133);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 17);
      this.label2.TabIndex = 0;
      this.label2.Text = "SMTP Host:";
      // 
      // tbSmtpHost
      // 
      this.tbSmtpHost.Font = new System.Drawing.Font("Calibri", 10F);
      this.tbSmtpHost.Location = new System.Drawing.Point(26, 153);
      this.tbSmtpHost.Name = "tbSmtpHost";
      this.tbSmtpHost.Size = new System.Drawing.Size(192, 24);
      this.tbSmtpHost.TabIndex = 1;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Calibri", 10F);
      this.label3.Location = new System.Drawing.Point(23, 187);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(70, 17);
      this.label3.TabIndex = 0;
      this.label3.Text = "Username:";
      // 
      // tbUsername
      // 
      this.tbUsername.Font = new System.Drawing.Font("Calibri", 10F);
      this.tbUsername.Location = new System.Drawing.Point(26, 207);
      this.tbUsername.Name = "tbUsername";
      this.tbUsername.Size = new System.Drawing.Size(192, 24);
      this.tbUsername.TabIndex = 1;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Calibri", 10F);
      this.label4.Location = new System.Drawing.Point(232, 187);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(65, 17);
      this.label4.TabIndex = 0;
      this.label4.Text = "Password:";
      // 
      // tbPassword
      // 
      this.tbPassword.Font = new System.Drawing.Font("Calibri", 10F);
      this.tbPassword.Location = new System.Drawing.Point(235, 207);
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.Size = new System.Drawing.Size(192, 24);
      this.tbPassword.TabIndex = 1;
      this.tbPassword.UseSystemPasswordChar = true;
      // 
      // cbUseCredential
      // 
      this.cbUseCredential.AutoSize = true;
      this.cbUseCredential.Font = new System.Drawing.Font("Calibri", 10F);
      this.cbUseCredential.Location = new System.Drawing.Point(26, 237);
      this.cbUseCredential.Name = "cbUseCredential";
      this.cbUseCredential.Size = new System.Drawing.Size(108, 21);
      this.cbUseCredential.TabIndex = 2;
      this.cbUseCredential.Text = "Use credential";
      this.cbUseCredential.UseVisualStyleBackColor = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Calibri", 10F);
      this.label5.Location = new System.Drawing.Point(232, 133);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(36, 17);
      this.label5.TabIndex = 0;
      this.label5.Text = "Port:";
      // 
      // nbPort
      // 
      this.nbPort.Font = new System.Drawing.Font("Calibri", 10F);
      this.nbPort.Location = new System.Drawing.Point(235, 153);
      this.nbPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
      this.nbPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nbPort.Name = "nbPort";
      this.nbPort.Size = new System.Drawing.Size(120, 24);
      this.nbPort.TabIndex = 3;
      this.nbPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Calibri", 10F);
      this.label6.Location = new System.Drawing.Point(23, 269);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(154, 17);
      this.label6.TabIndex = 0;
      this.label6.Text = "Ritardo tra mail (secondi):";
      // 
      // nbRitardoSecondi
      // 
      this.nbRitardoSecondi.Font = new System.Drawing.Font("Calibri", 10F);
      this.nbRitardoSecondi.Location = new System.Drawing.Point(183, 267);
      this.nbRitardoSecondi.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.nbRitardoSecondi.Name = "nbRitardoSecondi";
      this.nbRitardoSecondi.Size = new System.Drawing.Size(120, 24);
      this.nbRitardoSecondi.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(26, 312);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(137, 30);
      this.button1.TabIndex = 4;
      this.button1.Text = "Test connessione";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.btnTestConnection_Click);
      // 
      // btnTestMail
      // 
      this.btnTestMail.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTestMail.Location = new System.Drawing.Point(169, 312);
      this.btnTestMail.Name = "btnTestMail";
      this.btnTestMail.Size = new System.Drawing.Size(137, 30);
      this.btnTestMail.TabIndex = 4;
      this.btnTestMail.Text = "Invio mail test";
      this.btnTestMail.UseVisualStyleBackColor = true;
      this.btnTestMail.Click += new System.EventHandler(this.btnTestMail_Click);
      // 
      // btnSalva
      // 
      this.btnSalva.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSalva.Location = new System.Drawing.Point(354, 312);
      this.btnSalva.Name = "btnSalva";
      this.btnSalva.Size = new System.Drawing.Size(108, 30);
      this.btnSalva.TabIndex = 4;
      this.btnSalva.Text = "Salva";
      this.btnSalva.UseVisualStyleBackColor = true;
      this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.ForeColor = System.Drawing.Color.Navy;
      this.label7.Location = new System.Drawing.Point(15, 11);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(161, 23);
      this.label7.TabIndex = 5;
      this.label7.Text = "Impostazioni SMTP";
      // 
      // SmptView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.label7);
      this.Controls.Add(this.btnTestMail);
      this.Controls.Add(this.btnSalva);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.nbRitardoSecondi);
      this.Controls.Add(this.nbPort);
      this.Controls.Add(this.cbUseCredential);
      this.Controls.Add(this.tbPassword);
      this.Controls.Add(this.tbUsername);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.tbSmtpHost);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.tbSender);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "SmptView";
      this.Size = new System.Drawing.Size(861, 645);
      ((System.ComponentModel.ISupportInitialize)(this.nbPort)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nbRitardoSecondi)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbSender;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbSmtpHost;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tbUsername;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tbPassword;
    private System.Windows.Forms.CheckBox cbUseCredential;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown nbPort;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown nbRitardoSecondi;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnTestMail;
    private System.Windows.Forms.Button btnSalva;
    private System.Windows.Forms.Label label7;
  }
}
