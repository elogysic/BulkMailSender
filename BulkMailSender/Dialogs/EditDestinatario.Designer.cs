namespace BulkMailSender.Dialogs
{
  partial class EditDestinatario
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnAnnulla = new System.Windows.Forms.Button();
      this.btnSalva = new System.Windows.Forms.Button();
      this.tbMail = new System.Windows.Forms.TextBox();
      this.tbNome = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Calibri", 10F);
      this.label1.Location = new System.Drawing.Point(15, 74);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(46, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nome:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Calibri", 10F);
      this.label2.Location = new System.Drawing.Point(14, 11);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 17);
      this.label2.TabIndex = 0;
      this.label2.Text = "E-mail:";
      // 
      // btnAnnulla
      // 
      this.btnAnnulla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnAnnulla.Font = new System.Drawing.Font("Calibri", 10F);
      this.btnAnnulla.Location = new System.Drawing.Point(339, 147);
      this.btnAnnulla.Name = "btnAnnulla";
      this.btnAnnulla.Size = new System.Drawing.Size(75, 34);
      this.btnAnnulla.TabIndex = 2;
      this.btnAnnulla.Text = "Annulla";
      this.btnAnnulla.UseVisualStyleBackColor = true;
      this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
      // 
      // btnSalva
      // 
      this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSalva.Font = new System.Drawing.Font("Calibri", 10F);
      this.btnSalva.Location = new System.Drawing.Point(258, 147);
      this.btnSalva.Name = "btnSalva";
      this.btnSalva.Size = new System.Drawing.Size(75, 34);
      this.btnSalva.TabIndex = 2;
      this.btnSalva.Text = "Salva";
      this.btnSalva.UseVisualStyleBackColor = true;
      this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
      // 
      // tbMail
      // 
      this.tbMail.Font = new System.Drawing.Font("Calibri", 10F);
      this.tbMail.Location = new System.Drawing.Point(16, 31);
      this.tbMail.Name = "tbMail";
      this.tbMail.Size = new System.Drawing.Size(390, 24);
      this.tbMail.TabIndex = 0;
      // 
      // tbNome
      // 
      this.tbNome.Font = new System.Drawing.Font("Calibri", 10F);
      this.tbNome.Location = new System.Drawing.Point(17, 94);
      this.tbNome.Name = "tbNome";
      this.tbNome.Size = new System.Drawing.Size(390, 24);
      this.tbNome.TabIndex = 1;
      // 
      // EditDestinatario
      // 
      this.AcceptButton = this.btnSalva;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnAnnulla;
      this.ClientSize = new System.Drawing.Size(420, 189);
      this.Controls.Add(this.tbMail);
      this.Controls.Add(this.tbNome);
      this.Controls.Add(this.btnSalva);
      this.Controls.Add(this.btnAnnulla);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Calibri", 9F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditDestinatario";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Destinatario";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnAnnulla;
    private System.Windows.Forms.Button btnSalva;
    private System.Windows.Forms.TextBox tbMail;
    private System.Windows.Forms.TextBox tbNome;
  }
}