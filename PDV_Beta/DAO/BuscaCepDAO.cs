using PDV_Beta.Entity;
using PDV_Beta.Component;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.DAO
{
    class BuscaCepDAO : Connection
    {

        public DataTable BuscaCep(string cep)
        {
            try
            {
                CriarConexaoCep();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaCep", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@CEP", SqlDbType.VarChar).Value = cep;
                DataTable data = new DataTable();
                Cmd.Fill(data);

                Fechar();
                return data;

            }
            catch (Exception e)
            {
                Erros.SetErroBanco(e);
                Erros.SetHaErro(true);
            }
            finally
            {
                Fechar();
            }
            return null;
        }

    }
}
