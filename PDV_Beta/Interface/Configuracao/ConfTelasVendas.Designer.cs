namespace PDV_Beta.Interface
{
    partial class ConfTelasVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfTelasVendas));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.checkClientePadrao = new System.Windows.Forms.CheckBox();
            this.painelCadFuncionarios = new System.Windows.Forms.Panel();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboOperacao = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.painelBtnRodape = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTabelaPreco = new System.Windows.Forms.ComboBox();
            this.painelCadFuncionarios.SuspendLayout();
            this.painelBtnRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(3, 10);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 25);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // checkClientePadrao
            // 
            this.checkClientePadrao.AutoSize = true;
            this.checkClientePadrao.Location = new System.Drawing.Point(272, 113);
            this.checkClientePadrao.Name = "checkClientePadrao";
            this.checkClientePadrao.Size = new System.Drawing.Size(120, 17);
            this.checkClientePadrao.TabIndex = 53;
            this.checkClientePadrao.Text = "Usar Cliente Padrão";
            this.checkClientePadrao.UseVisualStyleBackColor = true;
            // 
            // painelCadFuncionarios
            // 
            this.painelCadFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painelCadFuncionarios.Controls.Add(this.comboTabelaPreco);
            this.painelCadFuncionarios.Controls.Add(this.label4);
            this.painelCadFuncionarios.Controls.Add(this.btnBuscaCliente);
            this.painelCadFuncionarios.Controls.Add(this.txtNomeCliente);
            this.painelCadFuncionarios.Controls.Add(this.txtCodCliente);
            this.painelCadFuncionarios.Controls.Add(this.label3);
            this.painelCadFuncionarios.Controls.Add(this.comboOperacao);
            this.painelCadFuncionarios.Controls.Add(this.richTextBox1);
            this.painelCadFuncionarios.Controls.Add(this.checkClientePadrao);
            this.painelCadFuncionarios.Controls.Add(this.txtNome);
            this.painelCadFuncionarios.Controls.Add(this.label2);
            this.painelCadFuncionarios.Controls.Add(this.label1);
            this.painelCadFuncionarios.Location = new System.Drawing.Point(12, 15);
            this.painelCadFuncionarios.Name = "painelCadFuncionarios";
            this.painelCadFuncionarios.Size = new System.Drawing.Size(560, 272);
            this.painelCadFuncionarios.TabIndex = 2;
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.BackgroundImage = global::PDV_Beta.Properties.Resources.Find;
            this.btnBuscaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscaCliente.Location = new System.Drawing.Point(85, 103);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(40, 35);
            this.btnBuscaCliente.TabIndex = 84;
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click_1);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(85, 143);
            this.txtNomeCliente.MaxLength = 100;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(393, 20);
            this.txtNomeCliente.TabIndex = 86;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Location = new System.Drawing.Point(131, 111);
            this.txtCodCliente.MaxLength = 30;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(125, 20);
            this.txtCodCliente.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Cliente Padrão";
            // 
            // comboOperacao
            // 
            this.comboOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOperacao.FormattingEnabled = true;
            this.comboOperacao.Location = new System.Drawing.Point(103, 67);
            this.comboOperacao.Name = "comboOperacao";
            this.comboOperacao.Size = new System.Drawing.Size(121, 21);
            this.comboOperacao.TabIndex = 55;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Location = new System.Drawing.Point(359, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(186, 76);
            this.richTextBox1.TabIndex = 54;
            this.richTextBox1.Text = "Dica: Atualize aqui as configurações de cada tela de vendas, Telas de venda rapid" +
    "a necessitam de um cliente padrão";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(103, 22);
            this.txtNome.MaxLength = 10;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(183, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tela";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "CFOP";
            // 
            // painelBtnRodape
            // 
            this.painelBtnRodape.Controls.Add(this.label27);
            this.painelBtnRodape.Controls.Add(this.btnSalvar);
            this.painelBtnRodape.Controls.Add(this.btnProximo);
            this.painelBtnRodape.Controls.Add(this.btnAnterior);
            this.painelBtnRodape.Location = new System.Drawing.Point(12, 305);
            this.painelBtnRodape.Name = "painelBtnRodape";
            this.painelBtnRodape.Size = new System.Drawing.Size(560, 42);
            this.painelBtnRodape.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(370, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 13);
            this.label27.TabIndex = 5;
            this.label27.Text = "Buscar";
            // 
            // btnProximo
            // 
            this.btnProximo.BackgroundImage = global::PDV_Beta.Properties.Resources.Play;
            this.btnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProximo.Location = new System.Drawing.Point(485, 5);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(50, 35);
            this.btnProximo.TabIndex = 4;
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackgroundImage = global::PDV_Beta.Properties.Resources.Playback;
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnterior.Location = new System.Drawing.Point(429, 5);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(50, 35);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Tabela De Preço Padrão";
            // 
            // comboTabelaPreco
            // 
            this.comboTabelaPreco.AutoCompleteCustomSource.AddRange(new string[] {
            "Preço 1",
            "Preço 2",
            "Preço 3"});
            this.comboTabelaPreco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTabelaPreco.FormattingEnabled = true;
            this.comboTabelaPreco.Items.AddRange(new object[] {
            "Preço 1",
            "Preço 2",
            "Preço 3"});
            this.comboTabelaPreco.Location = new System.Drawing.Point(135, 179);
            this.comboTabelaPreco.Name = "comboTabelaPreco";
            this.comboTabelaPreco.Size = new System.Drawing.Size(121, 21);
            this.comboTabelaPreco.TabIndex = 88;
            // 
            // ConfTelasVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.painelCadFuncionarios);
            this.Controls.Add(this.painelBtnRodape);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "ConfTelasVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfTelasVendas";
            this.painelCadFuncionarios.ResumeLayout(false);
            this.painelCadFuncionarios.PerformLayout();
            this.painelBtnRodape.ResumeLayout(false);
            this.painelBtnRodape.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox checkClientePadrao;
        private System.Windows.Forms.Panel painelCadFuncionarios;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel painelBtnRodape;
        private System.Windows.Forms.ComboBox comboOperacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscaCliente;
        public System.Windows.Forms.TextBox txtNomeCliente;
        public System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTabelaPreco;
    }
}