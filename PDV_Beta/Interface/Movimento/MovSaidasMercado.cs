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

namespace PDV_Beta.Interface.Movimento
{
    public partial class MovSaidasMercado : Form
    {
        public Saida saida = new Saida();
        Saida_Produtos spro = new Saida_Produtos();
        private Produto pro = new Produto();
        private int linha = 1;
        public Saidas_zConf conf = new Saidas_zConf();

        public MovSaidasMercado()
        {
            //TELA SAIDAS NUMERO 1 para zCONF
            InitializeComponent();

            AplicarEventos(txtTotalNota);
            AplicarEventos(txtRecCartaoCliente);
            AplicarEventos(txtRecCartaoConvenio);
            AplicarEventos(txtRecCartaoCredito);
            AplicarEventos(txtRecCartaoDebito);
            AplicarEventos(txtRecDinheiro);
            AplicarEventos(txtRecTroco);

            

            txtData.Value = DateTime.Now;

            MovSaidasBLL BLL = new MovSaidasBLL();

            ConfTelasVendasBLL BLLc = new ConfTelasVendasBLL();

            conf = BLLc.Busca(2); //CONFIGURAÇÔES DA TELA 1
            if (conf != null)
            {        
                saida.CFOP = conf.CFOP;

                if (conf.ClientePadraoAtivo == 1)
                {
                    saida.Cliente = conf.ClientePadrao;
                    saida.NomeCliente = conf.ClientePadrao;
                }
                saida.TabelaPreco = conf.TabelaPadrao;
            }

           MensagemErro();
            txtCodigoProduto.Focus();
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
            MovSaidasBLL BLL = new MovSaidasBLL();

            if (string.IsNullOrEmpty(txtSequencia.Text))
            {
                saida = BLL.Salvar(saida);
                switch (saida.Result)
                {
                    case 0:
                        return ("Cliente ou CFOP INVALIDO ");

                    case 1:
                        txtSequencia.Text = saida.Id;
                        Edita(false);
                        return ("Venda Salva");
                    case 2:
                        return ("Erro ao Gravar a Venda");
                    case 3:
                        return ("Erro no Banco de dados, GravaPRODUTOS, Procure o Suporte");
                    case 4:
                        return ("Erro no Banco de dados, GravaPRODUTOS, Procure o Suporte");
                    case 5:
                        return ("Erro no Banco de dados, GravaPRODUTOS, Procure o Suporte");
                    default:
                        return ("ERRO DESCONHECIDO, PROCURE O SUPORTE ");
                }
            }
            else
            {
                saida = BLL.Atualizar(saida);
                switch (saida.Result)
                {
                    case 0:
                        return ("ERRO AO ATUALIZAR");
                    case 1:
                        txtSequencia.Text = saida.Id;
                        Edita(false);
                        return ("Venda Salva");
                    default:
                        return ("ERRO DESCONHECIDO, PROCURE O SUPORTE ");
                }
            }

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string result = "ERRO DESCONHECIDO";
            result = SalvarSaida();
            MessageBox.Show(result);
            MensagemErro();
        }

       
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            txtCodigoProduto.Focus();
        }


        private void Edita(bool recebido)
        {
           if (recebido)
            {
                btnSalvar.Enabled = false;
                txtCodigoProduto.Enabled = false;
                txtRecCartaoCliente.Enabled = false;
                txtRecCartaoConvenio.Enabled = false;
                txtRecCartaoCredito.Enabled = false;
                txtRecCartaoDebito.Enabled = false;
                txtRecDinheiro.Enabled = false;
                txtRecTroco.Enabled = false;
                btnConsultaPreco.Enabled = false;
                btnRemoverProduto.Enabled = false;
            }

            txtCodigoProduto.Focus();
        }
        private void NaoEdita()
        {
            btnSalvar.Enabled = true;
            txtCodigoProduto.Enabled = true;
            txtRecCartaoCliente.Enabled = true;
            txtRecCartaoConvenio.Enabled = true;
            txtRecCartaoCredito.Enabled = true;
            txtRecCartaoDebito.Enabled = true;
            txtRecDinheiro.Enabled = true;
            txtRecTroco.Enabled = true;
            btnConsultaPreco.Enabled = true;
            btnRemoverProduto.Enabled = true;
        }


