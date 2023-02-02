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
    class CadProdutosBLL
    {
        public int CadastraProduto(Produto pro, bool edita)
        {
            if (pro.Nome.Length > 0 && pro.Nome.Length <= 50)
                if (pro.Codigo.Length > 0 && pro.Codigo.Length <= 20)
                {
                   
                        CadProdutosDAO DAO = new CadProdutosDAO();

                        DataTable Result = new DataTable();

                        Result = DAO.CadastraProduto(pro , edita, Autenticacao.GetCodUsuario(),Autenticacao.GetCodFilial());
                        if (Result != null)
                            if (Result.Rows.Count > 0)
                                if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                                    return 1;
                                else return 2;
       
                }
            return 3;
        }



        public Produto BuscaProxProduto(Produto pro)
        {

            CadProdutosDAO DAO = new CadProdutosDAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaProxProduto(pro);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        pro = DataToProduto(Result,pro);
                        return pro;
                    }
                    else return null;
                }
                else
                {
                    pro.Codigo = null;
                    Result = DAO.BuscaProxProduto(pro);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                pro = DataToProduto(Result, pro);
                                return pro;
                            }
                        }
                }
            return null;
        }


        public Produto BuscaAntProduto(Produto pro)
        {

            CadProdutosDAO DAO = new CadProdutosDAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaAntProduto(pro);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        pro = DataToProduto(Result, pro);
                        return pro;
                    }
                    else return null;
                }
                else
                {
                    pro.Codigo = null;
                    Result = DAO.BuscaAntProduto(pro);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                pro = DataToProduto(Result, pro);
                                return pro;
                            }
                        }
                }
            return null;
        }

        public string BuscaProxCodLivre()
        {
            CadProdutosDAO DAO = new CadProdutosDAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaProximoCodigoLivre();

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    return Result.Rows[0].ItemArray[0].ToString();
                }
            return null;
        }

        public bool ApagaProduto(string cod)
        {
            //Verificar se o funcinario pussui vendas cadastradas
            //Verificar se o funcionario fez algo que dependa do código

            CadProdutosDAO DAO = new CadProdutosDAO();


            if (!string.IsNullOrEmpty(cod))
            {

                DataTable Result = new DataTable();

                Result = DAO.ApagaProduto(cod);
                if (Result != null)
                    if (Result.Rows.Count > 0)
                        if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                            return true;
            }
            return false;
        }

        private Produto DataToProduto(DataTable data, Produto pro)
        {
            
            try { pro.Ativo = (int)data.Rows[0].ItemArray[0]; }
            catch (Exception) { }
            pro.Codigo= data.Rows[0].ItemArray[1].ToString();
            try { pro.Fracionado = (int)data.Rows[0].ItemArray[2]; }
            catch (Exception) { }
            try { pro.Tipo = (int)data.Rows[0].ItemArray[3]; }
            catch (Exception) { }
            pro.Nome = data.Rows[0].ItemArray[4].ToString();
            try { pro.Estoque = (int)data.Rows[0].ItemArray[5]; }
            catch (Exception) { }
            pro.Unidade_Venda = data.Rows[0].ItemArray[6].ToString();
            pro.Codigo_Fornecedor = data.Rows[0].ItemArray[7].ToString();
            pro.Fabricante = data.Rows[0].ItemArray[8].ToString();
            pro.Foto = data.Rows[0].ItemArray[9].ToString();
            pro.Peso = data.Rows[0].ItemArray[10].ToString();
            pro.Obs = data.Rows[0].ItemArray[11].ToString();
            pro.Preco1 = data.Rows[0].ItemArray[12].ToString();
            pro.Preco2 = data.Rows[0].ItemArray[13].ToString();
            pro.Preco3 = data.Rows[0].ItemArray[14].ToString();
            pro.Custo = data.Rows[0].ItemArray[15].ToString();



            return pro;
        }

  


    }
}
