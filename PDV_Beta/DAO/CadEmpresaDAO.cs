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
    class CadEmpresaDAO : Connection
    {

        public DataTable Atualiza(Empresa emp, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_AtualizaEmpresa", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@RAZAO", SqlDbType.VarChar).Value = emp.Razao;
                Cmd.SelectCommand.Parameters.Add("@FANTASIA", SqlDbType.VarChar).Value = emp.Fantasia;
                Cmd.SelectCommand.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = emp.Endereco;
                Cmd.SelectCommand.Parameters.Add("@COMPLEMENTO", SqlDbType.VarChar).Value = emp.Complemento;
                Cmd.SelectCommand.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = emp.Bairro;
                Cmd.SelectCommand.Parameters.Add("@CIDADE", SqlDbType.VarChar).Value = emp.Cidade;
                Cmd.SelectCommand.Parameters.Add("@ESTADO", SqlDbType.VarChar).Value = emp.Estado;
                Cmd.SelectCommand.Parameters.Add("@CEP", SqlDbType.VarChar).Value = emp.Cep;
                Cmd.SelectCommand.Parameters.Add("@NUMRUA", SqlDbType.VarChar).Value = emp.NumRua;
                Cmd.SelectCommand.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = emp.CNPJ;
                Cmd.SelectCommand.Parameters.Add("@INSCRICAO", SqlDbType.VarChar).Value = emp.Inscricao;
                Cmd.SelectCommand.Parameters.Add("@INCRICAO_MUNICIPAL", SqlDbType.VarChar).Value = emp.InscricaoMunicipal;
                Cmd.SelectCommand.Parameters.Add("@FONE_1", SqlDbType.VarChar).Value = emp.Fone1;
                Cmd.SelectCommand.Parameters.Add("@FONE_2", SqlDbType.VarChar).Value = emp.Fone2;                
                Cmd.SelectCommand.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = emp.Email;                
                Cmd.SelectCommand.Parameters.Add("@RUA_PROXIMA_1", SqlDbType.VarChar).Value = emp.Rua_Proxima1;
                Cmd.SelectCommand.Parameters.Add("@RUA_PROXIMA_2", SqlDbType.VarChar).Value = emp.Rua_Proxima2;               
                Cmd.SelectCommand.Parameters.Add("@OBSERVACOES", SqlDbType.VarChar).Value = emp.Observacoes;

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


        public DataTable Busca()
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaEmpresa", con);

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
