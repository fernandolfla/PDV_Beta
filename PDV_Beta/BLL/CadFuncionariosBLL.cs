using PDV_Beta.Component;
using PDV_Beta.DAO;
using PDV_Beta.Entity;
using PDV_Beta.Seguranca;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.BLL
{
    class CadFuncionariosBLL
    {
        public int CadastraFuncionarios(Funcionario funcionario)
        {
            if(funcionario.Apelido.Length > 0 && funcionario.Apelido.Length <= 10)
                if(funcionario.Nome.Length > 0 && funcionario.Nome.Length <= 50)
                    if(funcionario.Senha.Length > 0 && funcionario.Senha.Length <= 6)
                    {
                        CadFuncionariosDAO DAO = new CadFuncionariosDAO();
                        DataTable Result = new DataTable();
                        funcionario.Senha = Crypto.MD5(funcionario.Senha);
                        Result = DAO.CadastraFuncionario(funcionario, Autenticacao.GetCodUsuario());
                        if (Result != null)
                            if (Result.Rows.Count > 0)
                                if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                                {
                                    DataTable ultimo = DAO.UltimoFuncionario();
                                    if(ultimo != null)
                                        if(ultimo.Rows.Count > 0)
                                        {
                                            return Convert.ToInt32(ultimo.Rows[0].ItemArray[0]);
                                        }

                                }
                    }

            return -1;
        }


        public Funcionario BuscaProxFuncionarios(Funcionario fun)
        {
        
                CadFuncionariosDAO DAO = new CadFuncionariosDAO();
                DataTable Result = new DataTable();

                Result = DAO.BuscaProxFuncionarios(fun);

                if(Result != null)
                    if(Result.Rows.Count > 0)
                    {
                        if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                        {
                            fun = DataToFuncionario(Result, fun);
                            return fun;
                        } else return null;
                    }
                    else
                    {
                        fun.Codigo = null;
                        Result = DAO.BuscaProxFuncionarios(fun);
                        if (Result != null)
                            if (Result.Rows.Count > 0)
                                {
                                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                                    {
                                        fun = DataToFuncionario(Result, fun);
                                        return fun;
                                    }
                                }
                    }
            return null;
        }

        public Funcionario BuscaAntFuncionarios(Funcionario fun)
        {

            CadFuncionariosDAO DAO = new CadFuncionariosDAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaAntFuncionarios(fun);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    fun = DataToFuncionario(Result, fun);
                    return fun;
                }
                else
                {
                    fun.Codigo = null;
                    Result = DAO.BuscaAntFuncionarios(fun);
                    fun = DataToFuncionario(Result, fun);
                    return fun;
                }
            return null;
        }


        public int ApagaFuncionario(string CodFun)
        {
            //Verificar se o funcinario pussui vendas cadastradas
            //Verificar se o funcionario fez algo que dependa do código

            CadFuncionariosDAO DAO = new CadFuncionariosDAO();
            int codFun = 0;
            if (!string.IsNullOrEmpty(CodFun))
                if (!CodFun.Equals("1"))
                {
                    if (!Autenticacao.GetCodUsuario().ToString().Equals(CodFun))
                    {                      
                            codFun = Convert.ToInt32(CodFun);

                            DataTable Result = new DataTable();

                            Result = DAO.ApagaFuncionarios(codFun);
                            if (Result != null)
                                if (Result.Rows.Count > 0)
                                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                                        return 3;  
                    }
                    else return 2;
                }
                else return 1;
            return 0;
        }

        public List<Filial> ListaFiliais()
        {
            CadFuncionariosDAO DAO = new CadFuncionariosDAO();
            DataTable Result = new DataTable();
            Result = DAO.ListaFiliais();
            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    List<Filial> fil = new List<Filial>();
                    //List<Filial> fil2 = new List<Filial>();

                    try {
                        foreach (DataRow linha in Result.Rows)
                        {
                            Filial filial = new Filial();
                            filial.Codigo = linha.ItemArray[0].ToString();
                            filial.Nome = linha.ItemArray[1].ToString();

                            fil.Add(filial);
                        }
                    }
                    catch (Exception) { return null; }
                    return fil;
                }
            return null;
        }

   

        private Funcionario DataToFuncionario(DataTable data , Funcionario fun)
        {
            //Funcionario fun = new Funcionario();
            fun.Codigo = data.Rows[0].ItemArray[0].ToString();
            try { fun.Ativo = (int)data.Rows[0].ItemArray[1]; }
            catch (Exception) { }
            fun.Nome = data.Rows[0].ItemArray[2].ToString();
            fun.Apelido = data.Rows[0].ItemArray[3].ToString();
            fun.Sexo = data.Rows[0].ItemArray[4].ToString();
            fun.Admissao = data.Rows[0].ItemArray[5].ToString();
            fun.Nascimento = data.Rows[0].ItemArray[6].ToString();
            fun.Endereco = data.Rows[0].ItemArray[7].ToString();
            fun.Bairro = data.Rows[0].ItemArray[8].ToString();
            fun.Cidade = data.Rows[0].ItemArray[9].ToString();
            fun.Estado = data.Rows[0].ItemArray[10].ToString();
            fun.Cep = data.Rows[0].ItemArray[11].ToString();
            fun.Telefone = data.Rows[0].ItemArray[12].ToString();
            fun.Cargo = data.Rows[0].ItemArray[13].ToString();
            fun.Identidade = data.Rows[0].ItemArray[14].ToString();
            fun.CPF = data.Rows[0].ItemArray[15].ToString();
            fun.Carteira_Trabalho = data.Rows[0].ItemArray[16].ToString();
            fun.Email = data.Rows[0].ItemArray[17].ToString();
            try { fun.Filial_Todas = (int)data.Rows[0].ItemArray[18]; }
            catch (Exception) { }
            fun.Observacoes = data.Rows[0].ItemArray[19].ToString();
            fun.Comissao_Venda = data.Rows[0].ItemArray[20].ToString();
            fun.Qtde_Filhos = data.Rows[0].ItemArray[21].ToString();
            fun.Estado_Civil = data.Rows[0].ItemArray[22].ToString();
            fun.Celular = data.Rows[0].ItemArray[23].ToString();

            try { fun.SuperUsuario = Convert.ToInt32(data.Rows[0].ItemArray[24].ToString()); }
            catch (Exception) { }
            try { fun.PerCadastro = (int)data.Rows[0].ItemArray[25]; }
            catch (Exception) { }
            try { fun.PerMovimento = (int)data.Rows[0].ItemArray[26]; }
            catch (Exception) { }
            try { fun.PerFinanceiro = (int)data.Rows[0].ItemArray[27]; }
            catch (Exception) { }
            try { fun.PerConfiguracao = (int)data.Rows[0].ItemArray[28]; }
            catch (Exception) { }
            fun.Filial = data.Rows[0].ItemArray[29].ToString();
            fun.Salario = data.Rows[0].ItemArray[30].ToString();
            try { fun.Comissionado = (int)data.Rows[0].ItemArray[31]; }
            catch (Exception) { }

            fun.NumRua = data.Rows[0].ItemArray[32].ToString();
            

            return fun;
        }  
    }
}

