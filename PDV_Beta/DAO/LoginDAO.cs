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
    class LoginDAO : Connection
    {
        //private object sqlDbType;

        //public object SqlAdapter { get; private set; }

        public DataTable VerificaFilial(string codFilial)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ConsultaFilialLogin", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = codFilial;
                //Cmd.SelectCommand.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = entity.Senha;

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

        public DataTable VerificaUsuario(int codUsuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ConsultaUsuarioLogin", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = codUsuario;


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

        public DataTable VerifiCaixaAberto(int codUsuario , int filial)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Mov_Verifica_Caixa_Aberto_POR_USUARIO", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = codUsuario;
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

        public DataTable EfetuaLogin(int usuario, string senha)
        {

            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd = new SqlDataAdapter("SP_EfetuaLogin", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = senha;


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

