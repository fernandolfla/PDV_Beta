namespace PDV_Beta.Interface
{
    partial class BuscaEntradas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaEntradas));
            this.dataListaEntradas = new System.Windows.Forms.DataGridView();
            this.NumeroNF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.dateFim = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumNf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListaEntradas
            // 
            this.dataListaEntradas.AllowUserToAddRows = false;
            this.dataListaEntradas.AllowUserToDeleteRows = false;
            this.dataListaEntradas.AllowUserToResizeColumns = false;
            this.dataListaEntradas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dataListaEntradas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataListaEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroNF,
            this.Fornecedor,
            this.Data,
            this.Total});
            this.dataListaEntradas.Location = new System.Drawing.Point(12, 104);
            this.dataListaEntradas.Name = "dataListaEntradas";
            this.dataListaEntradas.ReadOnly = true;
            this.dataListaEntradas.RowHeadersWidth = 20;
            this.dataListaEntradas.Size = new System.Drawing.Size(560, 240);
            this.dataListaEntradas.TabIndex = 9;
            this.dataListaEntradas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaEntradas_CellClick);
            // 
            // NumeroNF
            // 
            this.NumeroNF.HeaderText = "Número NF";
            this.NumeroNF.Name = "NumeroNF";
            this.NumeroNF.ReadOnly = true;
            // 
            // Fornecedor
            // 
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            this.Fornecedor.Width = 237;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data Saída";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Entrada";
            // 
            // dateInicio
            // 
            this.dateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicio.Location = new System.Drawing.Point(24, 38);
            this.dateInicio.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(81, 20);
            this.dateInicio.TabIndex = 10;
            this.dateInicio.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // dateFim
            // 
            this.dateFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFim.Location = new System.Drawing.Point(138, 38);
            this.dateFim.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateFim.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateFim.Name = "dateFim";
            this.dateFim.Size = new System.Drawing.Size(81, 20);
            this.dateFim.TabIndex = 11;
            this.dateFim.Value = new System.DateTime(2015, 11, 10, 0, 0, 0, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(444, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "OU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Número da NF";
            // 
            // txtNumNf
            // 
            this.txtNumNf.Location = new System.Drawing.Point(282, 37);
            this.txtNumNf.MaxLength = 20;
            this.txtNumNf.Name = "txtNumNf";
            this.txtNumNf.Size = new System.Drawing.Size(125, 20);
            this.txtNumNf.TabIndex = 15;
            // 
            // BuscaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.txtNumNf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dateFim);
            this.Controls.Add(this.dateInicio);
            this.Controls.Add(this.dataListaEntradas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "BuscaEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BuscaEntradas";
            ((System.ComponentModel.ISupportInitialize)(this.dataListaEntradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListaEntradas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroNF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.DateTimePicker dateFim;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumNf;
    }
}