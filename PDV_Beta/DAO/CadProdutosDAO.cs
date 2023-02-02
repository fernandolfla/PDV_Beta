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
    class CadProdutosDAO : Connection
    {
        public DataTable CadastraProduto(Produto pro, bool edita, int usuario, int filial)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                if (edita)
                    Cmd = new SqlDataAdapter("SP_AtualizaProduto", con);
                else
                    Cmd = new SqlDataAdapter("SP_CadastraProduto", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@ATIVO", SqlDbType.VarChar).Value = pro.Ativo;
                Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = pro.Codigo;
                Cmd.SelectCommand.Parameters.Add("@FRACIONADO", SqlDbType.VarChar).Value = pro.Fracionado;
                Cmd.SelectCommand.Parameters.Add("@TIPO", SqlDbType.VarChar).Value = pro.Tipo;
                Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = pro.Nome;
                Cmd.SelectCommand.Parameters.Add("@ESTOQUE", SqlDbType.VarChar).Value = pro.Estoque;
                Cmd.SelectCommand.Parameters.Add("@UNIDADE_VENDA", SqlDbType.VarChar).Value = pro.Unidade_Venda;
                Cmd.SelectCommand.Parameters.Add("@CODIGO_FORNECEDOR", SqlDbType.VarChar).Value = pro.Codigo_Fornecedor;
                Cmd.SelectCommand.Parameters.Add("@FABRICANTE", SqlDbType.VarChar).Value = pro.Fabricante;
                Cmd.SelectCommand.Parameters.Add("@FOTO", SqlDbType.VarChar).Value = pro.Foto;
                Cmd.SelectCommand.Parameters.Add("@PESO", SqlDbType.VarChar).Value = pro.Peso;
                Cmd.SelectCommand.Parameters.Add("@OBS", SqlDbType.VarChar).Value = pro.Obs;
                Cmd.SelectCommand.Parameters.Add("@PRECO1", SqlDbType.VarChar).Value = pro.Preco1;
                Cmd.SelectCommand.Parameters.Add("@PRECO2", SqlDbType.VarChar).Value = pro.Preco2;
                Cmd.SelectCommand.Parameters.Add("@PRECO3", SqlDbType.VarChar).Value = pro.Preco3;
                Cmd.SelectCommand.Parameters.Add("@CUSTO", SqlDbType.VarChar).Value = pro.Custo;
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


        public DataTable BuscaProxProduto(Produto pro)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaProxProduto", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(pro.Codigo))
                {
                    Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = "000";
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = pro.Nome;
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


        public DataTable BuscaAntProduto(Produto pro)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaAntProduto", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(pro.Codigo))
                {
                    Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = "ZZZZZZZZZZ";
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = pro.Nome;
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



        public DataTable BuscaProximoCodigoLivre()
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ProxCodLivreProduto", con);

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


        public DataTable ApagaProduto(string cod)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ApagaProduto", con);

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
