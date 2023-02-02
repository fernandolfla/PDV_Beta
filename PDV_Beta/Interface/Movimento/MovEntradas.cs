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
    public partial class MovEntradas : Form
    {
        public MovEntradas()
        {
            InitializeComponent();

                AplicarEventos(txtPreco);
                AplicarEventos(txtDesconto);
                AplicarEventos(txtPrecoTotal);
                AplicarEventos(txtTotalProdutos);
                AplicarEventos(txtTotalDescontos);
                AplicarEventos(txtFrete);
                AplicarEventos(txtTotalNota);
                ApenasNumerico(txtNumNota);
                ApenasNumerico(txtVolumes);
                ApenasNumerico(txtQuantidade);
                ApenasNumericoPeso(txtPesoBruto);


            List<Operacoes> CFOP = new List<Operacoes>();
            MovEntradasBLL BLL = new MovEntradasBLL();
            CFOP = BLL.ListaOperacoes();
            if (CFOP != null)
            {
                foreach (Operacoes op in CFOP)
                {
                    if (op.Tipo == 0)
                        comboOperacao.Items.Add(op.CFOP);
                }
            }
        }

        private int linha = 1;
        private List<Entradas_Produtos> produtosgrid = new List<Entradas_Produtos>();
        public bool edita = false;
        private int ID = 0;

        private void Edita()
        {
            btnADDProduto.Enabled = false;
            btnBuscaFornecedor.Enabled = false;
            btnBuscaProduto.Enabled = false;
            btnTransportadora.Enabled = false;
            txtNumNota.Enabled = false;
            comboOperacao.Enabled = false;
            txtData.Enabled = false;
            txtVolumes.Enabled = false;
            txtPesoBruto.Enabled = false;
            txtFrete.Enabled = false;
            txtTotalNota.Enabled = false;
            txtObs.Enabled = false;
        }


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
            if (!edita)
            {
                MovEntradasBLL BLL = new MovEntradasBLL();
                int resultado = BLL.Cadastra(TelatoEntity());
                switch (resultado)
                {
                    case 0: MessageBox.Show("Preencha Corretamente os campos obrigatórios");
                        break;
                    case 1: MessageBox.Show("Cadastro Realizado com Sucesso");
                            LimpaTela();
                        break;
                    case 2: MessageBox.Show("Houve erros ao tentas gravar a entrada, reinicie a operação!");
                        break;
                    case 3: MessageBox.Show("Houve erros ao tentas gravar os produtos da entrada, reinicie a operação!");
                        break;
                    default: MessageBox.Show("Erro no banco de dados");
                        break;                           
                }

                MensagemErro();
            }
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string motivo = "";

            if (edita && ID != 0)
                if (!checkCancelado.Checked)
                {
                    DialogResult Result = MessageBox.Show("Realmente Deseja Cancelar esta Nota? ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Result == DialogResult.Yes)
                    {

                        if(TextInput.InputBox("Importante!", "Qual o Motivo do cancelamento da Nota?", ref motivo) == DialogResult.OK)
                        {
                            MovEntradasBLL BLL = new MovEntradasBLL();
                            if (BLL.CancelaNF(ID, motivo))
                            {
                                MessageBox.Show("Nota Cancelada");
                                LimpaTela();
                            }
                        }                        
                    }                            
                }
                else
                    MessageBox.Show("Nota Já Cancelada");

        }


        //Lançar o produto na grade
        private void btnADDProduto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoProduto.Text))
                if (!string.IsNullOrEmpty(txtQuantidade.Text))
                    if (!string.IsNullOrEmpty(txtPreco.Text) && !txtQuantidade.Text.Equals("0"))
                        if (!string.IsNullOrEmpty(txtPrecoTotal.Text))
                            if (!string.IsNullOrEmpty(txtNomeProduto.Text))
                            {
                                if (string.IsNullOrEmpty(txtDesconto.Text))
                                    txtDesconto.Text = "0";

                                if (produtosgrid == null)
                                    produtosgrid = new List<Entradas_Produtos>();

                                produtosgrid.Add(LinhaToEntity(linha));
                               
                                CalculaTotais();                  
                                LimpaProdutos();


                                string[] row = new string[] { linha.ToString(), produtosgrid[linha - 1].Nome_Produto,
                                produtosgrid[linha - 1].PrecoUnit.ToString("C2"), produtosgrid[linha - 1].Qtde.ToString(),
                                produtosgrid[linha - 1].Desconto_Total.ToString("C2"), produtosgrid[linha - 1].Preco_Final.ToString("C2") };

                                dataGridProdutos.Rows.Add(row);

                                linha++;
                            }
           
        }

        private void CalculaTotais()
        {
            try
            {
                decimal Total = 0;
                decimal Descontos = 0;
                decimal TotalNF = 0;

                if (produtosgrid.Count > 0)
                {
                    foreach (var l in produtosgrid)
                    {
                        Total = Total + Convert.ToDecimal(l.Preco_Total);
                        Descontos = Convert.ToDecimal(Descontos + l.Desconto_Total);
                        TotalNF = Total - Descontos;
                    }
                }

                txtTotalProdutos.Text = Total.ToString("C2");
                txtTotalDescontos.Text = Descontos.ToString("C2");
                txtTotalNota.Text = TotalNF.ToString("C2");

            }
            catch (Exception) { }

           
        }
        private void LimpaProdutos()
        {
            txtCodigoProduto.Text = "";
            txtQuantidade.Text = "";
            txtPreco.Text = "";
            txtPrecoTotal.Text = "";
            txtNomeProduto.Text = "";
            txtDesconto.Text = "";
        }

        private void LimpaTela()
        {
            LimpaProdutos();

            txtCodFornecedor.Text = "";
            txtNumNota.Text = "";
            comboOperacao.Refresh();  //Colocar Operação padrao da tela
            txtNomeFornecedor.Text = "";
            txtData.Value = DateTime.Now;
            txtTransportadoraCod.Text = "";
            txtObs.Text = "";
            txtVolumes.Text = "1";
            txtPesoBruto.Text = "";
            txtTotalProdutos.Text = "";
            txtTotalDescontos.Text = "";
            txtFrete.Text = "";
            txtTotalNota.Text = "";

            dataGridProdutos.Rows.Clear();
            dataGridProdutos.Refresh();

            ID = 0;
            produtosgrid = null;
            linha = 1;
            edita = false;
            pictureCancelada.Visible = false;
            pictureEstoque.Visible = false;
            lblCancelada.Text = "";

            // FALSO DO TXT EDITA
            btnADDProduto.Enabled = true;
            btnBuscaFornecedor.Enabled = true;
            btnBuscaProduto.Enabled = true;
            btnTransportadora.Enabled = true;
            txtNumNota.Enabled = true;
            comboOperacao.Enabled = true;
            txtData.Enabled = true;
            txtVolumes.Enabled = true;
            txtPesoBruto.Enabled = true;
            txtFrete.Enabled = true;
            txtTotalNota.Enabled = true;
            txtObs.Enabled = true;
        }

        private Entradas TelatoEntity()
        {
            Entradas entrada = new Entradas();

            entrada.Fornecedor = txtCodFornecedor.Text;
            entrada.NumNota = txtNumNota.Text;
            entrada.Cod_Operacao = comboOperacao.Text;  
            entrada.Data = txtData.Text;
            entrada.Transportadora = txtTransportadoraCod.Text;
            entrada.Observacoes = txtObs.Text;
            try { entrada.Volumes = Convert.ToInt32(txtVolumes.Text); } catch (Exception) { }
            if (string.IsNullOrEmpty(txtPesoBruto.Text))
                txtPesoBruto.Text = "0";
            try { entrada.Peso_bruto = Convert.ToDecimal(txtPesoBruto.Text.Trim()); } catch (Exception) { entrada.Peso_bruto = 1; }
            try { entrada.Produtos = Convert.ToDecimal(txtTotalProdutos.Text.Replace("R$", "").Trim()); } catch (Exception) { entrada.Produtos = 0; }
            try { entrada.Descontos = Convert.ToDecimal(txtTotalDescontos.Text.Replace("R$", "").Trim()); } catch (Exception) { entrada.Descontos = 0; }
            try { entrada.Frete = Convert.ToDecimal(txtFrete.Text.Replace("R$", "").Trim()); } catch (Exception) { entrada.Frete = 0; }
            try { entrada.Total = Convert.ToDecimal(txtTotalNota.Text.Replace("R$", "").Trim()); } catch (Exception) { entrada.Total = 0; }

            if (checkCancelado.Checked)
                entrada.Nota_Cancelada = 1;
            else entrada.Nota_Cancelada = 0;

            entrada.listagrid = produtosgrid;

            return entrada;
        }



        private Entradas_Produtos LinhaToEntity(int l)
        {
            Entradas_Produtos linha = new Entradas_Produtos();
            linha.Cod_Produto = txtCodigoProduto.Text;
            linha.Nome_Produto = txtNomeProduto.Text;
            try { linha.Qtde = Convert.ToDecimal(txtQuantidade.Text.Replace("R$", "").Trim()); } catch (Exception) { }
            try { linha.PrecoUnit = Convert.ToDecimal(txtPreco.Text.Replace("R$", "").Trim()); } catch (Exception) { }
            try { linha.Desconto_Total = Convert.ToDecimal(txtDesconto.Text.Replace("R$", "").Trim()); } catch (Exception) { }

            linha.Preco_Total = linha.PrecoUnit * linha.Qtde;

            if(linha.Desconto_Total > linha.Preco_Total)
            {
                MessageBox.Show("O Desconto é maior que o valor do produto, Verifique!");
                linha.Desconto_Total = linha.Preco_Total;
            }
            linha.Preco_Final = linha.Preco_Total - linha.Desconto_Total;

            linha.Linha = l; //L

            return linha;
        }
        
        public void EntityToTela(Entradas ent)
        {

            ID = ent.Id;
            txtCodFornecedor.Text = ent.Fornecedor;
            txtNomeFornecedor.Text = ent.NomeFornecedor;
            txtNumNota.Text = ent.NumNota;
            comboOperacao.Text = ent.Cod_Operacao; 
            txtData.Text = ent.Data;
            txtTransportadoraCod.Text = ent.Transportadora;
            txtObs.Text = ent.Observacoes;
            txtVolumes.Text = ent.Volumes.ToString();
            txtPesoBruto.Text = ent.Peso_bruto.ToString() ;
            txtTotalProdutos.Text = ent.Produtos.ToString("C2");
            txtTotalDescontos.Text = ent.Descontos.ToString("C2");
            txtFrete.Text = ent.Frete.ToString("C2");
            txtTotalNota.Text = ent.Total.ToString("C2");

            if (ent.Efetivado_Estoque == 1)
                pictureEstoque.Visible = true;
            else pictureEstoque.Visible = false;

            if (ent.Nota_Cancelada == 1)
            {
                checkCancelado.Checked = true;
                pictureCancelada.Visible = true;
                lblCancelada.Text = "NOTA CANCELADA MOTIVO : " + ent.Motivo_Cancelamento;
            }
            else
            {
                checkCancelado.Checked = false;
                pictureCancelada.Visible = false;
            }

            dataGridProdutos.Rows.Clear();
            dataGridProdutos.Refresh();

            if(ent.listagrid != null)
            foreach(var L in ent.listagrid)
            {
                string[] row = new string[] { L.Linha.ToString(), L.Nome_Produto,
                L.PrecoUnit.ToString("C2"), L.Qtde.ToString(),
                L.Desconto_Total.ToString("C2"), L.Preco_Final.ToString("C2") };

                dataGridProdutos.Rows.Add(row);
            }
            edita = true;
            Edita();
        }

        //Buscar o produto quando tab
        private void txtCodigo_Leave(object sender, EventArgs e)
        {

        }

        private void btnBuscaFornecedor_Click(object sender, EventArgs e)
        {
            BuscaClienteFornecedor busca = new BuscaClienteFornecedor(null,null,this,0,null);
            busca.ShowDialog();
        }
        private void btnTransportadora_Click(object sender, EventArgs e)
        {
            BuscaClienteFornecedor busca = new BuscaClienteFornecedor(null, null, this,1,null);
            busca.ShowDialog();
        }

        private void btnBuscaEntradas_Click(object sender, EventArgs e)
        {
            BuscaEntradas busca = new BuscaEntradas(this);
            busca.ShowDialog();
        }

        private void btnBuscaProduto_Click(object sender, EventArgs e)
        {
            BuscaProdutos busca = new BuscaProdutos(null,null,this,null, null, null, null, null);
            busca.ShowDialog();
        }




        //EVENTOS DE CAMPOS DE MOEDA
        private void RetornarMascara(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                txt.Text = double.Parse(txt.Text).ToString("C2");
            }
            catch (Exception) { }
        }

        private void RetornarMascaraPeso(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                txt.Text = double.Parse(txt.Text).ToString("0.000");
            }
            catch (Exception) { }
        }
        private void RetornarMascaraNumero(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                txt.Text = double.Parse(txt.Text).ToString("0");
            }
            catch (Exception) { }
        }
        private void TirarMascara(object sender, EventArgs e)
        {
            AtualizaTotalLinha();
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }

        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            AtualizaTotalLinha();
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

        private void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }

        private void ApenasNumericoPeso(TextBox txt)
        {
            txt.KeyPress += ApenasValorNumerico;
            txt.Leave += RetornarMascaraPeso;
        }

        private void ApenasNumerico(TextBox txt)
        {
            txt.KeyPress += ApenasValorNumerico;
            txt.Leave += RetornarMascaraNumero;
        }

        private void AtualizaTotalLinha()
        {
            try
            {
                decimal PrecoTotal; // = Convert.ToDecimal(txtPrecoTotal.Text.Replace("R$", "").Trim());
                decimal Desconto = 0;
                decimal Quantidade = 0;
                decimal Preco = 0;
                if (!string.IsNullOrEmpty(txtQuantidade.Text))
                    Quantidade = Convert.ToDecimal(txtQuantidade.Text.Replace("R$", "").Trim());

                if(!string.IsNullOrEmpty(txtPreco.Text))
                    Preco = Convert.ToDecimal(txtPreco.Text.Replace("R$", "").Trim());

                if (!string.IsNullOrEmpty(txtDesconto.Text))
                    Desconto = Convert.ToDecimal(txtDesconto.Text.Replace("R$", "").Trim());


                PrecoTotal = (Quantidade * Preco) - Desconto;

                txtPrecoTotal.Text = PrecoTotal.ToString();

            }
            catch (Exception) { }
        }

        //#####################################################





    }
}
