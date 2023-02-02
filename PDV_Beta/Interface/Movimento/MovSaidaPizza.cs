using PDV_Beta.BLL;
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

namespace PDV_Beta.Interface.Movimento
{
    public partial class MovSaidaPizza : Form
    {
        MovSaidasCompleto busca;
        MovSaidasPizzaria busca2; 
        MovSaidasCompleto busca3;//RESERVA
        MovSaidasCompleto busca4;//RESERVA
        Saidas_zConf conf;

        public Produto produto = new Produto();
        List<ProdutoTamanho> TAMANHOS = new List<ProdutoTamanho>();
        List<ProdutoTipo> TIPOS = new List<ProdutoTipo>();
        List<ProdutoTipo> TIPOS2 = new List<ProdutoTipo>();
        List<ProdutoSabor> SABOR = new List<ProdutoSabor>();

        decimal valorPizza;

        string CodTamanho;

        int QtdSabores;
        public MovSaidaPizza(MovSaidasCompleto busca, MovSaidasPizzaria busca2, MovSaidasCompleto busca3, MovSaidasCompleto busca4, Saidas_zConf conf)
        {
            InitializeComponent();
            valorPizza = 0;
            QtdSabores = 1;
            this.busca = busca;
            this.busca2 = busca2;
            this.busca3 = busca3;
            this.busca4 = busca4;
            this.conf = conf;

            CadProdutoT_T_S_BLL BLL = new CadProdutoT_T_S_BLL();

            TAMANHOS = BLL.ListaProdutoTamanho();

            if (TAMANHOS != null)
                foreach (ProdutoTamanho l in TAMANHOS)
                {
                    comboTamanho.Items.Add(l.Nome);
                }

            TIPOS = BLL.ListaProdutoTipo();


            txtCodProduto.Text = "1";
            txtCodProduto_Leave(null, null);

        }

