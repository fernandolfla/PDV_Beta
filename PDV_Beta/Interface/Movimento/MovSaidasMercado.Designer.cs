namespace PDV_Beta.Interface.Movimento
{
    partial class MovSaidasMercado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovSaidasMercado));
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.painelFundos = new System.Windows.Forms.Panel();
            this.painelRecebimento = new System.Windows.Forms.Panel();
            this.btnCancelaReceber = new System.Windows.Forms.Button();
            this.btnOkReceber = new System.Windows.Forms.Button();
            this.btnRecDinheiro = new System.Windows.Forms.Button();
            this.btnRecCartaoCredito = new System.Windows.Forms.Button();
            this.btnRecCartaoDebito = new System.Windows.Forms.Button();
            this.btnRecCartaoConvenio = new System.Windows.Forms.Button();
            this.btnRecCartaoCliente = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtRecTroco = new System.Windows.Forms.TextBox();
            this.txtRecDinheiro = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtRecCartaoCredito = new System.Windows.Forms.TextBox();
            this.txtRecCartaoDebito = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtRecCartaoConvenio = new System.Windows.Forms.TextBox();
            this.txtRecCartaoCliente = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.dataGridProdutos = new System.Windows.Forms.DataGridView();
            this.Linhas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.painelBtnRodape = new System.Windows.Forms.Panel();
            this.pictureFinanceiro = new System.Windows.Forms.PictureBox();
            this.btnReceber = new System.Windows.Forms.Button();
            this.pictureEstoque = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.painelFundo = new System.Windows.Forms.Panel();
            this.btnConsultaPreco = new System.Windows.Forms.Button();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalNota = new System.Windows.Forms.TextBox();
            this.txtSequencia = new System.Windows.Forms.TextBox();
            this.TotalNota = new System.Windows.Forms.Label();
            this.pictureLOGO = new System.Windows.Forms.PictureBox();
            this.painelFundos.SuspendLayout();
            this.painelRecebimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).BeginInit();
            this.painelBtnRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFinanceiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEstoque)).BeginInit();
            this.painelFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCodigoProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoProduto.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProduto.Location = new System.Drawing.Point(58, 175);
            this.txtCodigoProduto.MaxLength = 20;
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(400, 38);
            this.txtCodigoProduto.TabIndex = 1;
            this.txtCodigoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProduto_KeyDown);
            this.txtCodigoProduto.Leave += new System.EventHandler(this.txtCodigoProduto_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 31);
            this.label9.TabIndex = 98;
            this.label9.Text = "Código";
            // 
            // painelFundos
            // 
            this.painelFundos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painelFundos.Controls.Add(this.painelRecebimento);
            this.painelFundos.Controls.Add(this.dataGridProdutos);
            this.painelFundos.Location = new System.Drawing.Point(58, 256);
            this.painelFundos.Name = "painelFundos";
            this.painelFundos.Size = new System.Drawing.Size(900, 370);
            this.painelFundos.TabIndex = 79;
            // 
            // painelRecebimento
            // 
            this.painelRecebimento.Controls.Add(this.btnCancelaReceber);
            this.painelRecebimento.Controls.Add(this.btnOkReceber);
            this.painelRecebimento.Controls.Add(this.btnRecDinheiro);
            this.painelRecebimento.Controls.Add(this.btnRecCartaoCredito);
            this.painelRecebimento.Controls.Add(this.btnRecCartaoDebito);
            this.painelRecebimento.Controls.Add(this.btnRecCartaoConvenio);
            this.painelRecebimento.Controls.Add(this.btnRecCartaoCliente);
            this.painelRecebimento.Controls.Add(this.label30);
            this.painelRecebimento.Controls.Add(this.label29);
            this.painelRecebimento.Controls.Add(this.label28);
            this.painelRecebimento.Controls.Add(this.txtRecTroco);
            this.painelRecebimento.Controls.Add(this.txtRecDinheiro);
            this.painelRecebimento.Controls.Add(this.label26);
            this.painelRecebimento.Controls.Add(this.txtRecCartaoCredito);
            this.painelRecebimento.Controls.Add(this.txtRecCartaoDebito);
            this.painelRecebimento.Controls.Add(this.label25);
            this.painelRecebimento.Controls.Add(this.txtRecCartaoConvenio);
            this.painelRecebimento.Controls.Add(this.txtRecCartaoCliente);
            this.painelRecebimento.Controls.Add(this.label24);
            this.painelRecebimento.Location = new System.Drawing.Point(8, 3);
            this.painelRecebimento.Name = "painelRecebimento";
            this.painelRecebimento.Size = new System.Drawing.Size(400, 360);
            this.painelRecebimento.TabIndex = 152;
            this.painelRecebimento.Visible = false;
            // 
            // btnCancelaReceber
            // 
            this.btnCancelaReceber.Location = new System.Drawing.Point(146, 316);
            this.btnCancelaReceber.Name = "btnCancelaReceber";
            this.btnCancelaReceber.Size = new System.Drawing.Size(75, 23);
            this.btnCancelaReceber.TabIndex = 169;
            this.btnCancelaReceber.Text = "Cancelar";
            this.btnCancelaReceber.UseVisualStyleBackColor = true;
            this.btnCancelaReceber.Click += new System.EventHandler(this.btnCancelaReceber_Click);
            // 
            // btnOkReceber
            // 
            this.btnOkReceber.Enabled = false;
            this.btnOkReceber.Location = new System.Drawing.Point(35, 316);
            this.btnOkReceber.Name = "btnOkReceber";
            this.btnOkReceber.Size = new System.Drawing.Size(75, 23);
            this.btnOkReceber.TabIndex = 168;
            this.btnOkReceber.Text = "OK";
            this.btnOkReceber.UseVisualStyleBackColor = true;
            this.btnOkReceber.Click += new System.EventHandler(this.btnOkReceber_Click);
            // 
            // btnRecDinheiro
            // 
            this.btnRecDinheiro.BackgroundImage = global::PDV_Beta.Properties.Resources.Back;
            this.btnRecDinheiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRecDinheiro.Location = new System.Drawing.Point(346, 193);
            this.btnRecDinheiro.Name = "btnRecDinheiro";
            this.btnRecDinheiro.Size = new System.Drawing.Size(37, 32);
            this.btnRecDinheiro.TabIndex = 167;
            this.btnRecDinheiro.UseVisualStyleBackColor = true;
            this.btnRecDinheiro.Click += new System.EventHandler(this.btnRecDinheiro_Click);
            // 
            // btnRecCartaoCredito
            // 
            this.btnRecCartaoCredito.BackgroundImage = global::PDV_Beta.Properties.Resources.Back;
            this.btnRecCartaoCredito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRecCartaoCredito.Location = new System.Drawing.Point(346, 139);
            this.btnRecCartaoCredito.Name = "btnRecCartaoCredito";
            this.btnRecCartaoCredito.Size = new System.Drawing.Size(37, 32);
            this.btnRecCartaoCredito.TabIndex = 166;
            this.btnRecCartaoCredito.UseVisualStyleBackColor = true;
            this.btnRecCartaoCredito.Click += new System.EventHandler(this.btnRecCartaoCredito_Click);
            // 
            // btnRecCartaoDebito
            // 
            this.btnRecCartaoDebito.BackgroundImage = global::PDV_Beta.Properties.Resources.Back;
            this.btnRecCartaoDebito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRecCartaoDebito.Location = new System.Drawing.Point(346, 96);
            this.btnRecCartaoDebito.Name = "btnRecCartaoDebito";
            this.btnRecCartaoDebito.Size = new System.Drawing.Size(37, 32);
            this.btnRecCartaoDebito.TabIndex = 165;
            this.btnRecCartaoDebito.UseVisualStyleBackColor = true;
            this.btnRecCartaoDebito.Click += new System.EventHandler(this.btnRecCartaoDebito_Click);
            // 
            // btnRecCartaoConvenio
            // 
            this.btnRecCartaoConvenio.BackgroundImage = global::PDV_Beta.Properties.Resources.Back;
            this.btnRecCartaoConvenio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRecCartaoConvenio.Location = new System.Drawing.Point(346, 53);
            this.btnRecCartaoConvenio.Name = "btnRecCartaoConvenio";
            this.btnRecCartaoConvenio.Size = new System.Drawing.Size(37, 32);
            this.btnRecCartaoConvenio.TabIndex = 164;
            this.btnRecCartaoConvenio.UseVisualStyleBackColor = true;
            this.btnRecCartaoConvenio.Click += new System.EventHandler(this.btnRecCartaoConvenio_Click);
            // 
            // btnRecCartaoCliente
            // 
            this.btnRecCartaoCliente.BackgroundImage = global::PDV_Beta.Properties.Resources.Back;
            this.btnRecCartaoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRecCartaoCliente.Location = new System.Drawing.Point(346, 10);
            this.btnRecCartaoCliente.Name = "btnRecCartaoCliente";
            this.btnRecCartaoCliente.Size = new System.Drawing.Size(37, 32);
            this.btnRecCartaoCliente.TabIndex = 163;
            this.btnRecCartaoCliente.UseVisualStyleBackColor = true;
            this.btnRecCartaoCliente.Click += new System.EventHandler(this.btnRecCartaoCliente_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(59, 264);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(45, 13);
            this.label30.TabIndex = 162;
            this.label30.Text = "TROCO";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(47, 203);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(69, 13);
            this.label29.TabIndex = 161;
            this.label29.Text = "Rec Dinheiro";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(10, 148);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(112, 13);
            this.label28.TabIndex = 160;
            this.label28.Text = "Rec Cartão de Crédito";
            // 
            // txtRecTroco
            // 
            this.txtRecTroco.Enabled = false;
            this.txtRecTroco.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecTroco.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtRecTroco.Location = new System.Drawing.Point(145, 249);
            this.txtRecTroco.MaxLength = 15;
            this.txtRecTroco.Name = "txtRecTroco";
            this.txtRecTroco.Size = new System.Drawing.Size(194, 37);
            this.txtRecTroco.TabIndex = 159;
            this.txtRecTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRecDinheiro
            // 
            this.txtRecDinheiro.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecDinheiro.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtRecDinheiro.Location = new System.Drawing.Point(146, 188);
            this.txtRecDinheiro.MaxLength = 15;
            this.txtRecDinheiro.Name = "txtRecDinheiro";
            this.txtRecDinheiro.Size = new System.Drawing.Size(194, 37);
            this.txtRecDinheiro.TabIndex = 158;
            this.txtRecDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRecDinheiro.TextChanged += new System.EventHandler(this.txtRecDinheiro_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(16, 104);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(110, 13);
            this.label26.TabIndex = 157;
            this.label26.Text = "Rec Cartão de Débito";
            // 
            // txtRecCartaoCredito
            // 
            this.txtRecCartaoCredito.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecCartaoCredito.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtRecCartaoCredito.Location = new System.Drawing.Point(146, 134);
            this.txtRecCartaoCredito.MaxLength = 15;
            this.txtRecCartaoCredito.Name = "txtRecCartaoCredito";
            this.txtRecCartaoCredito.Size = new System.Drawing.Size(194, 37);
            this.txtRecCartaoCredito.TabIndex = 156;
            this.txtRecCartaoCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRecCartaoCredito.TextChanged += new System.EventHandler(this.txtRecCartaoCredito_TextChanged);
            // 
            // txtRecCartaoDebito
            // 
            this.txtRecCartaoDebito.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecCartaoDebito.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtRecCartaoDebito.Location = new System.Drawing.Point(146, 91);
            this.txtRecCartaoDebito.MaxLength = 15;
            this.txtRecCartaoDebito.Name = "txtRecCartaoDebito";
            this.txtRecCartaoDebito.Size = new System.Drawing.Size(194, 37);
            this.txtRecCartaoDebito.TabIndex = 155;
            this.txtRecCartaoDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRecCartaoDebito.TextChanged += new System.EventHandler(this.txtRecCartaoDebito_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(4, 63);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(124, 13);
            this.label25.TabIndex = 154;
            this.label25.Text = "Rec Cartão de Convênio";
            // 
            // txtRecCartaoConvenio
            // 
            this.txtRecCartaoConvenio.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecCartaoConvenio.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtRecCartaoConvenio.Location = new System.Drawing.Point(145, 48);
            this.txtRecCartaoConvenio.MaxLength = 15;
            this.txtRecCartaoConvenio.Name = "txtRecCartaoConvenio";
            this.txtRecCartaoConvenio.Size = new System.Drawing.Size(194, 37);
            this.txtRecCartaoConvenio.TabIndex = 153;
            this.txtRecCartaoConvenio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRecCartaoConvenio.TextChanged += new System.EventHandler(this.txtRecCartaoConvenio_TextChanged);
            // 
            // txtRecCartaoCliente
            // 
            this.txtRecCartaoCliente.Enabled = false;
            this.txtRecCartaoCliente.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecCartaoCliente.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtRecCartaoCliente.Location = new System.Drawing.Point(145, 5);
            this.txtRecCartaoCliente.MaxLength = 15;
            this.txtRecCartaoCliente.Name = "txtRecCartaoCliente";
            this.txtRecCartaoCliente.Size = new System.Drawing.Size(194, 37);
            this.txtRecCartaoCliente.TabIndex = 152;
            this.txtRecCartaoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRecCartaoCliente.TextChanged += new System.EventHandler(this.txtRecCartaoCliente_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(26, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(96, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Rec Cartão Cliente";
            // 
            // dataGridProdutos
            // 
            this.dataGridProdutos.AllowUserToAddRows = false;
            this.dataGridProdutos.AllowUserToDeleteRows = false;
            this.dataGridProdutos.AllowUserToResizeColumns = false;
            this.dataGridProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProdutos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Linhas,
            this.Codigo,
            this.Nome,
            this.Qtd,
            this.Preco});
            this.dataGridProdutos.Location = new System.Drawing.Point(-2, -2);
            this.dataGridProdutos.Name = "dataGridProdutos";
            this.dataGridProdutos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProdutos.RowHeadersWidth = 25;
            this.dataGridProdutos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridProdutos.RowTemplate.Height = 30;
            this.dataGridProdutos.Size = new System.Drawing.Size(900, 370);
            this.dataGridProdutos.TabIndex = 0;
            // 
            // Linhas
            // 
            this.Linhas.HeaderText = "Linha";
            this.Linhas.Name = "Linhas";
            this.Linhas.ReadOnly = true;
            this.Linhas.Width = 60;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 190;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MaxInputLength = 200;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 405;
            // 
            // Qtd
            // 
            this.Qtd.HeaderText = "Qtd";
            this.Qtd.MaxInputLength = 15;
            this.Qtd.Name = "Qtd";
            this.Qtd.ReadOnly = true;
            this.Qtd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Qtd.Width = 80;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.MaxInputLength = 20;
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 130;
            // 
            // painelBtnRodape
            // 
            this.painelBtnRodape.Controls.Add(this.pictureFinanceiro);
            this.painelBtnRodape.Controls.Add(this.btnReceber);
            this.painelBtnRodape.Controls.Add(this.pictureEstoque);
            this.painelBtnRodape.Controls.Add(this.btnSalvar);
            this.painelBtnRodape.Controls.Add(this.btnLimpar);
            this.painelBtnRodape.Location = new System.Drawing.Point(61, 633);
            this.painelBtnRodape.Name = "painelBtnRodape";
            this.painelBtnRodape.Size = new System.Drawing.Size(1256, 42);
            this.painelBtnRodape.TabIndex = 2;
            // 
            // pictureFinanceiro
            // 
            this.pictureFinanceiro.BackgroundImage = global::PDV_Beta.Properties.Resources.Dollar;
            this.pictureFinanceiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureFinanceiro.Location = new System.Drawing.Point(552, 7);
            this.pictureFinanceiro.Name = "pictureFinanceiro";
            this.pictureFinanceiro.Size = new System.Drawing.Size(32, 32);
            this.pictureFinanceiro.TabIndex = 74;
            this.pictureFinanceiro.TabStop = false;
            this.pictureFinanceiro.Visible = false;
            // 
            // btnReceber
            // 
            this.btnReceber.Location = new System.Drawing.Point(103, 10);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(80, 25);
            this.btnReceber.TabIndex = 1;
            this.btnReceber.Text = "Receber";
            this.btnReceber.UseVisualStyleBackColor = true;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // pictureEstoque
            // 
            this.pictureEstoque.BackgroundImage = global::PDV_Beta.Properties.Resources.Download;
            this.pictureEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureEstoque.Location = new System.Drawing.Point(502, 7);
            this.pictureEstoque.Name = "pictureEstoque";
            this.pictureEstoque.Size = new System.Drawing.Size(32, 32);
            this.pictureEstoque.TabIndex = 1;
            this.pictureEstoque.TabStop = false;
            this.pictureEstoque.Visible = false;
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
            this.btnLimpar.Location = new System.Drawing.Point(305, 10);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 25);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtData
            // 
            this.txtData.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.txtData.CalendarTitleForeColor = System.Drawing.SystemColors.Control;
            this.txtData.Enabled = false;
            this.txtData.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(1202, 12);
            this.txtData.MaxDate = new System.DateTime(2059, 12, 31, 0, 0, 0, 0);
            this.txtData.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(136, 29);
            this.txtData.TabIndex = 119;
            // 
            // painelFundo
            // 
            this.painelFundo.Controls.Add(this.btnConsultaPreco);
            this.painelFundo.Controls.Add(this.btnRemoverProduto);
            this.painelFundo.Controls.Add(this.label4);
            this.painelFundo.Controls.Add(this.txtTotalNota);
            this.painelFundo.Controls.Add(this.txtSequencia);
            this.painelFundo.Controls.Add(this.TotalNota);
            this.painelFundo.Controls.Add(this.pictureLOGO);
            this.painelFundo.Location = new System.Drawing.Point(0, 0);
            this.painelFundo.Name = "painelFundo";
            this.painelFundo.Size = new System.Drawing.Size(1349, 685);
            this.painelFundo.TabIndex = 3;
            // 
            // btnConsultaPreco
            // 
            this.btnConsultaPreco.BackgroundImage = global::PDV_Beta.Properties.Resources.Dollar;
            this.btnConsultaPreco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultaPreco.Location = new System.Drawing.Point(529, 175);
            this.btnConsultaPreco.Name = "btnConsultaPreco";
            this.btnConsultaPreco.Size = new System.Drawing.Size(46, 38);
            this.btnConsultaPreco.TabIndex = 0;
            this.btnConsultaPreco.UseVisualStyleBackColor = true;
            this.btnConsultaPreco.Click += new System.EventHandler(this.btnConsultaPreco_Click);
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.BackgroundImage = global::PDV_Beta.Properties.Resources.Close;
            this.btnRemoverProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoverProduto.Location = new System.Drawing.Point(599, 175);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(46, 38);
            this.btnRemoverProduto.TabIndex = 1;
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(968, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 120;
            this.label4.Text = "CUPOM";
            // 
            // txtTotalNota
            // 
            this.txtTotalNota.BackColor = System.Drawing.Color.AliceBlue;
            this.txtTotalNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalNota.Enabled = false;
            this.txtTotalNota.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNota.ForeColor = System.Drawing.Color.Red;
            this.txtTotalNota.Location = new System.Drawing.Point(1027, 541);
            this.txtTotalNota.MaxLength = 15;
            this.txtTotalNota.Name = "txtTotalNota";
            this.txtTotalNota.Size = new System.Drawing.Size(240, 41);
            this.txtTotalNota.TabIndex = 117;
            this.txtTotalNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSequencia
            // 
            this.txtSequencia.BackColor = System.Drawing.SystemColors.Window;
            this.txtSequencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSequencia.Enabled = false;
            this.txtSequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSequencia.ForeColor = System.Drawing.Color.DarkRed;
            this.txtSequencia.Location = new System.Drawing.Point(1053, 19);
            this.txtSequencia.MaxLength = 20;
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Size = new System.Drawing.Size(130, 22);
            this.txtSequencia.TabIndex = 121;
            // 
            // TotalNota
            // 
            this.TotalNota.AutoSize = true;
            this.TotalNota.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNota.Location = new System.Drawing.Point(1110, 505);
            this.TotalNota.Name = "TotalNota";
            this.TotalNota.Size = new System.Drawing.Size(73, 33);
            this.TotalNota.TabIndex = 116;
            this.TotalNota.Text = "Total";
            // 
            // pictureLOGO
            // 
            this.pictureLOGO.Location = new System.Drawing.Point(213, 12);
            this.pictureLOGO.Name = "pictureLOGO";
            this.pictureLOGO.Size = new System.Drawing.Size(520, 110);
            this.pictureLOGO.TabIndex = 0;
            this.pictureLOGO.TabStop = false;
            // 
            // MovSaidasMercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 687);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.painelFundos);
            this.Controls.Add(this.painelBtnRodape);
            this.Controls.Add(this.painelFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1364, 725);
            this.Name = "MovSaidasMercado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saídas Completo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.painelFundos.ResumeLayout(false);
            this.painelRecebimento.ResumeLayout(false);
            this.painelRecebimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).EndInit();
            this.painelBtnRodape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFinanceiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEstoque)).EndInit();
            this.painelFundo.ResumeLayout(false);
            this.painelFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLOGO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTotalNota;
        private System.Windows.Forms.Label TotalNota;
        public System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel painelFundos;
        private System.Windows.Forms.DataGridView dataGridProdutos;
        private System.Windows.Forms.Panel painelBtnRodape;
        private System.Windows.Forms.PictureBox pictureEstoque;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.Panel painelRecebimento;
        private System.Windows.Forms.TextBox txtRecCartaoCliente;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtRecCartaoConvenio;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtRecCartaoCredito;
        private System.Windows.Forms.TextBox txtRecCartaoDebito;
        private System.Windows.Forms.TextBox txtRecDinheiro;
        private System.Windows.Forms.TextBox txtRecTroco;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnRecDinheiro;
        private System.Windows.Forms.Button btnRecCartaoCredito;
        private System.Windows.Forms.Button btnRecCartaoDebito;
        private System.Windows.Forms.Button btnRecCartaoConvenio;
        private System.Windows.Forms.Button btnRecCartaoCliente;
        private System.Windows.Forms.Button btnCancelaReceber;
        private System.Windows.Forms.Button btnOkReceber;
        private System.Windows.Forms.PictureBox pictureFinanceiro;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.TextBox txtSequencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel painelFundo;
        private System.Windows.Forms.PictureBox pictureLOGO;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnConsultaPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linhas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
    }
}