using PDV_Beta.BLL;
using PDV_Beta.Entity;
using PDV_Beta.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV_Beta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

           
        }

        private bool filial_ok = false;
        private bool usuario_ok = false;

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Entrar(object sender, EventArgs e )
        {

            LoginBLL BLL = new LoginBLL();

            int resposta = BLL.Logar(txtCodFilial.Text, txtNomeFilial.Text, txtCodUsuario.Text, txtSenha.Text);

            BLL.VerificaCaixaAberto();

            switch (resposta)
            {
                case 0: MessageBox.Show("Usuario Invalido");
                    break;
                case 1: MessageBox.Show("Filial Invalida");
                    break;
                case 2: MessageBox.Show("Senha Invalida");
                    break;
                case 3:MessageBox.Show("Senha Incorreta"); 
                    break;
                case 4: MessageBox.Show("O Usuario não tem Acesso a Filial Selecionada");
                    break;
                case 5: DialogResult = DialogResult.OK;
                    break;
                default: MessageBox.Show("Ocorreu erros ao tentar logar, contacte o administrador");
                    break;
            }

            //if (txtCodUsuario.Text.Length > 0 && txtNomeFilial.Text.Length > 0)
            //    if (BLL.Logar(txtCodUsuario.Text, txtSenha.Text))
            //    {
            //        if (filial_ok && usuario_ok)
            //        {
            //            Autenticacao.Login(Convert.ToInt32(txtCodUsuario.Text), txtNomeUsuario.Text, Convert.ToInt32(txtCodFilial.Text), txtNomeFilial.Text);
            //            DialogResult = DialogResult.OK;
            //        }
            //    }
            //    else
            //        MessageBox.Show("Senha invalida");
    
        }

        private void SomenteNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void Cod_Filial_Leave(object sender, EventArgs e)
        {
            LoginBLL BLL = new LoginBLL();
            
            txtNomeFilial.Text =  BLL.VerificaFilial(txtCodFilial.Text);

            if (!txtNomeFilial.Text.Equals("") && txtNomeFilial.Text.Length > 1)
                filial_ok = true;
        }

        private void Cod_Usuario_Leave(object sender, EventArgs e)
        {
            LoginBLL BLL = new LoginBLL();
            txtNomeUsuario.Text = BLL.VerificaUsuario(txtCodUsuario.Text);

            if (!txtNomeUsuario.Text.Equals("") && txtNomeUsuario.Text.Length > 1)
                usuario_ok = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btn_Entrar(1, new EventArgs());
            }
        }

        private void txtNomeFilial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
