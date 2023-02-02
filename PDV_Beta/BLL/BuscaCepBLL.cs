using PDV_Beta.DAO;
using PDV_Beta.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.BLL
{
    class BuscaCepBLL
    {

        public Endereco BuscaCep(string cep)
        {

            if (!string.IsNullOrEmpty(cep))
                if (cep.Length == 8)
                {
                    DataTable Result = new DataTable();
                    BuscaCepDAO DAO = new BuscaCepDAO();
                    Result = DAO.BuscaCep(cep);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            Endereco end = new Endereco();
                            end.Cep = Result.Rows[0].ItemArray[0].ToString();
                            end.Rua = Result.Rows[0].ItemArray[1].ToString();
                            end.Bairro = Result.Rows[0].ItemArray[2].ToString();
                            end.Cidade = Result.Rows[0].ItemArray[3].ToString();
                            end.Estado = Result.Rows[0].ItemArray[4].ToString();
                            end.Sigla = Result.Rows[0].ItemArray[5].ToString();

                            return end;
                        }
                }
            return null;
        }

    }
}
