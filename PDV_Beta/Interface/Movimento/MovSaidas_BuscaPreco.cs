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
    public partial class MovSaidas_BuscaPreco : Form
    {
        MovSaidasMercado busca = new MovSaidasMercado();
        public MovSaidas_BuscaPreco(MovSaidasMercado busca)
        {
            InitializeComponent();
            this.busca = busca;

            txtCodigoProduto.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoProduto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoProduto.Text))
            {
                MovSaidasBLL BLL = new MovSaidasBLL();

                Produto pro = new Produto();
                pro = BLL.BuscaProdutoPorCodigo(txtCodigoProduto.Text);
                if (pro != null)
                {
                    txtCodigoProduto.Text = pro.Codigo;
                    txtNome.Text = pro.Nome;
                    decimal preco = 0;
                    try {
                        switch (busca.conf.TabelaPadrao)
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

                    txtPreco.Text = preco.ToString("C2");

                }
                else
                {
                    MessageBox.Show("Produto não Encontrado");
                }
            }
        }






    }
}
