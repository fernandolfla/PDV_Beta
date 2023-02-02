namespace PDV_Beta.Interface
{
    partial class MovCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovCaixa));
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnSangria = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.painelBtnRodape = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboCaixas = new System.Windows.Forms.ComboBox();
            this.painelCadFuncionarios = new System.Windows.Forms.Panel();
            this.txtValorInicial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.painelBtnRodape.SuspendLayout();
            this.painelCadFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(3, 10);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(80, 25);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnSangria
            // 
            this.btnSangria.Location = new System.Drawing.Point(175, 10);
            this.btnSangria.Name = "btnSangria";
            this.btnSangria.Size = new System.Drawing.Size(80, 25);
            this.btnSangria.TabIndex = 2;
            this.btnSangria.Text = "Sangria";
            this.btnSangria.UseVisualStyleBackColor = true;
            this.btnSangria.Click += new System.EventHandler(this.btnSangria_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(89, 10);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 25);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // painelBtnRodape
            // 
            this.painelBtnRodape.Controls.Add(this.btnAbrir);
            this.painelBtnRodape.Controls.Add(this.btnSangria);
            this.painelBtnRodape.Controls.Add(this.btnFechar);
            this.painelBtnRodape.Location = new System.Drawing.Point(12, 305);
            this.painelBtnRodape.Name = "painelBtnRodape";
            this.painelBtnRodape.Size = new System.Drawing.Size(560, 42);
            this.painelBtnRodape.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Assumir Caixa";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Location = new System.Drawing.Point(359, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(186, 76);
            this.richTextBox1.TabIndex = 54;
            this.richTextBox1.Text = "Dica: Você deve abrir e fechar o caixa diariamente ou por turnos para se ter um c" +
    "ontrole menlhor.";
            // 
            // comboCaixas
            // 
            this.comboCaixas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCaixas.FormattingEnabled = true;
            this.comboCaixas.Location = new System.Drawing.Point(102, 22);
            this.comboCaixas.Name = "comboCaixas";
            this.comboCaixas.Size = new System.Drawing.Size(121, 21);
            this.comboCaixas.TabIndex = 0;
            this.comboCaixas.SelectedIndexChanged += new System.EventHandler(this.comboCaixas_SelectedIndexChanged);
            // 
            // painelCadFuncionarios
            // 
            this.painelCadFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painelCadFuncionarios.Controls.Add(this.comboCaixas);
            this.painelCadFuncionarios.Controls.Add(this.txtValorInicial);
            this.painelCadFuncionarios.Controls.Add(this.label4);
            this.painelCadFuncionarios.Controls.Add(this.richTextBox1);
            this.painelCadFuncionarios.Controls.Add(this.label3);
            this.painelCadFuncionarios.Controls.Add(this.txtSituacao);
            this.painelCadFuncionarios.Controls.Add(this.label1);
            this.painelCadFuncionarios.Location = new System.Drawing.Point(12, 15);
            this.painelCadFuncionarios.Name = "painelCadFuncionarios";
            this.painelCadFuncionarios.Size = new System.Drawing.Size(560, 272);
            this.painelCadFuncionarios.TabIndex = 0;
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorInicial.Location = new System.Drawing.Point(4, 208);
            this.txtValorInicial.MaxLength = 30;
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.Size = new System.Drawing.Size(158, 37);
            this.txtValorInicial.TabIndex = 1;
            this.txtValorInicial.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Valor Inicial do Caixa";
            // 
            // txtSituacao
            // 
            this.txtSituacao.BackColor = System.Drawing.SystemColors.Window;
            this.txtSituacao.Enabled = false;
            this.txtSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacao.ForeColor = System.Drawing.Color.Red;
            this.txtSituacao.Location = new System.Drawing.Point(102, 100);
            this.txtSituacao.MaxLength = 30;
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(130, 22);
            this.txtSituacao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Situação do Caixa";
            // 
            // MovCaixa
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
            this.Name = "MovCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Abrir / Fechar Caixa";
            this.painelBtnRodape.ResumeLayout(false);
            this.painelCadFuncionarios.ResumeLayout(false);
            this.painelCadFuncionarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnSangria;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel painelBtnRodape;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboCaixas;
        private System.Windows.Forms.Panel painelCadFuncionarios;
        private System.Windows.Forms.TextBox txtValorInicial;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label label1;
    }
}