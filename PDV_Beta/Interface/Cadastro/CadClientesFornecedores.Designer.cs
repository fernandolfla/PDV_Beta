namespace PDV_Beta.Interface
{
    partial class CadClientesFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadClientesFornecedores));
            this.txtNumRua = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkAtivo = new System.Windows.Forms.CheckBox();
            this.checkTemConta = new System.Windows.Forms.CheckBox();
            this.checkCompraParcelado = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtInscricao = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.permi = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtObservacoes = new System.Windows.Forms.RichTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelMunicipal = new System.Windows.Forms.Label();
            this.labelCNPJ = new System.Windows.Forms.Label();
            this.labelInscricao = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.painelCadFuncionarios = new System.Windows.Forms.Panel();
            this.txtLimiteCred = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtRuaProx = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.comboOpEntrada = new System.Windows.Forms.ComboBox();
            this.comboOpSaida = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtEmailFinanceiro = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDiaVencConta = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInscricaoMunicipal = new System.Windows.Forms.MaskedTextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.comboFisicaJuridica = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.labelFantasia = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnProxCodLivre = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFretePadrao = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.painelCadFuncionarios.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumRua
            // 
            this.txtNumRua.Location = new System.Drawing.Point(84, 75);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkAtivo);
            this.panel1.Controls.Add(this.checkTemConta);
            this.panel1.Controls.Add(this.checkCompraParcelado);
            this.panel1.Location = new System.Drawing.Point(614, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 111);
            this.panel1.TabIndex = 24;
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
            // checkTemConta
            // 
            this.checkTemConta.AutoSize = true;
            this.checkTemConta.Location = new System.Drawing.Point(9, 31);
            this.checkTemConta.Name = "checkTemConta";
            this.checkTemConta.Size = new System.Drawing.Size(84, 17);
            this.checkTemConta.TabIndex = 1;
            this.checkTemConta.Text = "Tem Conta?";
            this.checkTemConta.UseVisualStyleBackColor = true;
            // 
            // checkCompraParcelado
            // 
            this.checkCompraParcelado.AutoSize = true;
            this.checkCompraParcelado.Location = new System.Drawing.Point(9, 54);
            this.checkCompraParcelado.Name = "checkCompraParcelado";
            this.checkCompraParcelado.Size = new System.Drawing.Size(119, 17);
            this.checkCompraParcelado.TabIndex = 2;
            this.checkCompraParcelado.Text = "Compra Parcelado?";
            this.checkCompraParcelado.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PDV_Beta.Properties.Resources.View;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(37, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 30);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(435, 108);
            this.txtCNPJ.Mask = "00000000000000";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(100, 20);
            this.txtCNPJ.TabIndex = 10;
            // 
            // txtInscricao
            // 
            this.txtInscricao.Location = new System.Drawing.Point(84, 108);
            this.txtInscricao.Mask = "00000000000A";
            this.txtInscricao.Name = "txtInscricao";
            this.txtInscricao.Size = new System.Drawing.Size(87, 20);
            this.txtInscricao.TabIndex = 8;
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Location = new System.Drawing.Point(659, 108);
            this.txtTelefone2.Mask = "(99) 0000-00000";
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(87, 20);
            this.txtTelefone2.TabIndex = 11;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(659, 75);
            this.txtTelefone.Mask = "(99) 0000-00000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(87, 20);
            this.txtTelefone.TabIndex = 7;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(84, 16);
            this.txtCep.Mask = "00000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(67, 20);
            this.txtCep.TabIndex = 0;
            // 
            // permi
            // 
            this.permi.AutoSize = true;
            this.permi.Location = new System.Drawing.Point(611, 263);
            this.permi.Name = "permi";
            this.permi.Size = new System.Drawing.Size(60, 13);
            this.permi.TabIndex = 37;
            this.permi.Text = "Permissões";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(191, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 13);
            this.label22.TabIndex = 5;
            this.label22.Text = "Complemento";
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
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(84, 177);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(373, 20);
            this.txtEmail.TabIndex = 15;
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
            this.txtEndereco.Location = new System.Drawing.Point(84, 44);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(491, 20);
            this.txtEndereco.TabIndex = 4;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(3, 279);
            this.txtObservacoes.MaxLength = 1000;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(448, 105);
            this.txtObservacoes.TabIndex = 18;
            this.txtObservacoes.Text = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(613, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Tipo";
            // 
            // comboTipo
            // 
            this.comboTipo.DisplayMember = "1";
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "C - Cliente",
            "F - Fornecedor"});
            this.comboTipo.Location = new System.Drawing.Point(650, 55);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(110, 21);
            this.comboTipo.TabIndex = 4;
            this.comboTipo.Tag = "";
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
            this.label18.Location = new System.Drawing.Point(6, 180);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "E-mail";
            // 
            // labelMunicipal
            // 
            this.labelMunicipal.AutoSize = true;
            this.labelMunicipal.Location = new System.Drawing.Point(191, 111);
            this.labelMunicipal.Name = "labelMunicipal";
            this.labelMunicipal.Size = new System.Drawing.Size(77, 13);
            this.labelMunicipal.TabIndex = 11;
            this.labelMunicipal.Text = "Insc. municipal";
            // 
            // labelCNPJ
            // 
            this.labelCNPJ.AutoSize = true;
            this.labelCNPJ.Location = new System.Drawing.Point(385, 111);
            this.labelCNPJ.Name = "labelCNPJ";
            this.labelCNPJ.Size = new System.Drawing.Size(34, 13);
            this.labelCNPJ.TabIndex = 8;
            this.labelCNPJ.Text = "CNPJ";
            // 
            // labelInscricao
            // 
            this.labelInscricao.AutoSize = true;
            this.labelInscricao.Location = new System.Drawing.Point(6, 111);
            this.labelInscricao.Name = "labelInscricao";
            this.labelInscricao.Size = new System.Drawing.Size(74, 13);
            this.labelInscricao.TabIndex = 7;
            this.labelInscricao.Text = "Insc. Estadual";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(577, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Tel Comercial";
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
            this.label9.Location = new System.Drawing.Point(599, 78);
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
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNome.Location = new System.Drawing.Point(296, 18);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(427, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCodigo.Location = new System.Drawing.Point(124, 18);
            this.txtCodigo.MaxLength = 9;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNum_KeyPress);
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
            // painelCadFuncionarios
            // 
            this.painelCadFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painelCadFuncionarios.Controls.Add(this.txtFretePadrao);
            this.painelCadFuncionarios.Controls.Add(this.label12);
            this.painelCadFuncionarios.Controls.Add(this.txtLimiteCred);
            this.painelCadFuncionarios.Controls.Add(this.txtReferencia);
            this.painelCadFuncionarios.Controls.Add(this.label29);
            this.painelCadFuncionarios.Controls.Add(this.txtRuaProx);
            this.painelCadFuncionarios.Controls.Add(this.label26);
            this.painelCadFuncionarios.Controls.Add(this.comboOpEntrada);
            this.painelCadFuncionarios.Controls.Add(this.comboOpSaida);
            this.painelCadFuncionarios.Controls.Add(this.label25);
            this.painelCadFuncionarios.Controls.Add(this.label24);
            this.painelCadFuncionarios.Controls.Add(this.label23);
            this.painelCadFuncionarios.Controls.Add(this.txtEmailFinanceiro);
            this.painelCadFuncionarios.Controls.Add(this.label17);
            this.painelCadFuncionarios.Controls.Add(this.txtDiaVencConta);
            this.painelCadFuncionarios.Controls.Add(this.label4);
            this.painelCadFuncionarios.Controls.Add(this.txtInscricaoMunicipal);
            this.painelCadFuncionarios.Controls.Add(this.txtComplemento);
            this.painelCadFuncionarios.Controls.Add(this.txtNumRua);
            this.painelCadFuncionarios.Controls.Add(this.label28);
            this.painelCadFuncionarios.Controls.Add(this.panel1);
            this.painelCadFuncionarios.Controls.Add(this.button1);
            this.painelCadFuncionarios.Controls.Add(this.txtCNPJ);
            this.painelCadFuncionarios.Controls.Add(this.txtInscricao);
            this.painelCadFuncionarios.Controls.Add(this.txtTelefone2);
            this.painelCadFuncionarios.Controls.Add(this.txtTelefone);
            this.painelCadFuncionarios.Controls.Add(this.txtCep);
            this.painelCadFuncionarios.Controls.Add(this.permi);
            this.painelCadFuncionarios.Controls.Add(this.label22);
            this.painelCadFuncionarios.Controls.Add(this.txtCidade);
            this.painelCadFuncionarios.Controls.Add(this.txtEstado);
            this.painelCadFuncionarios.Controls.Add(this.txtEmail);
            this.painelCadFuncionarios.Controls.Add(this.txtBairro);
            this.painelCadFuncionarios.Controls.Add(this.txtEndereco);
            this.painelCadFuncionarios.Controls.Add(this.txtObservacoes);
            this.painelCadFuncionarios.Controls.Add(this.label19);
            this.painelCadFuncionarios.Controls.Add(this.label18);
            this.painelCadFuncionarios.Controls.Add(this.labelMunicipal);
            this.painelCadFuncionarios.Controls.Add(this.labelCNPJ);
            this.painelCadFuncionarios.Controls.Add(this.labelInscricao);
            this.painelCadFuncionarios.Controls.Add(this.label11);
            this.painelCadFuncionarios.Controls.Add(this.label10);
            this.painelCadFuncionarios.Controls.Add(this.label9);
            this.painelCadFuncionarios.Controls.Add(this.label8);
            this.painelCadFuncionarios.Controls.Add(this.label7);
            this.painelCadFuncionarios.Controls.Add(this.label6);
            this.painelCadFuncionarios.Controls.Add(this.label5);
            this.painelCadFuncionarios.Location = new System.Drawing.Point(12, 92);
            this.painelCadFuncionarios.Name = "painelCadFuncionarios";
            this.painelCadFuncionarios.Size = new System.Drawing.Size(760, 400);
            this.painelCadFuncionarios.TabIndex = 5;
            // 
            // txtLimiteCred
            // 
            this.txtLimiteCred.Location = new System.Drawing.Point(659, 144);
            this.txtLimiteCred.MaxLength = 12;
            this.txtLimiteCred.Name = "txtLimiteCred";
            this.txtLimiteCred.Size = new System.Drawing.Size(87, 20);
            this.txtLimiteCred.TabIndex = 14;
            this.txtLimiteCred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLimiteCred.Enter += new System.EventHandler(this.LimiteCred_Enter);
            this.txtLimiteCred.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimiteCred_Keypress);
            this.txtLimiteCred.Leave += new System.EventHandler(this.LimiteCred_Leave);
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(388, 144);
            this.txtReferencia.MaxLength = 50;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(142, 20);
            this.txtReferencia.TabIndex = 13;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(323, 146);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 13);
            this.label29.TabIndex = 85;
            this.label29.Text = "Referência";
            // 
            // txtRuaProx
            // 
            this.txtRuaProx.Location = new System.Drawing.Point(84, 143);
            this.txtRuaProx.MaxLength = 60;
            this.txtRuaProx.Name = "txtRuaProx";
            this.txtRuaProx.Size = new System.Drawing.Size(217, 20);
            this.txtRuaProx.TabIndex = 12;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 147);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 13);
            this.label26.TabIndex = 83;
            this.label26.Text = "Rua Próximo A";
            // 
            // comboOpEntrada
            // 
            this.comboOpEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOpEntrada.FormattingEnabled = true;
            this.comboOpEntrada.Location = new System.Drawing.Point(533, 292);
            this.comboOpEntrada.Name = "comboOpEntrada";
            this.comboOpEntrada.Size = new System.Drawing.Size(72, 21);
            this.comboOpEntrada.TabIndex = 20;
            // 
            // comboOpSaida
            // 
            this.comboOpSaida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOpSaida.FormattingEnabled = true;
            this.comboOpSaida.Location = new System.Drawing.Point(533, 260);
            this.comboOpSaida.Name = "comboOpSaida";
            this.comboOpSaida.Size = new System.Drawing.Size(72, 21);
            this.comboOpSaida.TabIndex = 19;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(466, 295);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 13);
            this.label25.TabIndex = 80;
            this.label25.Text = "Op. Entrada";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(466, 263);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 13);
            this.label24.TabIndex = 79;
            this.label24.Text = "Op. Saída";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(562, 146);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 13);
            this.label23.TabIndex = 77;
            this.label23.Text = "Limite de Credito";
            // 
            // txtEmailFinanceiro
            // 
            this.txtEmailFinanceiro.Location = new System.Drawing.Point(84, 212);
            this.txtEmailFinanceiro.MaxLength = 50;
            this.txtEmailFinanceiro.Name = "txtEmailFinanceiro";
            this.txtEmailFinanceiro.Size = new System.Drawing.Size(373, 20);
            this.txtEmailFinanceiro.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 75;
            this.label17.Text = "E-mail Finan.";
            // 
            // txtDiaVencConta
            // 
            this.txtDiaVencConta.Location = new System.Drawing.Point(659, 174);
            this.txtDiaVencConta.Mask = "00";
            this.txtDiaVencConta.Name = "txtDiaVencConta";
            this.txtDiaVencConta.Size = new System.Drawing.Size(87, 20);
            this.txtDiaVencConta.TabIndex = 16;
            this.txtDiaVencConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Dia Venc. da Conta";
            // 
            // txtInscricaoMunicipal
            // 
            this.txtInscricaoMunicipal.Location = new System.Drawing.Point(282, 108);
            this.txtInscricaoMunicipal.Mask = "0000000000000";
            this.txtInscricaoMunicipal.Name = "txtInscricaoMunicipal";
            this.txtInscricaoMunicipal.Size = new System.Drawing.Size(86, 20);
            this.txtInscricaoMunicipal.TabIndex = 9;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(282, 75);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(293, 20);
            this.txtComplemento.TabIndex = 6;
            // 
            // comboFisicaJuridica
            // 
            this.comboFisicaJuridica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFisicaJuridica.FormattingEnabled = true;
            this.comboFisicaJuridica.Items.AddRange(new object[] {
            "F - Pessoa Física",
            "J - Pessoa Jurídica"});
            this.comboFisicaJuridica.Location = new System.Drawing.Point(486, 55);
            this.comboFisicaJuridica.Name = "comboFisicaJuridica";
            this.comboFisicaJuridica.Size = new System.Drawing.Size(110, 21);
            this.comboFisicaJuridica.TabIndex = 3;
            this.comboFisicaJuridica.SelectedIndexChanged += new System.EventHandler(this.PJouPF_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(430, 58);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "PF ou PJ";
            // 
            // txtFantasia
            // 
            this.txtFantasia.BackColor = System.Drawing.SystemColors.Window;
            this.txtFantasia.Location = new System.Drawing.Point(65, 55);
            this.txtFantasia.MaxLength = 50;
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(350, 20);
            this.txtFantasia.TabIndex = 2;
            // 
            // labelFantasia
            // 
            this.labelFantasia.AutoSize = true;
            this.labelFantasia.Location = new System.Drawing.Point(12, 58);
            this.labelFantasia.Name = "labelFantasia";
            this.labelFantasia.Size = new System.Drawing.Size(47, 13);
            this.labelFantasia.TabIndex = 26;
            this.labelFantasia.Text = "Fantasia";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnBuscarCli);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnAnt);
            this.panel2.Controls.Add(this.btnLimpar);
            this.panel2.Controls.Add(this.btnProx);
            this.panel2.Controls.Add(this.btnApagar);
            this.panel2.Location = new System.Drawing.Point(12, 508);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 42);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buscar";
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.BackgroundImage = global::PDV_Beta.Properties.Resources.Find;
            this.btnBuscarCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarCli.Location = new System.Drawing.Point(513, 4);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(40, 35);
            this.btnBuscarCli.TabIndex = 3;
            this.btnBuscarCli.UseVisualStyleBackColor = true;
            this.btnBuscarCli.Click += new System.EventHandler(this.btnBuscarCli_Click);
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
            // btnAnt
            // 
            this.btnAnt.BackgroundImage = global::PDV_Beta.Properties.Resources.Playback;
            this.btnAnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnt.Location = new System.Drawing.Point(582, 5);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(50, 35);
            this.btnAnt.TabIndex = 4;
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
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
            // btnProx
            // 
            this.btnProx.BackgroundImage = global::PDV_Beta.Properties.Resources.Play;
            this.btnProx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProx.Location = new System.Drawing.Point(638, 5);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(50, 35);
            this.btnProx.TabIndex = 5;
            this.btnProx.UseVisualStyleBackColor = true;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
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
            // btnProxCodLivre
            // 
            this.btnProxCodLivre.BackgroundImage = global::PDV_Beta.Properties.Resources.Last_recor;
            this.btnProxCodLivre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProxCodLivre.Location = new System.Drawing.Point(65, 10);
            this.btnProxCodLivre.Name = "btnProxCodLivre";
            this.btnProxCodLivre.Size = new System.Drawing.Size(40, 35);
            this.btnProxCodLivre.TabIndex = 27;
            this.btnProxCodLivre.UseVisualStyleBackColor = true;
            this.btnProxCodLivre.Click += new System.EventHandler(this.btnProxCodLivre_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(585, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 86;
            this.label12.Text = "Frete Padrão";
            // 
            // txtFretePadrao
            // 
            this.txtFretePadrao.Location = new System.Drawing.Point(659, 44);
            this.txtFretePadrao.MaxLength = 15;
            this.txtFretePadrao.Name = "txtFretePadrao";
            this.txtFretePadrao.Size = new System.Drawing.Size(87, 20);
            this.txtFretePadrao.TabIndex = 87;
            this.txtFretePadrao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFretePadrao.Enter += new System.EventHandler(this.txtFretePadrao_Enter);
            this.txtFretePadrao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFretePadrao_KeyPress);
            this.txtFretePadrao.Leave += new System.EventHandler(this.txtFretePadrao_Leave);
            // 
            // CadClientesFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnProxCodLivre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtFantasia);
            this.Controls.Add(this.labelFantasia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.painelCadFuncionarios);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.comboFisicaJuridica);
            this.Controls.Add(this.label21);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CadClientesFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clientes e Fornecedores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.painelCadFuncionarios.ResumeLayout(false);
            this.painelCadFuncionarios.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNumRua;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkAtivo;
        private System.Windows.Forms.CheckBox checkTemConta;
        private System.Windows.Forms.CheckBox checkCompraParcelado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.MaskedTextBox txtInscricao;
        private System.Windows.Forms.MaskedTextBox txtTelefone2;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        public System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label permi;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.RichTextBox txtObservacoes;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelMunicipal;
        private System.Windows.Forms.Label labelCNPJ;
        private System.Windows.Forms.Label labelInscricao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel painelCadFuncionarios;
        private System.Windows.Forms.ComboBox comboFisicaJuridica;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboOpEntrada;
        private System.Windows.Forms.ComboBox comboOpSaida;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtEmailFinanceiro;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtDiaVencConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtInscricaoMunicipal;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.Label labelFantasia;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtRuaProx;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtLimiteCred;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarCli;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnProxCodLivre;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFretePadrao;
    }
}