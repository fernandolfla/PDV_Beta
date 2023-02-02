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
    public partial class CadProdutoTipoTamanhoPreco : Form
    {
        private List<ProdutoTipo> proTipo = new List<ProdutoTipo>();
        private List<ProdutoTamanho> proTamanho = new List<ProdutoTamanho>();
        public CadProdutoTipoTamanhoPreco()
        {
            InitializeComponent();

            CadProdutoT_T_S_BLL BLL = new CadProdutoT_T_S_BLL();

            proTipo = BLL.ListaProdutoTipo();

            comboTipo.Items.Add("");
            comboTamanho.Items.Add("");

            if (proTipo != null)
            {
                foreach (ProdutoTipo p in proTipo)
                {
                    comboTipo.Items.Add(p.Id);
                }
            }

            proTamanho = BLL.ListaProdutoTamanho();

            if(proTamanho != null)
            {
                foreach(ProdutoTamanho t in proTamanho)
                {
                    comboTamanho.Items.Add(t.Id);
                }
            }

        }

        private void btnCadastrarSabores_Click(object sender, EventArgs e)
        {
            CadProdutoSabores sabor = new CadProdutoSabores();
            sabor.ShowDialog();
        }

        private void btnCadastrarTipo_Click(object sender, EventArgs e)
        {
            CadProdutoTipo tipo = new CadProdutoTipo();
            tipo.ShowDialog();
        }

        private void btnCadastrarTamanho_Click(object sender, EventArgs e)
        {
            CadProdutoTamanho tamanho = new CadProdutoTamanho();
            tamanho.ShowDialog();
        }

        private bool edita = false;


        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show(Erros.GetMensagemErro() + " " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //if (!edita)
            
                CadProdutoT_T_S_BLL BLL = new CadProdutoT_T_S_BLL();
                ProdutoTipoTamanhoPreco pro = new ProdutoTipoTamanhoPreco();

                pro = TelaToEntity();

                if (BLL.CadastraProdutoTipoTamanhoPreco(pro))
                {
                    MessageBox.Show("Cadastro Realizado com Sucesso");
                    LimpaTela();
                }
                else
                    MessageBox.Show("Verifique os campos Obrigatórios");


                MensagemErro();
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (edita)
            {
                DialogResult Result = MessageBox.Show("Realmente deseja Excluir? ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    CadProdutoT_T_S_BLL BLL = new CadProdutoT_T_S_BLL();
                    ProdutoTipoTamanhoPreco pro = new ProdutoTipoTamanhoPreco();

                    pro = TelaToEntity();
                    if (BLL.ApagaProdutoTipoTamanhoPreco(txtCodigo.Text))
                    {
                        MessageBox.Show("Preço Deletado com Sucesso");
                    }
                    else MessageBox.Show("O Preço já foi utilizado e não poderá ser excluido");

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
            ProdutoTipoTamanhoPreco pro = new ProdutoTipoTamanhoPreco();

            pro = TelaToEntity();

            pro = BLL.BuscaAntProdutoTipoTamanhoPreco(pro);

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
            ProdutoTipoTamanhoPreco pro = new ProdutoTipoTamanhoPreco();

            pro = TelaToEntity();

            pro = BLL.BuscaProxProdutoTipoTamanhoPreco(pro);

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
            comboTipo.Text = "";
            comboTamanho.Text = "";
            txtTipoNome.Text = "";
            txtTamanhoNome.Text = "";
            txtPrecoVenda1.Text = "";
            txtPrecoVenda2.Text = "";
            txtPrecoVenda3.Text = "";
            txtPrecoCusto.Text = "";

            edita = false;
        }
        private ProdutoTipoTamanhoPreco TelaToEntity()
        {
            ProdutoTipoTamanhoPreco pro = new ProdutoTipoTamanhoPreco();

            pro.Id = txtCodigo.Text;
            pro.CodTipo = comboTipo.Text;
            pro.CodTamanho = comboTamanho.Text;
            pro.Preco1 = txtPrecoVenda1.Text.Replace(".", "").Replace("R$", "").Replace(",", ".");
            pro.Preco2 = txtPrecoVenda2.Text.Replace(".", "").Replace("R$", "").Replace(",", ".");
            pro.Preco3 = txtPrecoVenda3.Text.Replace(".", "").Replace("R$", "").Replace(",", ".");
            pro.Custo = txtPrecoCusto.Text.Replace(".", "").Replace("R$", "").Replace(",", ".");

            return pro;
        }

        private void EntityToTela(ProdutoTipoTamanhoPreco pro)
        {
            txtCodigo.Text = pro.Id;
            comboTipo.Text = pro.CodTipo;
            comboTamanho.Text = pro.CodTamanho;
            txtPrecoVenda1.Text = pro.Preco1;
            txtPrecoVenda2.Text = pro.Preco2;
            txtPrecoVenda3.Text = pro.Preco3;
            txtPrecoCusto.Text = pro.Custo;

            AtualizaTextTipo();
            AtualizaTextTamanho();
            MoedaToTextBox();
        }
        private void txtTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaTextTipo();
        }

        private void txtTamanho_SelectedIndexChange(object sender, EventArgs e)
        {
            AtualizaTextTamanho();
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
                        {
                            txtTipoNome.Text = p.Nome;
                            break;
                        }
                        else txtTipoNome.Text = "";
                    }
                }
            }
            catch (Exception) { }
        }

        private void AtualizaTextTamanho()
        {
            try
            {
                if (proTamanho != null)
                {
                    foreach (ProdutoTamanho t in proTamanho)
                    {
                        if (t.Id.Equals(comboTamanho.SelectedItem.ToString()))
                        {
                            txtTamanhoNome.Text = t.Nome;
                            break;
                        }
                        else txtTamanhoNome.Text = "";
                    }
                }
            }
            catch (Exception) { }
        }


        private void MoedaToTextBox()
        {
            try { txtPrecoVenda1.Text = Convert.ToDouble(txtPrecoVenda1.Text).ToString("C"); }
            catch (Exception) { }
            try { txtPrecoVenda2.Text = Convert.ToDouble(txtPrecoVenda2.Text).ToString("C"); }
            catch (Exception) { }
            try { txtPrecoVenda3.Text = Convert.ToDouble(txtPrecoVenda3.Text).ToString("C"); }
            catch (Exception) { }
            try { txtPrecoCusto.Text = Convert.ToDouble(txtPrecoCusto.Text).ToString("C"); }
            catch (Exception) { }
        }

        private void txtPrecoVenda1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtPrecoVenda1.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtPrecoVenda2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
             (e.KeyChar != ',' && e.KeyChar != '.' &&
              e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtPrecoVenda2.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtPrecoVenda3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtPrecoVenda3.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
             (e.KeyChar != ',' && e.KeyChar != '.' &&
              e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtPrecoCusto.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtPrecoVenda1_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtPrecoVenda1.Text.Length - 1; i++)
            {
                if ((txtPrecoVenda1.Text[i] >= '0' &&
                    txtPrecoVenda1.Text[i] <= '9') ||
                    txtPrecoVenda1.Text[i] == ',')
                {
                    x += txtPrecoVenda1.Text[i];
                }
            }
            txtPrecoVenda1.Text = x;
            txtPrecoVenda1.SelectAll();
        }

        private void txtPrecoVenda2_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtPrecoVenda2.Text.Length - 1; i++)
            {
                if ((txtPrecoVenda2.Text[i] >= '0' &&
                    txtPrecoVenda2.Text[i] <= '9') ||
                    txtPrecoVenda2.Text[i] == ',')
                {
                    x += txtPrecoVenda2.Text[i];
                }
            }
            txtPrecoVenda2.Text = x;
            txtPrecoVenda2.SelectAll();
        }

        private void txtPrecoVenda3_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtPrecoVenda3.Text.Length - 1; i++)
            {
                if ((txtPrecoVenda3.Text[i] >= '0' &&
                    txtPrecoVenda3.Text[i] <= '9') ||
                    txtPrecoVenda3.Text[i] == ',')
                {
                    x += txtPrecoVenda3.Text[i];
                }
            }
            txtPrecoVenda3.Text = x;
            txtPrecoVenda3.SelectAll();
        }

        private void txtPrecoCusto_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtPrecoCusto.Text.Length - 1; i++)
            {
                if ((txtPrecoCusto.Text[i] >= '0' &&
                    txtPrecoCusto.Text[i] <= '9') ||
                    txtPrecoCusto.Text[i] == ',')
                {
                    x += txtPrecoCusto.Text[i];
                }
            }
            txtPrecoCusto.Text = x;
            txtPrecoCusto.SelectAll();
        }

        private void txtPrecoVenda1_Leave(object sender, EventArgs e)
        {
            MoedaToTextBox();
        }
    }
}
