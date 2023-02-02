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
    class CadOperacoesBLL
    {
        public bool Cadastra(Operacoes op)
        {
            if (op.Nome.Length > 0 && op.Nome.Length <= 200)
                if(op.CFOP.Length > 3 && op.CFOP.Length <=5)
                if (string.IsNullOrEmpty(op.Codigo))
                {
                     op.CFOP =   op.CFOP.Replace(",", ".");
                    CadOperacoesDAO DAO = new CadOperacoesDAO();
                    DataTable Result = new DataTable();

                    Result = DAO.Cadastra(op, Autenticacao.GetCodUsuario());
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                            if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                                return true;
                            else return false;
                }
            return false;
        }


        public bool Apaga(string cod)
        {

            CadOperacoesDAO DAO = new CadOperacoesDAO();
            if (!string.IsNullOrEmpty(cod))
            {

                DataTable Result = new DataTable();

                Result = DAO.Apaga(cod);
                if (Result != null)
                    if (Result.Rows.Count > 0)
                        if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                            return true;
            }
            return false;
        }



        public Operacoes BuscaProx(Operacoes op)
        {

            CadOperacoesDAO DAO = new CadOperacoesDAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaProx(op);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        op = DataToFilial(Result, op);
                        return op;
                    }
                    else return null;
                }
                else
                {
                    op.Codigo = null;
                    Result = DAO.BuscaProx(op);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                op = DataToFilial(Result, op);
                                return op;
                            }
                        }
                }
            return null;
        }


        public Operacoes BuscaAnt(Operacoes op)
        {
            CadOperacoesDAO DAO = new CadOperacoesDAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaAnt(op);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        op = DataToFilial(Result, op);
                        return op;
                    }
                    else return null;
                }
                else
                {
                    op.Codigo = null;
                    Result = DAO.BuscaAnt(op);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                op = DataToFilial(Result, op);
                                return op;
                            }
                        }
                }
            return null;
        }


        private Operacoes DataToFilial(DataTable data, Operacoes op)
        {
            op.Codigo = data.Rows[0].ItemArray[0].ToString();
            try { op.Ativo = (int)data.Rows[0].ItemArray[1]; }
            catch (Exception) { }
            try { op.Tipo = (int)data.Rows[0].ItemArray[2]; }
            catch (Exception) { }
            op.CFOP = data.Rows[0].ItemArray[3].ToString();
            op.Nome = data.Rows[0].ItemArray[4].ToString();
            op.Descricao = data.Rows[0].ItemArray[5].ToString();

            return op;
        }

    }
}
