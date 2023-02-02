namespace PDV_Beta.Interface
{
    partial class CadProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadProdutos));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.painelBtnRodape = new System.Windows.Forms.Panel();
            this.btnBuscarProdutos = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.RichTextBox();
            this.painelCadFuncionarios = new System.Windows.Forms.Panel();
            this.btnAddImagem = new System.Windows.Forms.Button();
            this.pictureProduto = new System.Windows.Forms.PictureBox();
            this.btnBuscarFornecedor = new System.Windows.Forms.Button();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecoVenda3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecoVenda2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecoVenda1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCadastrarTipo = new System.Windows.Forms.Button();
            this.checkAtivo = new System.Windows.Forms.CheckBox();
            this.checkFracionado = new System.Windows.Forms.CheckBox();
            this.checkEstoque = new System.Windows.Forms.CheckBox();
            this.checkTipo = new System.Windows.Forms.CheckBox();
            this.txtUnidadeVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.btnProxCodLivre = new System.Windows.Forms.Button();
            this.painelBtnRodape.SuspendLayout();
            this.painelCadFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduto)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNome.Location = new System.Drawing.Point(58, 54);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(439, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCodigo.Location = new System.Drawing.Point(112, 18);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(200, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código";
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
            // painelBtnRodape
            // 
            this.painelBtnRodape.Controls.Add(this.btnBuscarProdutos);
            this.painelBtnRodape.Controls.Add(this.label27);
            this.painelBtnRodape.Controls.Add(this.btnSalvar);
            this.painelBtnRodape.Controls.Add(this.btnProximo);
            this.painelBtnRodape.Controls.Add(this.btnLimpar);
            this.painelBtnRodape.Controls.Add(this.btnAnterior);
            this.painelBtnRodape.Controls.Add(this.btnApagar);
            this.painelBtnRodape.Location = new System.Drawing.Point(12, 502);
            this.painelBtnRodape.Name = "painelBtnRodape";
            this.painelBtnRodape.Size = new System.Drawing.Size(760, 42);
            this.painelBtnRodape.TabIndex = 4;
            // 
            // btnBuscarProdutos
            // 
            this.btnBuscarProdutos.BackgroundImage = global::PDV_Beta.Properties.Resources.Find;
            this.btnBuscarProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarProdutos.Location = new System.Drawing.Point(491, 5);
            this.btnBuscarProdutos.Name = "btnBuscarProdutos";
            this.btnBuscarProdutos.Size = new System.Drawing.Size(40, 35);
            this.btnBuscarProdutos.TabIndex = 3;
            this.btnBuscarProdutos.UseVisualStyleBackColor = true;
            this.btnBuscarProdutos.Click += new System.EventHandler(this.btnBuscarProdutos_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackgroundImage = global::PDV_Beta.Properties.Resources.Play;
            this.btnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProximo.Location = new System.Drawing.Point(623, 5);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(50, 35);
            this.btnProximo.TabIndex = 5;
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackgroundImage = global::PDV_Beta.Properties.Resources.Playback;
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnterior.Location = new System.Drawing.Point(567, 5);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(50, 35);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 263);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "Observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(3, 279);
            this.txtObservacoes.MaxLength = 500;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(448, 105);
            this.txtObservacoes.TabIndex = 7;
            this.txtObservacoes.Text = "";
            // 
            // painelCadFuncionarios
            // 
            this.painelCadFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painelCadFuncionarios.Controls.Add(this.btnAddImagem);
            this.painelCadFuncionarios.Controls.Add(this.pictureProduto);
            this.painelCadFuncionarios.Controls.Add(this.btnBuscarFornecedor);
            this.painelCadFuncionarios.Controls.Add(this.txtFornecedor);
            this.painelCadFuncionarios.Controls.Add(this.label12);
            this.painelCadFuncionarios.Controls.Add(this.txtPeso);
            this.painelCadFuncionarios.Controls.Add(this.label11);
            this.painelCadFuncionarios.Controls.Add(this.txtPrecoCusto);
            this.painelCadFuncionarios.Controls.Add(this.label10);
            this.painelCadFuncionarios.Controls.Add(this.txtPrecoVenda3);
            this.painelCadFuncionarios.Controls.Add(this.label9);
            this.painelCadFuncionarios.Controls.Add(this.txtPrecoVenda2);
            this.painelCadFuncionarios.Controls.Add(this.label8);
            this.painelCadFuncionarios.Controls.Add(this.txtPrecoVenda1);
            this.painelCadFuncionarios.Controls.Add(this.label7);
            this.painelCadFuncionarios.Controls.Add(this.label6);
            this.painelCadFuncionarios.Controls.Add(this.panel2);
            this.painelCadFuncionarios.Controls.Add(this.txtUnidadeVenda);
            this.painelCadFuncionarios.Controls.Add(this.label4);
            this.painelCadFuncionarios.Controls.Add(this.txtObservacoes);
            this.painelCadFuncionarios.Controls.Add(this.label19);
            this.painelCadFuncionarios.Location = new System.Drawing.Point(12, 92);
            this.painelCadFuncionarios.Name = "painelCadFuncionarios";
            this.painelCadFuncionarios.Size = new System.Drawing.Size(760, 400);
            this.painelCadFuncionarios.TabIndex = 3;
            // 
            // btnAddImagem
            // 
            this.btnAddImagem.BackgroundImage = global::PDV_Beta.Properties.Resources.Add;
            this.btnAddImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddImagem.Location = new System.Drawing.Point(642, 169);
            this.btnAddImagem.Name = "btnAddImagem";
            this.btnAddImagem.Size = new System.Drawing.Size(40, 35);
            this.btnAddImagem.TabIndex = 43;
            this.btnAddImagem.UseVisualStyleBackColor = true;
            this.btnAddImagem.Click += new System.EventHandler(this.btnAddImagem_Click);
            // 
            // pictureProduto
            // 
            this.pictureProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureProduto.Image = global::PDV_Beta.Properties.Resources.no_image_180x150;
            this.pictureProduto.InitialImage = global::PDV_Beta.Properties.Resources.no_image_180x150;
            this.pictureProduto.Location = new System.Drawing.Point(565, 15);
            this.pictureProduto.Name = "pictureProduto";
            this.pictureProduto.Size = new System.Drawing.Size(180, 150);
            this.pictureProduto.TabIndex = 0;
            this.pictureProduto.TabStop = false;
            // 
            // btnBuscarFornecedor
            // 
            this.btnBuscarFornecedor.BackgroundImage = global::PDV_Beta.Properties.Resources.Find;
            this.btnBuscarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarFornecedor.Location = new System.Drawing.Point(596, 271);
            this.btnBuscarFornecedor.Name = "btnBuscarFornecedor";
            this.btnBuscarFornecedor.Size = new System.Drawing.Size(40, 35);
            this.btnBuscarFornecedor.TabIndex = 6;
            this.btnBuscarFornecedor.UseVisualStyleBackColor = true;
            this.btnBuscarFornecedor.Click += new System.EventHandler(this.btnBuscarFornecedor_Click);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(642, 279);
            this.txtFornecedor.MaxLength = 30;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtFornecedor.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(529, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Fornecedor";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(642, 243);
            this.txtPeso.MaxLength = 8;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 5;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPeso.Enter += new System.EventHandler(this.Peso_Enter);
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Peso_Keypress);
            this.txtPeso.Leave += new System.EventHandler(this.MoedaToTextBox_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(529, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Peso \'Gramas\'";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Location = new System.Drawing.Point(360, 184);
            this.txtPrecoCusto.MaxLength = 13;
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoCusto.TabIndex = 4;
            this.txtPrecoCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoCusto.Enter += new System.EventHandler(this.Custo_Enter);
            this.txtPrecoCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecoCusto_Keypress);
            this.txtPrecoCusto.Leave += new System.EventHandler(this.MoedaToTextBox_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Preço de Custo";
            // 
            // txtPrecoVenda3
            // 
            this.txtPrecoVenda3.Location = new System.Drawing.Point(360, 143);
            this.txtPrecoVenda3.MaxLength = 13;
            this.txtPrecoVenda3.Name = "txtPrecoVenda3";
            this.txtPrecoVenda3.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoVenda3.TabIndex = 3;
            this.txtPrecoVenda3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoVenda3.Enter += new System.EventHandler(this.Preco3_Enter);
            this.txtPrecoVenda3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Preco3_Keypress);
            this.txtPrecoVenda3.Leave += new System.EventHandler(this.MoedaToTextBox_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Preço de Venda 3";
            // 
            // txtPrecoVenda2
            // 
            this.txtPrecoVenda2.Location = new System.Drawing.Point(360, 107);
            this.txtPrecoVenda2.MaxLength = 13;
            this.txtPrecoVenda2.Name = "txtPrecoVenda2";
            this.txtPrecoVenda2.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoVenda2.TabIndex = 2;
            this.txtPrecoVenda2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoVenda2.Enter += new System.EventHandler(this.Preco2_Enter);
            this.txtPrecoVenda2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Preco2_Keypress);
            this.txtPrecoVenda2.Leave += new System.EventHandler(this.MoedaToTextBox_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Preço de Venda 2";
            // 
            // txtPrecoVenda1
            // 
            this.txtPrecoVenda1.Location = new System.Drawing.Point(360, 67);
            this.txtPrecoVenda1.MaxLength = 13;
            this.txtPrecoVenda1.Name = "txtPrecoVenda1";
            this.txtPrecoVenda1.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoVenda1.TabIndex = 1;
            this.txtPrecoVenda1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoVenda1.Enter += new System.EventHandler(this.Preco1_Enter);
            this.txtPrecoVenda1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecoVenda_Keypress);
            this.txtPrecoVenda1.Leave += new System.EventHandler(this.MoedaToTextBox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Preço Venda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Este Produto Controla";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnCadastrarTipo);
            this.panel2.Controls.Add(this.checkAtivo);
            this.panel2.Controls.Add(this.checkFracionado);
            this.panel2.Controls.Add(this.checkEstoque);
            this.panel2.Controls.Add(this.checkTipo);
            this.panel2.Location = new System.Drawing.Point(9, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 200);
            this.panel2.TabIndex = 8;
            // 
            // btnCadastrarTipo
            // 
            this.btnCadastrarTipo.BackgroundImage = global::PDV_Beta.Properties.Resources.Add;
            this.btnCadastrarTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarTipo.Location = new System.Drawing.Point(152, 37);
            this.btnCadastrarTipo.Name = "btnCadastrarTipo";
            this.btnCadastrarTipo.Size = new System.Drawing.Size(40, 35);
            this.btnCadastrarTipo.TabIndex = 3;
            this.btnCadastrarTipo.UseVisualStyleBackColor = true;
            this.btnCadastrarTipo.Click += new System.EventHandler(this.btnCadastrarTipo_Click);
            // 
            // checkAtivo
            // 
            this.checkAtivo.AutoSize = true;
            this.checkAtivo.Checked = true;
            this.checkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAtivo.Location = new System.Drawing.Point(7, 112);
            this.checkAtivo.Name = "checkAtivo";
            this.checkAtivo.Size = new System.Drawing.Size(50, 17);
            this.checkAtivo.TabIndex = 2;
            this.checkAtivo.Text = "Ativo";
            this.checkAtivo.UseVisualStyleBackColor = true;
            // 
            // checkFracionado
            // 
            this.checkFracionado.AutoSize = true;
            this.checkFracionado.Location = new System.Drawing.Point(7, 79);
            this.checkFracionado.Name = "checkFracionado";
            this.checkFracionado.Size = new System.Drawing.Size(79, 17);
            this.checkFracionado.TabIndex = 1;
            this.checkFracionado.Text = "Fracionado";
            this.checkFracionado.UseVisualStyleBackColor = true;
            // 
            // checkEstoque
            // 
            this.checkEstoque.AutoSize = true;
            this.checkEstoque.Checked = true;
            this.checkEstoque.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEstoque.Location = new System.Drawing.Point(7, 18);
            this.checkEstoque.Name = "checkEstoque";
            this.checkEstoque.Size = new System.Drawing.Size(65, 17);
            this.checkEstoque.TabIndex = 4;
            this.checkEstoque.Text = "Estoque";
            this.checkEstoque.UseVisualStyleBackColor = true;
            // 
            // checkTipo
            // 
            this.checkTipo.AutoSize = true;
            this.checkTipo.Location = new System.Drawing.Point(7, 47);
            this.checkTipo.Name = "checkTipo";
            this.checkTipo.Size = new System.Drawing.Size(139, 17);
            this.checkTipo.TabIndex = 0;
            this.checkTipo.Text = "Tipo / Tamanho / Pizza";
            this.checkTipo.UseVisualStyleBackColor = true;
            this.checkTipo.CheckedChanged += new System.EventHandler(this.checkTipo_CheckedChanged);
            // 
            // txtUnidadeVenda
            // 
            this.txtUnidadeVenda.Location = new System.Drawing.Point(360, 28);
            this.txtUnidadeVenda.MaxLength = 5;
            this.txtUnidadeVenda.Name = "txtUnidadeVenda";
            this.txtUnidadeVenda.Size = new System.Drawing.Size(100, 20);
            this.txtUnidadeVenda.TabIndex = 0;
            this.txtUnidadeVenda.Text = "Un";
            this.txtUnidadeVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Unidade de Venda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fabricante";
            // 
            // txtFabricante
            // 
            this.txtFabricante.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFabricante.Location = new System.Drawing.Point(419, 18);
            this.txtFabricante.MaxLength = 50;
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(325, 20);
            this.txtFabricante.TabIndex = 2;
            // 
            // btnProxCodLivre
            // 
            this.btnProxCodLivre.BackgroundImage = global::PDV_Beta.Properties.Resources.Last_recor;
            this.btnProxCodLivre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProxCodLivre.Location = new System.Drawing.Point(58, 10);
            this.btnProxCodLivre.Name = "btnProxCodLivre";
            this.btnProxCodLivre.Size = new System.Drawing.Size(40, 35);
            this.btnProxCodLivre.TabIndex = 28;
            this.btnProxCodLivre.UseVisualStyleBackColor = true;
            this.btnProxCodLivre.Click += new System.EventHandler(this.btnProxCodLivre_Click);
            // 
            // CadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnProxCodLivre);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.painelCadFuncionarios);
            this.Controls.Add(this.painelBtnRodape);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CadProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Produtos";
            this.painelBtnRodape.ResumeLayout(false);
            this.painelBtnRodape.PerformLayout();
            this.painelCadFuncionarios.ResumeLayout(false);
            this.painelCadFuncionarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Panel painelBtnRodape;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RichTextBox txtObservacoes;
        private System.Windows.Forms.Panel painelCadFuncionarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkTipo;
        private System.Windows.Forms.TextBox txtUnidadeVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkEstoque;
        private System.Windows.Forms.CheckBox checkAtivo;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecoVenda3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecoVenda2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecoVenda1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkFracionado;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBuscarFornecedor;
        private System.Windows.Forms.Button btnBuscarProdutos;
        private System.Windows.Forms.Button btnCadastrarTipo;
        private System.Windows.Forms.PictureBox pictureProduto;
        private System.Windows.Forms.Button btnAddImagem;
        public System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Button btnProxCodLivre;
        public System.Windows.Forms.TextBox txtCodigo;
    }
}