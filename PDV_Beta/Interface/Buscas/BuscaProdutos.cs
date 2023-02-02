using PDV_Beta.BLL;
using PDV_Beta.Entity;
using PDV_Beta.Interface.Movimento;
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
    public partial class BuscaProdutos : Form
    {

        private CadProdutos busca;
        private CadProdutoTipo busca2 ;
        private MovEntradas busca3;
        private MovSaidasCompleto busca4;
        private MovSaidaPizza busca5;
        private MovSaidasPizzaria busca6;
        private MovSaidaPizza busca7;
        private MovSaidaPizza busca8;

        List<Produto> produtos = new List<Produto>();
        List<Produto> produtosT = new List<Produto>();

        public BuscaProdutos(CadProdutos busca,CadProdutoTipo busca2, MovEntradas busca3, MovSaidasCompleto busca4, MovSaidaPizza busca5, MovSaidasPizzaria busca6, MovSaidaPizza busca7, MovSaidaPizza busca8)
        {
            InitializeComponent();
            this.busca = busca;
            this.busca2 = busca2;
            this.busca3 = busca3;
            this.busca4 = busca4;
            this.busca5 = busca5;
            this.busca6 = busca6; 
            this.busca7 = busca7;//reserva
            this.busca8 = busca8;//reserva
        }

        private void BuscaProdutos_Load(object sender, EventArgs e)
        {

        }



        private void BuscaPorNome()
        {
            dataListaProdutos.Rows.Clear();
            dataListaProdutos.Refresh();

            BuscaProdutosBLL BLL = new BuscaProdutosBLL();

            produtosT = null;
            if(produtosT == null)
                produtosT = new List<Produto>();

            produtos = null;
            produtos = BLL.BuscaProdutoPorNome(txtNome.Text);

            
            if (produtos != null)
            {
                if (busca != null || busca3 != null || busca4 != null || busca6 != null)
                {
                    foreach (var indice in produtos)
                    {

                        string[] row = new string[] { indice.Codigo, indice.Nome, indice.QTD , indice.Custo, indice.Preco1, indice.Preco2, indice.Preco3 };

                        dataListaProdutos.Rows.Add(row);

                    }
                }
                if (busca2 != null || busca5 != null)
                {
                    foreach (var indice in produtos)
                    {
                        if (indice.Tipo == 1)
                            produtosT.Add(indice);
                    }
                    foreach (var indice in produtosT)
                    {

                        string[] row = new string[] { indice.Codigo, indice.Nome, indice.QTD, indice.Custo, indice.Preco1, indice.Preco2, indice.Preco3 };

                        dataListaProdutos.Rows.Add(row);

                    }
                }
            } 
        }

        private void BuscaPorCodigo()
        {
            dataListaProdutos.Rows.Clear();
            dataListaProdutos.Refresh();

            BuscaProdutosBLL BLL = new BuscaProdutosBLL();

            produtosT = null;
            if (produtosT == null)
                produtosT = new List<Produto>();
            produtos = null;
            produtos = BLL.BuscaProdutoPorCodigo(txtCodigo.Text);

            if (produtos != null)
            {
                if (busca != null || busca3 != null || busca4 != null || busca6 != null)
                {
                    foreach (var indice in produtos)
                    {

                        string[] row = new string[] { indice.Codigo, indice.Nome, indice.QTD, indice.Custo, indice.Preco1, indice.Preco2, indice.Preco3 };

                        dataListaProdutos.Rows.Add(row);

                    }
                }
                if (busca2 != null || busca5 != null)
                {
                    foreach(var indice in produtos)
                    {
                        if (indice.Tipo == 1)
                            produtosT.Add(indice);
                    }
                    foreach (var indice in produtosT)
                    {

                        string[] row = new string[] { indice.Codigo, indice.Nome, indice.QTD, indice.Custo, indice.Preco1, indice.Preco2, indice.Preco3 };

                        dataListaProdutos.Rows.Add(row);

                    }
                }
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            BuscaPorCodigo();
            this.Cursor = Cursors.Default;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            BuscaPorNome();
            this.Cursor = Cursors.Default;
        }

        private void dataProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (produtos != null)
                if (produtos.Count > 0)
                    if (e.RowIndex >= 0)
                    {
                        if (busca != null)
                        {
                            busca.EntityToTela(produtos[e.RowIndex]);
                            busca.txtCodigo.Enabled = false;
                            busca.edita = true;
                        }
                        if(busca2 != null)
                        {
                            busca2.txtProduto.Text = produtosT[e.RowIndex].Codigo;
                        }
                        if(busca3 != null)
                        {
                            busca3.txtCodigoProduto.Text = produtos[e.RowIndex].Codigo;
                            busca3.txtNomeProduto.Text = produtos[e.RowIndex].Nome;
                            try { busca3.txtPreco.Text = Convert.ToDecimal(produtos[e.RowIndex].Custo).ToString("C2"); } catch (Exception) { }
                        }
                        if(busca4 != null)
                        {
                            busca4.txtCodigoProduto.Text = produtos[e.RowIndex].Codigo;
                            busca4.txtQuantidade.Focus();
                        }
                        if(busca5 != null)
                        {
                            busca5.produto = null;
                            busca5.produto = new Produto();
                            busca5.produto = produtosT[e.RowIndex];
                            busca5.LancaProduto();
                        }
                        if (busca6 != null)
                        {
                            busca6.txtCodigoProduto.Text = produtos[e.RowIndex].Codigo;
                            busca6.txtQuantidade.Focus();
                        }
                    }  

            this.Close();
        }

        private void dataListaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
