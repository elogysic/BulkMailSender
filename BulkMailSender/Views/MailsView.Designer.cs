namespace BulkMailSender.Views
{
  partial class MailsView
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnSalva = new System.Windows.Forms.Button();
      this.btnEliminaMail = new System.Windows.Forms.Button();
      this.btnNuova = new System.Windows.Forms.Button();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.tbSubject = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.btnClear);
      this.panel1.Controls.Add(this.btnSalva);
      this.panel1.Controls.Add(this.btnEliminaMail);
      this.panel1.Controls.Add(this.btnNuova);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1034, 69);
      this.panel1.TabIndex = 0;
      // 
      // btnClear
      // 
      this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClear.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClear.Location = new System.Drawing.Point(875, 29);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 33);
      this.btnClear.TabIndex = 1;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // btnSalva
      // 
      this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSalva.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSalva.Location = new System.Drawing.Point(956, 30);
      this.btnSalva.Name = "btnSalva";
      this.btnSalva.Size = new System.Drawing.Size(75, 33);
      this.btnSalva.TabIndex = 1;
      this.btnSalva.Text = "Salva";
      this.btnSalva.UseVisualStyleBackColor = true;
      this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
      // 
      // btnEliminaMail
      // 
      this.btnEliminaMail.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEliminaMail.Location = new System.Drawing.Point(88, 30);
      this.btnEliminaMail.Name = "btnEliminaMail";
      this.btnEliminaMail.Size = new System.Drawing.Size(75, 33);
      this.btnEliminaMail.TabIndex = 1;
      this.btnEliminaMail.Text = "Elimina";
      this.btnEliminaMail.UseVisualStyleBackColor = true;
      this.btnEliminaMail.Click += new System.EventHandler(this.btnEliminaMail_Click);
      // 
      // btnNuova
      // 
      this.btnNuova.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNuova.Location = new System.Drawing.Point(7, 30);
      this.btnNuova.Name = "btnNuova";
      this.btnNuova.Size = new System.Drawing.Size(75, 33);
      this.btnNuova.TabIndex = 2;
      this.btnNuova.Text = "Nuova";
      this.btnNuova.UseVisualStyleBackColor = true;
      this.btnNuova.Click += new System.EventHandler(this.btnNuova_Click);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 69);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.treeView1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.panel3);
      this.splitContainer1.Panel2.Controls.Add(this.panel2);
      this.splitContainer1.Size = new System.Drawing.Size(1034, 512);
      this.splitContainer1.SplitterDistance = 239;
      this.splitContainer1.TabIndex = 1;
      // 
      // treeView1
      // 
      this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeView1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.treeView1.LabelEdit = true;
      this.treeView1.Location = new System.Drawing.Point(0, 0);
      this.treeView1.Name = "treeView1";
      this.treeView1.Size = new System.Drawing.Size(239, 512);
      this.treeView1.TabIndex = 0;
      this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
      this.treeView1.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeView1_DrawNode);
      this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
      this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
      // 
      // panel3
      // 
      this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel3.Location = new System.Drawing.Point(0, 40);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(791, 472);
      this.panel3.TabIndex = 2;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.tbSubject);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(791, 40);
      this.panel2.TabIndex = 1;
      // 
      // tbSubject
      // 
      this.tbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbSubject.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbSubject.Location = new System.Drawing.Point(61, 7);
      this.tbSubject.Name = "tbSubject";
      this.tbSubject.Size = new System.Drawing.Size(724, 24);
      this.tbSubject.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(4, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Subject:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Navy;
      this.label2.Location = new System.Drawing.Point(3, 5);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(46, 23);
      this.label2.TabIndex = 3;
      this.label2.Text = "Mail";
      // 
      // MailsView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "MailsView";
      this.Size = new System.Drawing.Size(1034, 581);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    //private Components.EditorForm editorForm1;
    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.Button btnEliminaMail;
    private System.Windows.Forms.Button btnNuova;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox tbSubject;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSalva;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label label2;
  }
}
