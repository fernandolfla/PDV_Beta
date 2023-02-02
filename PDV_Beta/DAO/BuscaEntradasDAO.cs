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
    class BuscaEntradasDAO : Connection
    {
        public DataTable BuscaEntrada(DateTime inicio, DateTime fim, int Filial)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Mov_BuscaEntradasPorData", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@INICIO", SqlDbType.VarChar).Value = inicio;
                Cmd.SelectCommand.Parameters.Add("@FIM", SqlDbType.VarChar).Value = fim;
                Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = Filial;
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

        public DataTable BuscaEntradaNF(string NF, int Filial)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Mov_BuscaEntradasPorNF", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@NF", SqlDbType.VarChar).Value = NF;
                Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = Filial;
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

        public DataTable BuscaEntrada_Produtos(int entrada)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Mov_BuscaEntradaLinhasPorEntradaId", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@ID_ENTRADA", SqlDbType.VarChar).Value = entrada;
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
