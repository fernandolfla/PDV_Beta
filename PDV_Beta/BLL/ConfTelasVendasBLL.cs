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
    class ConfTelasVendasBLL
    {
        public bool Atualiza(Saidas_zConf conf)
        {
            ConfTelasVendasDAO DAO = new ConfTelasVendasDAO();
            DataTable Result = new DataTable();
            Result = DAO.Atualiza(conf,Autenticacao.GetCodUsuario());
            if (Result != null)
                if (Result.Rows.Count > 0)
                    if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                        return true;
            return false;
        }

        public Saidas_zConf Busca(int t)
        {
            ConfTelasVendasDAO DAO = new ConfTelasVendasDAO();
            DataTable Result = new DataTable();
            Result = DAO.Busca(t); //Busca a ID 1
            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    Saidas_zConf conf = new Saidas_zConf();

                    try { conf.Id = (int)Result.Rows[0].ItemArray[0]; } catch { conf.Id = 1; }
                    conf.CFOP = Result.Rows[0].ItemArray[1].ToString();
                    conf.ClientePadrao = Result.Rows[0].ItemArray[2].ToString();
                    try {
                            conf.ClientePadraoAtivo = (int)Result.Rows[0].ItemArray[3]; }
                    catch { conf.ClientePadraoAtivo = 0; }
                    conf.Nome = Result.Rows[0].ItemArray[4].ToString();
                    conf.ClientePadraoNome = Result.Rows[0].ItemArray[5].ToString();
                    try { conf.TabelaPadrao = (int)Result.Rows[0].ItemArray[6]; } catch { conf.TabelaPadrao = 1; }
                    return conf;
                }
            return null;
        }



    }
}
