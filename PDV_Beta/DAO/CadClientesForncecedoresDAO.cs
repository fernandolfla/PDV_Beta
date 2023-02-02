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
    class CadClientesForncecedoresDAO : Connection
    {
        public DataTable CadastraFornecedor(ClienteFornecedor cli, bool edita, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                if (edita)
                     Cmd = new SqlDataAdapter("SP_AtualizaCliFor", con);
                else
                     Cmd = new SqlDataAdapter("SP_CadastraCliFor", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = cli.Codigo;
                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@ATIVO", SqlDbType.VarChar).Value =   cli.Ativo;
                Cmd.SelectCommand.Parameters.Add("@TIPO", SqlDbType.VarChar).Value =   cli.Tipo;
                Cmd.SelectCommand.Parameters.Add("@FISICA_JURIDICA", SqlDbType.VarChar).Value =   cli.Fisica_Juridica;
                Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value =   cli.Nome;
                Cmd.SelectCommand.Parameters.Add("@FANTASIA", SqlDbType.VarChar).Value =   cli.Fantasia;
                Cmd.SelectCommand.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value =   cli.Endereco;
                Cmd.SelectCommand.Parameters.Add("@COMPLEMENTO", SqlDbType.VarChar).Value =   cli.Complemento;
                Cmd.SelectCommand.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value =   cli.Bairro;
                Cmd.SelectCommand.Parameters.Add("@CIDADE", SqlDbType.VarChar).Value =   cli.Cidade;
                Cmd.SelectCommand.Parameters.Add("@ESTADO", SqlDbType.VarChar).Value =   cli.Estado;
                Cmd.SelectCommand.Parameters.Add("@CEP", SqlDbType.VarChar).Value =   cli.Cep;
                Cmd.SelectCommand.Parameters.Add("@NUMRUA", SqlDbType.VarChar).Value =   cli.NumRua;
                Cmd.SelectCommand.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value =   cli.CNPJ;
                Cmd.SelectCommand.Parameters.Add("@INSCRICAO", SqlDbType.VarChar).Value =   cli.Inscricao;
                Cmd.SelectCommand.Parameters.Add("@INCRICAO_MUNICIPAL", SqlDbType.VarChar).Value =   cli.InscricaoMunicipal;
                Cmd.SelectCommand.Parameters.Add("@FONE_1", SqlDbType.VarChar).Value =   cli.Fone1;
                Cmd.SelectCommand.Parameters.Add("@FONE_2", SqlDbType.VarChar).Value =   cli.Fone2;
                Cmd.SelectCommand.Parameters.Add("@TEM_CONTA", SqlDbType.VarChar).Value =   cli.TemConta;
                Cmd.SelectCommand.Parameters.Add("@DIA_FECHAMENTO_CONTA", SqlDbType.VarChar).Value =   cli.DiaFechamentoConta;
                Cmd.SelectCommand.Parameters.Add("@COMPRA_PARCELADO", SqlDbType.VarChar).Value =   cli.CompraParcelado;
                Cmd.SelectCommand.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value =   cli.Email;
                Cmd.SelectCommand.Parameters.Add("@EMAIL_FINANCEIRO", SqlDbType.VarChar).Value =  cli.EmailFinanceiro ;
                Cmd.SelectCommand.Parameters.Add("@LIMITE_CREDITO", SqlDbType.VarChar).Value =   cli.LimiteCredito;
                Cmd.SelectCommand.Parameters.Add("@RUA_PROXIMA_1", SqlDbType.VarChar).Value =   cli.Rua_Proxima1;
                Cmd.SelectCommand.Parameters.Add("@RUA_PROXIMA_2", SqlDbType.VarChar).Value =   cli.Rua_Proxima2;
                Cmd.SelectCommand.Parameters.Add("@OPERACAO_PADRAO_SAIDA", SqlDbType.VarChar).Value =   cli.OperacaoPadraoSaida;
                Cmd.SelectCommand.Parameters.Add("@OPERACAO_PADRAO_ENTRADA", SqlDbType.VarChar).Value =   cli.OperacaoPadraoEntrada;
                Cmd.SelectCommand.Parameters.Add("@OBSERVACOES", SqlDbType.VarChar).Value =   cli.Observacoes;
                Cmd.SelectCommand.Parameters.Add("@FRETEPADRAO", SqlDbType.VarChar).Value = cli.FretePadrao;

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


        public DataTable BuscaProxClienteFornecedor(ClienteFornecedor cli)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaProxCli_For", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(cli.Codigo))
                {
                    Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = "000";
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = cli.Nome;
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


        public DataTable BuscaAntClienteFornecedor(ClienteFornecedor cli)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaAntCli_For", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(cli.Codigo))
                {
                    Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = "ZZZZZZZZZZZZ";
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = cli.Nome;
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



        public DataTable ApagaClienteFornecedor(string cod)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ApagaClienteFornecedor", con);

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


        public DataTable BuscaProximoCodigoLivre()
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ProxCodLivreCli_For", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                //Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = cod;
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

        public DataTable ListaOperacoes()
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ListaOperacoes", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                //Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = cod;
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
