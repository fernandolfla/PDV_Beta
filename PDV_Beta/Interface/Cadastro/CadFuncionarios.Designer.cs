namespace PDV_Beta.Interface
{
    partial class CadFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadFuncionarios));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.painelBtnRodape = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.painelCadFuncionarios = new System.Windows.Forms.Panel();
            this.txtNumRua = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtDataAdmissao = new System.Windows.Forms.DateTimePicker();
            this.comboFilial = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.checkFilialTodas = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkFinanceiro = new System.Windows.Forms.CheckBox();
            this.checkSuperUser = new System.Windows.Forms.CheckBox();
            this.checkAtivo = new System.Windows.Forms.CheckBox();
            this.checkConfiguracoes = new System.Windows.Forms.CheckBox();
            this.checkCadastros = new System.Windows.Forms.CheckBox();
            this.checkMovimento = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCLT = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtComissao = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtSalario = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.comboQtdFilhos = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.checkComissionado = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.permi = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtObservacoes = new System.Windows.Forms.RichTextBox();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.painelBtnRodape.SuspendLayout();
            this.painelCadFuncionarios.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(58, 24);
            this.txtCodigo.MaxLength = 3;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNum_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNome.Location = new System.Drawing.Point(58, 60);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(350, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apelido";
            // 
            // txtApelido
            // 
            this.txtApelido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApelido.Location = new System.Drawing.Point(471, 60);
            this.txtApelido.MaxLength = 10;
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(118, 20);
            this.txtApelido.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSenha.Location = new System.Drawing.Point(654, 60);
            this.txtSenha.MaxLength = 6;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 2;
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
            // btnAnterior
            // 
            this.btnAnterior.BackgroundImage = global::PDV_Beta.Properties.Resources.Playback;
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnterior.Location = new System.Drawing.Point(567, 5);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(50, 35);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackgroundImage = global::PDV_Beta.Properties.Resources.Play;
            this.btnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProximo.Location = new System.Drawing.Point(623, 5);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(50, 35);
            this.btnProximo.TabIndex = 4;
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // painelBtnRodape
            // 
            this.painelBtnRodape.Controls.Add(this.label27);
            this.painelBtnRodape.Controls.Add(this.btnSalvar);
            this.painelBtnRodape.Controls.Add(this.btnProximo);
            this.painelBtnRodape.Controls.Add(this.btnLimpar);
            this.painelBtnRodape.Controls.Add(this.btnAnterior);
            this.painelBtnRodape.Controls.Add(this.btnApagar);
            this.painelBtnRodape.Location = new System.Drawing.Point(12, 508);
            this.painelBtnRodape.Name = "painelBtnRodape";
            this.painelBtnRodape.Size = new System.Drawing.Size(760, 42);
            this.painelBtnRodape.TabIndex = 13;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(508, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 13);
            this.label27.TabIndex = 5;
            this.label27.Text = "Buscar";
            // 
            // painelCadFuncionarios
            // 
            this.painelCadFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painelCadFuncionarios.Controls.Add(this.txtNumRua);
            this.painelCadFuncionarios.Controls.Add(this.label28);
            this.painelCadFuncionarios.Controls.Add(this.label26);
            this.painelCadFuncionarios.Controls.Add(this.txtDataNascimento);
            this.painelCadFuncionarios.Controls.Add(this.txtDataAdmissao);
            this.painelCadFuncionarios.Controls.Add(this.comboFilial);
            this.painelCadFuncionarios.Controls.Add(this.label17);
            this.painelCadFuncionarios.Controls.Add(this.checkFilialTodas);
            this.painelCadFuncionarios.Controls.Add(this.panel1);
            this.painelCadFuncionarios.Controls.Add(this.button1);
            this.painelCadFuncionarios.Controls.Add(this.txtCLT);
            this.painelCadFuncionarios.Controls.Add(this.txtCPF);
            this.painelCadFuncionarios.Controls.Add(this.txtRG);
            this.painelCadFuncionarios.Controls.Add(this.txtComissao);
            this.painelCadFuncionarios.Controls.Add(this.txtCelular);
            this.painelCadFuncionarios.Controls.Add(this.txtTelefone);
            this.painelCadFuncionarios.Controls.Add(this.txtSalario);
            this.painelCadFuncionarios.Controls.Add(this.txtCep);
            this.painelCadFuncionarios.Controls.Add(this.comboQtdFilhos);
            this.painelCadFuncionarios.Controls.Add(this.label25);
            this.painelCadFuncionarios.Controls.Add(this.label24);
            this.painelCadFuncionarios.Controls.Add(this.checkComissionado);
            this.painelCadFuncionarios.Controls.Add(this.label23);
            this.painelCadFuncionarios.Controls.Add(this.permi);
            this.painelCadFuncionarios.Controls.Add(this.label22);
            this.painelCadFuncionarios.Controls.Add(this.txtCidade);
            this.painelCadFuncionarios.Controls.Add(this.txtEstado);
            this.painelCadFuncionarios.Controls.Add(this.txtCargo);
            this.painelCadFuncionarios.Controls.Add(this.txtEmail);
            this.painelCadFuncionarios.Controls.Add(this.txtBairro);
            this.painelCadFuncionarios.Controls.Add(this.txtEndereco);
            this.painelCadFuncionarios.Controls.Add(this.txtObservacoes);
            this.painelCadFuncionarios.Controls.Add(this.comboSexo);
            this.painelCadFuncionarios.Controls.Add(this.label21);
            this.painelCadFuncionarios.Controls.Add(this.label20);
            this.painelCadFuncionarios.Controls.Add(this.comboEstadoCivil);
            this.painelCadFuncionarios.Controls.Add(this.label19);
            this.painelCadFuncionarios.Controls.Add(this.label18);
            this.painelCadFuncionarios.Controls.Add(this.label16);
            this.painelCadFuncionarios.Controls.Add(this.label15);
            this.painelCadFuncionarios.Controls.Add(this.label14);
            this.painelCadFuncionarios.Controls.Add(this.label13);
            this.painelCadFuncionarios.Controls.Add(this.label12);
            this.painelCadFuncionarios.Controls.Add(this.label11);
            this.painelCadFuncionarios.Controls.Add(this.label10);
            this.painelCadFuncionarios.Controls.Add(this.label9);
            this.painelCadFuncionarios.Controls.Add(this.label8);
            this.painelCadFuncionarios.Controls.Add(this.label7);
            this.painelCadFuncionarios.Controls.Add(this.label6);
            this.painelCadFuncionarios.Controls.Add(this.label5);
            this.painelCadFuncionarios.Location = new System.Drawing.Point(12, 98);
            this.painelCadFuncionarios.Name = "painelCadFuncionarios";
            this.painelCadFuncionarios.Size = new System.Drawing.Size(760, 400);
            this.painelCadFuncionarios.TabIndex = 14;
            // 
            // txtNumRua
            // 
            this.txtNumRua.Location = new System.Drawing.Point(78, 75);
            this.txtNumRua.MaxLength = 8;
            this.txtNumRua.Name = "txtNumRua";
            this.txtNumRua.Size = new System.Drawing.Size(87, 20);
            this.txtNumRua.TabIndex = 5;
            this.txtNumRua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumRua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNum_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 78);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 70;
            this.label28.Text = "Número";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(538, 155);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(89, 13);
            this.label26.TabIndex = 69;
            this.label26.Text = "Data Nascimento";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataNascimento.Location = new System.Drawing.Point(633, 149);
            this.txtDataNascimento.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.txtDataNascimento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(102, 20);
            this.txtDataNascimento.TabIndex = 16;
            // 
            // txtDataAdmissao
            // 
            this.txtDataAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataAdmissao.Location = new System.Drawing.Point(427, 149);
            this.txtDataAdmissao.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.txtDataAdmissao.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.txtDataAdmissao.Name = "txtDataAdmissao";
            this.txtDataAdmissao.Size = new System.Drawing.Size(102, 20);
            this.txtDataAdmissao.TabIndex = 15;
            // 
            // comboFilial
            // 
            this.comboFilial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilial.FormattingEnabled = true;
            this.comboFilial.Location = new System.Drawing.Point(469, 304);
            this.comboFilial.Name = "comboFilial";
            this.comboFilial.Size = new System.Drawing.Size(121, 21);
            this.comboFilial.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(476, 282);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Filial";
            // 
            // checkFilialTodas
            // 
            this.checkFilialTodas.AutoSize = true;
            this.checkFilialTodas.Checked = true;
            this.checkFilialTodas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFilialTodas.Location = new System.Drawing.Point(509, 281);
            this.checkFilialTodas.Name = "checkFilialTodas";
            this.checkFilialTodas.Size = new System.Drawing.Size(56, 17);
            this.checkFilialTodas.TabIndex = 22;
            this.checkFilialTodas.Text = "Todas";
            this.checkFilialTodas.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkFinanceiro);
            this.panel1.Controls.Add(this.checkSuperUser);
            this.panel1.Controls.Add(this.checkAtivo);
            this.panel1.Controls.Add(this.checkConfiguracoes);
            this.panel1.Controls.Add(this.checkCadastros);
            this.panel1.Controls.Add(this.checkMovimento);
            this.panel1.Location = new System.Drawing.Point(614, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 146);
            this.panel1.TabIndex = 24;
            // 
            // checkFinanceiro
            // 
            this.checkFinanceiro.AutoSize = true;
            this.checkFinanceiro.Location = new System.Drawing.Point(9, 77);
            this.checkFinanceiro.Name = "checkFinanceiro";
            this.checkFinanceiro.Size = new System.Drawing.Size(75, 17);
            this.checkFinanceiro.TabIndex = 3;
            this.checkFinanceiro.Text = "Financeiro";
            this.checkFinanceiro.UseVisualStyleBackColor = true;
            // 
            // checkSuperUser
            // 
            this.checkSuperUser.AutoSize = true;
            this.checkSuperUser.Checked = true;
            this.checkSuperUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSuperUser.Location = new System.Drawing.Point(9, 121);
            this.checkSuperUser.Name = "checkSuperUser";
            this.checkSuperUser.Size = new System.Drawing.Size(93, 17);
            this.checkSuperUser.TabIndex = 5;
            this.checkSuperUser.Text = "Super Usuario";
            this.checkSuperUser.UseVisualStyleBackColor = true;
            // 
            // checkAtivo
            // 
            this.checkAtivo.AutoSize = true;
            this.checkAtivo.Checked = true;
            this.checkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAtivo.Location = new System.Drawing.Point(9, 8);
            this.checkAtivo.Name = "checkAtivo";
            this.checkAtivo.Size = new System.Drawing.Size(50, 17);
            this.checkAtivo.TabIndex = 0;
            this.checkAtivo.Text = "Ativo";
            this.checkAtivo.UseVisualStyleBackColor = true;
            // 
            // checkConfiguracoes
            // 
            this.checkConfiguracoes.AutoSize = true;
            this.checkConfiguracoes.Location = new System.Drawing.Point(9, 100);
            this.checkConfiguracoes.Name = "checkConfiguracoes";
            this.checkConfiguracoes.Size = new System.Drawing.Size(94, 17);
            this.checkConfiguracoes.TabIndex = 4;
            this.checkConfiguracoes.Text = "Configurações";
            this.checkConfiguracoes.UseVisualStyleBackColor = true;
            // 
            // checkCadastros
            // 
            this.checkCadastros.AutoSize = true;
            this.checkCadastros.Location = new System.Drawing.Point(9, 31);
            this.checkCadastros.Name = "checkCadastros";
            this.checkCadastros.Size = new System.Drawing.Size(73, 17);
            this.checkCadastros.TabIndex = 1;
            this.checkCadastros.Text = "Cadastros";
            this.checkCadastros.UseVisualStyleBackColor = true;
            // 
            // checkMovimento
            // 
            this.checkMovimento.AutoSize = true;
            this.checkMovimento.Location = new System.Drawing.Point(9, 54);
            this.checkMovimento.Name = "checkMovimento";
            this.checkMovimento.Size = new System.Drawing.Size(78, 17);
            this.checkMovimento.TabIndex = 2;
            this.checkMovimento.Text = "Movimento";
            this.checkMovimento.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PDV_Beta.Properties.Resources.View;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(37, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 30);
            this.button1.TabIndex = 55;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCLT
            // 
            this.txtCLT.Location = new System.Drawing.Point(78, 188);
            this.txtCLT.MaxLength = 16;
            this.txtCLT.Name = "txtCLT";
            this.txtCLT.Size = new System.Drawing.Size(100, 20);
            this.txtCLT.TabIndex = 17;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(236, 152);
            this.txtCPF.Mask = "00000000000";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(87, 20);
            this.txtCPF.TabIndex = 14;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(78, 152);
            this.txtRG.Mask = "000000000000";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 13;
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(412, 111);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(91, 20);
            this.txtComissao.TabIndex = 11;
            this.txtComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtComissao.Enter += new System.EventHandler(this.Comissao_Enter);
            this.txtComissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Comissao_keyPress);
            this.txtComissao.Leave += new System.EventHandler(this.Comissao_Leave);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(236, 111);
            this.txtCelular.Mask = "(99) 0000-00000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(87, 20);
            this.txtCelular.TabIndex = 10;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(78, 111);
            this.txtTelefone.Mask = "(99) 0000-00000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(87, 20);
            this.txtTelefone.TabIndex = 9;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(412, 75);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(91, 20);
            this.txtSalario.TabIndex = 6;
            this.txtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSalario.Enter += new System.EventHandler(this.Salario_Enter);
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Salario_KeyPress);
            this.txtSalario.Leave += new System.EventHandler(this.Salario_Leave);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(77, 16);
            this.txtCep.Mask = "00000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(67, 20);
            this.txtCep.TabIndex = 0;
            // 
            // comboQtdFilhos
            // 
            this.comboQtdFilhos.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboQtdFilhos.FormattingEnabled = true;
            this.comboQtdFilhos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboQtdFilhos.Location = new System.Drawing.Point(521, 231);
            this.comboQtdFilhos.Name = "comboQtdFilhos";
            this.comboQtdFilhos.Size = new System.Drawing.Size(69, 21);
            this.comboQtdFilhos.TabIndex = 20;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(481, 234);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(34, 13);
            this.label25.TabIndex = 42;
            this.label25.Text = "Filhos";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(518, 114);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 13);
            this.label24.TabIndex = 41;
            this.label24.Text = "Comissionado";
            // 
            // checkComissionado
            // 
            this.checkComissionado.AutoSize = true;
            this.checkComissionado.Location = new System.Drawing.Point(596, 113);
            this.checkComissionado.Name = "checkComissionado";
            this.checkComissionado.Size = new System.Drawing.Size(45, 17);
            this.checkComissionado.TabIndex = 12;
            this.checkComissionado.Text = "SIM";
            this.checkComissionado.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(353, 114);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 13);
            this.label23.TabIndex = 38;
            this.label23.Text = "Comissão";
            // 
            // permi
            // 
            this.permi.AutoSize = true;
            this.permi.Location = new System.Drawing.Point(611, 231);
            this.permi.Name = "permi";
            this.permi.Size = new System.Drawing.Size(60, 13);
            this.permi.TabIndex = 37;
            this.permi.Text = "Permissões";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(367, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 13);
            this.label22.TabIndex = 5;
            this.label22.Text = "Salario";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(388, 13);
            this.txtCidade.MaxLength = 30;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(95, 20);
            this.txtCidade.TabIndex = 2;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(541, 16);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(34, 20);
            this.txtEstado.TabIndex = 3;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(236, 188);
            this.txtCargo.MaxLength = 20;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(165, 20);
            this.txtCargo.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(78, 231);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(373, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(209, 16);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(127, 20);
            this.txtBairro.TabIndex = 1;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(77, 44);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(500, 20);
            this.txtEndereco.TabIndex = 4;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(3, 279);
            this.txtObservacoes.MaxLength = 1000;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(448, 105);
            this.txtObservacoes.TabIndex = 23;
            this.txtObservacoes.Text = "";
            // 
            // comboSexo
            // 
            this.comboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboSexo.Location = new System.Drawing.Point(668, 47);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(85, 21);
            this.comboSexo.TabIndex = 8;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(596, 47);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Sexo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(596, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Estado Civil";
            // 
            // comboEstadoCivil
            // 
            this.comboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstadoCivil.FormattingEnabled = true;
            this.comboEstadoCivil.Items.AddRange(new object[] {
            "Solteiro (a)",
            "Casado (a)",
            "Divorciado (a)"});
            this.comboEstadoCivil.Location = new System.Drawing.Point(668, 13);
            this.comboEstadoCivil.Name = "comboEstadoCivil";
            this.comboEstadoCivil.Size = new System.Drawing.Size(85, 21);
            this.comboEstadoCivil.TabIndex = 7;
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 234);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "E-mail";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(343, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Data Admissão";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(191, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Cargo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Num CLT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(191, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "CPF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Identidade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(191, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Celular";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CEP";
            // 
            // CadFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.painelCadFuncionarios);
            this.Controls.Add(this.painelBtnRodape);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CadFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionarios";
            this.Load += new System.EventHandler(this.CadFuncionarios_Load);
            this.painelBtnRodape.ResumeLayout(false);
            this.painelBtnRodape.PerformLayout();
            this.painelCadFuncionarios.ResumeLayout(false);
            this.painelCadFuncionarios.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Panel painelBtnRodape;
        private System.Windows.Forms.Panel painelCadFuncionarios;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RichTextBox txtObservacoes;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboEstadoCivil;
        private System.Windows.Forms.ComboBox comboQtdFilhos;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox checkComissionado;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label permi;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox txtComissao;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCLT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkFinanceiro;
        private System.Windows.Forms.CheckBox checkSuperUser;
        private System.Windows.Forms.CheckBox checkAtivo;
        private System.Windows.Forms.CheckBox checkConfiguracoes;
        private System.Windows.Forms.CheckBox checkCadastros;
        private System.Windows.Forms.CheckBox checkMovimento;
        private System.Windows.Forms.ComboBox comboFilial;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox checkFilialTodas;
        private System.Windows.Forms.DateTimePicker txtDataAdmissao;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker txtDataNascimento;
        public System.Windows.Forms.MaskedTextBox txtCep;
        public System.Windows.Forms.TextBox txtEstado;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox txtSalario;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtNumRua;
        private System.Windows.Forms.Label label28;
    }
}