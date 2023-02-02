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
    public partial class CadProdutos : Form
    {
        public CadProdutos()
        {
            InitializeComponent();
        }

        private string IMG_Produto_SemFoto = Environment.CurrentDirectory + "\\Imagens\\no_image_180x150.png";
        public bool edita = false;

        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show("Ouve um erro a conectar ao banco de dados, reinicie o programa, caso persista entre em contato com o suporte. ERRO = " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
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
            try { txtPeso.Text = Convert.ToDouble(txtPeso.Text).ToString(""); }
            catch (Exception) { }

        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadProdutosBLL BLL = new CadProdutosBLL();
            Produto pro = new Produto();
            int result = -2;

            pro = TelaToEntity();

            result = BLL.CadastraProduto(pro, edita);

            switch (result)
            {
                case 1:
                    if (edita)
                        MessageBox.Show("Cadastro Editado com Sucesso");
                    else MessageBox.Show("Cadastro Realizado com Sucesso");
                    break;
                case 2:
                    MessageBox.Show("O código já existe, tente outro código ou clique na seta de Prox Código");
                    break;
                case 3:
                    MessageBox.Show("Verifique os campos Obrigatórios");
                    break;
                case 4:
                    MessageBox.Show("O primeiro Digito do Nome precisa ser uma Letra");
                    break;
                default:
                    MessageBox.Show("Ocorreram Erros ao cadastrar o Produto, Tente Novamente");
                    break;

            }

            if(!edita)
                LimpaTela();

            MensagemErro();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Realmente deseja Excluir? Marque como inativo para que não apareça mais nas telas de compra e venda, Caso exclua um produto já vendido poderá ter inconsistencia no banco de dados! Exclua apenas caso tenha cadastrado errado! ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                CadProdutosBLL BLL = new CadProdutosBLL();
                if (BLL.ApagaProduto(txtCodigo.Text))
                {
                    MessageBox.Show("Produto Deletado com Sucesso");
                }
                else MessageBox.Show("O Produto possui notas ou compras e não será possivel apagar, marque-o como Inativo");

                LimpaTela();
                MensagemErro();
            }           
        }

        private void btnBuscarProdutos_Click(object sender, EventArgs e)
        {
            BuscaProdutos busca = new BuscaProdutos(this,null,null,null, null, null, null,null);
            busca.ShowDialog();
        }

        private void btnBuscarFornecedor_Click(object sender, EventArgs e)
        {
            BuscaClienteFornecedor busca = new BuscaClienteFornecedor(null, this,null,0,null);
            busca.ShowDialog();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
           
            Produto pro = new Produto();
            CadProdutosBLL BLL = new CadProdutosBLL();

            pro = TelaToEntity();

            pro = BLL.BuscaAntProduto(pro);

            if (pro != null)
            {
                LimpaTela();
                EntityToTela(pro);
            }

            txtCodigo.Enabled = false;
            edita = true;
            MensagemErro();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
           
            
            Produto pro = new Produto();
            CadProdutosBLL BLL = new CadProdutosBLL();

            pro = TelaToEntity();

            pro = BLL.BuscaProxProduto(pro);

            if (pro != null)
            {
                LimpaTela();
                EntityToTela(pro);
            }

            txtCodigo.Enabled = false;
            edita = true;
            MensagemErro();
        }

        private void btnProxCodLivre_Click(object sender, EventArgs e)
        {
            if (!edita)
            {
                CadProdutosBLL BLL = new CadProdutosBLL();

                txtCodigo.Text = BLL.BuscaProxCodLivre();
            }
            MensagemErro();
        }


        private void btnAddImagem_Click(object sender, EventArgs e)
        {
            //Copiar Imagem para local e jogar para imagem 

            OpenFileDialog BuscaIMG = new OpenFileDialog();
            BuscaIMG.Filter = "Imagem|*.jpg;*.png;*.png";
            try
            {
                if (BuscaIMG.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(BuscaIMG.FileName);

                    string origem = BuscaIMG.FileName;
                    string destino = string.Concat(Environment.CurrentDirectory + "\\Imagens\\", System.IO.Path.GetFileName(origem));
                    System.IO.File.Delete(destino);
                    System.IO.File.Copy(origem, destino);

                    ResizeIMG.ResizeImage(destino, destino, 180, 150);
                    //salvar Destino no banco =)
                    sr.Close();

                    pictureProduto.ImageLocation = destino;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A imagem já existe na pasta com o mesmo nome, abra novamente e mude o nome. ERRO = " + ex);
            }
        }

        private void btnCadastrarTipo_Click(object sender, EventArgs e)
        {
            CadProdutoTipoTamanhoPreco ttp = new CadProdutoTipoTamanhoPreco();
            ttp.ShowDialog();
        }

        private void LimpaTela()
        {
            txtCodigo.Text = "";
            txtFabricante.Text = "";
            txtNome.Text = "";
            txtUnidadeVenda.Text = "";
            txtPrecoVenda1.Text = "";
            txtPrecoVenda2.Text = "";
            txtPrecoVenda3.Text = "";
            txtPrecoCusto.Text = "";
            txtPeso.Text = "";
            txtFornecedor.Text = "";
            txtObservacoes.Text = "";

            checkAtivo.Checked = true;
            checkTipo.Checked = false;
            checkFracionado.Checked = false;
            checkEstoque.Checked = true;
            pictureProduto.ImageLocation = IMG_Produto_SemFoto;

            txtCodigo.Enabled = true;
            edita = false;
            txtCodigo.Focus();

        }

        private Produto TelaToEntity()
        {
            Produto pro = new Produto();

            pro.Codigo = txtCodigo.Text ;
            pro.Fabricante = txtFabricante.Text;
            pro.Nome = txtNome.Text;
            pro.Unidade_Venda = txtUnidadeVenda.Text;
            pro.Preco1 = txtPrecoVenda1.Text.Replace(".", "").Replace("R$", "").Replace(",", "."); 
            pro.Preco2 = txtPrecoVenda2.Text.Replace(".", "").Replace("R$", "").Replace(",", ".");
            pro.Preco3 = txtPrecoVenda3.Text.Replace(".", "").Replace("R$", "").Replace(",", ".");
            pro.Custo = txtPrecoCusto.Text.Replace(".", "").Replace("R$", "").Replace(",", ".");
            pro.Peso = txtPeso.Text;
            pro.Codigo_Fornecedor = txtFornecedor.Text;
            pro.Obs = txtObservacoes.Text;

            if (checkAtivo.Checked)
                pro.Ativo = 1;
            else pro.Ativo = 2;
            if (checkTipo.Checked)
                pro.Tipo = 1;
            else pro.Tipo = 0;
            if (checkFracionado.Checked)
                pro.Fracionado = 1;
            else pro.Fracionado = 0;
            if (checkEstoque.Checked)
                pro.Estoque = 1;
            else pro.Estoque = 0;

            if (pictureProduto.ImageLocation != null)
                pro.Foto = pictureProduto.ImageLocation;
            else
                pro.Foto = IMG_Produto_SemFoto;

            return pro;
        }


        public void EntityToTela(Produto pro)
        {
            txtCodigo.Text = pro.Codigo;
            txtFabricante.Text = pro.Fabricante;
            txtNome.Text = pro.Nome;
            txtUnidadeVenda.Text = pro.Unidade_Venda;
            txtPrecoVenda1.Text = pro.Preco1;
            txtPrecoVenda2.Text = pro.Preco2;
            txtPrecoVenda3.Text = pro.Preco3;
            txtPrecoCusto.Text = pro.Custo;
            txtPeso.Text = pro.Peso;
            txtFornecedor.Text = pro.Codigo_Fornecedor;
            txtObservacoes.Text = pro.Obs;

            if (pro.Ativo == 1)
                checkAtivo.Checked = true;
            else
                checkAtivo.Checked = false;
            if(pro.Tipo == 1)
                checkTipo.Checked = true;
            else
                checkTipo.Checked = false;
            if(pro.Fracionado == 1)
                checkFracionado.Checked = true;
            else
                checkFracionado.Checked = false;
            if(pro.Estoque == 1)
                checkEstoque.Checked = true;
            else
                checkEstoque.Checked = false;

            //if (pictureProduto.ImageLocation != null)
            //{
            //    if (pictureProduto.ImageLocation.Length > 5)
                    pictureProduto.ImageLocation = pro.Foto;
            //    else pictureProduto.ImageLocation = IMG_Produto_SemFoto;
            //}
            //else pictureProduto.ImageLocation = IMG_Produto_SemFoto;

            MoedaToTextBox();
        }

       

        private void Preco1_Enter(object sender, EventArgs e)
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

        private void Preco2_Enter(object sender, EventArgs e)
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

        private void Preco3_Enter(object sender, EventArgs e)
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

        private void Custo_Enter(object sender, EventArgs e)
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

        private void MoedaToTextBox_Leave(object sender, EventArgs e)
        {
            MoedaToTextBox();
        }

        private void PrecoVenda_Keypress(object sender, KeyPressEventArgs e)
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

        private void Preco2_Keypress(object sender, KeyPressEventArgs e)
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

        private void Preco3_Keypress(object sender, KeyPressEventArgs e)
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

        private void PrecoCusto_Keypress(object sender, KeyPressEventArgs e)
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

        private void Peso_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtPeso.Text.Length - 1; i++)
            {
                if ((txtPeso.Text[i] >= '0' &&
                    txtPeso.Text[i] <= '9') ||
                    txtPeso.Text[i] == ',')
                {
                    x += txtPeso.Text[i];
                }
            }
            txtPeso.Text = x;
            txtPeso.SelectAll();
        }

        private void Peso_Keypress(object sender, KeyPressEventArgs e)
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
                    if (!txtPeso.Text.Contains(','))
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

        private void checkTipo_CheckedChanged(object sender, EventArgs e)
        {
            if(checkTipo.Checked)
            {
                txtUnidadeVenda.Enabled = false;
                txtPrecoVenda1.Enabled = false;
                txtPrecoVenda2.Enabled = false;
                txtPrecoVenda3.Enabled = false;
                txtPrecoCusto.Enabled = false;
            }
            else
            {
                txtUnidadeVenda.Enabled = true;
                txtPrecoVenda1.Enabled = true;
                txtPrecoVenda2.Enabled = true;
                txtPrecoVenda3.Enabled = true;
                txtPrecoCusto.Enabled = true;
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNome.Focus();
            }
        }
    }
}
