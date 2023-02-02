using PDV_Beta.DAO;
using PDV_Beta.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.BLL
{
    class BuscaFuncionariosBLL
    {
        public List<Funcionario> BuscaPorCodigo(string codigo) //VERIFICAR
        {
            DataTable Result = new DataTable();
            BuscaFuncionariosDAO DAO = new BuscaFuncionariosDAO();

            Result = DAO.BuscaPorCodigo(codigo);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    return DataToEntity(Result);
                }
            return null;
        }


        public List<Funcionario> BuscaPorNome(string nome) //VERIFICAR
        {
            DataTable Result = new DataTable();
            BuscaFuncionariosDAO DAO = new BuscaFuncionariosDAO();

            Result = DAO.BuscaPorNome(nome);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    return DataToEntity(Result);
                }
            return null;
        }


        private List<Funcionario> DataToEntity(DataTable data)
        {

            List<Funcionario> FUN = new List<Funcionario>();

            foreach (DataRow linha in data.Rows)
            {
                Funcionario fun = new Funcionario();

                fun.Codigo = linha.ItemArray[0].ToString();
                //try { fun.Ativo = (int)linha.ItemArray[1]; }
                //catch (Exception) { }
                fun.Nome = linha.ItemArray[2].ToString();
                //fun.Apelido = linha.ItemArray[3].ToString();
                //fun.Sexo = linha.ItemArray[4].ToString();
                //fun.Admissao = linha.ItemArray[5].ToString();
                //fun.Nascimento = linha.ItemArray[6].ToString();
                //fun.Endereco = linha.ItemArray[7].ToString();
                //fun.Bairro = linha.ItemArray[8].ToString();
                //fun.Cidade = linha.ItemArray[9].ToString();
                //fun.Estado = linha.ItemArray[10].ToString();
                //fun.Cep = linha.ItemArray[11].ToString();
                //fun.Telefone = linha.ItemArray[12].ToString();
                //fun.Cargo = linha.ItemArray[13].ToString();
                //fun.Identidade = linha.ItemArray[14].ToString();
                //fun.CPF = linha.ItemArray[15].ToString();
                //fun.Carteira_Trabalho = linha.ItemArray[16].ToString();
                //fun.Email = linha.ItemArray[17].ToString();
                //try { fun.Filial_Todas = (int)linha.ItemArray[18]; }
                //catch (Exception) { }
                //fun.Observacoes = linha.ItemArray[19].ToString();
                //fun.Comissao_Venda = linha.ItemArray[20].ToString();
                //fun.Qtde_Filhos = linha.ItemArray[21].ToString();
                //fun.Estado_Civil = linha.ItemArray[22].ToString();
                //fun.Celular = linha.ItemArray[23].ToString();

                //try { fun.SuperUsuario = Convert.ToInt32(linha.ItemArray[24].ToString()); }
                //catch (Exception) { }
                //try { fun.PerCadastro = (int)linha.ItemArray[25]; }
                //catch (Exception) { }
                //try { fun.PerMovimento = (int)linha.ItemArray[26]; }
                //catch (Exception) { }
                //try { fun.PerFinanceiro = (int)linha.ItemArray[27]; }
                //catch (Exception) { }
                //try { fun.PerConfiguracao = (int)linha.ItemArray[28]; }
                //catch (Exception) { }
                //fun.Filial = linha.ItemArray[29].ToString();
                //fun.Salario = linha.ItemArray[30].ToString();
                //try { fun.Comissionado = (int)linha.ItemArray[31]; }
                //catch (Exception) { }

                //fun.NumRua = linha.ItemArray[32].ToString();

                FUN.Add(fun);

            }

            return FUN;
        }


    }
}
