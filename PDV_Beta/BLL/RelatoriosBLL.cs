using PDV_Beta.DAO;
using PDV_Beta.Seguranca;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.BLL
{
    class RelatoriosBLL
    {
        public DataTable Rel_Vendas(DateTime inicio, DateTime fim)
        {
            RelatoriosDAO DAO = new RelatoriosDAO();
            DataTable Result = new DataTable();

            TimeSpan inc = new TimeSpan(23, 59, 59);

            if (inicio > fim)
                inicio = fim;
            fim = fim.Add(inc);

            Result = DAO.Rel_Vendas(Autenticacao.GetCodFilial(), inicio, fim);
            if (Result != null)
                if (Result.Rows.Count > 0)
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                        return Result;

            return null;
        }


        public DataTable Rel_Caixa_Ativo(string caixa, DateTime inicio)
        {
            RelatoriosDAO DAO = new RelatoriosDAO();
            DataTable Result = new DataTable();

            Result = DAO.Rel_Caixa_Ativo(caixa,inicio);
            if (Result != null)
                if (Result.Rows.Count > 0)
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                        return Result;

            return null;
        }


        public DataTable Rel_Entregas(DateTime inicio, DateTime fim, string transportadora)
        {
            RelatoriosDAO DAO = new RelatoriosDAO();
            DataTable Result = new DataTable();

            TimeSpan inc = new TimeSpan(23, 59, 59);

            if (inicio > fim)
                inicio = fim;
            fim = fim.Add(inc);

            Result = DAO.Rel_Entregas(Autenticacao.GetCodFilial(), inicio, fim, transportadora);
            if (Result != null)
                if (Result.Rows.Count > 0)
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                        return Result;

            return null;
        }


    }
}
