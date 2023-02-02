namespace PDV_Beta.Interface.Movimento
{
    partial class MovSaidaPizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovSaidaPizza));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.comboTamanho = new System.Windows.Forms.ComboBox();
            this.lblTananho = new System.Windows.Forms.Label();
            this.lblSabor1 = new System.Windows.Forms.Label();
            this.lblSabor2 = new System.Windows.Forms.Label();
            this.lblSabor3 = new System.Windows.Forms.Label();
            this.lblSabor4 = new System.Windows.Forms.Label();
            this.lblSabor5 = new System.Windows.Forms.Label();
            this.comboSabor1 = new System.Windows.Forms.ComboBox();
            this.comboSabor2 = new System.Windows.Forms.ComboBox();
            this.comboSabor3 = new System.Windows.Forms.ComboBox();
            this.comboSabor4 = new System.Windows.Forms.ComboBox();
            this.comboSabor5 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecoFinal = new System.Windows.Forms.TextBox();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQTDPedacos = new System.Windows.Forms.TextBox();
            this.btnBuscarPizza = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNomePizza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.Borda = new System.Windows.Forms.Label();
            this.comboBorda = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProduto.Location = new System.Drawing.Point(125, 9);
            this.txtCodProduto.MaxLength = 20;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(86, 26);
            this.txtCodProduto.TabIndex = 1;
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(218, 11);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(354, 24);
            this.txtNomeProduto.TabIndex = 2;
            // 
            // comboTamanho
            // 
            this.comboTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTamanho.FormattingEnabled = true;
            this.comboTamanho.Location = new System.Drawing.Point(81, 60);
            this.comboTamanho.Name = "comboTamanho";
            this.comboTamanho.Size = new System.Drawing.Size(186, 28);
            this.comboTamanho.TabIndex = 3;
            this.comboTamanho.SelectedIndexChanged += new System.EventHandler(this.comboTamanho_SelectedIndexChanged);
            // 
            // lblTananho
            // 
            this.lblTananho.AutoSize = true;
            this.lblTananho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTananho.Location = new System.Drawing.Point(4, 63);
            this.lblTananho.Name = "lblTananho";
            this.lblTananho.Size = new System.Drawing.Size(76, 20);
            this.lblTananho.TabIndex = 4;
            this.lblTananho.Text = "Tamanho";
            // 
            // lblSabor1
            // 
            this.lblSabor1.AutoSize = true;
            this.lblSabor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabor1.Location = new System.Drawing.Point(4, 167);
            this.lblSabor1.Name = "lblSabor1";
            this.lblSabor1.Size = new System.Drawing.Size(65, 20);
            this.lblSabor1.TabIndex = 5;
            this.lblSabor1.Text = "Sabor 1";
            this.lblSabor1.Visible = false;
            // 
            // lblSabor2
            // 
            this.lblSabor2.AutoSize = true;
            this.lblSabor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabor2.Location = new System.Drawing.Point(4, 217);
            this.lblSabor2.Name = "lblSabor2";
            this.lblSabor2.Size = new System.Drawing.Size(65, 20);
            this.lblSabor2.TabIndex = 6;
            this.lblSabor2.Text = "Sabor 2";
            this.lblSabor2.Visible = false;
            // 
            // lblSabor3
            // 
            this.lblSabor3.AutoSize = true;
            this.lblSabor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabor3.Location = new System.Drawing.Point(4, 267);
            this.lblSabor3.Name = "lblSabor3";
            this.lblSabor3.Size = new System.Drawing.Size(65, 20);
            this.lblSabor3.TabIndex = 7;
            this.lblSabor3.Text = "Sabor 3";
            this.lblSabor3.Visible = false;
            // 
            // lblSabor4
            // 
            this.lblSabor4.AutoSize = true;
            this.lblSabor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabor4.Location = new System.Drawing.Point(4, 317);
            this.lblSabor4.Name = "lblSabor4";
            this.lblSabor4.Size = new System.Drawing.Size(65, 20);
            this.lblSabor4.TabIndex = 8;
            this.lblSabor4.Text = "Sabor 4";
            this.lblSabor4.Visible = false;
            // 
            // lblSabor5
            // 
            this.lblSabor5.AutoSize = true;
            this.lblSabor5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabor5.Location = new System.Drawing.Point(4, 367);
            this.lblSabor5.Name = "lblSabor5";
            this.lblSabor5.Size = new System.Drawing.Size(65, 20);
            this.lblSabor5.TabIndex = 9;
            this.lblSabor5.Text = "Sabor 5";
            this.lblSabor5.Visible = false;
            // 
            // comboSabor1
            // 
            this.comboSabor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSabor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSabor1.FormattingEnabled = true;
            this.comboSabor1.Location = new System.Drawing.Point(81, 166);
            this.comboSabor1.Name = "comboSabor1";
            this.comboSabor1.Size = new System.Drawing.Size(213, 28);
            this.comboSabor1.TabIndex = 10;
            this.comboSabor1.Visible = false;
            this.comboSabor1.SelectedIndexChanged += new System.EventHandler(this.comboSabor1_SelectedIndexChanged);
            // 
            // comboSabor2
            // 
            this.comboSabor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSabor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSabor2.FormattingEnabled = true;
            this.comboSabor2.Location = new System.Drawing.Point(81, 216);
            this.comboSabor2.Name = "comboSabor2";
            this.comboSabor2.Size = new System.Drawing.Size(213, 28);
            this.comboSabor2.TabIndex = 11;
            this.comboSabor2.Visible = false;
            this.comboSabor2.SelectedIndexChanged += new System.EventHandler(this.comboSabor2_SelectedIndexChanged);
            // 
            // comboSabor3
            // 
            this.comboSabor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSabor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSabor3.FormattingEnabled = true;
            this.comboSabor3.Location = new System.Drawing.Point(81, 266);
            this.comboSabor3.Name = "comboSabor3";
            this.comboSabor3.Size = new System.Drawing.Size(213, 28);
            this.comboSabor3.TabIndex = 12;
            this.comboSabor3.Visible = false;
            this.comboSabor3.SelectedIndexChanged += new System.EventHandler(this.comboSabor3_SelectedIndexChanged);
            // 
            // comboSabor4
            // 
            this.comboSabor4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSabor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSabor4.FormattingEnabled = true;
            this.comboSabor4.Location = new System.Drawing.Point(81, 316);
            this.comboSabor4.Name = "comboSabor4";
            this.comboSabor4.Size = new System.Drawing.Size(213, 28);
            this.comboSabor4.TabIndex = 13;
            this.comboSabor4.Visible = false;
            this.comboSabor4.SelectedIndexChanged += new System.EventHandler(this.comboSabor4_SelectedIndexChanged);
            // 
            // comboSabor5
            // 
            this.comboSabor5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSabor5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSabor5.FormattingEnabled = true;
            this.comboSabor5.Location = new System.Drawing.Point(81, 366);
            this.comboSabor5.Name = "comboSabor5";
            this.comboSabor5.Size = new System.Drawing.Size(213, 28);
            this.comboSabor5.TabIndex = 14;
            this.comboSabor5.Visible = false;
            this.comboSabor5.SelectedIndexChanged += new System.EventHandler(this.comboSabor5_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Preço Final";
            // 
            // txtPrecoFinal
            // 
            this.txtPrecoFinal.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoFinal.Location = new System.Drawing.Point(332, 343);
            this.txtPrecoFinal.Name = "txtPrecoFinal";
            this.txtPrecoFinal.Size = new System.Drawing.Size(221, 37);
            this.txtPrecoFinal.TabIndex = 16;
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPizza.Location = new System.Drawing.Point(332, 398);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(89, 38);
            this.btnAddPizza.TabIndex = 17;
            this.btnAddPizza.Text = "Lançar";
            this.btnAddPizza.UseVisualStyleBackColor = true;
            this.btnAddPizza.Click += new System.EventHandler(this.btnAddPizza_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "QTD de Pedaços ";
            // 
            // txtQTDPedacos
            // 
            this.txtQTDPedacos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQTDPedacos.Enabled = false;
            this.txtQTDPedacos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQTDPedacos.Location = new System.Drawing.Point(448, 54);
            this.txtQTDPedacos.Name = "txtQTDPedacos";
            this.txtQTDPedacos.Size = new System.Drawing.Size(44, 19);
            this.txtQTDPedacos.TabIndex = 19;
            // 
            // btnBuscarPizza
            // 
            this.btnBuscarPizza.BackgroundImage = global::PDV_Beta.Properties.Resources.pizza;
            this.btnBuscarPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarPizza.Location = new System.Drawing.Point(79, 6);
            this.btnBuscarPizza.Name = "btnBuscarPizza";
            this.btnBuscarPizza.Size = new System.Drawing.Size(40, 35);
            this.btnBuscarPizza.TabIndex = 146;
            this.btnBuscarPizza.UseVisualStyleBackColor = true;
            this.btnBuscarPizza.Click += new System.EventHandler(this.btnBuscarPizza_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(478, 399);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 37);
            this.btnLimpar.TabIndex = 147;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNomePizza
            // 
            this.txtNomePizza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomePizza.Enabled = false;
            this.txtNomePizza.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePizza.Location = new System.Drawing.Point(300, 77);
            this.txtNomePizza.Multiline = true;
            this.txtNomePizza.Name = "txtNomePizza";
            this.txtNomePizza.Size = new System.Drawing.Size(277, 129);
            this.txtNomePizza.TabIndex = 148;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 149;
            this.label4.Text = "Observações e Bordas";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.Location = new System.Drawing.Point(303, 248);
            this.txtObservacoes.MaxLength = 100;
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(269, 55);
            this.txtObservacoes.TabIndex = 150;
            // 
            // Borda
            // 
            this.Borda.AutoSize = true;
            this.Borda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borda.Location = new System.Drawing.Point(8, 117);
            this.Borda.Name = "Borda";
            this.Borda.Size = new System.Drawing.Size(52, 20);
            this.Borda.TabIndex = 151;
            this.Borda.Text = "Borda";
            // 
            // comboBorda
            // 
            this.comboBorda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBorda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBorda.FormattingEnabled = true;
            this.comboBorda.Items.AddRange(new object[] {
            "Catupiry",
            "Cheddar",
            "Chocolate",
            "Cream Cheese"});
            this.comboBorda.Location = new System.Drawing.Point(81, 114);
            this.comboBorda.Name = "comboBorda";
            this.comboBorda.Size = new System.Drawing.Size(186, 28);
            this.comboBorda.TabIndex = 152;
            this.comboBorda.SelectedIndexChanged += new System.EventHandler(this.ComboBorda);
            // 
            // MovSaidaPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.comboBorda);
            this.Controls.Add(this.Borda);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomePizza);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscarPizza);
            this.Controls.Add(this.txtQTDPedacos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddPizza);
            this.Controls.Add(this.txtPrecoFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboSabor5);
            this.Controls.Add(this.comboSabor4);
            this.Controls.Add(this.comboSabor3);
            this.Controls.Add(this.comboSabor2);
            this.Controls.Add(this.comboSabor1);
            this.Controls.Add(this.lblSabor5);
            this.Controls.Add(this.lblSabor4);
            this.Controls.Add(this.lblSabor3);
            this.Controls.Add(this.lblSabor2);
            this.Controls.Add(this.lblSabor1);
            this.Controls.Add(this.lblTananho);
            this.Controls.Add(this.comboTamanho);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "MovSaidaPizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Monte sua Pizza";
            this.Load += new System.EventHandler(this.MovSaidaPizza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.ComboBox comboTamanho;
        private System.Windows.Forms.Label lblTananho;
        private System.Windows.Forms.Label lblSabor1;
        private System.Windows.Forms.Label lblSabor2;
        private System.Windows.Forms.Label lblSabor3;
        private System.Windows.Forms.Label lblSabor4;
        private System.Windows.Forms.Label lblSabor5;
        private System.Windows.Forms.ComboBox comboSabor1;
        private System.Windows.Forms.ComboBox comboSabor2;
        private System.Windows.Forms.ComboBox comboSabor3;
        private System.Windows.Forms.ComboBox comboSabor4;
        private System.Windows.Forms.ComboBox comboSabor5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecoFinal;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQTDPedacos;
        private System.Windows.Forms.Button btnBuscarPizza;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtNomePizza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label Borda;
        private System.Windows.Forms.ComboBox comboBorda;
    }
}