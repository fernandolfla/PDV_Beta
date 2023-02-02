namespace PDV_Beta.Interface.Configuracao
{
    partial class ConfTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfTelaInicial));
            this.painelBtnRodape = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddImagem = new System.Windows.Forms.Button();
            this.pictureFotoInicio = new System.Windows.Forms.PictureBox();
            this.painelBtnRodape.SuspendLayout();
            this.painelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFotoInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // painelBtnRodape
            // 
            this.painelBtnRodape.Controls.Add(this.btnSalvar);
            this.painelBtnRodape.Location = new System.Drawing.Point(12, 305);
            this.painelBtnRodape.Name = "painelBtnRodape";
            this.painelBtnRodape.Size = new System.Drawing.Size(560, 42);
            this.painelBtnRodape.TabIndex = 5;
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
            // painelPrincipal
            // 
            this.painelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painelPrincipal.Controls.Add(this.pictureFotoInicio);
            this.painelPrincipal.Controls.Add(this.btnAddImagem);
            this.painelPrincipal.Controls.Add(this.label2);
            this.painelPrincipal.Controls.Add(this.txtTitulo);
            this.painelPrincipal.Controls.Add(this.label1);
            this.painelPrincipal.Location = new System.Drawing.Point(12, 15);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(560, 272);
            this.painelPrincipal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(69, 25);
            this.txtTitulo.MaxLength = 30;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(399, 31);
            this.txtTitulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imagem";
            // 
            // btnAddImagem
            // 
            this.btnAddImagem.BackgroundImage = global::PDV_Beta.Properties.Resources.Add;
            this.btnAddImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddImagem.Location = new System.Drawing.Point(76, 88);
            this.btnAddImagem.Name = "btnAddImagem";
            this.btnAddImagem.Size = new System.Drawing.Size(46, 41);
            this.btnAddImagem.TabIndex = 3;
            this.btnAddImagem.UseVisualStyleBackColor = true;
            this.btnAddImagem.Click += new System.EventHandler(this.btnAddImagem_Click);
            // 
            // pictureFotoInicio
            // 
            this.pictureFotoInicio.Location = new System.Drawing.Point(152, 62);
            this.pictureFotoInicio.Name = "pictureFotoInicio";
            this.pictureFotoInicio.Size = new System.Drawing.Size(300, 203);
            this.pictureFotoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFotoInicio.TabIndex = 4;
            this.pictureFotoInicio.TabStop = false;
            // 
            // ConfTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.painelBtnRodape);
            this.Controls.Add(this.painelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "ConfTelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfTelaInicial";
            this.painelBtnRodape.ResumeLayout(false);
            this.painelPrincipal.ResumeLayout(false);
            this.painelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFotoInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel painelBtnRodape;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddImagem;
        private System.Windows.Forms.PictureBox pictureFotoInicio;
    }
}