namespace BulkMailSender.Views
{
  partial class RecipientiView
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.lbNumero = new System.Windows.Forms.Label();
      this.btnAddDestinatario = new System.Windows.Forms.Button();
      this.btnRimuoviDuplicati = new System.Windows.Forms.Button();
      this.btnEliminaSelezionati = new System.Windows.Forms.Button();
      this.btnImporta = new System.Windows.Forms.Button();
      this.btnEliminaRecipiente = new System.Windows.Forms.Button();
      this.btnNuova = new System.Windows.Forms.Button();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Elimina = new System.Windows.Forms.DataGridViewButtonColumn();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.lbNumero);
      this.panel1.Controls.Add(this.btnAddDestinatario);
      this.panel1.Controls.Add(this.btnRimuoviDuplicati);
      this.panel1.Controls.Add(this.btnEliminaSelezionati);
      this.panel1.Controls.Add(this.btnImporta);
      this.panel1.Controls.Add(this.btnEliminaRecipiente);
      this.panel1.Controls.Add(this.btnNuova);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(776, 68);
      this.panel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Navy;
      this.label1.Location = new System.Drawing.Point(3, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(90, 23);
      this.label1.TabIndex = 2;
      this.label1.Text = "Recipienti";
      // 
      // lbNumero
      // 
      this.lbNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lbNumero.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbNumero.ForeColor = System.Drawing.Color.Navy;
      this.lbNumero.Location = new System.Drawing.Point(468, 3);
      this.lbNumero.Name = "lbNumero";
      this.lbNumero.Size = new System.Drawing.Size(305, 22);
      this.lbNumero.TabIndex = 1;
      this.lbNumero.Text = "label1";
      this.lbNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnAddDestinatario
      // 
      this.btnAddDestinatario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAddDestinatario.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddDestinatario.Location = new System.Drawing.Point(468, 31);
      this.btnAddDestinatario.Name = "btnAddDestinatario";
      this.btnAddDestinatario.Size = new System.Drawing.Size(173, 33);
      this.btnAddDestinatario.TabIndex = 0;
      this.btnAddDestinatario.Text = "Aggiungi destinatario";
      this.btnAddDestinatario.UseVisualStyleBackColor = true;
      this.btnAddDestinatario.Click += new System.EventHandler(this.btnAddDestinatario_Click);
      // 
      // btnRimuoviDuplicati
      // 
      this.btnRimuoviDuplicati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRimuoviDuplicati.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRimuoviDuplicati.Location = new System.Drawing.Point(647, 31);
      this.btnRimuoviDuplicati.Name = "btnRimuoviDuplicati";
      this.btnRimuoviDuplicati.Size = new System.Drawing.Size(126, 33);
      this.btnRimuoviDuplicati.TabIndex = 0;
      this.btnRimuoviDuplicati.Text = "Rimuovi duplicati";
      this.btnRimuoviDuplicati.UseVisualStyleBackColor = true;
      this.btnRimuoviDuplicati.Click += new System.EventHandler(this.btnRimuoviDuplicati_Click);
      // 
      // btnEliminaSelezionati
      // 
      this.btnEliminaSelezionati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnEliminaSelezionati.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEliminaSelezionati.Location = new System.Drawing.Point(251, 31);
      this.btnEliminaSelezionati.Name = "btnEliminaSelezionati";
      this.btnEliminaSelezionati.Size = new System.Drawing.Size(130, 33);
      this.btnEliminaSelezionati.TabIndex = 0;
      this.btnEliminaSelezionati.Text = "Elimina selezionati";
      this.btnEliminaSelezionati.UseVisualStyleBackColor = true;
      this.btnEliminaSelezionati.Click += new System.EventHandler(this.btnEliminaSelezionati_Click);
      // 
      // btnImporta
      // 
      this.btnImporta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnImporta.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnImporta.Location = new System.Drawing.Point(387, 31);
      this.btnImporta.Name = "btnImporta";
      this.btnImporta.Size = new System.Drawing.Size(75, 33);
      this.btnImporta.TabIndex = 0;
      this.btnImporta.Text = "Importa";
      this.btnImporta.UseVisualStyleBackColor = true;
      this.btnImporta.Click += new System.EventHandler(this.btnImporta_Click);
      // 
      // btnEliminaRecipiente
      // 
      this.btnEliminaRecipiente.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEliminaRecipiente.Location = new System.Drawing.Point(81, 31);
      this.btnEliminaRecipiente.Name = "btnEliminaRecipiente";
      this.btnEliminaRecipiente.Size = new System.Drawing.Size(75, 33);
      this.btnEliminaRecipiente.TabIndex = 0;
      this.btnEliminaRecipiente.Text = "Elimina";
      this.btnEliminaRecipiente.UseVisualStyleBackColor = true;
      this.btnEliminaRecipiente.Click += new System.EventHandler(this.btnEliminaRecipiente_Click);
      // 
      // btnNuova
      // 
      this.btnNuova.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNuova.Location = new System.Drawing.Point(0, 31);
      this.btnNuova.Name = "btnNuova";
      this.btnNuova.Size = new System.Drawing.Size(75, 33);
      this.btnNuova.TabIndex = 0;
      this.btnNuova.Text = "Nuova";
      this.btnNuova.UseVisualStyleBackColor = true;
      this.btnNuova.Click += new System.EventHandler(this.btnNuova_Click);
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
      this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
      this.splitContainer1.Size = new System.Drawing.Size(776, 557);
      this.splitContainer1.SplitterDistance = 186;
      this.splitContainer1.TabIndex = 1;
      // 
      // treeView1
      // 
      this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeView1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.treeView1.HideSelection = false;
      this.treeView1.LabelEdit = true;
      this.treeView1.Location = new System.Drawing.Point(0, 0);
      this.treeView1.Name = "treeView1";
      this.treeView1.Size = new System.Drawing.Size(186, 557);
      this.treeView1.TabIndex = 0;
      this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
      this.treeView1.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeView1_DrawNode);
      this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.AllowUserToResizeRows = false;
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mail,
            this.Nome,
            this.Elimina});
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(586, 557);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
      this.dataGridView1.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_RowValidating);
      this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Mail
      // 
      this.Mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.Mail.DataPropertyName = "Address";
      this.Mail.HeaderText = "Mail";
      this.Mail.Name = "Mail";
      // 
      // Nome
      // 
      this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.Nome.DataPropertyName = "Nome";
      this.Nome.HeaderText = "Nome";
      this.Nome.Name = "Nome";
      // 
      // Elimina
      // 
      this.Elimina.HeaderText = "Azione";
      this.Elimina.Name = "Elimina";
      this.Elimina.Text = "Elimina";
      this.Elimina.UseColumnTextForButtonValue = true;
      this.Elimina.Width = 44;
      // 
      // RecipientiView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "RecipientiView";
      this.Size = new System.Drawing.Size(776, 625);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Button btnRimuoviDuplicati;
    private System.Windows.Forms.Button btnImporta;
    private System.Windows.Forms.Button btnEliminaRecipiente;
    private System.Windows.Forms.Button btnNuova;
    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnAddDestinatario;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label lbNumero;
    private System.Windows.Forms.Button btnEliminaSelezionati;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    private System.Windows.Forms.DataGridViewButtonColumn Elimina;
  }
}
