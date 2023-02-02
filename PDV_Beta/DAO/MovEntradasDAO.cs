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
    class MovEntradasDAO : Connection
    {

        public DataTable Cadastra(Entradas ent, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_Mov_CadastraEntradas", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@NUMNOTA", SqlDbType.VarChar).Value = ent.NumNota;
                Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = ent.Filial;
                Cmd.SelectCommand.Parameters.Add("@DATA", SqlDbType.VarChar).Value = ent.Data;
                Cmd.SelectCommand.Parameters.Add("@COD_OPERACAO", SqlDbType.VarChar).Value = ent.Cod_Operacao;
                Cmd.SelectCommand.Parameters.Add("@FORNECEDOR", SqlDbType.VarChar).Value = ent.Fornecedor;
                Cmd.SelectCommand.Parameters.Add("@OBSERVACOES", SqlDbType.VarChar).Value = ent.Observacoes;
                Cmd.SelectCommand.Parameters.Add("@PRODUTOS", SqlDbType.VarChar).Value = ent.Produtos.ToString().Replace(",",".");
                Cmd.SelectCommand.Parameters.Add("@DESCONTO", SqlDbType.VarChar).Value = ent.Descontos.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@FRETE", SqlDbType.VarChar).Value = ent.Frete.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@TOTAL", SqlDbType.VarChar).Value = ent.Total.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@TRANSPORTADORA", SqlDbType.VarChar).Value = ent.Transportadora;
                Cmd.SelectCommand.Parameters.Add("@PESO_BRUTO", SqlDbType.VarChar).Value = ent.Peso_bruto.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@VOLUMES", SqlDbType.VarChar).Value = ent.Volumes;

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

        public DataTable CadastraProdutos(Entradas ent,Entradas_Produtos pro, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_Mov_CadastraEntradas_Produtos", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@ID_ENTRADA", SqlDbType.VarChar).Value = ent.Id;
                Cmd.SelectCommand.Parameters.Add("@LINHA", SqlDbType.VarChar).Value = pro.Linha;
                Cmd.SelectCommand.Parameters.Add("@COD_PRODUTO", SqlDbType.VarChar).Value = pro.Cod_Produto;
                Cmd.SelectCommand.Parameters.Add("@NOME_PRODUTO", SqlDbType.VarChar).Value = pro.Nome_Produto;
                Cmd.SelectCommand.Parameters.Add("@QTDE", SqlDbType.VarChar).Value = pro.Qtde.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@PRECO_UNIT", SqlDbType.VarChar).Value = pro.PrecoUnit.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@PRECO_TOTAL", SqlDbType.VarChar).Value = pro.Preco_Total.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@DESCONTO_TOTAL", SqlDbType.VarChar).Value = pro.Desconto_Total.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@PRECO_FINAL", SqlDbType.VarChar).Value = pro.Preco_Final.ToString().Replace(",", ".");
                Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = ent.Filial;
                Cmd.SelectCommand.Parameters.Add("@OPERACAO", SqlDbType.VarChar).Value = ent.Cod_Operacao;
                Cmd.SelectCommand.Parameters.Add("@NUMNF", SqlDbType.VarChar).Value = ent.NumNota;

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


        public DataTable CancelaNota( int usuario, int id, string motivo)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Mov_CancelaEntrada", con);
                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
                Cmd.SelectCommand.Parameters.Add("@MOTIVO", SqlDbType.VarChar).Value = motivo;

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
