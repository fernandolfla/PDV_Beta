namespace PDV_Beta.Interface.Relatorios
{
    partial class Rel_Entregas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rel_Entregas));
            this.relatorioEntregas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnOk = new System.Windows.Forms.Button();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.dateFim = new System.Windows.Forms.DateTimePicker();
            this.lblqualquer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeTransportadora = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnTransportadora = new System.Windows.Forms.Button();
            this.txtCodTransportadora = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // relatorioEntregas
            // 
            this.relatorioEntregas.LocalReport.ReportEmbeddedResource = "PDV_Beta.Interface.Relatorios.Rel_Entregas.rdlc";
            this.relatorioEntregas.Location = new System.Drawing.Point(12, 54);
            this.relatorioEntregas.Name = "relatorioEntregas";
            this.relatorioEntregas.Size = new System.Drawing.Size(960, 500);
            this.relatorioEntregas.TabIndex = 6;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(630, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(47, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dateInicio
            // 
            this.dateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateInicio.Location = new System.Drawing.Point(382, 15);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(92, 20);
            this.dateInicio.TabIndex = 8;
            // 
            // dateFim
            // 
            this.dateFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFim.Location = new System.Drawing.Point(527, 15);
            this.dateFim.Name = "dateFim";
            this.dateFim.Size = new System.Drawing.Size(86, 20);
            this.dateFim.TabIndex = 9;
            // 
            // lblqualquer
            // 
            this.lblqualquer.AutoSize = true;
            this.lblqualquer.Location = new System.Drawing.Point(355, 21);
            this.lblqualquer.Name = "lblqualquer";
            this.lblqualquer.Size = new System.Drawing.Size(21, 13);
            this.lblqualquer.TabIndex = 10;
            this.lblqualquer.Text = "De";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Até";
            // 
            // txtNomeTransportadora
            // 
            this.txtNomeTransportadora.Enabled = false;
            this.txtNomeTransportadora.Location = new System.Drawing.Point(159, 28);
            this.txtNomeTransportadora.MaxLength = 100;
            this.txtNomeTransportadora.Name = "txtNomeTransportadora";
            this.txtNomeTransportadora.Size = new System.Drawing.Size(171, 20);
            this.txtNomeTransportadora.TabIndex = 147;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Orange;
            this.label20.Location = new System.Drawing.Point(12, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 13);
            this.label20.TabIndex = 145;
            this.label20.Text = "Transp. / Motoboy";
            // 
            // btnTransportadora
            // 
            this.btnTransportadora.BackgroundImage = global::PDV_Beta.Properties.Resources.Find;
            this.btnTransportadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransportadora.Location = new System.Drawing.Point(113, 6);
            this.btnTransportadora.Name = "btnTransportadora";
            this.btnTransportadora.Size = new System.Drawing.Size(40, 35);
            this.btnTransportadora.TabIndex = 144;
            this.btnTransportadora.UseVisualStyleBackColor = true;
            this.btnTransportadora.Click += new System.EventHandler(this.btnTransportadora_Click);
            // 
            // txtCodTransportadora
            // 
            this.txtCodTransportadora.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodTransportadora.Enabled = false;
            this.txtCodTransportadora.Location = new System.Drawing.Point(159, 6);
            this.txtCodTransportadora.MaxLength = 30;
            this.txtCodTransportadora.Name = "txtCodTransportadora";
            this.txtCodTransportadora.Size = new System.Drawing.Size(125, 20);
            this.txtCodTransportadora.TabIndex = 146;
            // 
            // Rel_Entregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.txtNomeTransportadora);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnTransportadora);
            this.Controls.Add(this.txtCodTransportadora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblqualquer);
            this.Controls.Add(this.dateFim);
            this.Controls.Add(this.dateInicio);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.relatorioEntregas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Rel_Entregas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rel_Entregas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer relatorioEntregas;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.DateTimePicker dateFim;
        private System.Windows.Forms.Label lblqualquer;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNomeTransportadora;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnTransportadora;
        public System.Windows.Forms.TextBox txtCodTransportadora;
    }
}