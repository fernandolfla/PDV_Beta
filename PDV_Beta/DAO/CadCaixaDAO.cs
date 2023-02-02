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
    class CadCaixaDAO : Connection
    {
        public DataTable CadastraCaixa(Caixa cx , int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_CadastraCaixa", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@ATIVO", SqlDbType.VarChar).Value = cx.Ativo;
                Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = cx.Filial;
                Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = cx.Nome;
                Cmd.SelectCommand.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = cx.Descicao;

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


        public DataTable BuscaProxCaixa(Caixa cx)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaProxCaixa", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(cx.Id))
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = 0;
                    Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = cx.Filial;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = cx.Id;
                    Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = cx.Filial;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
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

        public DataTable BuscaAntCaixa(Caixa cx)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaAntCaixa", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(cx.Id))
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = 99999;
                    Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = cx.Filial;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = cx.Id;
                    Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = cx.Filial;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
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



        public DataTable ApagaCaixa(string cod,int filial)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ApagaCaixa", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = cod;
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

        public DataTable BuscaProximoCodigoLivre()
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ProxCodLivreCaixa", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
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
