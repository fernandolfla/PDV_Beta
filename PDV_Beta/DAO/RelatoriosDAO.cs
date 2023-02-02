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
    class RelatoriosDAO: Connection
    {

        public DataTable Rel_Vendas(int filial, DateTime inicio,DateTime fim)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;


                Cmd = new SqlDataAdapter("SP_Rel_Relatorio_Vendas", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = filial;
                Cmd.SelectCommand.Parameters.Add("@DATA_INICIO", SqlDbType.VarChar).Value = inicio;
                Cmd.SelectCommand.Parameters.Add("@DATA_FIM", SqlDbType.VarChar).Value = fim;

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
        

        public DataTable Rel_Caixa_Ativo(string caixa, DateTime inicio)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;


                Cmd = new SqlDataAdapter("SP_Rel_Relatorio_Caixa_Ativo", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@CAIXA", SqlDbType.VarChar).Value = caixa;
                Cmd.SelectCommand.Parameters.Add("@DATA_INICIO", SqlDbType.VarChar).Value = inicio;

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

        

        public DataTable Rel_Entregas(int filial, DateTime inicio, DateTime fim, string transportadora)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;


                Cmd = new SqlDataAdapter("SP_Rel_Relatorio_Entregas", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = filial;
                Cmd.SelectCommand.Parameters.Add("@DATA_INICIO", SqlDbType.VarChar).Value = inicio;
                Cmd.SelectCommand.Parameters.Add("@DATA_FIM", SqlDbType.VarChar).Value = fim;
                Cmd.SelectCommand.Parameters.Add("@TRANSPORTADORA", SqlDbType.VarChar).Value = transportadora;

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
