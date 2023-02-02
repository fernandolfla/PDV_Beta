using PDV_Beta.BLL;
using PDV_Beta.Component;
using PDV_Beta.Entity;
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
    public partial class CadProdutoSabores : Form
    {
        private List<ProdutoTipo> proTipo = new List<ProdutoTipo>();
        public CadProdutoSabores()
        {
            InitializeComponent();

            CadProdutoT_T_S_BLL BLL = new CadProdutoT_T_S_BLL();

            proTipo = BLL.ListaProdutoTipo();

            if(proTipo != null)
            {
                foreach(ProdutoTipo p in proTipo)
                {
                    comboTipo.Items.Add(p.Id);
                }
            }


        }
        private bool edita = false;

        

        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show(Erros.GetMensagemErro() + " " +  Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!edita)
            {
                CadProdutoT_T_S_BLL BLL = new CadProdutoT_T_S_BLL();
                ProdutoSabor pro = new ProdutoSabor();

                pro = TelaToEntity();

                if (BLL.CadastraProdutoSabor(pro))
                {
                    MessageBox.Show("Cadastro Realizado com Sucesso");
                    LimpaTela();
                }
                else
                    MessageBox.Show("Verifique os campos Obrigatórios");

                MensagemErro();
            }

            txtNome.Focus();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (edita)
            {
                DialogResult Result = MessageBox.Show("Realmente deseja Excluir? ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    CadProdutoT_T_S_BLL BLL = new CadProdutoT_T_S_BLL();
                    ProdutoSabor pro = new ProdutoSabor();

                    pro = TelaToEntity();
                    if (BLL.ApagaProdutoSabor(txtCodigo.Text))
                    {
                        MessageBox.Show("Sabor Deletado com Sucesso");
                    }
                    else MessageBox.Show("O Sabor já foi utilizado e não poderá ser excluido");

                    LimpaTela();
                    MensagemErro();

                }
            }
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            CadProdutoT_T_S_BLL BLL = new CadProdutoT_T_S_BLL();
            ProdutoSabor pro = new ProdutoSabor();

            pro = TelaToEntity();

            pro = BLL.BuscaAntProdutoSabor(pro);

            if (pro != null)
            {
                LimpaTela();
                EntityToTela(pro);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();
            edita = true;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            CadProdutoT_T_S_BLL BLL = new CadProdutoT_T_S_BLL();
            ProdutoSabor pro = new ProdutoSabor();

            pro = TelaToEntity();

            pro = BLL.BuscaProxProdutoSabor(pro);

            if (pro != null)
            {
                LimpaTela();
                EntityToTela(pro);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();
            edita = true;
        }


        private void LimpaTela()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            comboTipo.Text = "";
            txtTipoNome.Text = "";

            edita = false;
        }
        private ProdutoSabor TelaToEntity()
        {
            ProdutoSabor pro = new ProdutoSabor();

            pro.Id = txtCodigo.Text;
            pro.Nome = txtNome.Text;
            pro.Produto_Tipo = comboTipo.Text;

            return pro;
        }

        private void EntityToTela(ProdutoSabor pro)
        {
            txtCodigo.Text = pro.Id;
            txtNome.Text = pro.Nome;
            comboTipo.Text = pro.Produto_Tipo;
            AtualizaTextTipo();
        }

        private void comboTibo_IndexChange(object sender, EventArgs e)
        {
            AtualizaTextTipo();
        }


        private void AtualizaTextTipo()
        {
            try
            {
                if (proTipo != null)
                {
                    foreach (ProdutoTipo p in proTipo)
                    {
                        if (p.Id.Equals(comboTipo.SelectedItem.ToString()))
                            txtTipoNome.Text = p.Nome;
                    }
                }
            }
            catch (Exception) { }
        }

        
    }
}
