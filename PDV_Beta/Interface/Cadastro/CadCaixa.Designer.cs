namespace PDV_Beta.Interface
{
    partial class CadCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadCaixa));
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.checAtivo = new System.Windows.Forms.CheckBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.painelCadFuncionarios = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.painelBtnRodape = new System.Windows.Forms.Panel();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.painelCadFuncionarios.SuspendLayout();
            this.painelBtnRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescricao.Location = new System.Drawing.Point(74, 148);
            this.txtDescricao.MaxLength = 30;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(287, 20);
            this.txtDescricao.TabIndex = 2;
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
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(100, 10);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 25);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // checAtivo
            // 
            this.checAtivo.AutoSize = true;
            this.checAtivo.Checked = true;
            this.checAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checAtivo.Location = new System.Drawing.Point(28, 215);
            this.checAtivo.Name = "checAtivo";
            this.checAtivo.Size = new System.Drawing.Size(50, 17);
            this.checAtivo.TabIndex = 53;
            this.checAtivo.Text = "Ativo";
            this.checAtivo.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(196, 10);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(80, 25);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // painelCadFuncionarios
            // 
            this.painelCadFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painelCadFuncionarios.Controls.Add(this.richTextBox1);
            this.painelCadFuncionarios.Controls.Add(this.checAtivo);
            this.painelCadFuncionarios.Controls.Add(this.label3);
            this.painelCadFuncionarios.Controls.Add(this.txtCodigo);
            this.painelCadFuncionarios.Controls.Add(this.txtDescricao);
            this.painelCadFuncionarios.Controls.Add(this.txtNome);
            this.painelCadFuncionarios.Controls.Add(this.label2);
            this.painelCadFuncionarios.Controls.Add(this.label1);
            this.painelCadFuncionarios.Location = new System.Drawing.Point(12, 15);
            this.painelCadFuncionarios.Name = "painelCadFuncionarios";
            this.painelCadFuncionarios.Size = new System.Drawing.Size(560, 272);
            this.painelCadFuncionarios.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Location = new System.Drawing.Point(359, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(186, 76);
            this.richTextBox1.TabIndex = 54;
            this.richTextBox1.Text = "Dica:Você pode Cadastrar Diversos Caixas de Acordo como sua Necessidade, os caixa" +
    "s são separados por Filiais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(74, 22);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(71, 20);
            this.txtCodigo.TabIndex = 50;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNome.Location = new System.Drawing.Point(74, 81);
            this.txtNome.MaxLength = 10;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(138, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Descrição";
            // 
            // painelBtnRodape
            // 
            this.painelBtnRodape.Controls.Add(this.label27);
            this.painelBtnRodape.Controls.Add(this.btnSalvar);
            this.painelBtnRodape.Controls.Add(this.btnProximo);
            this.painelBtnRodape.Controls.Add(this.btnLimpar);
            this.painelBtnRodape.Controls.Add(this.btnAnterior);
            this.painelBtnRodape.Controls.Add(this.btnApagar);
            this.painelBtnRodape.Location = new System.Drawing.Point(12, 305);
            this.painelBtnRodape.Name = "painelBtnRodape";
            this.painelBtnRodape.Size = new System.Drawing.Size(560, 42);
            this.painelBtnRodape.TabIndex = 1;
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
            // CadCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.painelCadFuncionarios);
            this.Controls.Add(this.painelBtnRodape);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "CadCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Caixa";
            this.painelCadFuncionarios.ResumeLayout(false);
            this.painelCadFuncionarios.PerformLayout();
            this.painelBtnRodape.ResumeLayout(false);
            this.painelBtnRodape.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.CheckBox checAtivo;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Panel painelCadFuncionarios;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel painelBtnRodape;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}