namespace PDV_Beta.Interface.Buscas
{
    partial class BuscaSaidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaSaidas));
            this.dataListaSaidas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComanda = new System.Windows.Forms.TextBox();
            this.txtMesa = new System.Windows.Forms.TextBox();
            this.txtPainel = new System.Windows.Forms.TextBox();
            this.txtSequencia = new System.Windows.Forms.TextBox();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateFim = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEmAberto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Painel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref_NF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recebido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaSaidas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListaSaidas
            // 
            this.dataListaSaidas.AllowUserToAddRows = false;
            this.dataListaSaidas.AllowUserToDeleteRows = false;
            this.dataListaSaidas.AllowUserToResizeColumns = false;
            this.dataListaSaidas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dataListaSaidas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataListaSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaSaidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sequencia,
            this.Cliente,
            this.Mesa,
            this.Painel,
            this.Ref_NF,
            this.Data,
            this.Total,
            this.Recebido,
            this.Cancelada});
            this.dataListaSaidas.Location = new System.Drawing.Point(2, 110);
            this.dataListaSaidas.Name = "dataListaSaidas";
            this.dataListaSaidas.ReadOnly = true;
            this.dataListaSaidas.RowHeadersWidth = 10;
            this.dataListaSaidas.Size = new System.Drawing.Size(679, 240);
            this.dataListaSaidas.TabIndex = 5;
            this.dataListaSaidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaSaidas_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mesa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Painel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sequencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ref / NF";
            // 
            // txtComanda
            // 
            this.txtComanda.Enabled = false;
            this.txtComanda.Location = new System.Drawing.Point(89, 16);
            this.txtComanda.Name = "txtComanda";
            this.txtComanda.Size = new System.Drawing.Size(150, 20);
            this.txtComanda.TabIndex = 11;
            this.txtComanda.Leave += new System.EventHandler(this.txtComanda_Leave);
            // 
            // txtMesa
            // 
            this.txtMesa.Location = new System.Drawing.Point(89, 43);
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.Size = new System.Drawing.Size(150, 20);
            this.txtMesa.TabIndex = 12;
            this.txtMesa.Leave += new System.EventHandler(this.txtMesa_Leave);
            // 
            // txtPainel
            // 
            this.txtPainel.Location = new System.Drawing.Point(89, 69);
            this.txtPainel.Name = "txtPainel";
            this.txtPainel.Size = new System.Drawing.Size(150, 20);
            this.txtPainel.TabIndex = 13;
            this.txtPainel.Leave += new System.EventHandler(this.txtPainel_Leave);
            // 
            // txtSequencia
            // 
            this.txtSequencia.Location = new System.Drawing.Point(332, 16);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Size = new System.Drawing.Size(150, 20);
            this.txtSequencia.TabIndex = 14;
            this.txtSequencia.Leave += new System.EventHandler(this.txtSequencia_Leave);
            // 
            // txtNF
            // 
            this.txtNF.Location = new System.Drawing.Point(332, 43);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(150, 20);
            this.txtNF.TabIndex = 15;
            this.txtNF.Leave += new System.EventHandler(this.txtNF_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "De";
            // 
            // dateInicio
            // 
            this.dateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicio.Location = new System.Drawing.Point(304, 69);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(85, 20);
            this.dateInicio.TabIndex = 17;
            this.dateInicio.Value = new System.DateTime(2015, 12, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Até";
            // 
            // dateFim
            // 
            this.dateFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFim.Location = new System.Drawing.Point(435, 69);
            this.dateFim.Name = "dateFim";
            this.dateFim.Size = new System.Drawing.Size(85, 20);
            this.dateFim.TabIndex = 19;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(515, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 47);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Busca Por Data";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEmAberto
            // 
            this.btnEmAberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmAberto.ForeColor = System.Drawing.Color.Red;
            this.btnEmAberto.Location = new System.Drawing.Point(597, 12);
            this.btnEmAberto.Name = "btnEmAberto";
            this.btnEmAberto.Size = new System.Drawing.Size(75, 69);
            this.btnEmAberto.TabIndex = 21;
            this.btnEmAberto.Text = "Em Aberto";
            this.btnEmAberto.UseVisualStyleBackColor = true;
            this.btnEmAberto.Click += new System.EventHandler(this.btnEmAberto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Comanda";
            // 
            // Sequencia
            // 
            this.Sequencia.HeaderText = "Sequencia";
            this.Sequencia.Name = "Sequencia";
            this.Sequencia.ReadOnly = true;
            this.Sequencia.Width = 75;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Mesa
            // 
            this.Mesa.HeaderText = "Mesa";
            this.Mesa.Name = "Mesa";
            this.Mesa.ReadOnly = true;
            this.Mesa.Width = 65;
            // 
            // Painel
            // 
            this.Painel.HeaderText = "Painel";
            this.Painel.Name = "Painel";
            this.Painel.ReadOnly = true;
            this.Painel.Width = 50;
            // 
            // Ref_NF
            // 
            this.Ref_NF.HeaderText = "Ref_NF";
            this.Ref_NF.Name = "Ref_NF";
            this.Ref_NF.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 115;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // Recebido
            // 
            this.Recebido.HeaderText = "Rec.";
            this.Recebido.Name = "Recebido";
            this.Recebido.ReadOnly = true;
            this.Recebido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Recebido.Width = 40;
            // 
            // Cancelada
            // 
            this.Cancelada.HeaderText = "Canc.";
            this.Cancelada.Name = "Cancelada";
            this.Cancelada.ReadOnly = true;
            this.Cancelada.Width = 40;
            // 
            // BuscaSaidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this.btnEmAberto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dateFim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNF);
            this.Controls.Add(this.txtSequencia);
            this.Controls.Add(this.txtPainel);
            this.Controls.Add(this.txtMesa);
            this.Controls.Add(this.txtComanda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataListaSaidas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "BuscaSaidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busca de Vendas";
            this.Load += new System.EventHandler(this.BuscaSaidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListaSaidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListaSaidas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComanda;
        private System.Windows.Forms.TextBox txtMesa;
        private System.Windows.Forms.TextBox txtPainel;
        private System.Windows.Forms.TextBox txtSequencia;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateFim;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEmAberto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cancelada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recebido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref_NF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Painel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sequencia;
    }
}