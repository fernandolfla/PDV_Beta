using PDV_Beta.Component;
using PDV_Beta.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.DAO
{
    class ConfTelasVendasDAO : Connection
    {

        public DataTable Atualiza(Saidas_zConf conf, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_CONF_Atualiza_Configuracao_Telas_Vendas", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
              
                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = conf.Id;
                Cmd.SelectCommand.Parameters.Add("@CFOP", SqlDbType.VarChar).Value = conf.CFOP;
                Cmd.SelectCommand.Parameters.Add("@CLIENTE_PADRAO", SqlDbType.VarChar).Value = conf.ClientePadrao;
                Cmd.SelectCommand.Parameters.Add("@CLIENTEPADRAOATIVO", SqlDbType.VarChar).Value = conf.ClientePadraoAtivo;
                Cmd.SelectCommand.Parameters.Add("@CLIENTEPADRAONOME", SqlDbType.VarChar).Value = conf.ClientePadraoNome;
                Cmd.SelectCommand.Parameters.Add("@TABELAPADRAO", SqlDbType.VarChar).Value = conf.TabelaPadrao;

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


        public DataTable Busca(int Id)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_CONF_BuscaConfiguracao_Telas_Vendas", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = Id;
                
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
