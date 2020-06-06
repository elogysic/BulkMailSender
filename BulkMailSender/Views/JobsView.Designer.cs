namespace BulkMailSender.Views
{
  partial class JobsView
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cbStati = new System.Windows.Forms.ComboBox();
      this.btnDeselectAll = new System.Windows.Forms.Button();
      this.btnSelectAll = new System.Windows.Forms.Button();
      this.btnSetState = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.btnEliminaRecipiente = new System.Windows.Forms.Button();
      this.btnNuovo = new System.Windows.Forms.Button();
      this.lbState = new System.Windows.Forms.Label();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.tbLog = new System.Windows.Forms.TextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.btnStartStopJob = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.Selezionato = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.StatoStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.UltimoTentativoInvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.cbStati);
      this.panel1.Controls.Add(this.btnDeselectAll);
      this.panel1.Controls.Add(this.btnSelectAll);
      this.panel1.Controls.Add(this.btnSetState);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.btnEliminaRecipiente);
      this.panel1.Controls.Add(this.btnNuovo);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(997, 68);
      this.panel1.TabIndex = 1;
      // 
      // cbStati
      // 
      this.cbStati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cbStati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbStati.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbStati.FormattingEnabled = true;
      this.cbStati.Location = new System.Drawing.Point(841, 2);
      this.cbStati.Name = "cbStati";
      this.cbStati.Size = new System.Drawing.Size(151, 23);
      this.cbStati.TabIndex = 5;
      // 
      // btnDeselectAll
      // 
      this.btnDeselectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDeselectAll.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDeselectAll.Location = new System.Drawing.Point(699, 29);
      this.btnDeselectAll.Name = "btnDeselectAll";
      this.btnDeselectAll.Size = new System.Drawing.Size(125, 32);
      this.btnDeselectAll.TabIndex = 4;
      this.btnDeselectAll.Text = "Deseleziona tutti";
      this.btnDeselectAll.UseVisualStyleBackColor = true;
      this.btnDeselectAll.Click += new System.EventHandler(this.btnDeselectAll_Click);
      // 
      // btnSelectAll
      // 
      this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSelectAll.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSelectAll.Location = new System.Drawing.Point(568, 29);
      this.btnSelectAll.Name = "btnSelectAll";
      this.btnSelectAll.Size = new System.Drawing.Size(125, 32);
      this.btnSelectAll.TabIndex = 4;
      this.btnSelectAll.Text = "Seleziona tutti";
      this.btnSelectAll.UseVisualStyleBackColor = true;
      this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
      // 
      // btnSetState
      // 
      this.btnSetState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSetState.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSetState.Location = new System.Drawing.Point(841, 29);
      this.btnSetState.Name = "btnSetState";
      this.btnSetState.Size = new System.Drawing.Size(151, 32);
      this.btnSetState.TabIndex = 3;
      this.btnSetState.Text = "Imposta\r\n";
      this.btnSetState.UseVisualStyleBackColor = true;
      this.btnSetState.Click += new System.EventHandler(this.btnSetState_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Navy;
      this.label1.Location = new System.Drawing.Point(3, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(87, 23);
      this.label1.TabIndex = 2;
      this.label1.Text = "Jobs invio";
      // 
      // btnEliminaRecipiente
      // 
      this.btnEliminaRecipiente.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEliminaRecipiente.Location = new System.Drawing.Point(88, 31);
      this.btnEliminaRecipiente.Name = "btnEliminaRecipiente";
      this.btnEliminaRecipiente.Size = new System.Drawing.Size(75, 33);
      this.btnEliminaRecipiente.TabIndex = 0;
      this.btnEliminaRecipiente.Text = "Elimina";
      this.btnEliminaRecipiente.UseVisualStyleBackColor = true;
      this.btnEliminaRecipiente.Click += new System.EventHandler(this.btnEliminaJob_Click);
      // 
      // btnNuovo
      // 
      this.btnNuovo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNuovo.Location = new System.Drawing.Point(7, 31);
      this.btnNuovo.Name = "btnNuovo";
      this.btnNuovo.Size = new System.Drawing.Size(75, 33);
      this.btnNuovo.TabIndex = 0;
      this.btnNuovo.Text = "Nuovo";
      this.btnNuovo.UseVisualStyleBackColor = true;
      this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
      // 
      // lbState
      // 
      this.lbState.AutoSize = true;
      this.lbState.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbState.ForeColor = System.Drawing.Color.Navy;
      this.lbState.Location = new System.Drawing.Point(3, 9);
      this.lbState.Name = "lbState";
      this.lbState.Size = new System.Drawing.Size(42, 17);
      this.lbState.TabIndex = 1;
      this.lbState.Text = "label1";
      this.lbState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 68);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.treeView1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
      this.splitContainer1.Panel2.Controls.Add(this.panel2);
      this.splitContainer1.Size = new System.Drawing.Size(997, 580);
      this.splitContainer1.SplitterDistance = 222;
      this.splitContainer1.TabIndex = 2;
      // 
      // treeView1
      // 
      this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeView1.LabelEdit = true;
      this.treeView1.Location = new System.Drawing.Point(0, 0);
      this.treeView1.Name = "treeView1";
      this.treeView1.Size = new System.Drawing.Size(222, 580);
      this.treeView1.TabIndex = 0;
      this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
      this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
      // 
      // splitContainer2
      // 
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.Location = new System.Drawing.Point(0, 37);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.tbLog);
      this.splitContainer2.Size = new System.Drawing.Size(771, 543);
      this.splitContainer2.SplitterDistance = 343;
      this.splitContainer2.TabIndex = 2;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selezionato,
            this.Mail,
            this.Nome,
            this.StatoStr,
            this.UltimoTentativoInvio});
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersVisible = false;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(771, 343);
      this.dataGridView1.TabIndex = 1;
      // 
      // tbLog
      // 
      this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbLog.Location = new System.Drawing.Point(0, 0);
      this.tbLog.Multiline = true;
      this.tbLog.Name = "tbLog";
      this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbLog.Size = new System.Drawing.Size(771, 196);
      this.tbLog.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.label2);
      this.panel2.Controls.Add(this.btnStartStopJob);
      this.panel2.Controls.Add(this.lbState);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(771, 37);
      this.panel2.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoEllipsis = true;
      this.label2.Location = new System.Drawing.Point(187, 6);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(456, 23);
      this.label2.TabIndex = 2;
      this.label2.Text = "label2";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnStartStopJob
      // 
      this.btnStartStopJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnStartStopJob.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStartStopJob.Location = new System.Drawing.Point(649, 3);
      this.btnStartStopJob.Name = "btnStartStopJob";
      this.btnStartStopJob.Size = new System.Drawing.Size(119, 28);
      this.btnStartStopJob.TabIndex = 0;
      this.btnStartStopJob.Text = "Avvia";
      this.btnStartStopJob.UseVisualStyleBackColor = true;
      this.btnStartStopJob.Click += new System.EventHandler(this.btnStartStopJob_Click);
      // 
      // timer1
      // 
      this.timer1.Interval = 500;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Selezionato
      // 
      this.Selezionato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.Selezionato.DataPropertyName = "Selezionato";
      this.Selezionato.HeaderText = "Sel.";
      this.Selezionato.Name = "Selezionato";
      this.Selezionato.Width = 60;
      // 
      // Mail
      // 
      this.Mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.Mail.DataPropertyName = "Mail";
      this.Mail.HeaderText = "Mail";
      this.Mail.Name = "Mail";
      this.Mail.ReadOnly = true;
      // 
      // Nome
      // 
      this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.Nome.DataPropertyName = "Nome";
      this.Nome.HeaderText = "Nome";
      this.Nome.Name = "Nome";
      this.Nome.ReadOnly = true;
      // 
      // StatoStr
      // 
      this.StatoStr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.StatoStr.DataPropertyName = "StatoStr";
      this.StatoStr.HeaderText = "Stato";
      this.StatoStr.Name = "StatoStr";
      this.StatoStr.ReadOnly = true;
      // 
      // UltimoTentativoInvio
      // 
      this.UltimoTentativoInvio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.UltimoTentativoInvio.DataPropertyName = "UltimoTentativoInvioStr";
      this.UltimoTentativoInvio.HeaderText = "Ultimo Invio";
      this.UltimoTentativoInvio.Name = "UltimoTentativoInvio";
      this.UltimoTentativoInvio.ReadOnly = true;
      this.UltimoTentativoInvio.Width = 140;
      // 
      // JobsView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.panel1);
      this.Name = "JobsView";
      this.Size = new System.Drawing.Size(997, 648);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      this.splitContainer2.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lbState;
    private System.Windows.Forms.Button btnEliminaRecipiente;
    private System.Windows.Forms.Button btnNuovo;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button btnStartStopJob;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.TextBox tbLog;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnDeselectAll;
    private System.Windows.Forms.Button btnSelectAll;
    private System.Windows.Forms.ComboBox cbStati;
    private System.Windows.Forms.Button btnSetState;
    private System.Windows.Forms.DataGridViewCheckBoxColumn Selezionato;
    private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    private System.Windows.Forms.DataGridViewTextBoxColumn StatoStr;
    private System.Windows.Forms.DataGridViewTextBoxColumn UltimoTentativoInvio;
  }
}
