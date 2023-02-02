namespace PDV_Beta.Interface.Relatorios
{
    partial class Rel_Vendas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rel_Vendas));
            this.sPRelRelatorioVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rel_VendasDataSet = new PDV_Beta.Rel_VendasDataSet();
            this.relatorioVendas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnOk = new System.Windows.Forms.Button();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.dateFim = new System.Windows.Forms.DateTimePicker();
            this.lblqualquer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sP_Rel_Relatorio_VendasTableAdapter = new PDV_Beta.Rel_VendasDataSetTableAdapters.SP_Rel_Relatorio_VendasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPRelRelatorioVendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rel_VendasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sPRelRelatorioVendasBindingSource
            // 
            this.sPRelRelatorioVendasBindingSource.DataMember = "SP_Rel_Relatorio_Vendas";
            this.sPRelRelatorioVendasBindingSource.DataSource = this.rel_VendasDataSet;
            // 
            // rel_VendasDataSet
            // 
            this.rel_VendasDataSet.DataSetName = "Rel_VendasDataSet";
            this.rel_VendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatorioVendas
            // 
            this.relatorioVendas.LocalReport.ReportEmbeddedResource = "PDV_Beta.Interface.Relatorios.Rel_Vendas.rdlc";
            this.relatorioVendas.Location = new System.Drawing.Point(12, 58);
            this.relatorioVendas.Name = "relatorioVendas";
            this.relatorioVendas.Size = new System.Drawing.Size(960, 500);
            this.relatorioVendas.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(287, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(47, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dateInicio
            // 
            this.dateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicio.Location = new System.Drawing.Point(39, 15);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(86, 20);
            this.dateInicio.TabIndex = 2;
            // 
            // dateFim
            // 
            this.dateFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFim.Location = new System.Drawing.Point(184, 15);
            this.dateFim.Name = "dateFim";
            this.dateFim.Size = new System.Drawing.Size(86, 20);
            this.dateFim.TabIndex = 3;
            // 
            // lblqualquer
            // 
            this.lblqualquer.AutoSize = true;
            this.lblqualquer.Location = new System.Drawing.Point(12, 21);
            this.lblqualquer.Name = "lblqualquer";
            this.lblqualquer.Size = new System.Drawing.Size(21, 13);
            this.lblqualquer.TabIndex = 4;
            this.lblqualquer.Text = "De";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Até";
            // 
            // sP_Rel_Relatorio_VendasTableAdapter
            // 
            this.sP_Rel_Relatorio_VendasTableAdapter.ClearBeforeFill = true;
            // 
            // Rel_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblqualquer);
            this.Controls.Add(this.dateFim);
            this.Controls.Add(this.dateInicio);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.relatorioVendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Rel_Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas";
            this.Load += new System.EventHandler(this.Rel_Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPRelRelatorioVendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rel_VendasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer relatorioVendas;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.DateTimePicker dateFim;
        private System.Windows.Forms.Label lblqualquer;
        private System.Windows.Forms.Label label1;
        private Rel_VendasDataSet rel_VendasDataSet;
        private Rel_VendasDataSetTableAdapters.SP_Rel_Relatorio_VendasTableAdapter sP_Rel_Relatorio_VendasTableAdapter;
        private System.Windows.Forms.BindingSource sPRelRelatorioVendasBindingSource;
    }
}