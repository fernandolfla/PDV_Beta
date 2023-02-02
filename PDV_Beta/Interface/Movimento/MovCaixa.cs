using PDV_Beta.BLL;
using PDV_Beta.Component;
using PDV_Beta.Entity;
using PDV_Beta.Seguranca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV_Beta.Interface
{
    public partial class MovCaixa : Form
    {
        private List<Caixa> cxs = new List<Caixa>();
        private string caixaSelected = null;
        public MovCaixa()
        {
            InitializeComponent();

            AplicarEventos(txtValorInicial);


            MovCaixaBLL BLL = new MovCaixaBLL();
            cxs = BLL.ListaCaixa();

            foreach (Caixa c in cxs)
            {
                comboCaixas.Items.Add(c.Nome);

                if(Autenticacao.GetCaixa_Status())
                    if (c.Id.Equals(Autenticacao.GetCaixa().ToString()))
                    {
                        comboCaixas.Text = c.Nome;
                        comboCaixas.Enabled = false;
                        txtValorInicial.Visible = false;
                    }
            }

            if(Autenticacao.GetCaixa_Status())
            {
                Aberto();
            }


            MensagemErro();
        }
        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show(Erros.GetMensagemErro() + " " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }

        private decimal GetValorInicial()
        {
            decimal vl;
            try { vl = Convert.ToDecimal(txtValorInicial.Text.Replace("R$", "").Trim()); } catch{ vl = 0; }
            return vl;
        }

        private void Aberto()
        {
            btnFechar.Enabled = true;
            btnSangria.Enabled = true;
            btnAbrir.Enabled = false;
        }
        private void Fechado()
        {
            btnFechar.Enabled = false;
            btnSangria.Enabled = false;
            btnAbrir.Enabled = true;
        }


        private void btnSangria_Click(object sender, EventArgs e)
        {
            MovCaixaBLL BLL = new MovCaixaBLL();
            if(Autenticacao.GetCaixa_Status())
            {
                MessageBox.Show("Função não disponivel no momento");
            }

            MensagemErro();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            MovCaixaBLL BLL = new MovCaixaBLL();
            if (Autenticacao.GetCaixa_Status())
            {
                if (BLL.Fechar())
                {
                    MessageBox.Show("Caixa Fechado com Sucesso!");
                    this.Close();
                }
            }
            MensagemErro();
           
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            MovCaixaBLL BLL = new MovCaixaBLL();
            if(caixaSelected != null)
            {
                if(BLL.Abrir(caixaSelected,GetValorInicial()))
                {
                    MessageBox.Show("Caixa Aberto com Sucesso!");
                    this.Close();
                }
            }

            MensagemErro();
            
        }



        private void comboCaixas_SelectedIndexChanged(object sender, EventArgs e)
        {
            MovCaixaBLL BLL = new MovCaixaBLL();
            Caixa_Situacao c = new Caixa_Situacao();
            
            c = BLL.Busca(cxs[comboCaixas.SelectedIndex].Id);
            caixaSelected = cxs[comboCaixas.SelectedIndex].Id;

            if (c != null)
            {
                if (c.SituacaoId == 1)
                {
                    Aberto();
                    txtValorInicial.Visible = false;
                }
                else {
                    Fechado();
                    txtValorInicial.Visible = true;
                }

                txtSituacao.Text = c.SituacaoNome;
            }
            else
            {
                txtSituacao.Text = "Fechado";
                txtValorInicial.Visible = true;
                Fechado();
            }
   
        }



        private void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }


        private void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }
        private void RetornarMascara(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                txt.Text = double.Parse(txt.Text).ToString("C2");
            }
            catch (Exception) { }
        }

        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }



    }
}
