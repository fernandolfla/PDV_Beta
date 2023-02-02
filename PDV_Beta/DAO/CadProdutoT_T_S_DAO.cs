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
    class CadProdutoT_T_S_DAO : Connection
    {

        //PRODUTOTIPO ########################################################################
        public DataTable CadastraProdutoTipo(ProdutoTipo pro, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_CadastraProduto_Tipo", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = pro.Nome;
                Cmd.SelectCommand.Parameters.Add("@CODPRODUTO", SqlDbType.VarChar).Value = pro.CodProduto;
                Cmd.SelectCommand.Parameters.Add("@PIZZA", SqlDbType.VarChar).Value = pro.EPizza;
                
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


        public DataTable BuscaProxProdutoTipo(ProdutoTipo pro)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaProxProduto_Tipo", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(pro.Id))
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = 0;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = pro.Id;
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

        public DataTable BuscaAntProdutoTipo(ProdutoTipo pro)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaAntProduto_Tipo", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(pro.Id))
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = 99999;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = pro.Id;
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


        
        public DataTable ApagaProdutoTipo(string cod)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ApagaProduto_Tipo", con);

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


        //PRODUTOTIPO #####################################################################


        //PRODUTOTAMANHO ##################################################################

        public DataTable CadastraProdutoTamanho(ProdutoTamanho pro, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_CadastraProduto_Tamanho", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = pro.Nome;
                Cmd.SelectCommand.Parameters.Add("@QTD_SABORES", SqlDbType.VarChar).Value =pro.QtdSabores;
                Cmd.SelectCommand.Parameters.Add("@QTD_PEDACOS", SqlDbType.VarChar).Value = pro.QtdPedacos;

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


        public DataTable BuscaProxProdutoTamanho(ProdutoTamanho pro)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaProxProduto_Tamanho", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(pro.Id))
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = 0;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = pro.Id;
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

        public DataTable BuscaAntProdutoTamanho(ProdutoTamanho pro)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaAntProduto_Tamanho", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(pro.Id))
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = 99999;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = pro.Id;
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



        public DataTable ApagaProdutoTamanho(string cod)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ApagaProduto_Tamanho", con);

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


        //PRODUTOTAMANHO ##################################################################


        //PRODUTOSABOR ####################################################################


        public DataTable CadastraProdutoSabor(ProdutoSabor pro, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_CadastraProduto_Sabor", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = pro.Nome;
                Cmd.SelectCommand.Parameters.Add("@PRODUTO_TIPO", SqlDbType.VarChar).Value = pro.Produto_Tipo;

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


        public DataTable BuscaProxProdutoSabor(ProdutoSabor pro)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaProxProduto_Sabor", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(pro.Id))
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = 0;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = pro.Id;
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

        public DataTable BuscaAntProdutoSabor(ProdutoSabor pro)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaAntProduto_Sabor", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(pro.Id))
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = 99999;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = pro.Id;
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



        public DataTable ApagaProdutoSabor(string cod)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ApagaProduto_Sabor", con);

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

        //PRODUTOSABOR ####################################################################

        //#################################GERAL###########################################

        public DataTable ListaProduto_Tipo()
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ListaProduto_Tipo", con);

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


        public DataTable ListaProduto_Tamanho()
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ListaProduto_Tamanho", con);

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

        //###################################GERAL#########################################

        //###################################TIPOSABORPRECO#########################################

        public DataTable CadastraProdutoTipoTamanhoPreco(ProdutoTipoTamanhoPreco pro, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                if (string.IsNullOrEmpty(pro.Id))
                {
                    Cmd = new SqlDataAdapter("SP_CadastraProduto_Tipo_Tamanho_Preco", con);
                    pro.Id = "0";
                }
                else
                    Cmd = new SqlDataAdapter("SP_AtualizaProduto_Tipo_Tamanho_Preco", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@CODTIPO", SqlDbType.VarChar).Value = pro.CodTipo;
                Cmd.SelectCommand.Parameters.Add("@CODTAMANHO", SqlDbType.VarChar).Value = pro.CodTamanho;
                Cmd.SelectCommand.Parameters.Add("@PRECO1", SqlDbType.VarChar).Value = pro.Preco1;
                Cmd.SelectCommand.Parameters.Add("@PRECO2", SqlDbType.VarChar).Value = pro.Preco2;
                Cmd.SelectCommand.Parameters.Add("@PRECO3", SqlDbType.VarChar).Value = pro.Preco3;
                Cmd.SelectCommand.Parameters.Add("@CUSTO", SqlDbType.VarChar).Value = pro.Custo;
                Cmd.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = pro.Id;

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


        public DataTable BuscaProxProdutoTipoTamanhoPreco(ProdutoTipoTamanhoPreco pro)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaProxProduto_Tipo_Tamanho_Preco", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(pro.Id))
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = 0;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = pro.Id;
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

        public DataTable BuscaAntProdutoTipoTamanhoPreco(ProdutoTipoTamanhoPreco pro)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaAntProduto_Tipo_Tamanho_Preco", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(pro.Id))
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = 99999;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = pro.Id;
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



        public DataTable ApagaProdutoTipoTamanhoPreco(string cod)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ApagaProduto_Tipo_Tamanho_Preco", con);

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
