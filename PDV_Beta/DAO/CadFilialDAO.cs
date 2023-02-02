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
    class CadFilialDAO : Connection
    {

        public DataTable Cadastra(Filial fi, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_CadastraFilial", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@ATIVO", SqlDbType.VarChar).Value = fi.Ativo;
                Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = fi.Nome;
                Cmd.SelectCommand.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = fi.CNPJ;
                Cmd.SelectCommand.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = fi.Endereco;
                Cmd.SelectCommand.Parameters.Add("@COMPLEMENTO", SqlDbType.VarChar).Value = fi.Complemento;
                Cmd.SelectCommand.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = fi.Bairro;
                Cmd.SelectCommand.Parameters.Add("@CIDADE", SqlDbType.VarChar).Value = fi.Cidade;
                Cmd.SelectCommand.Parameters.Add("@ESTADO", SqlDbType.VarChar).Value = fi.Estado;
                Cmd.SelectCommand.Parameters.Add("@CEP", SqlDbType.VarChar).Value = fi.Cep;
                Cmd.SelectCommand.Parameters.Add("@NUMRUA", SqlDbType.VarChar).Value = fi.NumRua;
                Cmd.SelectCommand.Parameters.Add("@INSCRICAO", SqlDbType.VarChar).Value = fi.Inscricao;
                Cmd.SelectCommand.Parameters.Add("@INCRICAO_MUNICIPAL", SqlDbType.VarChar).Value = fi.InscricaoMunicipal;
                Cmd.SelectCommand.Parameters.Add("@FONE_1", SqlDbType.VarChar).Value = fi.Fone1;
                Cmd.SelectCommand.Parameters.Add("@FONE_2", SqlDbType.VarChar).Value = fi.Fone2;
                Cmd.SelectCommand.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = fi.Email;
                Cmd.SelectCommand.Parameters.Add("@RUA_PROXIMA_1", SqlDbType.VarChar).Value = fi.Rua_Proxima1;
                Cmd.SelectCommand.Parameters.Add("@RUA_PROXIMA_2", SqlDbType.VarChar).Value = fi.Rua_Proxima2;
                Cmd.SelectCommand.Parameters.Add("@OBSERVACOES", SqlDbType.VarChar).Value = fi.Observacoes;

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


        public DataTable BuscaProx(Filial fi)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaProxFilial", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(fi.Codigo))
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = 0;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = fi.Codigo;
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

        public DataTable BuscaAnt(Filial fi)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaAntFilial", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(fi.Codigo))
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = 99999;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = fi.Codigo;
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



        public DataTable Apaga(string cod)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ApagaFilial", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = cod;
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
