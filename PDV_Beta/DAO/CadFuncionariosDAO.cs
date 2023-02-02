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
    public class CadFuncionariosDAO : Connection
    {

        public DataTable CadastraFuncionario(Funcionario fun, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd;
                
                if(string.IsNullOrEmpty(fun.Codigo))
                    Cmd = new SqlDataAdapter("SP_CadastraFuncionario", con);
                else
                    Cmd = new SqlDataAdapter("SP_EditaFuncionario", con);


                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USER", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = fun.Codigo ;
                Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = fun.Nome;
                Cmd.SelectCommand.Parameters.Add("@APELIDO", SqlDbType.VarChar).Value = fun.Apelido;
                Cmd.SelectCommand.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = fun.Senha;
                Cmd.SelectCommand.Parameters.Add("@ATIVO", SqlDbType.VarChar).Value = fun.Ativo;
                Cmd.SelectCommand.Parameters.Add("@SEXO", SqlDbType.VarChar).Value = fun.Sexo;
                Cmd.SelectCommand.Parameters.Add("@ADMISSAO", SqlDbType.VarChar).Value = fun.Admissao;
                Cmd.SelectCommand.Parameters.Add("@NASCIMENTO", SqlDbType.VarChar).Value = fun.Nascimento;
                Cmd.SelectCommand.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = fun.Endereco;
                Cmd.SelectCommand.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = fun.Bairro;
                Cmd.SelectCommand.Parameters.Add("@CIDADE", SqlDbType.VarChar).Value = fun.Cidade;
                Cmd.SelectCommand.Parameters.Add("@ESTADO", SqlDbType.VarChar).Value = fun.Estado;
                Cmd.SelectCommand.Parameters.Add("@CEP", SqlDbType.VarChar).Value = fun.Cep;
                Cmd.SelectCommand.Parameters.Add("@TELEFONE", SqlDbType.VarChar).Value = fun.Telefone;
                Cmd.SelectCommand.Parameters.Add("@CARGO", SqlDbType.VarChar).Value = fun.Cargo;
                Cmd.SelectCommand.Parameters.Add("@IDENTIDADE", SqlDbType.VarChar).Value = fun.Identidade;
                Cmd.SelectCommand.Parameters.Add("@CPF", SqlDbType.VarChar).Value = fun.CPF;
                Cmd.SelectCommand.Parameters.Add("@CTPS", SqlDbType.VarChar).Value = fun.Carteira_Trabalho;
                Cmd.SelectCommand.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = fun.Email;
                Cmd.SelectCommand.Parameters.Add("@FILIAL_TODAS", SqlDbType.VarChar).Value = fun.Filial_Todas;
                Cmd.SelectCommand.Parameters.Add("@OBSERVACOES", SqlDbType.VarChar).Value = fun.Observacoes;
                Cmd.SelectCommand.Parameters.Add("@COMISSAO", SqlDbType.VarChar).Value = fun.Comissao_Venda;
                Cmd.SelectCommand.Parameters.Add("@QTDEFILHOS", SqlDbType.VarChar).Value = fun.Qtde_Filhos;
                Cmd.SelectCommand.Parameters.Add("@ESTADOCIVIL", SqlDbType.VarChar).Value = fun.Estado_Civil;
                Cmd.SelectCommand.Parameters.Add("@CELULAR", SqlDbType.VarChar).Value = fun.Celular;
                Cmd.SelectCommand.Parameters.Add("@SUPERUSUARIO", SqlDbType.VarChar).Value = fun.SuperUsuario;
                Cmd.SelectCommand.Parameters.Add("@PERCADASTRO", SqlDbType.VarChar).Value = fun.PerCadastro;
                Cmd.SelectCommand.Parameters.Add("@PERMOVIMENTO", SqlDbType.VarChar).Value = fun.PerMovimento;
                Cmd.SelectCommand.Parameters.Add("@PERFINANCEIRO", SqlDbType.VarChar).Value = fun.PerFinanceiro;
                Cmd.SelectCommand.Parameters.Add("@PERCONFIGURACAO", SqlDbType.VarChar).Value = fun.PerConfiguracao;
                Cmd.SelectCommand.Parameters.Add("@FILIAL", SqlDbType.VarChar).Value = fun.Filial;
                Cmd.SelectCommand.Parameters.Add("@SALARIO", SqlDbType.VarChar).Value = fun.Salario;
                Cmd.SelectCommand.Parameters.Add("@COMISSIONADO", SqlDbType.VarChar).Value = fun.Comissionado;
                Cmd.SelectCommand.Parameters.Add("@NUMRUA", SqlDbType.VarChar).Value = fun.NumRua;

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


        public DataTable BuscaProxFuncionarios(Funcionario fun)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaProxFuncionarios", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(fun.Codigo))
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = 0;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    return data;
                } else
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = fun.Codigo;
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

        public DataTable BuscaAntFuncionarios(Funcionario fun)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaAntFuncionarios", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(fun.Codigo))
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = 0;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = fun.Codigo;
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


        public DataTable ApagaFuncionarios(int cod)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ApagaFuncionario", con);

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

        public DataTable ListaFiliais()
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ListaFiliais", con);

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

        public DataTable UltimoFuncionario()
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_UltimoFuncionario", con);

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
