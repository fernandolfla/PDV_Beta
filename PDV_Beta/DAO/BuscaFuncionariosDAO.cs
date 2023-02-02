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
    class BuscaFuncionariosDAO : Connection
    {

        public DataTable BuscaPorCodigo(string codigo)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Busca_Funcionario_POR_CODIGO", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;


                Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = codigo;
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


        public DataTable BuscaPorNome(string nome)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Busca_Funcionario_POR_NOME", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = nome;
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
