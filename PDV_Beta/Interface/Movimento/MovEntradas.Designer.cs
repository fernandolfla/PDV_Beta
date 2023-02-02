namespace PDV_Beta.Interface
{
    partial class MovEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovEntradas));
            this.painelFundos = new System.Windows.Forms.Panel();
            this.dataGridProdutos = new System.Windows.Forms.DataGridView();
            this.Linhas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label27 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.painelBtnRodape = new System.Windows.Forms.Panel();
            this.pictureCancelada = new System.Windows.Forms.PictureBox();
            this.btnBuscaEntradas = new System.Windows.Forms.Button();
            this.pictureEstoque = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscaFornecedor = new System.Windows.Forms.Button();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.comboOperacao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumNota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnTransportadora = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTransportadoraCod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPesoBruto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrecoTotal = new System.Windows.Forms.TextBox();
            this.btnADDProduto = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalProdutos = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotalDescontos = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFrete = new System.Windows.Forms.TextBox();
            this.TotalNota = new System.Windows.Forms.Label();
            this.txtTotalNota = new System.Windows.Forms.TextBox();
            this.txtVolumes = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.checkCancelado = new System.Windows.Forms.CheckBox();
            this.btnBuscaProduto = new System.Windows.Forms.Button();
            this.lblCancelada = new System.Windows.Forms.Label();
            this.painelFundos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).BeginInit();
            this.painelBtnRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCancelada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // painelFundos
            // 
            this.painelFundos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painelFundos.Controls.Add(this.dataGridProdutos);
            this.painelFundos.Location = new System.Drawing.Point(12, 226);
            this.painelFundos.Name = "painelFundos";
            this.painelFundos.Size = new System.Drawing.Size(602, 270);
            this.painelFundos.TabIndex = 32;
            // 
            // dataGridProdutos
            // 
            this.dataGridProdutos.AllowUserToAddRows = false;
            this.dataGridProdutos.AllowUserToDeleteRows = false;
            this.dataGridProdutos.AllowUserToResizeColumns = false;
            this.dataGridProdutos.AllowUserToResizeRows = false;
            this.dataGridProdutos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Linhas,
            this.Nome,
            this.Preco,
            this.Qtd,
            this.Desconto,
            this.Total});
            this.dataGridProdutos.Location = new System.Drawing.Point(-2, -2);
            this.dataGridProdutos.Name = "dataGridProdutos";
            this.dataGridProdutos.ReadOnly = true;
            this.dataGridProdutos.RowHeadersWidth = 20;
            this.dataGridProdutos.Size = new System.Drawing.Size(602, 270);
            this.dataGridProdutos.TabIndex = 0;
            // 
            // Linhas
            // 
            this.Linhas.HeaderText = "Linha";
            this.Linhas.Name = "Linhas";
            this.Linhas.ReadOnly = true;
            this.Linhas.Width = 40;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MaxInputLength = 200;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 205;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.MaxInputLength = 20;
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 95;
            // 
            // Qtd
            // 
            this.Qtd.HeaderText = "Qtd";
            this.Qtd.MaxInputLength = 15;
            this.Qtd.Name = "Qtd";
            this.Qtd.ReadOnly = true;
            this.Qtd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Qtd.Width = 50;
            // 
            // Desconto
            // 
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.MaxInputLength = 15;
            this.Desconto.Name = "Desconto";
            this.Desconto.ReadOnly = true;
            this.Desconto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Desconto.Width = 80;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MaxInputLength = 20;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 108;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(445, 16);
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
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(196, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 25);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar NF";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // painelBtnRodape
            // 
            this.painelBtnRodape.Controls.Add(this.pictureCancelada);
            this.painelBtnRodape.Controls.Add(this.btnBuscaEntradas);
            this.painelBtnRodape.Controls.Add(this.pictureEstoque);
            this.painelBtnRodape.Controls.Add(this.label27);
            this.painelBtnRodape.Controls.Add(this.btnSalvar);
            this.painelBtnRodape.Controls.Add(this.btnLimpar);
            this.painelBtnRodape.Controls.Add(this.btnCancelar);
            this.painelBtnRodape.Location = new System.Drawing.Point(12, 506);
            this.painelBtnRodape.Name = "painelBtnRodape";
            this.painelBtnRodape.Size = new System.Drawing.Size(760, 42);
            this.painelBtnRodape.TabIndex = 33;
            // 
            // pictureCancelada
            // 
            this.pictureCancelada.BackgroundImage = global::PDV_Beta.Properties.Resources.Delete;
            this.pictureCancelada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureCancelada.Location = new System.Drawing.Point(353, 7);
            this.pictureCancelada.Name = "pictureCancelada";
            this.pictureCancelada.Size = new System.Drawing.Size(32, 32);
            this.pictureCancelada.TabIndex = 72;
            this.pictureCancelada.TabStop = false;
            this.pictureCancelada.Visible = false;
            // 
            // btnBuscaEntradas
            // 
            this.btnBuscaEntradas.BackgroundImage = global::PDV_Beta.Properties.Resources.Find;
            this.btnBuscaEntradas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscaEntradas.Location = new System.Drawing.Point(491, 5);
            this.btnBuscaEntradas.Name = "btnBuscaEntradas";
            this.btnBuscaEntradas.Size = new System.Drawing.Size(40, 35);
            this.btnBuscaEntradas.TabIndex = 3;
            this.btnBuscaEntradas.UseVisualStyleBackColor = true;
            this.btnBuscaEntradas.Click += new System.EventHandler(this.btnBuscaEntradas_Click);
            // 
            // pictureEstoque
            // 
            this.pictureEstoque.BackgroundImage = global::PDV_Beta.Properties.Resources.Download;
            this.pictureEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureEstoque.Location = new System.Drawing.Point(297, 7);
            this.pictureEstoque.Name = "pictureEstoque";
            this.pictureEstoque.Size = new System.Drawing.Size(32, 32);
            this.pictureEstoque.TabIndex = 1;
            this.pictureEstoque.TabStop = false;
            this.pictureEstoque.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Fornecedor";
            // 
            // btnBuscaFornecedor
            // 
            this.btnBuscaFornecedor.BackgroundImage = global::PDV_Beta.Properties.Resources.Find;
            this.btnBuscaFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscaFornecedor.Location = new System.Drawing.Point(79, 12);
            this.btnBuscaFornecedor.Name = "btnBuscaFornecedor";
            this.btnBuscaFornecedor.Size = new System.Drawing.Size(40, 35);
            this.btnBuscaFornecedor.TabIndex = 6;
            this.btnBuscaFornecedor.UseVisualStyleBackColor = true;
            this.btnBuscaFornecedor.Click += new System.EventHandler(this.btnBuscaFornecedor_Click);
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Enabled = false;
            this.txtCodFornecedor.Location = new System.Drawing.Point(125, 20);
            this.txtCodFornecedor.MaxLength = 30;
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(125, 20);
            this.txtCodFornecedor.TabIndex = 35;
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Enabled = false;
            this.txtNomeFornecedor.Location = new System.Drawing.Point(125, 46);
            this.txtNomeFornecedor.MaxLength = 100;
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(393, 20);
            this.txtNomeFornecedor.TabIndex = 36;
            // 
            // comboOperacao
            // 
            this.comboOperacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOperacao.FormattingEnabled = true;
            this.comboOperacao.Location = new System.Drawing.Point(635, 15);
            this.comboOperacao.Name = "comboOperacao";
            this.comboOperacao.Size = new System.Drawing.Size(121, 21);
            this.comboOperacao.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Operação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Data de Emissão";
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(635, 53);
            this.txtData.MaxDate = new System.DateTime(2059, 12, 31, 0, 0, 0, 0);
            this.txtData.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(121, 20);
            this.txtData.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Número NF";
            // 
            // txtNumNota
            // 
            this.txtNumNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNumNota.Location = new System.Drawing.Point(347, 16);
            this.txtNumNota.MaxLength = 20;
            this.txtNumNota.Name = "txtNumNota";
            this.txtNumNota.Size = new System.Drawing.Size(171, 20);
            this.txtNumNota.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Obs";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(309, 86);
            this.txtObs.MaxLength = 70;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(209, 20);
            this.txtObs.TabIndex = 44;
            // 
            // btnTransportadora
            // 
            this.btnTransportadora.BackgroundImage = global::PDV_Beta.Properties.Resources.Find;
            this.btnTransportadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransportadora.Location = new System.Drawing.Point(97, 78);
            this.btnTransportadora.Name = "btnTransportadora";
            this.btnTransportadora.Size = new System.Drawing.Size(40, 35);
            this.btnTransportadora.TabIndex = 45;
            this.btnTransportadora.UseVisualStyleBackColor = true;
            this.btnTransportadora.Click += new System.EventHandler(this.btnTransportadora_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Transportadora";
            // 
            // txtTransportadoraCod
            // 
            this.txtTransportadoraCod.Enabled = false;
            this.txtTransportadoraCod.Location = new System.Drawing.Point(143, 86);
            this.txtTransportadoraCod.MaxLength = 30;
            this.txtTransportadoraCod.Name = "txtTransportadoraCod";
            this.txtTransportadoraCod.Size = new System.Drawing.Size(125, 20);
            this.txtTransportadoraCod.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Quantidade de Volumes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(576, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Peso Bruto";
            // 
            // txtPesoBruto
            // 
            this.txtPesoBruto.Location = new System.Drawing.Point(668, 133);
            this.txtPesoBruto.MaxLength = 9;
            this.txtPesoBruto.Name = "txtPesoBruto";
            this.txtPesoBruto.Size = new System.Drawing.Size(100, 20);
            this.txtPesoBruto.TabIndex = 51;
            this.txtPesoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Código";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(12, 170);
            this.txtCodigoProduto.MaxLength = 20;
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(107, 20);
            this.txtCodigoProduto.TabIndex = 53;
            this.txtCodigoProduto.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(125, 170);
            this.txtQuantidade.MaxLength = 10;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(60, 20);
            this.txtQuantidade.TabIndex = 55;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.Location = new System.Drawing.Point(12, 196);
            this.txtNomeProduto.MaxLength = 60;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(329, 20);
            this.txtNomeProduto.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(190, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(191, 170);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 58;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(294, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(297, 170);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtDesconto.TabIndex = 60;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(403, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "Preço Total";
            // 
            // txtPrecoTotal
            // 
            this.txtPrecoTotal.Location = new System.Drawing.Point(406, 170);
            this.txtPrecoTotal.Name = "txtPrecoTotal";
            this.txtPrecoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoTotal.TabIndex = 62;
            this.txtPrecoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnADDProduto
            // 
            this.btnADDProduto.Location = new System.Drawing.Point(530, 170);
            this.btnADDProduto.Name = "btnADDProduto";
            this.btnADDProduto.Size = new System.Drawing.Size(75, 23);
            this.btnADDProduto.TabIndex = 63;
            this.btnADDProduto.Text = "Adicionar";
            this.btnADDProduto.UseVisualStyleBackColor = true;
            this.btnADDProduto.Click += new System.EventHandler(this.btnADDProduto_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(639, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 64;
            this.label14.Text = "Total em Produtos";
            // 
            // txtTotalProdutos
            // 
            this.txtTotalProdutos.Enabled = false;
            this.txtTotalProdutos.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProdutos.Location = new System.Drawing.Point(622, 244);
            this.txtTotalProdutos.MaxLength = 15;
            this.txtTotalProdutos.Name = "txtTotalProdutos";
            this.txtTotalProdutos.Size = new System.Drawing.Size(150, 41);
            this.txtTotalProdutos.TabIndex = 65;
            this.txtTotalProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(647, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "Total Descontos";
            // 
            // txtTotalDescontos
            // 
            this.txtTotalDescontos.Enabled = false;
            this.txtTotalDescontos.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDescontos.Location = new System.Drawing.Point(622, 309);
            this.txtTotalDescontos.MaxLength = 15;
            this.txtTotalDescontos.Name = "txtTotalDescontos";
            this.txtTotalDescontos.Size = new System.Drawing.Size(150, 41);
            this.txtTotalDescontos.TabIndex = 67;
            this.txtTotalDescontos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(669, 360);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 68;
            this.label16.Text = "Frete";
            // 
            // txtFrete
            // 
            this.txtFrete.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrete.Location = new System.Drawing.Point(622, 376);
            this.txtFrete.MaxLength = 15;
            this.txtFrete.Name = "txtFrete";
            this.txtFrete.Size = new System.Drawing.Size(150, 41);
            this.txtFrete.TabIndex = 69;
            this.txtFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalNota
            // 
            this.TotalNota.AutoSize = true;
            this.TotalNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNota.Location = new System.Drawing.Point(647, 424);
            this.TotalNota.Name = "TotalNota";
            this.TotalNota.Size = new System.Drawing.Size(82, 20);
            this.TotalNota.TabIndex = 70;
            this.TotalNota.Text = "Total Nota";
            // 
            // txtTotalNota
            // 
            this.txtTotalNota.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNota.Location = new System.Drawing.Point(622, 447);
            this.txtTotalNota.MaxLength = 15;
            this.txtTotalNota.Name = "txtTotalNota";
            this.txtTotalNota.Size = new System.Drawing.Size(150, 41);
            this.txtTotalNota.TabIndex = 71;
            this.txtTotalNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVolumes
            // 
            this.txtVolumes.Location = new System.Drawing.Point(698, 93);
            this.txtVolumes.MaxLength = 3;
            this.txtVolumes.Name = "txtVolumes";
            this.txtVolumes.Size = new System.Drawing.Size(58, 20);
            this.txtVolumes.TabIndex = 72;
            this.txtVolumes.Text = "1";
            this.txtVolumes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(667, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 13);
            this.label17.TabIndex = 73;
            this.label17.Text = "Nota Cancelada?";
            // 
            // checkCancelado
            // 
            this.checkCancelado.AutoSize = true;
            this.checkCancelado.Enabled = false;
            this.checkCancelado.ForeColor = System.Drawing.Color.Red;
            this.checkCancelado.Location = new System.Drawing.Point(698, 182);
            this.checkCancelado.Name = "checkCancelado";
            this.checkCancelado.Size = new System.Drawing.Size(43, 17);
            this.checkCancelado.TabIndex = 74;
            this.checkCancelado.Text = "Sim";
            this.checkCancelado.UseVisualStyleBackColor = true;
            // 
            // btnBuscaProduto
            // 
            this.btnBuscaProduto.BackgroundImage = global::PDV_Beta.Properties.Resources.Find;
            this.btnBuscaProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscaProduto.Location = new System.Drawing.Point(51, 133);
            this.btnBuscaProduto.Name = "btnBuscaProduto";
            this.btnBuscaProduto.Size = new System.Drawing.Size(40, 35);
            this.btnBuscaProduto.TabIndex = 76;
            this.btnBuscaProduto.UseVisualStyleBackColor = true;
            this.btnBuscaProduto.Click += new System.EventHandler(this.btnBuscaProduto_Click);
            // 
            // lblCancelada
            // 
            this.lblCancelada.AutoSize = true;
            this.lblCancelada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelada.ForeColor = System.Drawing.Color.Crimson;
            this.lblCancelada.Location = new System.Drawing.Point(115, 116);
            this.lblCancelada.Name = "lblCancelada";
            this.lblCancelada.Size = new System.Drawing.Size(0, 13);
            this.lblCancelada.TabIndex = 77;
            // 
            // MovEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblCancelada);
            this.Controls.Add(this.btnBuscaProduto);
            this.Controls.Add(this.checkCancelado);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtVolumes);
            this.Controls.Add(this.txtTotalNota);
            this.Controls.Add(this.TotalNota);
            this.Controls.Add(this.txtFrete);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTotalDescontos);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTotalProdutos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnADDProduto);
            this.Controls.Add(this.txtPrecoTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPesoBruto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTransportadoraCod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTransportadora);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumNota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboOperacao);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.txtCodFornecedor);
            this.Controls.Add(this.btnBuscaFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.painelFundos);
            this.Controls.Add(this.painelBtnRodape);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MovEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entradas";
            this.painelFundos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).EndInit();
            this.painelBtnRodape.ResumeLayout(false);
            this.painelBtnRodape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCancelada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel painelFundos;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel painelBtnRodape;
        private System.Windows.Forms.Button btnBuscaEntradas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscaFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Button btnTransportadora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPesoBruto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrecoTotal;
        private System.Windows.Forms.Button btnADDProduto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotalProdutos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotalDescontos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtFrete;
        private System.Windows.Forms.Label TotalNota;
        private System.Windows.Forms.TextBox txtTotalNota;
        private System.Windows.Forms.DataGridView dataGridProdutos;
        private System.Windows.Forms.PictureBox pictureEstoque;
        private System.Windows.Forms.PictureBox pictureCancelada;
        private System.Windows.Forms.TextBox txtVolumes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox checkCancelado;
        public System.Windows.Forms.TextBox txtCodFornecedor;
        public System.Windows.Forms.TextBox txtNomeFornecedor;
        public System.Windows.Forms.ComboBox comboOperacao;
        public System.Windows.Forms.TextBox txtTransportadoraCod;
        private System.Windows.Forms.Button btnBuscaProduto;
        public System.Windows.Forms.TextBox txtCodigoProduto;
        public System.Windows.Forms.TextBox txtPreco;
        public System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linhas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label lblCancelada;
    }
}