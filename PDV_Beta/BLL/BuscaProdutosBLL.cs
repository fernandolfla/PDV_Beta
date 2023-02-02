using PDV_Beta.DAO;
using PDV_Beta.Entity;
using PDV_Beta.Seguranca;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.BLL
{
    class BuscaProdutosBLL
    {
        public List<Produto> BuscaProdutoPorCodigo(string codigo) 
        {
            DataTable Result = new DataTable();
            BuscaProdutosDAO DAO = new BuscaProdutosDAO();

            Result = DAO.BuscaPorCodigo(codigo, Autenticacao.GetCodFilial());

            if (Result != null)
                if (Result.Rows.Count > 0)
                     return DataToProduto(Result);
            return null;
        }


        public List<Produto> BuscaProdutoPorNome(string nome) //VERIFICAR
        {
            DataTable Result = new DataTable();
            BuscaProdutosDAO DAO = new BuscaProdutosDAO();

            Result = DAO.BuscaPorNome(nome, Autenticacao.GetCodFilial());

            if (Result != null)
                if (Result.Rows.Count > 0)
                     return DataToProduto(Result);
            return null;
        }


        private List<Produto> DataToProduto(DataTable data)
        {

            List<Produto> PRO = new List<Produto>();

            foreach (DataRow linha in data.Rows)
            {
                Produto pro = new Produto();

                try { pro.Ativo = (int)linha.ItemArray[0]; }
                catch (Exception) { }
                pro.Codigo = linha.ItemArray[1].ToString();
                try { pro.Fracionado = (int)linha.ItemArray[2]; }
                catch (Exception) { }
                try { pro.Tipo = (int)linha.ItemArray[3]; }
                catch (Exception) { }
                pro.Nome = linha.ItemArray[4].ToString();
                try { pro.Estoque = (int)linha.ItemArray[5]; }
                catch (Exception) { }
                pro.Unidade_Venda = linha.ItemArray[6].ToString();
                pro.Codigo_Fornecedor = linha.ItemArray[7].ToString();
                pro.Fabricante = linha.ItemArray[8].ToString();
                pro.Foto = linha.ItemArray[9].ToString();
                pro.Peso = linha.ItemArray[10].ToString();
                pro.Obs = linha.ItemArray[11].ToString();
                pro.Preco1 = linha.ItemArray[12].ToString();
                pro.Preco2 = linha.ItemArray[13].ToString();
                pro.Preco3 = linha.ItemArray[14].ToString();
                pro.Custo = linha.ItemArray[15].ToString();
                pro.QTD = linha.ItemArray[16].ToString();

                PRO.Add(pro);

            }

            return PRO;
        }



    }
}
