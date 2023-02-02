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
    class MovSaidasDAO : Connection
    {

        public DataTable SalvaSaida(Saida saida, int filial, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_Mov_Cadastra_NOVA_Saidas", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@NUMNOTA", SqlDbType.VarChar).Value = saida.NumNota;
                Cmd.SelectCommand.Parameters.Add("@COMANDA", SqlDbType.VarChar).Value = saida.Comanda;
                Cmd.SelectCommand.Parameters.Add("@MESA", SqlDbType.VarChar).Value = saida.Mesa;
                Cmd.SelectCommand.Parameters.Add("@PAINEL", SqlDbType.VarChar).Value = saida.Painel;
                Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = filial;
                Cmd.SelectCommand.Parameters.Add("@CFOP", SqlDbType.VarChar).Value = saida.CFOP;
                Cmd.SelectCommand.Parameters.Add("@CAIXA", SqlDbType.VarChar).Value = saida.Caixa;
                Cmd.SelectCommand.Parameters.Add("@CLIENTE", SqlDbType.VarChar).Value = saida.Cliente;
                Cmd.SelectCommand.Parameters.Add("@CPF", SqlDbType.VarChar).Value = saida.CPF;
                Cmd.SelectCommand.Parameters.Add("@VENDEDOR", SqlDbType.VarChar).Value = saida.Vendedor;
                Cmd.SelectCommand.Parameters.Add("@OBSERVACOES", SqlDbType.VarChar).Value = saida.Observacoes;
                Cmd.SelectCommand.Parameters.Add("@PARAENTREGA", SqlDbType.VarChar).Value = saida.ParaEntrega;               
                Cmd.SelectCommand.Parameters.Add("@ENDERECOENTREGA", SqlDbType.VarChar).Value = saida.Endereco_Entrega;
                Cmd.SelectCommand.Parameters.Add("@COMPLEMENTO", SqlDbType.VarChar).Value = saida.Complemento_Entrega;
                Cmd.SelectCommand.Parameters.Add("@CIDADE", SqlDbType.VarChar).Value = saida.Cidade_Entrega;
                Cmd.SelectCommand.Parameters.Add("@ESTADO", SqlDbType.VarChar).Value = saida.Estado_Entrega;
                Cmd.SelectCommand.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = saida.Bairro_Entrega;
                Cmd.SelectCommand.Parameters.Add("@CEP", SqlDbType.VarChar).Value = saida.CEP_Entrega;
                Cmd.SelectCommand.Parameters.Add("@NUMRUA", SqlDbType.VarChar).Value = saida.NumRua_Entrega;
                Cmd.SelectCommand.Parameters.Add("@TRANSPORTADORA", SqlDbType.VarChar).Value = saida.Transportadora;
                Cmd.SelectCommand.Parameters.Add("@PESO", SqlDbType.VarChar).Value = saida.Peso.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@VOLUMES", SqlDbType.VarChar).Value = saida.Volumes;
                Cmd.SelectCommand.Parameters.Add("@PRODUTOS", SqlDbType.VarChar).Value = saida.Produtos.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@DESCONTO", SqlDbType.VarChar).Value = saida.Desconto.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@FRETE", SqlDbType.VarChar).Value = saida.Frete.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@TOTAL", SqlDbType.VarChar).Value = saida.Total.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@TROCO_ENTREGA", SqlDbType.VarChar).Value = saida.Troco_Entrega.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@PAGAMENTO_ENTREGA", SqlDbType.VarChar).Value = saida.Pagamento_Entrega.ToString().Replace(",", ".");
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

        public DataTable AtualizaSaida(Saida saida, int filial, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_Mov_ATULIZA_Saidas", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = saida.Id;
                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@CLIENTE", SqlDbType.VarChar).Value = saida.Cliente;
                Cmd.SelectCommand.Parameters.Add("@CPF", SqlDbType.VarChar).Value = saida.CPF;
                Cmd.SelectCommand.Parameters.Add("@VENDEDOR", SqlDbType.VarChar).Value = saida.Vendedor;
                Cmd.SelectCommand.Parameters.Add("@OBSERVACOES", SqlDbType.VarChar).Value = saida.Observacoes;
                Cmd.SelectCommand.Parameters.Add("@PARAENTREGA", SqlDbType.VarChar).Value = saida.ParaEntrega;
                Cmd.SelectCommand.Parameters.Add("@ENDERECOENTREGA", SqlDbType.VarChar).Value = saida.Endereco_Entrega;
                Cmd.SelectCommand.Parameters.Add("@COMPLEMENTO", SqlDbType.VarChar).Value = saida.Complemento_Entrega;
                Cmd.SelectCommand.Parameters.Add("@CIDADE", SqlDbType.VarChar).Value = saida.Cidade_Entrega;
                Cmd.SelectCommand.Parameters.Add("@ESTADO", SqlDbType.VarChar).Value = saida.Estado_Entrega;
                Cmd.SelectCommand.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = saida.Bairro_Entrega;
                Cmd.SelectCommand.Parameters.Add("@CEP", SqlDbType.VarChar).Value = saida.CEP_Entrega;
                Cmd.SelectCommand.Parameters.Add("@NUMRUA", SqlDbType.VarChar).Value = saida.NumRua_Entrega;
                Cmd.SelectCommand.Parameters.Add("@TRANSPORTADORA", SqlDbType.VarChar).Value = saida.Transportadora;
                Cmd.SelectCommand.Parameters.Add("@PESO", SqlDbType.VarChar).Value = saida.Peso.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@VOLUMES", SqlDbType.VarChar).Value = saida.Volumes;
                Cmd.SelectCommand.Parameters.Add("@PRODUTOS", SqlDbType.VarChar).Value = saida.Produtos.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@DESCONTO", SqlDbType.VarChar).Value = saida.Desconto.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@FRETE", SqlDbType.VarChar).Value = saida.Frete.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@TOTAL", SqlDbType.VarChar).Value = saida.Total.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@EF_ESTOQUE", SqlDbType.VarChar).Value = saida.Efetivada_estoque;
                Cmd.SelectCommand.Parameters.Add("@EF_FIN", SqlDbType.VarChar).Value = saida.Efetivada_Financ;
                Cmd.SelectCommand.Parameters.Add("@NF_IMPR", SqlDbType.VarChar).Value = saida.Nota_Impressa;
                Cmd.SelectCommand.Parameters.Add("@TIK_IMPRESSO", SqlDbType.VarChar).Value = saida.Tiket_Impresso;
                Cmd.SelectCommand.Parameters.Add("@REC_DINHEIRO", SqlDbType.VarChar).Value = saida.Recebe_Dinheiro.ToString().Replace(",", "."); ;
                Cmd.SelectCommand.Parameters.Add("@REC_CREDITO_CLIENTE", SqlDbType.VarChar).Value = saida.Recebe_Credito_Cliente.ToString().Replace(",", "."); ;
                Cmd.SelectCommand.Parameters.Add("@REC_CARTAO_DEBITO", SqlDbType.VarChar).Value = saida.Recebe_Cartao_Debito.ToString().Replace(",", "."); ;
                Cmd.SelectCommand.Parameters.Add("@REC_CARTAO_CREDITO", SqlDbType.VarChar).Value = saida.Recebe_cartao_Credito.ToString().Replace(",", "."); ;
                Cmd.SelectCommand.Parameters.Add("@REC_CARTAO_CONVENIO", SqlDbType.VarChar).Value = saida.Recebe_Cartao_Convenio.ToString().Replace(",", "."); ;
                Cmd.SelectCommand.Parameters.Add("@REC_TOTAL", SqlDbType.VarChar).Value = saida.Recebe_Total.ToString().Replace(",", "."); ;
                Cmd.SelectCommand.Parameters.Add("@MOTIVO_CANCELAMENTO", SqlDbType.VarChar).Value = saida.Motivo_cancelamento;
                Cmd.SelectCommand.Parameters.Add("@USUARIO_CANCELAMENTO", SqlDbType.VarChar).Value = saida.Usuario_Cancelamento;
                Cmd.SelectCommand.Parameters.Add("@TROCO_ENTREGA", SqlDbType.VarChar).Value = saida.Troco_Entrega.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@PAGAMENTO_ENTREGA", SqlDbType.VarChar).Value = saida.Pagamento_Entrega.ToString().Replace(",", ".");

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

        public DataTable SalvaProduto(Saida_Produtos pro, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_Mov_Cadastra_Saidas_PRODUTOS", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@ID_SAIDA", SqlDbType.VarChar).Value = pro.ID_Saida;
                Cmd.SelectCommand.Parameters.Add("@LINHA", SqlDbType.VarChar).Value = pro.Linha;
                Cmd.SelectCommand.Parameters.Add("@COD_PRODUTO", SqlDbType.VarChar).Value = pro.CodProduto;
                Cmd.SelectCommand.Parameters.Add("@NOME_PRODUTO", SqlDbType.VarChar).Value = pro.NomeProduto;
                Cmd.SelectCommand.Parameters.Add("@TABELA_PRECO", SqlDbType.VarChar).Value = pro.Tabela_Preco;
                Cmd.SelectCommand.Parameters.Add("@QTDE", SqlDbType.VarChar).Value = pro.Qtde.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@PRECO_UNIT", SqlDbType.VarChar).Value = pro.Preco_Unit.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@PRECO_TOTAL", SqlDbType.VarChar).Value = pro.Preco_Total.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@DESCONTO", SqlDbType.VarChar).Value = pro.Desconto.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@PRECO_FINAL", SqlDbType.VarChar).Value = pro.Preco_Final.ToString().Replace(",", ".");

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

        public DataTable FechaTodasVendas()
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Mov_FechaTodasVendas", con);

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


        public DataTable BuscaProdutoPorCodigo(string codigo)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaProduto_UNICO_POR_CODIGO", con);
                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = codigo;

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

        public DataTable BuscaSaidas(int filial, string numnota, string sequencia, string comanda, string mesa, string painel)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Mov_Busca_SAIDAS", con);
                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = filial;
                Cmd.SelectCommand.Parameters.Add("@NUMNOTA", SqlDbType.VarChar).Value = numnota;
                Cmd.SelectCommand.Parameters.Add("@SEQUENCIA", SqlDbType.VarChar).Value = sequencia;
                Cmd.SelectCommand.Parameters.Add("@COMANDA", SqlDbType.VarChar).Value = comanda;
                Cmd.SelectCommand.Parameters.Add("@MESA", SqlDbType.VarChar).Value = mesa;
                Cmd.SelectCommand.Parameters.Add("@PAINEL", SqlDbType.VarChar).Value = painel;

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

        public DataTable BuscaSaidasPorData(int filial, DateTime inicio, DateTime fim)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Mov_Busca_SAIDAS_POR_DATA", con);
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

        public DataTable ApagaLinhas(string id)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Mov_ApagaLinhasProdutos", con);
                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;

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


        public DataTable BuscaSaida_Produtos(string id)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Mov_Busca_SAIDAS_PRODUTOS", con);
                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@ID_SAIDA", SqlDbType.VarChar).Value = id;

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

        public DataTable AtualizaFinanceiro(int usuario, int filial,string id_NF,int id_Situacao, decimal total_nf ,decimal dinheiro, decimal convenio, decimal credito, decimal debito)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Mov_ATULIZA_Saidas_FINANCEIRO", con);
                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = filial;
                Cmd.SelectCommand.Parameters.Add("@ID_NF", SqlDbType.VarChar).Value = id_NF;
                Cmd.SelectCommand.Parameters.Add("@ID_SITUACAO", SqlDbType.VarChar).Value = id_Situacao;
                Cmd.SelectCommand.Parameters.Add("@TOTAL_NF", SqlDbType.VarChar).Value = total_nf.ToString().Replace(",",".");
                Cmd.SelectCommand.Parameters.Add("@DINHEIRO", SqlDbType.VarChar).Value = dinheiro.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@CONVENIO", SqlDbType.VarChar).Value = convenio.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@CREDITO", SqlDbType.VarChar).Value = credito.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@DEBITO", SqlDbType.VarChar).Value = debito.ToString().Replace(",", ".");

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

        public DataTable AtualizaEstoque(int usuario, int filial, string id_NF, string cod_produto, string operacao, decimal qtde)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Mov_ATULIZA_Saidas_ESTOQUE", con);
                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = filial;
                Cmd.SelectCommand.Parameters.Add("@ID_NF", SqlDbType.VarChar).Value = id_NF;
                Cmd.SelectCommand.Parameters.Add("@COD_PRODUTO", SqlDbType.VarChar).Value = cod_produto;
                Cmd.SelectCommand.Parameters.Add("@OPERACAO", SqlDbType.VarChar).Value = operacao;
                Cmd.SelectCommand.Parameters.Add("@QTDE", SqlDbType.VarChar).Value = qtde.ToString().Replace(",", "."); ;

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


        public DataTable CancelaNota(int usuario, int filial, string id_NF, int id_Situacao, decimal total_nf, string motivo,decimal dinheiro,decimal convenio,decimal credito,decimal debito)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Mov_CANCELA_Saida", con);
                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = filial;
                Cmd.SelectCommand.Parameters.Add("@ID_NF", SqlDbType.VarChar).Value = id_NF;
                Cmd.SelectCommand.Parameters.Add("@ID_SITUACAO", SqlDbType.VarChar).Value = id_Situacao;
                Cmd.SelectCommand.Parameters.Add("@TOTAL_NF", SqlDbType.VarChar).Value = total_nf.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@MOTIVO", SqlDbType.VarChar).Value = motivo;
                Cmd.SelectCommand.Parameters.Add("@DINHEIRO", SqlDbType.VarChar).Value = dinheiro.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@CONVENIO", SqlDbType.VarChar).Value = convenio.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@CREDITO", SqlDbType.VarChar).Value = credito.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@DEBITO", SqlDbType.VarChar).Value = debito.ToString().Replace(",", ".");

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

        public DataTable ListaSabores(string id)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Mov_ListaProduto_Sabores", con);
                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;

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

        public DataTable ListaProdutoTipoTamanhoPreco(string tipo, string tamanho)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Mov_Busca_Produto_Tipo_Tamanho_Preco", con);
                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@COD_TIPO", SqlDbType.VarChar).Value = tipo;
                Cmd.SelectCommand.Parameters.Add("@COD_TAMANHO", SqlDbType.VarChar).Value = tamanho;

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