        private void LimpaProdutos()
        {
            txtCodigoProduto.Text = "";
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
            txtSequencia.Text = "";     
            txtTotalNota.Text = "";
            dataGridProdutos.Rows.Clear();
            dataGridProdutos.Refresh();
            linha = 1;
            txtRecCartaoCliente.Text = "";
            txtRecCartaoConvenio.Text = "";
            txtRecCartaoCredito.Text = "";
            txtRecCartaoDebito.Text = "";
            txtRecDinheiro.Text = "";
            txtRecTroco.Text = "";
            pictureEstoque.Visible = false;
            pictureFinanceiro.Visible = false;

            if (conf != null)
            {
                saida.CFOP = conf.CFOP;

                if (conf.ClientePadraoAtivo == 1)
                {
                    saida.Cliente = conf.ClientePadrao;
                    saida.NomeCliente = conf.ClientePadrao;
                }
                saida.TabelaPreco = conf.TabelaPadrao;
            }


        }
        private void LancaProdutos()
        {
            if (saida.Efetivada_Financ != 1)
            {
                if (!string.IsNullOrEmpty(txtCodigoProduto.Text))
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
                        CalculaTotais();
                        ADDProduto();
                    }
                    else
                    {
                        LimpaProdutos();
                        txtCodigoProduto.Focus();
                        MessageBox.Show("Produto não Encontrado");

                    }
                }
            }
        }
        private void txtCodigoProduto_Leave(object sender, EventArgs e)
        {
            LancaProdutos();
        }

        private void CalculaTotais()
        {
            decimal preco = 0;
            
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


                if (spro == null)
                    spro = new Saida_Produtos();
                spro.Tabela_Preco = saida.TabelaPreco;
                spro.CodProduto = pro.Codigo;
                spro.NomeProduto = pro.Nome;
                spro.Preco_Unit = preco;
                spro.Qtde = 1;
                spro.Desconto = 0;
                spro.Preco_Total = preco;
                spro.Preco_Final = preco;
            }

        }


        private void CalculaTotalNota()
        {
            decimal total = 0;
            decimal final = 0;
            if (saida != null)
            {
                if (saida.Lista_produtos != null)
                    if (saida.Lista_produtos.Count > 0)
                    {
                        foreach (Saida_Produtos l in saida.Lista_produtos)
                        {
                            final += l.Preco_Final;
                            total += l.Preco_Total;

                        }
                    }

                saida.Desconto = 0;
                saida.Produtos = total;
                saida.Total = final;
            }
            txtTotalNota.Text = saida.Total.ToString("C2");

        }
       
        private void ADDProduto()
        {
            if (!string.IsNullOrEmpty(txtCodigoProduto.Text))
            {
                CalculaTotais();
                spro.Linha = linha;

                if (saida.Lista_produtos == null)
                    saida.Lista_produtos = new List<Saida_Produtos>();

                saida.Lista_produtos.Add(spro);

                string[] row = new string[] { linha.ToString(), spro.CodProduto , spro.NomeProduto
                , spro.Qtde.ToString() , spro.Preco_Unit.ToString("C2")};

                dataGridProdutos.Rows.Add(row);

                LimpaProdutos();

                CalculaTotalNota();
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

        private void btnRemoverProduto_Click(object sender, EventArgs e)
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
        private void btnConsultaPreco_Click(object sender, EventArgs e)
        {
            MovSaidas_BuscaPreco busca = new MovSaidas_BuscaPreco(this);
            busca.ShowDialog();
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

        private void txtCodigoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LancaProdutos();
            }
        }
    }
}
