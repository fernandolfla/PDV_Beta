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
    class ConfTelaInicialBLL
    {
        public bool Atualiza(string titulo, string imagem)
        {
            if (!string.IsNullOrEmpty(titulo))
                if (!string.IsNullOrEmpty(imagem))
                {
                    ConfTelaInicialDAO DAO = new ConfTelaInicialDAO();
                    DataTable Result = new DataTable();
                    Result = DAO.Atualiza(titulo, imagem, Autenticacao.GetCodUsuario());
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                            if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                                return true;
                }
            return false;
        }

        public XConfiguracoes Busca()
        {
            ConfTelaInicialDAO DAO = new ConfTelaInicialDAO();
            DataTable Result = new DataTable();
            Result = DAO.Busca(); 
            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    XConfiguracoes conf = new XConfiguracoes();

                    conf.Titulo = Result.Rows[0].ItemArray[0].ToString();
                    conf.Imagem = Result.Rows[0].ItemArray[1].ToString();

                    return conf;
                }
            return null;
        }



    }
}
