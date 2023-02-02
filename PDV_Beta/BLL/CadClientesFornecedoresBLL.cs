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
    class CadClientesFornecedoresBLL
    {
        public int CadastraFornecedor(ClienteFornecedor cli, bool edita)
        {
            if (cli.Nome.Length > 0 && cli.Nome.Length <= 60)
                if (cli.Codigo.Length > 0 && cli.Codigo.Length <= 20)
                {
                   
                        CadClientesForncecedoresDAO DAO = new CadClientesForncecedoresDAO();
                        DataTable Result = new DataTable();

                        Result = DAO.CadastraFornecedor(cli, edita, Autenticacao.GetCodUsuario());
                        if (Result != null)
                            if (Result.Rows.Count > 0)
                                if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                                    return 1;
                                else return 2;

                }
                return 3;
        }

        //private bool VerificaPrimeiraLetra(string l)
        //{
        //    char[] c = l.ToCharArray();
        //    char s = c[0];
        //    if (char.IsNumber(s))
        //        return false;
        //    return true;
        //}

        public ClienteFornecedor BuscaProxClienteFornecedor(ClienteFornecedor cli)
        {

            CadClientesForncecedoresDAO DAO = new CadClientesForncecedoresDAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaProxClienteFornecedor(cli);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        cli = DataToClienteFornecedor(Result, cli);
                        return cli;
                    }
                    else return null;
                }
                else
                {
                    cli.Codigo = null;
                    Result = DAO.BuscaProxClienteFornecedor(cli);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                cli = DataToClienteFornecedor(Result, cli);
                                return cli;
                            }
                        }
                }
            return null;
        }


        public ClienteFornecedor BuscaAntClienteFornecedor(ClienteFornecedor cli)
        {

            CadClientesForncecedoresDAO DAO = new CadClientesForncecedoresDAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaAntClienteFornecedor(cli);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        cli = DataToClienteFornecedor(Result, cli);
                        return cli;
                    }
                    else return null;
                }
                else
                {
                    cli.Codigo = null;
                    Result = DAO.BuscaAntClienteFornecedor(cli);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                cli = DataToClienteFornecedor(Result, cli);
                                return cli;
                            }
                        }
                }
            return null;
        }


        public bool ApagaClienteFornecedor(string cod)
        {
            //Verificar se o funcinario pussui vendas cadastradas
            //Verificar se o funcionario fez algo que dependa do código

            CadClientesForncecedoresDAO DAO = new CadClientesForncecedoresDAO();


            if (!string.IsNullOrEmpty(cod))
                {
                   
                   DataTable Result = new DataTable();

                   Result = DAO.ApagaClienteFornecedor(cod);
                        if (Result != null)
                            if (Result.Rows.Count > 0)
                                if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                                    return true;               
                }
                 return false;
        }


        public string BuscaProxCodLivre()
        {
            CadClientesForncecedoresDAO DAO = new CadClientesForncecedoresDAO();
            DataTable Result = new DataTable();
         
            Result = DAO.BuscaProximoCodigoLivre();

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                        return Result.Rows[0].ItemArray[0].ToString();   
                }
            return null;
        }

        public List<Operacoes> ListaOperacoes()
        {
            CadClientesForncecedoresDAO DAO = new CadClientesForncecedoresDAO();
            DataTable Result = new DataTable();
            Result = DAO.ListaOperacoes();
            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    List<Operacoes> OP = new List<Operacoes>();
                    try
                    {
                        foreach (DataRow linha in Result.Rows)
                        {
                            Operacoes operacao = new Operacoes();
                            operacao.Ativo = Convert.ToInt32(linha.ItemArray[1]);
                            operacao.Tipo = Convert.ToInt32(linha.ItemArray[2]);
                            operacao.CFOP = linha.ItemArray[3].ToString();

                            OP.Add(operacao);
                        }

                    }
                    catch (Exception) { return null; }
                    return OP;
                }
            return null;
        }

        private ClienteFornecedor DataToClienteFornecedor(DataTable data , ClienteFornecedor cli)
        {


            cli.Codigo = data.Rows[0].ItemArray[0].ToString();
            try { cli.Ativo = (int)data.Rows[0].ItemArray[1]; }
            catch (Exception) { }
            cli.Tipo = data.Rows[0].ItemArray[2].ToString();
            cli.Fisica_Juridica = data.Rows[0].ItemArray[3].ToString();
            cli.Nome = data.Rows[0].ItemArray[4].ToString();
            cli.Fantasia = data.Rows[0].ItemArray[5].ToString();
            cli.Endereco = data.Rows[0].ItemArray[6].ToString();
            cli.Complemento = data.Rows[0].ItemArray[7].ToString();
            cli.Bairro = data.Rows[0].ItemArray[8].ToString();
            cli.Cidade = data.Rows[0].ItemArray[9].ToString();
            cli.Estado = data.Rows[0].ItemArray[10].ToString();
            cli.Cep = data.Rows[0].ItemArray[11].ToString();
            cli.NumRua = data.Rows[0].ItemArray[12].ToString();
            cli.CNPJ = data.Rows[0].ItemArray[13].ToString();
            cli.Inscricao = data.Rows[0].ItemArray[14].ToString();
            cli.InscricaoMunicipal = data.Rows[0].ItemArray[15].ToString();
            cli.Fone1 = data.Rows[0].ItemArray[16].ToString();
            cli.Fone2 = data.Rows[0].ItemArray[17].ToString();

            try { cli.TemConta = (int)data.Rows[0].ItemArray[18]; }
            catch (Exception) { }
            cli.DiaFechamentoConta = data.Rows[0].ItemArray[19].ToString();


            try { cli.CompraParcelado = (int)data.Rows[0].ItemArray[20]; }
            catch (Exception) { }
            cli.Email = data.Rows[0].ItemArray[21].ToString();
            cli.EmailFinanceiro = data.Rows[0].ItemArray[22].ToString();
            cli.LimiteCredito = data.Rows[0].ItemArray[23].ToString();
            cli.Rua_Proxima1 = data.Rows[0].ItemArray[24].ToString();
            cli.Rua_Proxima2 = data.Rows[0].ItemArray[25].ToString();
            cli.OperacaoPadraoSaida = data.Rows[0].ItemArray[26].ToString();
            cli.OperacaoPadraoEntrada = data.Rows[0].ItemArray[27].ToString();
            cli.Observacoes = data.Rows[0].ItemArray[28].ToString();
            cli.FretePadrao = data.Rows[0].ItemArray[29].ToString();



            return cli;
        }





    }
}
