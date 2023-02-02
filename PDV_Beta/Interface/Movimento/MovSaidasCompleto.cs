using PDV_Beta.BLL;
using PDV_Beta.Component;
using PDV_Beta.Entity;
using PDV_Beta.Interface.Buscas;
using PDV_Beta.Interface.Movimento;
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
    public partial class MovSaidasCompleto : Form
    {
        public Saida saida = new Saida();
        Saida_Produtos spro = new Saida_Produtos();
        private Produto pro = new Produto();
        private int linha = 1;
        Saidas_zConf conf = new Saidas_zConf();

        private string CFPOpadrao = "";
        private string ClientePadraoNome = "";
        private string ClientePadraoCod = "";
        public MovSaidasCompleto()
        {
            //TELA SAIDAS NUMERO 1 para zCONF
            InitializeComponent();

            AplicarEventos(txtFrete);
            ApenasNumerico(txtNF);
            ApenasNumerico(txtComanda);
            ApenasNumerico(txtMesa);
            AplicarEventos(txtPreco);
            AplicarEventos(txtDesconto);
            AplicarEventos(txtPrecoTotal);
            ApenasNumericoPeso(txtPeso);
            ApenasNumerico(txtVolumes);
            AplicarEventos(txtTotalProdutos);
            AplicarEventos(txtTotalDescontos);
            AplicarEventos(txtTotalNota);
            ApenasNumericoPeso(txtQuantidade);
            AplicarEventos(txtRecCartaoCliente);
            AplicarEventos(txtRecCartaoConvenio);
            AplicarEventos(txtRecCartaoCredito);
            AplicarEventos(txtRecCartaoDebito);
            AplicarEventos(txtRecDinheiro);
            AplicarEventos(txtRecTroco);

            txtData.Value = DateTime.Now;

            MovSaidasBLL BLL = new MovSaidasBLL();

            ConfTelasVendasBLL BLLc = new ConfTelasVendasBLL();
            
            conf = BLLc.Busca(1);
            if (conf != null)
            {
                //CONFIGURAÇÔES DA TELA 1
                CFPOpadrao = conf.CFOP;

                if(conf.ClientePadraoAtivo == 1)
                {
                    txtCodCliente.Text = conf.ClientePadrao;
                    txtNomeCliente.Text = conf.ClientePadraoNome;
                    ClientePadraoNome = conf.ClientePadraoNome;
                    ClientePadraoCod = conf.ClientePadrao;
                }
                saida.TabelaPreco = conf.TabelaPadrao;


            }

            List<Operacoes> CFOP = new List<Operacoes>();           
            CFOP = BLL.ListaOperacoes();

            if (CFOP != null)
            {
                foreach (Operacoes op in CFOP)
                {
                    if (op.Tipo == 1)
                        comboOperacao.Items.Add(op.CFOP);
                }
            }

            comboOperacao.SelectedItem = CFPOpadrao;

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

        private string SalvarSaida()
        {
           
            TelaToEntity();
            MovSaidasBLL BLL = new MovSaidasBLL();

            if (string.IsNullOrEmpty(txtSequencia.Text))
            {
                saida = BLL.Salvar(saida);
                switch (saida.Result)
                {
                    case 0:
                        return("Cliente ou CFOP INVALIDO ");
        
                    case 1:
                        txtSequencia.Text = saida.Id;
                        Edita(false);
                        return("Venda Salva");
                      
                    case 2:
                        return("Erro ao Gravar a Venda");
                     
                    case 3:
                        return("Erro no Banco de dados, GravaPRODUTOS, Procure o Suporte");
                      
                    case 4:
                        return("Erro no Banco de dados, GravaPRODUTOS, Procure o Suporte");
                   
                    case 5:
                        return("Erro no Banco de dados, GravaPRODUTOS, Procure o Suporte");

                    default:
                        return("ERRO DESCONHECIDO, PROCURE O SUPORTE ");
                }
            }
            else
            {
                saida = BLL.Atualizar(saida);
                switch (saida.Result)
                {
                    case 0:
                        return("ERRO AO ATUALIZAR");
                    case 1:
                        txtSequencia.Text = saida.Id;
                        Edita(false);
                        return("Venda Salva");
                    default:
                        return("ERRO DESCONHECIDO, PROCURE O SUPORTE ");
                }
            }

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string result = "ERRO DESCONHECIDO";
            if (!string.IsNullOrEmpty(txtCodCliente.Text))
            {
                result = SalvarSaida();
                MessageBox.Show(result);
            }
            else
                MessageBox.Show("Cliente invalido");

            MensagemErro();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(saida.Efetivada_estoque == 1 || saida.Efetivada_Financ == 1)
            {
                MessageBox.Show("Não é possível Excluir itens de vendas concluidas, cancele a nota");
            }
            else
            {

                if (dataGridProdutos.SelectedRows.Count > 0)
                {
                    DialogResult Result = MessageBox.Show("Realmente Deseja Cancelar este Item?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Result == DialogResult.Yes)
                    {

                        if (dataGridProdutos.SelectedRows.Count <= 1)
                        {
                            int l = dataGridProdutos.SelectedRows[0].Index;
                            dataGridProdutos.Rows.RemoveAt(dataGridProdutos.SelectedRows[0].Index);
                            saida.Lista_produtos.RemoveAt(l);
                            CalculaTotalNota();

                        }
                        else
                            MessageBox.Show("Selecione Apenas uma Linha por vez");
                    }
                }              
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }


        private void Edita(bool recebido)
        {
            btnBuscaCliente.Enabled = false;
            txtMesa.Enabled = false;
            txtComanda.Enabled = false;
            txtNF.Enabled = false;

            if(recebido)
            {
                btnADDProduto.Enabled = false;
                btnBuscaProduto.Enabled = false;
                btnBuscaVendedor.Enabled = false;
                btnPizza.Enabled = false;
                btnRemover.Enabled = false;
                btnSalvar.Enabled = false;
                txtObs.Enabled = false;
                comboOperacao.Enabled = false;
                txtPeso.Enabled = false;
                txtVolumes.Enabled = false;
                txtFrete.Enabled = false;
                txtCodigoProduto.Enabled = false;
                txtQuantidade.Enabled = false;
                txtDesconto.Enabled = false;
                txtRecCartaoCliente.Enabled = false;
                txtRecCartaoConvenio.Enabled = false;
                txtRecCartaoCredito.Enabled = false;
                txtRecCartaoDebito.Enabled = false;
                txtRecDinheiro.Enabled = false;
                txtRecTroco.Enabled = false;
                btnTransportadora.Enabled = false;
            }


        }
        private void NaoEdita()
        {
            btnBuscaCliente.Enabled = true;
            txtMesa.Enabled = true;
            txtComanda.Enabled = true;
            txtNF.Enabled = true;

            btnADDProduto.Enabled = true;
            btnBuscaProduto.Enabled = true;
            btnBuscaVendedor.Enabled = true;
            btnPizza.Enabled = true;
            btnRemover.Enabled = true;
            btnSalvar.Enabled = true;
            txtObs.Enabled = true;
            comboOperacao.Enabled = true;
            txtPeso.Enabled = true;
            txtVolumes.Enabled = true;
            txtFrete.Enabled = true;
            txtCodigoProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            txtDesconto.Enabled = true;
            //txtRecCartaoCliente.Enabled = true;
            txtRecCartaoConvenio.Enabled = true;
            txtRecCartaoCredito.Enabled = true;
            txtRecCartaoDebito.Enabled = true;
            txtRecDinheiro.Enabled = true;
            txtRecTroco.Enabled = true;
            btnTransportadora.Enabled = true;
        }


        private void LimpaProdutos()
        {
            txtCodigoProduto.Text = "";
            txtQuantidade.Text = "";
            txtPreco.Text = "";
            txtNomeProduto.Text = "";
            txtDesconto.Text = "";
            txtPrecoTotal.Text = "";
            pro = null;
            pro = new Produto();
            spro = null;
            spro = new Saida_Produtos();
        }

        private void LimpaTela()
        {
            LimpaProdutos();
            NaoEdita();

            saida = null;
            saida = new Saida();

            painelRecebimento.Visible = false;
            txtCodCliente.Text = "";
            txtNomeCliente.Text = "";
            txtSequencia.Text = "";
            txtNF.Text = "";
            txtObs.Text = "";
            txtComanda.Text = "";
            txtMesa.Text = "";
            txtPainel.Text = "";
            txtNomeVendedor.Text = "";
            txtCodVendedor.Text = "";
            txtNomeTransportadora.Text = "";
            txtCodTransportadora.Text = "";
            txtPeso.Text = "";
            txtVolumes.Text = "";
            txtFrete.Text = "";
            txtTotalProdutos.Text = "";
            txtTotalDescontos.Text = "";
            txtTotalNota.Text = "";
            checkCancelado.Checked = false;
            checkParaEntrega.Checked = false;

            comboOperacao.SelectedItem = CFPOpadrao;
            txtCodCliente.Text = ClientePadraoCod;
            txtNomeCliente.Text = ClientePadraoNome;

            dataGridProdutos.Rows.Clear();
            dataGridProdutos.Refresh();
            linha = 1;

            txtRecCartaoCliente.Text = "";
            txtRecCartaoConvenio.Text = "";
            txtRecCartaoCredito.Text = "";
            txtRecCartaoDebito.Text = "";
            txtRecDinheiro.Text = "";
            txtRecTroco.Text = "";

            pictureCancelada.Visible = false;
            pictureEstoque.Visible = false;
            pictureFinanceiro.Visible = false;


        }

        private void TelaToEntity()
        {
            saida.Cliente = txtCodCliente.Text;
            saida.NumNota = txtNF.Text;
            saida.CFOP = comboOperacao.Text;
            if (checkParaEntrega.Checked)
                saida.ParaEntrega = 1;
            else
                saida.ParaEntrega = 0;

            saida.Comanda = txtComanda.Text;
            saida.Mesa = txtMesa.Text;
            saida.Observacoes = txtObs.Text;
            if (string.IsNullOrEmpty(txtPeso.Text))
                txtVolumes.Text = "0";
            try { saida.Peso = Convert.ToDecimal(txtPeso.Text); } catch { saida.Peso = 0; }
            if (string.IsNullOrEmpty(txtVolumes.Text))
                txtVolumes.Text = "1";
            try { saida.Volumes = Convert.ToInt32(txtVolumes.Text); } catch { saida.Volumes = 1; }
            saida.Vendedor = txtCodVendedor.Text;
            saida.Transportadora = txtCodTransportadora.Text;
            if(string.IsNullOrEmpty(txtPainel.Text))
            {
                Random rdn = new Random();
                txtPainel.Text = rdn.Next(1, 99).ToString();
            }
            saida.Painel = txtPainel.Text;

        }

        public void EntityToTela(Saida sd)
        {
            LimpaTela();
            saida = sd;

            txtCodCliente.Text = saida.Cliente;
            txtNomeCliente.Text = saida.NomeCliente;
            txtSequencia.Text = saida.Id;
            txtNF.Text = saida.NumNota;
            txtObs.Text = saida.Observacoes;
            txtComanda.Text = saida.Comanda;
            txtMesa.Text = saida.Mesa;
            txtPainel.Text = saida.Painel;
            txtNomeVendedor.Text = saida.NomeVendedor;
            txtCodVendedor.Text = saida.Vendedor;
            txtNomeTransportadora.Text = saida.NomeTransportadora;
            txtCodTransportadora.Text = saida.Transportadora;
            txtPeso.Text = saida.Peso.ToString();
            txtVolumes.Text = saida.Volumes.ToString();
            txtFrete.Text = saida.Frete.ToString("C2");
            txtTotalProdutos.Text = saida.Produtos.ToString("C2");
            txtTotalDescontos.Text = saida.Desconto.ToString("C2");
            txtTotalNota.Text = saida.Total.ToString("C2");

            txtRecCartaoCliente.Text = saida.Recebe_Credito_Cliente.ToString("C2");
            txtRecCartaoConvenio.Text = saida.Recebe_Cartao_Convenio.ToString("C2");
            txtRecCartaoCredito.Text = saida.Recebe_cartao_Credito.ToString("C2");
            txtRecCartaoDebito.Text = saida.Recebe_Cartao_Debito.ToString("C2");
            txtRecDinheiro.Text = saida.Recebe_Dinheiro.ToString("C2");

            if (saida.Efetivada_Financ == 1)
            {
                pictureEstoque.Visible = true;
                pictureFinanceiro.Visible = true;
            }
            else
            {
                pictureEstoque.Visible = false;
                pictureFinanceiro.Visible = false;
            }

            if (saida.Nota_cancelada == 1)
            {
                pictureCancelada.Visible = true;
                checkCancelado.Checked = true;
                pictureEstoque.Visible = false;
                pictureFinanceiro.Visible = false;
            }
            else
            {
                checkCancelado.Checked = false;
                pictureCancelada.Visible = false;
            }
            if(saida.ParaEntrega == 1)
                checkParaEntrega.Checked = true;
            else
                checkParaEntrega.Checked = false;

            comboOperacao.Text = saida.CFOP;

            if (saida.Lista_produtos != null)
                ListaGridProdutos(saida.Lista_produtos);
            if (saida.Efetivada_Financ == 1)
                Edita(true);
            else Edita(false);
        }
        private void ListaGridProdutos(List<Saida_Produtos> PROS)
        {
            foreach(var l in PROS)
            {
                string[] row = new string[] { l.Linha.ToString(), l.CodProduto , l.NomeProduto,
                l.Preco_Unit.ToString("C2"), l.Qtde.ToString(),
                l.Desconto.ToString("C2"), l.Preco_Final.ToString("C2") };

                linha = l.Linha +1;
                dataGridProdutos.Rows.Add(row);
            }
           
        }
         
        //BOTÕES DE BUSCA
        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            // 0 = PARA BUSCA DE CLIENTE
            BuscaClienteFornecedor_Vendas busca = new BuscaClienteFornecedor_Vendas(0, this, null, null, null, null);
            busca.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 1 = PARA BUSCA DE TRANSPORTADORA
            BuscaClienteFornecedor_Vendas busca = new BuscaClienteFornecedor_Vendas(1, this, null, null, null, null);
            busca.ShowDialog();
        }
        private void btnBuscaProduto_Click(object sender, EventArgs e)
        {
            BuscaProdutos busca = new BuscaProdutos(null, null, null, this, null, null, null, null);
            busca.ShowDialog();
            txtCodigoProduto_Leave(null, null);
            txtQuantidade.Focus();

        }
        private void btnSetaEnderecoEntrega_Click(object sender, EventArgs e)
        {
            MovSaidas_SetaEnderecoEntrega seta = new MovSaidas_SetaEnderecoEntrega(this,null);
            seta.ShowDialog();
        }

        private void btnBuscaVendedor_Click(object sender, EventArgs e)
        {
            BuscaFuncionarios busca = new BuscaFuncionarios(this,null);
            busca.ShowDialog();
        }
        private void LancaProdutos()
        {
            MovSaidasBLL BLL = new MovSaidasBLL();
            pro = null;
            spro = null;
            pro = new Produto();
            spro = new Saida_Produtos();

            string cod = txtCodigoProduto.Text;
            pro = BLL.BuscaProdutoPorCodigo(txtCodigoProduto.Text);
            if (pro != null)
            {
                VerificaTabelaPreco();
                CalculaTotais();
            }
            else
            {
                LimpaProdutos();
                txtCodigoProduto.Text = cod;
            }
        }
        private void txtCodigoProduto_Leave(object sender, EventArgs e)
        {
            LancaProdutos();
            
        }

        public void LancaPizza(Produto prod)
        {
            MovSaidasBLL BLL = new MovSaidasBLL();
            pro = null;
            spro = null;
            pro = new Produto();
            spro = new Saida_Produtos();

            pro = prod;
            if (pro != null)
            {
                txtCodigoProduto.Text = pro.Codigo;
                VerificaTabelaPreco();
                CalculaTotais();
            }
            else
            {
                LimpaProdutos();
                txtCodigoProduto.Text = "";
            }

        }
        private void VerificaTabelaPreco()
        {
            txtNomeProduto.Text = pro.Nome;
            switch(saida.TabelaPreco)
            {
                case 1: txtPreco.Text = pro.Preco1;
                    break;
                case 2: txtPreco.Text = pro.Preco2;
                    break;
                case 3: txtPreco.Text = pro.Preco3;
                    break;
                default: txtPreco.Text = pro.Preco1;
                    break;
            }

        }

        private void CalculaTotais()
        {
            decimal preco = 0;
            decimal qtd = 0;
            int qtd2 = 0;
            decimal desconto = 0;
            decimal total = 0;

            if (!string.IsNullOrEmpty(txtCodigoProduto.Text))
            {
                try
                {
                    switch (saida.TabelaPreco)
                    {
                        case 1:
                            preco = Convert.ToDecimal(pro.Preco1.Replace("R$", "").Trim());
                            break;
                        case 2:
                            preco = Convert.ToDecimal(pro.Preco2.Replace("R$", "").Trim());
                            break;
                        case 3:
                            preco = Convert.ToDecimal(pro.Preco3.Replace("R$", "").Trim());
                            break;
                        default:
                            preco = Convert.ToDecimal(pro.Preco1.Replace("R$", "").Trim());
                            break;
                    }
                }
                catch { preco = 0; }

                try { qtd = Convert.ToDecimal(txtQuantidade.Text.Replace("R$", "").Trim()); } catch { qtd = 1; }

                if(pro.Fracionado == 0)
                {
                    try { txtQuantidade.Text = double.Parse(txtQuantidade.Text).ToString("0"); } catch { }
                    try {  qtd2 = Convert.ToInt32( txtQuantidade.Text.Replace("R$", "").Trim()) ;} catch { qtd2 = 1; }
                    qtd = qtd2;
                }

                try { desconto = Convert.ToDecimal(txtDesconto.Text.Replace("R$", "").Trim()); } catch { desconto = 0; }

                total = (preco * qtd) - desconto;
                txtPrecoTotal.Text = total.ToString("C2");

                if (spro == null)
                    spro = new Saida_Produtos();
                spro.Tabela_Preco = saida.TabelaPreco;
                spro.CodProduto = pro.Codigo;
                spro.NomeProduto = pro.Nome;
                spro.Preco_Unit = preco;
                spro.Qtde = qtd;
                spro.Desconto = desconto;
                spro.Preco_Total = preco * qtd;
                spro.Preco_Final = total;
            }

        }


        private void CalculaTotalNota()
        {
            decimal total = 0;
            decimal desconto = 0;
            decimal final = 0;
            if(saida != null)
            {
                if(saida.Lista_produtos!= null)
                if(saida.Lista_produtos.Count > 0)
                {
                    foreach(Saida_Produtos l in saida.Lista_produtos)
                    {
                        final += l.Preco_Final;
                        desconto += l.Desconto;
                        total += l.Preco_Total;

                    }
                }
                try { saida.Frete = Convert.ToDecimal(txtFrete.Text.Replace("R$", "").Trim()); } catch { saida.Frete = 0; }

                saida.Desconto = desconto;
                saida.Produtos = total;
                saida.Total = final;
                saida.Total += saida.Frete;
            }
            txtTotalNota.Text = saida.Total.ToString("C2");
            txtTotalDescontos.Text = saida.Desconto.ToString("C2");
            txtTotalProdutos.Text = saida.Produtos.ToString("C2");

        }
        private void txtFrete_TextChanged(object sender, EventArgs e)
        {
            try { saida.Frete = Convert.ToDecimal(txtFrete.Text.Replace("R$", "").Trim()); } catch { saida.Frete = 0; }
            CalculaTotalNota();
            txtTotalNota.Text = saida.Total.ToString("C2");
            txtTotalDescontos.Text = saida.Desconto.ToString("C2");
            txtTotalProdutos.Text = saida.Produtos.ToString("C2");
        }
        private void btnADDProduto_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNomeProduto.Text))
                if(!string.IsNullOrEmpty(txtCodigoProduto.Text))
                {
                    if (string.IsNullOrEmpty(txtQuantidade.Text))
                        txtQuantidade.Text = "1";
                    if (string.IsNullOrEmpty(txtDesconto.Text))
                        txtDesconto.Text = "0";

                    CalculaTotais();                   

                    spro.Linha = linha;
                    if (saida.Lista_produtos == null)
                        saida.Lista_produtos = new List<Saida_Produtos>();
                    saida.Lista_produtos.Add(spro);

                    string[] row = new string[] { linha.ToString(), spro.CodProduto , spro.NomeProduto,
                    spro.Preco_Unit.ToString("C2"), spro.Qtde.ToString(),
                    spro.Desconto.ToString("C2"), spro.Preco_Final.ToString("C2") };

                    dataGridProdutos.Rows.Add(row);

                    LimpaProdutos();

                    CalculaTotalNota();
                    //txtTotalNota.Text = saida.Total.ToString("C2");
                    //txtTotalDescontos.Text = saida.Desconto.ToString("C2");
                    //txtTotalProdutos.Text = saida.Produtos.ToString("C2");
                    linha++;

                    txtCodigoProduto.Focus();

                    if (dataGridProdutos.Rows.Count > 0)
                    {
                        if (dataGridProdutos.FirstDisplayedScrollingRowIndex != dataGridProdutos.Rows.Count - 1)
                        {
                            dataGridProdutos.FirstDisplayedScrollingRowIndex++;
                        }
                    }
                }
        }


        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            CalculaTotais();
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            CalculaTotais();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            CalculaTotais();
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            CalculaTotais();
        }


        //EVENTOS DE CAMPOS NUMERICOS / MOEDA / PESO
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
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
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

        public void AplicarEventos(TextBox txt)
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
            //#################################################################################
        }

        private void btnBuscaSaidas_Click(object sender, EventArgs e)
        {
            BuscaSaidas busca = new BuscaSaidas(this,null);
            busca.ShowDialog();
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(saida.Id))
            {
                painelRecebimento.Visible = true;
                SalvarSaida();
            }
        }

        private void btnCancelaReceber_Click(object sender, EventArgs e)
        {
            painelRecebimento.Visible = false;
        }

        private void btnOkReceber_Click(object sender, EventArgs e)
        {
            if (saida.Efetivada_Financ != 1)
            {
                if (SalvaRecebimento())
                {
                    MovSaidasBLL BLL = new MovSaidasBLL();
                    string result = "ERRO AO RECEBER";
                    result = SalvarSaida();
                    if (BLL.AtualizaFinanceiro(saida))
                        if (BLL.AtualizaEstoque(saida))
                        {
                            saida.Efetivada_estoque = 1;
                            saida.Efetivada_Financ = 1;
                            pictureEstoque.Visible = true;
                            pictureFinanceiro.Visible = true;
                            Edita(true);
                        }

                    MessageBox.Show(result);
                    painelRecebimento.Visible = false;
                }
                else MessageBox.Show("Receba o valor total para continuar");
            }
            else MessageBox.Show("Venda Finalizada!");

            MensagemErro();
        }

        private void btnRecCartaoCliente_Click(object sender, EventArgs e)
        {
            //decimal valor = CalculaRecebimento();
            //decimal txt = 0;
            //if (valor > 0)
            //{
            //    try { txt = Convert.ToDecimal(txtRecCartaoCliente.Text.Replace("R$", "").Trim()); } catch { txt = 0; }
            //    valor += txt;
            //    txtRecCartaoCliente.Text = valor.ToString("C2");
            //}
        }

        private void btnRecCartaoConvenio_Click(object sender, EventArgs e)
        {
            decimal valor = CalculaRecebimento();
            decimal txt = 0;
            if (valor > 0)
            {
                try { txt = Convert.ToDecimal(txtRecCartaoConvenio.Text.Replace("R$", "").Trim()); } catch { txt = 0; }
                valor += txt;
                txtRecCartaoConvenio.Text = valor.ToString("C2");
            }
        }

        private void btnRecCartaoDebito_Click(object sender, EventArgs e)
        {
            decimal valor = CalculaRecebimento();
            decimal txt = 0;
            if (valor > 0)
            {
                try { txt = Convert.ToDecimal(txtRecCartaoDebito.Text.Replace("R$", "").Trim()); } catch { txt = 0; }
                valor += txt;
                txtRecCartaoDebito.Text = valor.ToString("C2");
            }
        }

        private void btnRecCartaoCredito_Click(object sender, EventArgs e)
        {
            decimal valor = CalculaRecebimento();
            decimal txt = 0;
            if (valor > 0)
            {
                try { txt = Convert.ToDecimal(txtRecCartaoCredito.Text.Replace("R$", "").Trim()); } catch { txt = 0; }
                valor += txt;
                txtRecCartaoCredito.Text = valor.ToString("C2");
            }
        }

        private void btnRecDinheiro_Click(object sender, EventArgs e)
        {
            decimal valor = CalculaRecebimento();
            decimal txt = 0;
            if (valor > 0)
            {
                try { txt = Convert.ToDecimal(txtRecDinheiro.Text.Replace("R$", "").Trim()); } catch { txt = 0; }
                valor += txt;
                txtRecDinheiro.Text = valor.ToString("C2");
            }
        }

        private bool SalvaRecebimento()
        {
            try { saida.Recebe_Credito_Cliente = Convert.ToDecimal(txtRecCartaoCliente.Text.Replace("R$", "").Trim()); } catch { saida.Recebe_Credito_Cliente = 0; }
            try { saida.Recebe_Cartao_Convenio = Convert.ToDecimal(txtRecCartaoConvenio.Text.Replace("R$", "").Trim()); } catch { saida.Recebe_Cartao_Convenio = 0; }
            try { saida.Recebe_cartao_Credito = Convert.ToDecimal(txtRecCartaoCredito.Text.Replace("R$", "").Trim()); } catch { saida.Recebe_cartao_Credito = 0; }
            try { saida.Recebe_Cartao_Debito = Convert.ToDecimal(txtRecCartaoDebito.Text.Replace("R$", "").Trim()); } catch { saida.Recebe_Cartao_Debito = 0; }
            try { saida.Recebe_Dinheiro = Convert.ToDecimal(txtRecDinheiro.Text.Replace("R$", "").Trim()); } catch { saida.Recebe_Dinheiro = 0; }

            decimal total = saida.Recebe_Credito_Cliente + saida.Recebe_Cartao_Convenio + saida.Recebe_cartao_Credito +
                saida.Recebe_Cartao_Debito + saida.Recebe_Dinheiro;

            decimal troco = total - saida.Total;

            saida.Recebe_Dinheiro = saida.Recebe_Dinheiro - troco;

            if (saida.Recebe_Dinheiro < 0)
                return false;

            saida.Recebe_Total = saida.Total;
    
            return true;
        }
        private decimal CalculaRecebimento()
        {
           
            decimal restante = 0;

            decimal CartaoCliente = 0;
            decimal CartaoConvenio = 0;
            decimal CartaoDebito = 0;
            decimal CartaoCredito = 0;
            decimal Dinheiro = 0;
            decimal Troco = 0;
            decimal Total = 0;
            if (saida.Efetivada_Financ != 1)
            {
                try { CartaoCliente = Convert.ToDecimal(txtRecCartaoCliente.Text.Replace("R$", "").Trim()); } catch { CartaoCliente = 0; }
                try { CartaoConvenio = Convert.ToDecimal(txtRecCartaoConvenio.Text.Replace("R$", "").Trim()); } catch { CartaoConvenio = 0; }
                try { CartaoCredito = Convert.ToDecimal(txtRecCartaoCredito.Text.Replace("R$", "").Trim()); } catch { CartaoCredito = 0; }
                try { CartaoDebito = Convert.ToDecimal(txtRecCartaoDebito.Text.Replace("R$", "").Trim()); } catch { CartaoDebito = 0; }
                try { Dinheiro = Convert.ToDecimal(txtRecDinheiro.Text.Replace("R$", "").Trim()); } catch { Dinheiro = 0; }

                Total = CartaoCliente + CartaoConvenio + CartaoDebito + CartaoCredito + Dinheiro;

                Troco = Total - saida.Total;

                restante = saida.Total - Total;

                if (Total >= saida.Total)
                    btnOkReceber.Enabled = true;
                else
                    btnOkReceber.Enabled = false;

                txtRecTroco.Text = Troco.ToString("C2");
            }
            return restante;
        }

        private void txtRecCartaoCliente_TextChanged(object sender, EventArgs e)
        {
            CalculaRecebimento();
        }

        private void txtRecCartaoConvenio_TextChanged(object sender, EventArgs e)
        {
            CalculaRecebimento();
        }

        private void txtRecCartaoDebito_TextChanged(object sender, EventArgs e)
        {
            CalculaRecebimento();
        }

        private void txtRecCartaoCredito_TextChanged(object sender, EventArgs e)
        {
            CalculaRecebimento();
        }

        private void txtRecDinheiro_TextChanged(object sender, EventArgs e)
        {
            CalculaRecebimento();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string motivo = "";
            if (saida != null)
                if (!string.IsNullOrEmpty(saida.Id))
                {
                    DialogResult Result = MessageBox.Show("Realmente Deseja Cancelar esta Nota? ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Result == DialogResult.Yes)
                    {

                        if (TextInput.InputBox("Importante!", "Qual o Motivo do cancelamento da Nota?", ref motivo) == DialogResult.OK)
                        {
                            saida.Motivo_cancelamento = motivo;
                            MovSaidasBLL BLL = new MovSaidasBLL();
                            if (BLL.CancelaNota(saida))
                            {
                                MessageBox.Show("Nota Cancelada");
                                LimpaTela();
                            }
                            else
                                MessageBox.Show("ERRO AO CANCELAR NOTA");
                        }
                    }
                }

            MensagemErro();
               
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            MovSaidaPizza busca = new MovSaidaPizza(this,null,null,null,conf);
            busca.ShowDialog();
            txtQuantidade.Focus();
        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnADDProduto_Click(null, null);
            }
        }

        private void txtDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnADDProduto_Click(null, null);
            }
        }

        private void txtCodigoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQuantidade.Focus();
            }
        }
    }
}