        private void MovSaidaPizza_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarPizza_Click(object sender, EventArgs e)
        {
            BuscaProdutos busca = new BuscaProdutos(null, null, null, null, this, null, null, null);
            busca.ShowDialog();
        }
        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCodProduto.Text))
            {
                MovSaidasBLL BLL = new MovSaidasBLL();
                produto = null;
                produto = new Produto();
              
                produto = BLL.BuscaProdutoPorCodigo(txtCodProduto.Text);
                if (produto != null)
                {
                    if (produto.Tipo == 1)
                        LancaProduto();
                    else
                    {
                        txtCodProduto.Text = "";
                        txtNomeProduto.Text = "";
                    }
                }
                else
                {
                    txtCodProduto.Text = "";
                    txtNomeProduto.Text = "";
                }
            }
            
        }
        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            if(produto != null)
            {
                txtNomePizza.Text = txtNomePizza.Text + "  " + txtObservacoes.Text;
                produto.Preco1 = txtPrecoFinal.Text.Replace("R$", "").Trim();
                produto.Preco2 = produto.Preco1;
                produto.Preco3 = produto.Preco1;
                produto.Nome = txtNomePizza.Text;

                if(busca != null)
                    busca.LancaPizza(produto);
                if (busca2 != null)
                    busca2.LancaPizza(produto);
                this.Close();
            }
        }

        public void LancaProduto()
        {
            if(produto != null)
            {
                txtCodProduto.Text = produto.Codigo;
                txtNomeProduto.Text = produto.Nome;

                TIPOS2 = null;
                TIPOS2 = new List<ProdutoTipo>();
                SABOR = null;
                SABOR = new List<ProdutoSabor>();


                if (TIPOS != null)
                    foreach (var l in TIPOS)
                    {
                        if (l.CodProduto.Equals(produto.Codigo))
                            TIPOS2.Add(l);
                    }

                MovSaidasBLL BLL = new MovSaidasBLL();

                if (TIPOS2 != null)
                    foreach(var l in TIPOS2)
                    {
                        List<ProdutoSabor> ADD = BLL.ListaSabores(l.Id);
                        if(ADD != null)
                            SABOR.AddRange(ADD);
                    }

                comboSabor1.Items.Clear();
                comboSabor2.Items.Clear();
                comboSabor3.Items.Clear();
                comboSabor4.Items.Clear();
                comboSabor5.Items.Clear();

                if (SABOR != null)
                    foreach(var l in SABOR)
                    {
                        comboSabor1.Items.Add(l.Nome);
                        comboSabor2.Items.Add(l.Nome);
                        comboSabor3.Items.Add(l.Nome);
                        comboSabor4.Items.Add(l.Nome);
                        comboSabor5.Items.Add(l.Nome);
                    }


            }
        }

        private void comboTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQTDPedacos.Text = TAMANHOS[comboTamanho.SelectedIndex].QtdPedacos;
            
            try { QtdSabores = Convert.ToInt32(TAMANHOS[comboTamanho.SelectedIndex].QtdSabores); } catch { QtdSabores = 1; }

            CodTamanho = TAMANHOS[comboTamanho.SelectedIndex].Id;
            EnableSabores();
            

        }

        private void EnableSabores()
        {
            switch (QtdSabores)
            {
                case 1:
                    lblSabor1.Visible = true;
                    lblSabor2.Visible = false;
                    lblSabor3.Visible = false;
                    lblSabor4.Visible = false;
                    lblSabor5.Visible = false;
                    comboSabor1.Visible = true;
                    comboSabor2.Visible = false;
                    comboSabor3.Visible = false;
                    comboSabor4.Visible = false;
                    comboSabor5.Visible = false;
                    break;
                case 2:
                    lblSabor1.Visible = true;
                    lblSabor2.Visible = true;
                    lblSabor3.Visible = false;
                    lblSabor4.Visible = false;
                    lblSabor5.Visible = false;
                    comboSabor1.Visible = true;
                    comboSabor2.Visible = true;
                    comboSabor3.Visible = false;
                    comboSabor4.Visible = false;
                    comboSabor5.Visible = false;
                    break;
                case 3:
                    lblSabor1.Visible = true;
                    lblSabor2.Visible = true;
                    lblSabor3.Visible = true;
                    lblSabor4.Visible = false;
                    lblSabor5.Visible = false;
                    comboSabor1.Visible = true;
                    comboSabor2.Visible = true;
                    comboSabor3.Visible = true;
                    comboSabor4.Visible = false;
                    comboSabor5.Visible = false;
                    break;
                case 4:
                    lblSabor1.Visible = true;
                    lblSabor2.Visible = true;
                    lblSabor3.Visible = true;
                    lblSabor4.Visible = true;
                    lblSabor5.Visible = false;
                    comboSabor1.Visible = true;
                    comboSabor2.Visible = true;
                    comboSabor3.Visible = true;
                    comboSabor4.Visible = true;
                    comboSabor5.Visible = false;
                    break;
                case 5:
                    lblSabor1.Visible = true;
                    lblSabor2.Visible = true;
                    lblSabor3.Visible = true;
                    lblSabor4.Visible = true;
                    lblSabor5.Visible = true;
                    comboSabor1.Visible = true;
                    comboSabor2.Visible = true;
                    comboSabor3.Visible = true;
                    comboSabor4.Visible = true;
                    comboSabor5.Visible = true;
                    break;
            }
        }


        private void CalculaTotal(int combo)
        {
            string CodTipo = SABOR[comboSabor1.SelectedIndex].Produto_Tipo;
            decimal ValorMaior = 0;

            switch(combo)
            {
                case 1:
                    CodTipo = SABOR[comboSabor1.SelectedIndex].Produto_Tipo;
                    
                    break;
                case 2:
                    CodTipo = SABOR[comboSabor2.SelectedIndex].Produto_Tipo;
                    break;
                case 3:
                    CodTipo = SABOR[comboSabor3.SelectedIndex].Produto_Tipo;
                    break;
                case 4:
                    CodTipo = SABOR[comboSabor4.SelectedIndex].Produto_Tipo;
                    break;
                case 5:
                    CodTipo = SABOR[comboSabor5.SelectedIndex].Produto_Tipo;
                    break;

                    //ver o que calcula o que
            }

            MovSaidasBLL BLL = new MovSaidasBLL();

            ProdutoTipoTamanhoPreco preco = new ProdutoTipoTamanhoPreco();

            preco = BLL.BuscaProdutoTipoTamanhoPreco(CodTipo, CodTamanho);

            if (preco != null)
            {
                if(conf != null)
                {
                    switch(conf.TabelaPadrao)
                    {
                        case 1:
                            try { ValorMaior = Convert.ToDecimal(preco.Preco1); } catch { ValorMaior = 0; }
                            break;
                        case 2:
                            try { ValorMaior = Convert.ToDecimal(preco.Preco2); } catch { ValorMaior = 0; }
                            break;
                        case 3:
                            try { ValorMaior = Convert.ToDecimal(preco.Preco3); } catch { ValorMaior = 0; }
                            break;
                        default:
                            try { ValorMaior = Convert.ToDecimal(preco.Preco1); } catch { ValorMaior = 0; }
                            break;
                    }
                    
                }
                
            }
            if (ValorMaior > valorPizza)
                valorPizza = ValorMaior;

            txtPrecoFinal.Text = valorPizza.ToString("C2");

            switch (QtdSabores)
            {
                case 1:
                    txtNomePizza.Text = txtNomeProduto.Text + " " + comboTamanho.Text + " " + comboBorda.Text + " " + comboSabor1.Text;
                    break;
                case 2:
                    txtNomePizza.Text = txtNomeProduto.Text + " " + comboTamanho.Text + " " + comboBorda.Text + " " + comboSabor1.Text + " / " + comboSabor2.Text;
                    break;
                case 3:
                    txtNomePizza.Text = txtNomeProduto.Text + " " + comboTamanho.Text + " " + comboBorda.Text + " " + comboSabor1.Text + " / " + comboSabor2.Text +
                     " / " + comboSabor3.Text;
                    break;
                case 4:
                    txtNomePizza.Text = txtNomeProduto.Text + " " + comboTamanho.Text + " " + comboBorda.Text + " " + comboSabor1.Text + " / " + comboSabor2.Text +
                     " / " + comboSabor3.Text + " / " + comboSabor4.Text;
                    break;
                case 5:
                    txtNomePizza.Text = txtNomeProduto.Text + " " + comboTamanho.Text + " " + comboBorda.Text + " " + comboSabor1.Text + " / " + comboSabor2.Text +
                    " / " + comboSabor3.Text + " / " + comboSabor4.Text + " / " + comboSabor5.Text;
                    break;
                case 6:
                    txtNomePizza.Text = txtNomeProduto.Text + " " + comboTamanho.Text;
                    break;
            }
            

        }

        private void comboSabor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculaTotal(1);
        }

        private void comboSabor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculaTotal(2);
        }

        private void comboSabor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculaTotal(3);
        }

        private void comboSabor4_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculaTotal(4);
        }

        private void comboSabor5_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculaTotal(5);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            valorPizza = 0;
            txtPrecoFinal.Text = valorPizza.ToString("C2");
            txtNomePizza.Text = "";
        }

        private void ComboBorda(object sender, EventArgs e)
        {

        }

        //private void txtObservacoes_Leave(object sender, EventArgs e)
        //{
        //    txtNomePizza.Text = txtNomePizza.Text + "  " + txtObservacoes.Text;
        //}
    }
}
