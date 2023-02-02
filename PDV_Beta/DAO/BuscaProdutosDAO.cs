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
    class BuscaProdutosDAO : Connection
    {
        public DataTable BuscaPorCodigo(string codigo, int filial)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaProduto_POR_CODIGO", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = codigo;
                Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = filial;
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


        public DataTable BuscaPorNome(string nome, int filial)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaProduto_POR_NOME", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = nome;
                Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = filial;
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
