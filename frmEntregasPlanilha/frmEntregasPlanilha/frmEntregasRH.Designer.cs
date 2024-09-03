
namespace frmEntregasPlanilha
{
    partial class frmEntregasRH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntregasRH));
            this.dtEntregas = new System.Windows.Forms.DateTimePicker();
            this.btnImporta = new System.Windows.Forms.Button();
            this.dgvEntregas = new System.Windows.Forms.DataGridView();
            this.btnExporta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cbxSetor = new System.Windows.Forms.ComboBox();
            this.cbxCesta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtEntregas
            // 
            this.dtEntregas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtEntregas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEntregas.Location = new System.Drawing.Point(68, 7);
            this.dtEntregas.Name = "dtEntregas";
            this.dtEntregas.Size = new System.Drawing.Size(92, 24);
            this.dtEntregas.TabIndex = 0;
            this.dtEntregas.ValueChanged += new System.EventHandler(this.dtEntregas_ValueChanged);
            // 
            // btnImporta
            // 
            this.btnImporta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnImporta.Image = ((System.Drawing.Image)(resources.GetObject("btnImporta.Image")));
            this.btnImporta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImporta.Location = new System.Drawing.Point(970, 28);
            this.btnImporta.Name = "btnImporta";
            this.btnImporta.Size = new System.Drawing.Size(93, 36);
            this.btnImporta.TabIndex = 1;
            this.btnImporta.Text = "Importa";
            this.btnImporta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImporta.UseVisualStyleBackColor = true;
            this.btnImporta.Click += new System.EventHandler(this.btnImporta_Click);
            // 
            // dgvEntregas
            // 
            this.dgvEntregas.AllowUserToAddRows = false;
            this.dgvEntregas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregas.Location = new System.Drawing.Point(13, 70);
            this.dgvEntregas.Name = "dgvEntregas";
            this.dgvEntregas.RowHeadersVisible = false;
            this.dgvEntregas.Size = new System.Drawing.Size(1051, 368);
            this.dgvEntregas.TabIndex = 2;
            // 
            // btnExporta
            // 
            this.btnExporta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnExporta.Image = ((System.Drawing.Image)(resources.GetObject("btnExporta.Image")));
            this.btnExporta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExporta.Location = new System.Drawing.Point(870, 28);
            this.btnExporta.Name = "btnExporta";
            this.btnExporta.Size = new System.Drawing.Size(94, 36);
            this.btnExporta.TabIndex = 3;
            this.btnExporta.Text = "Exporta";
            this.btnExporta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExporta.UseVisualStyleBackColor = true;
            this.btnExporta.Click += new System.EventHandler(this.btnExporta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.Location = new System.Drawing.Point(534, 18);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(83, 36);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbxSetor
            // 
            this.cbxSetor.FormattingEnabled = true;
            this.cbxSetor.Items.AddRange(new object[] {
            "ACB A1",
            "ACB A2",
            "ACB A3",
            "ACB B1",
            "ACB B2",
            "ACB B3",
            "COB",
            "CST",
            "CTQ",
            "CTV",
            "DHO",
            "DIR",
            "DPR",
            "EXP",
            "FIN",
            "FISCAL",
            "GDC",
            "IND",
            "INJ A1",
            "LIM",
            "LOG",
            "LOJA",
            "MKT",
            "MNP",
            "MNT ",
            "MOV",
            "MTG",
            "OPRH",
            "POL",
            "REC",
            "RES",
            "RTM A1",
            "RTM A2",
            "RTM A3",
            "SPV",
            "USI ",
            "VDD",
            "VTE",
            "ZETA"});
            this.cbxSetor.Location = new System.Drawing.Point(392, 39);
            this.cbxSetor.Name = "cbxSetor";
            this.cbxSetor.Size = new System.Drawing.Size(75, 21);
            this.cbxSetor.TabIndex = 6;
            this.cbxSetor.Text = "SETORES";
            // 
            // cbxCesta
            // 
            this.cbxCesta.FormattingEnabled = true;
            this.cbxCesta.Items.AddRange(new object[] {
            "CESTA BASICA",
            "CESTA ALTERNATIVA"});
            this.cbxCesta.Location = new System.Drawing.Point(392, 7);
            this.cbxCesta.Name = "cbxCesta";
            this.cbxCesta.Size = new System.Drawing.Size(121, 21);
            this.cbxCesta.TabIndex = 7;
            this.cbxCesta.Text = "TIPO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(332, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Setor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(332, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cesta:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.Location = new System.Drawing.Point(623, 18);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(83, 36);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(73, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(248, 20);
            this.txtNome.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 450);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCesta);
            this.Controls.Add(this.cbxSetor);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExporta);
            this.Controls.Add(this.dgvEntregas);
            this.Controls.Add(this.btnImporta);
            this.Controls.Add(this.dtEntregas);
            this.Name = "Form1";
            this.Text = "Entregas RH";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtEntregas;
        private System.Windows.Forms.Button btnImporta;
        private System.Windows.Forms.DataGridView dgvEntregas;
        private System.Windows.Forms.Button btnExporta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cbxSetor;
        private System.Windows.Forms.ComboBox cbxCesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
    }
}

