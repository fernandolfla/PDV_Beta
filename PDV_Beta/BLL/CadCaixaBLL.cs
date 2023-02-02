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
    class CadCaixaBLL
    {
        public bool CadastraCaixa(Caixa cx)
        {
            if (cx.Nome.Length > 0 && cx.Nome.Length <= 20)
                 if (string.IsNullOrEmpty(cx.Id))
                {

                    CadCaixaDAO DAO = new CadCaixaDAO();

                    DataTable Result = new DataTable();
                    cx.Filial = Autenticacao.GetCodFilial();

                    Result = DAO.CadastraCaixa(cx, Autenticacao.GetCodUsuario());
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                            if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                                return true;
                            else return false;
                }
        return false;
        }

        public bool ApagaCaixa(string cod)
        {

            CadCaixaDAO DAO = new CadCaixaDAO();
            if (!string.IsNullOrEmpty(cod))
            {

                DataTable Result = new DataTable();

                Result = DAO.ApagaCaixa(cod,Autenticacao.GetCodFilial());
                if (Result != null)
                    if (Result.Rows.Count > 0)
                        if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                            return true;
            }
            return false;
        }



        public Caixa BuscaProxCaixa(Caixa cx)
        {
            cx.Filial = Autenticacao.GetCodFilial();
            CadCaixaDAO DAO = new CadCaixaDAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaProxCaixa(cx);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        cx = DataToCaixa(Result, cx);
                        return cx;
                    }
                    else return null;
                }
                else
                {
                    cx.Id = null;
                    Result = DAO.BuscaProxCaixa(cx);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                cx = DataToCaixa(Result, cx);
                                return cx;
                            }
                        }
                }
            return null;
        }


        public Caixa BuscaAntCaixa(Caixa cx)
        {
            cx.Filial = Autenticacao.GetCodFilial();
            CadCaixaDAO DAO = new CadCaixaDAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaAntCaixa(cx);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        cx = DataToCaixa(Result, cx);
                        return cx;
                    }
                    else return null;
                }
                else
                {
                    cx.Id = null;
                    Result = DAO.BuscaAntCaixa(cx);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                cx = DataToCaixa(Result, cx);
                                return cx;
                            }
                        }
                }
            return null;
        }


        public string BuscaProxCodLivre()
        {
            CadCaixaDAO DAO = new CadCaixaDAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaProximoCodigoLivre();

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    return Result.Rows[0].ItemArray[0].ToString();
                }
            return null;
        }

        private Caixa DataToCaixa(DataTable data, Caixa cx)
        {
            cx.Id = data.Rows[0].ItemArray[0].ToString();
            try { cx.Ativo = (int)data.Rows[0].ItemArray[1]; }
            catch (Exception) { }
            try { cx.Filial = (int)data.Rows[0].ItemArray[2]; }
            catch (Exception) { }
            cx.Nome = data.Rows[0].ItemArray[3].ToString();
            cx.Descicao = data.Rows[0].ItemArray[4].ToString();

            return cx;
        }


    }
}
