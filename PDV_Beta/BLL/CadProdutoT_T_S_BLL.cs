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
    class CadProdutoT_T_S_BLL
    {
        //PRODUTOTIPO ########################################################################
        public bool CadastraProdutoTipo(ProdutoTipo pro)
        {
            if (pro.Nome.Length > 0 && pro.Nome.Length <= 30)
                if (string.IsNullOrEmpty(pro.Id))
                    if(!string.IsNullOrEmpty(pro.CodProduto))
                    {

                        CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();

                        DataTable Result = new DataTable();

                        Result = DAO.CadastraProdutoTipo(pro,Autenticacao.GetCodUsuario());
                        if (Result != null)
                            if (Result.Rows.Count > 0)
                                if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                                    return true;
                                else return false;

                    }
            return false;
        }

        public bool ApagaProdutoTipo(string cod)
        {

            CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();
            if (!string.IsNullOrEmpty(cod))
            {

                DataTable Result = new DataTable();

                Result = DAO.ApagaProdutoTipo(cod);
                if (Result != null)
                    if (Result.Rows.Count > 0)
                        if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                            return true;
            }
            return false;
        }



        public ProdutoTipo BuscaProxProdutoTipo(ProdutoTipo pro)
        {

            CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaProxProdutoTipo(pro);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        pro = DataToProdutoTipo(Result, pro);
                        return pro;
                    }
                    else return null;
                }
                else
                {
                    pro.Id = null;
                    Result = DAO.BuscaProxProdutoTipo(pro);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                pro = DataToProdutoTipo(Result, pro);
                                return pro;
                            }
                        }
                }
            return null;
        }


        public ProdutoTipo BuscaAntProdutoTipo(ProdutoTipo pro)
        {

            CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaAntProdutoTipo(pro);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        pro = DataToProdutoTipo(Result, pro);
                        return pro;
                    }
                    else return null;
                }
                else
                {
                    pro.Id = null;
                    Result = DAO.BuscaAntProdutoTipo(pro);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                pro = DataToProdutoTipo(Result, pro);
                                return pro;
                            }
                        }
                }
            return null;
        }

        private ProdutoTipo DataToProdutoTipo(DataTable data, ProdutoTipo pro)
        {
            pro.Id = data.Rows[0].ItemArray[0].ToString();
            pro.CodProduto = data.Rows[0].ItemArray[1].ToString();
            pro.Nome = data.Rows[0].ItemArray[2].ToString();
            try { pro.EPizza = (int)data.Rows[0].ItemArray[3]; }
            catch (Exception) { }

            return pro;
        }

        //PRODUTOTIPO #####################################################################


        //PRODUTOTAMANHO ##################################################################

        public bool CadastraProdutoTamanho(ProdutoTamanho pro)
        {
            if (pro.Nome.Length > 0 && pro.Nome.Length <= 30)
                if (string.IsNullOrEmpty(pro.Id))
                    if (!string.IsNullOrEmpty(pro.QtdPedacos))
                        if (!string.IsNullOrEmpty(pro.QtdSabores))
                        {

                        CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();

                        DataTable Result = new DataTable();

                        Result = DAO.CadastraProdutoTamanho(pro, Autenticacao.GetCodUsuario());
                        if (Result != null)
                            if (Result.Rows.Count > 0)
                                if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                                    return true;
                                else return false;

                    }
            return false;
        }

        public bool ApagaProdutoTamanho(string cod)
        {

            CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();
            if (!string.IsNullOrEmpty(cod))
            {

                DataTable Result = new DataTable();

                Result = DAO.ApagaProdutoTamanho(cod);
                if (Result != null)
                    if (Result.Rows.Count > 0)
                        if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                            return true;
            }
            return false;
        }



        public ProdutoTamanho BuscaProxProdutoTamanho(ProdutoTamanho pro)
        {

            CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaProxProdutoTamanho(pro);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        pro = DataToProdutoTamanho(Result, pro);
                        return pro;
                    }
                    else return null;
                }
                else
                {
                    pro.Id = null;
                    Result = DAO.BuscaProxProdutoTamanho(pro);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                pro = DataToProdutoTamanho(Result, pro);
                                return pro;
                            }
                        }
                }
            return null;
        }


        public ProdutoTamanho BuscaAntProdutoTamanho(ProdutoTamanho pro)
        {

            CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaAntProdutoTamanho(pro);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        pro = DataToProdutoTamanho(Result, pro);
                        return pro;
                    }
                    else return null;
                }
                else
                {
                    pro.Id = null;
                    Result = DAO.BuscaAntProdutoTamanho(pro);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                pro = DataToProdutoTamanho(Result, pro);
                                return pro;
                            }
                        }
                }
            return null;
        }

        private ProdutoTamanho DataToProdutoTamanho(DataTable data, ProdutoTamanho pro)
        {
            pro.Id = data.Rows[0].ItemArray[0].ToString();
            pro.Nome = data.Rows[0].ItemArray[1].ToString();
            pro.QtdSabores = data.Rows[0].ItemArray[2].ToString();
            pro.QtdPedacos = data.Rows[0].ItemArray[3].ToString();
           
            return pro;
        }

        //PRODUTOTAMANHO ##################################################################


        //PRODUTOSABOR ##################################################################


        public bool CadastraProdutoSabor(ProdutoSabor pro)
        {
            if (pro.Nome.Length > 0 && pro.Nome.Length <= 30)
                if (string.IsNullOrEmpty(pro.Id))
                    if (!string.IsNullOrEmpty(pro.Produto_Tipo))
                        {

                            CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();

                            DataTable Result = new DataTable();

                            Result = DAO.CadastraProdutoSabor(pro, Autenticacao.GetCodUsuario());
                            if (Result != null)
                                if (Result.Rows.Count > 0)
                                    if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                                        return true;
                                    else return false;

                        }
            return false;
        }

        public bool ApagaProdutoSabor(string cod)
        {

            CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();
            if (!string.IsNullOrEmpty(cod))
            {

                DataTable Result = new DataTable();

                Result = DAO.ApagaProdutoSabor(cod);
                if (Result != null)
                    if (Result.Rows.Count > 0)
                        if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                            return true;
            }
            return false;
        }



        public ProdutoSabor BuscaProxProdutoSabor(ProdutoSabor pro)
        {

            CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaProxProdutoSabor(pro);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        pro = DataToProdutoSabor(Result, pro);
                        return pro;
                    }
                    else return null;
                }
                else
                {
                    pro.Id = null;
                    Result = DAO.BuscaProxProdutoSabor(pro);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                pro = DataToProdutoSabor(Result, pro);
                                return pro;
                            }
                        }
                }
            return null;
        }


        public ProdutoSabor BuscaAntProdutoSabor(ProdutoSabor pro)
        {

            CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaAntProdutoSabor(pro);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        pro = DataToProdutoSabor(Result, pro);
                        return pro;
                    }
                    else return null;
                }
                else
                {
                    pro.Id = null;
                    Result = DAO.BuscaAntProdutoSabor(pro);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                pro = DataToProdutoSabor(Result, pro);
                                return pro;
                            }
                        }
                }
            return null;
        }

        private ProdutoSabor DataToProdutoSabor(DataTable data, ProdutoSabor pro)
        {
            pro.Id = data.Rows[0].ItemArray[0].ToString();
            pro.Nome = data.Rows[0].ItemArray[1].ToString();
            pro.Produto_Tipo = data.Rows[0].ItemArray[2].ToString();

            return pro;
        }


        public List<ProdutoTipo> ListaProdutoTipo()
        {    
            CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();

            DataTable Result = new DataTable();
            Result = DAO.ListaProduto_Tipo();

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    List<ProdutoTipo> prot = new List<ProdutoTipo>();
                    try
                    {
                        foreach (DataRow linha in Result.Rows)
                        {
                            ProdutoTipo pro = new ProdutoTipo();
                            pro.Id = linha.ItemArray[0].ToString();
                            pro.CodProduto = linha.ItemArray[1].ToString();
                            pro.Nome = linha.ItemArray[2].ToString();
                            pro.EPizza = Convert.ToInt32(linha.ItemArray[3]);

                            prot.Add(pro);
                        }

                    }
                    catch (Exception) { return null; }
                    return prot;
                }
            return null;
        }

        public List<ProdutoTamanho> ListaProdutoTamanho()
        {
            CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();

            DataTable Result = new DataTable();
            Result = DAO.ListaProduto_Tamanho();

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    List<ProdutoTamanho> prot = new List<ProdutoTamanho>();
                    try
                    {
                        foreach (DataRow linha in Result.Rows)
                        {
                            ProdutoTamanho pro = new ProdutoTamanho();
                            pro.Id = linha.ItemArray[0].ToString();
                            pro.Nome= linha.ItemArray[1].ToString();
                            pro.QtdSabores  = linha.ItemArray[2].ToString();
                            pro.QtdPedacos = linha.ItemArray[3].ToString();

                            prot.Add(pro);
                        }
                    }
                    catch (Exception) { return null; }
                    return prot;
                }
            return null;
        }

        //PRODUTOTipoTamanhoPreco###############################################################


        public bool CadastraProdutoTipoTamanhoPreco(ProdutoTipoTamanhoPreco pro)
        {
            if (pro.Preco1.Length > 0 )
                if (!string.IsNullOrEmpty(pro.CodTipo))
                    if (!string.IsNullOrEmpty(pro.CodTamanho))
                    {

                        CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();

                        DataTable Result = new DataTable();

                        Result = DAO.CadastraProdutoTipoTamanhoPreco(pro, Autenticacao.GetCodUsuario());
                        if (Result != null)
                            if (Result.Rows.Count > 0)
                                if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                                    return true;
                                else return false;

                    }
            return false;
        }

        public bool ApagaProdutoTipoTamanhoPreco(string cod)
        {

            CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();
            if (!string.IsNullOrEmpty(cod))
            {

                DataTable Result = new DataTable();

                Result = DAO.ApagaProdutoTipoTamanhoPreco(cod);
                if (Result != null)
                    if (Result.Rows.Count > 0)
                        if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                            return true;
            }
            return false;
        }



        public ProdutoTipoTamanhoPreco BuscaProxProdutoTipoTamanhoPreco(ProdutoTipoTamanhoPreco pro)
        {

            CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaProxProdutoTipoTamanhoPreco(pro);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        pro = DataToProdutoTipoTamanhoPreco(Result, pro);
                        return pro;
                    }
                    else return null;
                }
                else
                {
                    pro.Id = null;
                    Result = DAO.BuscaProxProdutoTipoTamanhoPreco(pro);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                pro = DataToProdutoTipoTamanhoPreco(Result, pro);
                                return pro;
                            }
                        }
                }
            return null;
        }


        public ProdutoTipoTamanhoPreco BuscaAntProdutoTipoTamanhoPreco(ProdutoTipoTamanhoPreco pro)
        {

            CadProdutoT_T_S_DAO DAO = new CadProdutoT_T_S_DAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaAntProdutoTipoTamanhoPreco(pro);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        pro = DataToProdutoTipoTamanhoPreco(Result, pro);
                        return pro;
                    }
                    else return null;
                }
                else
                {
                    pro.Id = null;
                    Result = DAO.BuscaAntProdutoTipoTamanhoPreco(pro);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                pro = DataToProdutoTipoTamanhoPreco(Result, pro);
                                return pro;
                            }
                        }
                }
            return null;
        }

        private ProdutoTipoTamanhoPreco DataToProdutoTipoTamanhoPreco(DataTable data, ProdutoTipoTamanhoPreco pro)
        {
            pro.Id = data.Rows[0].ItemArray[0].ToString();
            pro.CodTipo = data.Rows[0].ItemArray[1].ToString();
            pro.CodTamanho = data.Rows[0].ItemArray[2].ToString();
            pro.Preco1 = data.Rows[0].ItemArray[3].ToString();
            pro.Preco2 = data.Rows[0].ItemArray[4].ToString();
            pro.Preco3 = data.Rows[0].ItemArray[5].ToString();
            pro.Custo = data.Rows[0].ItemArray[6].ToString();
            
            return pro;
        }

    }
}
