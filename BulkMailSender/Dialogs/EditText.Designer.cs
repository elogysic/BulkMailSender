namespace BulkMailSender.Dialogs
{
  partial class EditText
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
      this.tbText = new System.Windows.Forms.TextBox();
      this.cbWordWrap = new System.Windows.Forms.CheckBox();
      this.btnAnnulla = new System.Windows.Forms.Button();
      this.btnSalva = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnSalva);
      this.panel1.Controls.Add(this.btnAnnulla);
      this.panel1.Controls.Add(this.cbWordWrap);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(941, 40);
      this.panel1.TabIndex = 0;
      // 
      // tbText
      // 
      this.tbText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbText.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbText.Location = new System.Drawing.Point(0, 40);
      this.tbText.Multiline = true;
      this.tbText.Name = "tbText";
      this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbText.Size = new System.Drawing.Size(941, 591);
      this.tbText.TabIndex = 1;
      // 
      // cbWordWrap
      // 
      this.cbWordWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cbWordWrap.AutoSize = true;
      this.cbWordWrap.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbWordWrap.Location = new System.Drawing.Point(687, 11);
      this.cbWordWrap.Name = "cbWordWrap";
      this.cbWordWrap.Size = new System.Drawing.Size(89, 21);
      this.cbWordWrap.TabIndex = 0;
      this.cbWordWrap.Text = "Word wrap";
      this.cbWordWrap.UseVisualStyleBackColor = true;
      this.cbWordWrap.CheckedChanged += new System.EventHandler(this.cbWordWrap_CheckedChanged);
      // 
      // btnAnnulla
      // 
      this.btnAnnulla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAnnulla.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAnnulla.Location = new System.Drawing.Point(859, 5);
      this.btnAnnulla.Name = "btnAnnulla";
      this.btnAnnulla.Size = new System.Drawing.Size(75, 31);
      this.btnAnnulla.TabIndex = 1;
      this.btnAnnulla.Text = "Annulla";
      this.btnAnnulla.UseVisualStyleBackColor = true;
      this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
      // 
      // btnSalva
      // 
      this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSalva.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSalva.Location = new System.Drawing.Point(778, 5);
      this.btnSalva.Name = "btnSalva";
      this.btnSalva.Size = new System.Drawing.Size(75, 31);
      this.btnSalva.TabIndex = 1;
      this.btnSalva.Text = "Salva";
      this.btnSalva.UseVisualStyleBackColor = true;
      this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
      // 
      // EditText
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(941, 631);
      this.Controls.Add(this.tbText);
      this.Controls.Add(this.panel1);
      this.Name = "EditText";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "EditText";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.CheckBox cbWordWrap;
    private System.Windows.Forms.TextBox tbText;
    private System.Windows.Forms.Button btnSalva;
    private System.Windows.Forms.Button btnAnnulla;
  }
}