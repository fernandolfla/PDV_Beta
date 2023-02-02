namespace PDV_Beta.Interface.Relatorios
{
    partial class Rel_Caixa_Atual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rel_Caixa_Atual));
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.relatorioCaixaAtivo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboCaixas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateInicio
            // 
            this.dateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicio.Location = new System.Drawing.Point(225, 15);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(86, 20);
            this.dateInicio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inicio";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(332, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(47, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // relatorioCaixaAtivo
            // 
            this.relatorioCaixaAtivo.LocalReport.ReportEmbeddedResource = "PDV_Beta.Interface.Relatorios.Rel_Caixa_Atual.rdlc";
            this.relatorioCaixaAtivo.Location = new System.Drawing.Point(12, 58);
            this.relatorioCaixaAtivo.Name = "relatorioCaixaAtivo";
            this.relatorioCaixaAtivo.Size = new System.Drawing.Size(960, 500);
            this.relatorioCaixaAtivo.TabIndex = 6;
            // 
            // comboCaixas
            // 
            this.comboCaixas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCaixas.FormattingEnabled = true;
            this.comboCaixas.Location = new System.Drawing.Point(65, 15);
            this.comboCaixas.Name = "comboCaixas";
            this.comboCaixas.Size = new System.Drawing.Size(90, 21);
            this.comboCaixas.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Caixa";
            // 
            // Rel_Caixa_Atual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboCaixas);
            this.Controls.Add(this.relatorioCaixaAtivo);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Rel_Caixa_Atual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rel_Caixa_Atual";
            this.Load += new System.EventHandler(this.Rel_Caixa_Atual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private Microsoft.Reporting.WinForms.ReportViewer relatorioCaixaAtivo;
        private System.Windows.Forms.ComboBox comboCaixas;
        private System.Windows.Forms.Label label2;
    }
}