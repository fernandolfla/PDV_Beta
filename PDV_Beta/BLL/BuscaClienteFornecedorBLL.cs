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
    class BuscaClienteFornecedorBLL
    {

        public List<ClienteFornecedor> BuscaClienteFornecedorPorCodigo(string codigo) //VERIFICAR
        {
            DataTable Result = new DataTable();
            BuscaClienteFornecedorDAO DAO = new BuscaClienteFornecedorDAO();

            Result = DAO.BuscaPorCodigo(codigo);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    List<ClienteFornecedor> Cli = new List<ClienteFornecedor>();

                    
                    return DataToClienteFornecedor(Result);
                }



          return null;
        }


         public List<ClienteFornecedor> BuscaClienteFornecedorPorNome(string nome) //VERIFICAR
        {
            DataTable Result = new DataTable();
            BuscaClienteFornecedorDAO DAO = new BuscaClienteFornecedorDAO();

            Result = DAO.BuscaPorNome(nome);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    List<ClienteFornecedor> Cli = new List<ClienteFornecedor>();

                    
                    return DataToClienteFornecedor(Result);
                }



          return null;
        }

  
        private List<ClienteFornecedor> DataToClienteFornecedor(DataTable data)
        {

            List<ClienteFornecedor> CLI = new List<ClienteFornecedor>();

            foreach (DataRow linha in data.Rows)
            {
                ClienteFornecedor cli = new ClienteFornecedor();

                cli.Codigo = linha.ItemArray[0].ToString();
                try { cli.Ativo = (int)linha.ItemArray[1]; }
                catch (Exception) { }
                cli.Tipo = linha.ItemArray[2].ToString();
                cli.Fisica_Juridica = linha.ItemArray[3].ToString();
                cli.Nome = linha.ItemArray[4].ToString();
                cli.Fantasia = linha.ItemArray[5].ToString();
                cli.Endereco = linha.ItemArray[6].ToString();
                cli.Complemento = linha.ItemArray[7].ToString();
                cli.Bairro = linha.ItemArray[8].ToString();
                cli.Cidade = linha.ItemArray[9].ToString();
                cli.Estado = linha.ItemArray[10].ToString();
                cli.Cep = linha.ItemArray[11].ToString();
                cli.NumRua = linha.ItemArray[12].ToString();
                cli.CNPJ = linha.ItemArray[13].ToString();
                cli.Inscricao = linha.ItemArray[14].ToString();
                cli.InscricaoMunicipal = linha.ItemArray[15].ToString();
                cli.Fone1 = linha.ItemArray[16].ToString();
                cli.Fone2 = linha.ItemArray[17].ToString();

                try { cli.TemConta = (int)linha.ItemArray[18]; }
                catch (Exception) { }
                cli.DiaFechamentoConta = linha.ItemArray[19].ToString();


                try { cli.CompraParcelado = (int)linha.ItemArray[20]; }
                catch (Exception) { }
                cli.Email = linha.ItemArray[21].ToString();
                cli.EmailFinanceiro = linha.ItemArray[22].ToString();
                cli.LimiteCredito = linha.ItemArray[23].ToString();
                cli.Rua_Proxima1 = linha.ItemArray[24].ToString();
                cli.Rua_Proxima2 = linha.ItemArray[25].ToString();
                cli.OperacaoPadraoSaida = linha.ItemArray[26].ToString();
                cli.OperacaoPadraoEntrada = linha.ItemArray[27].ToString();
                cli.Observacoes = linha.ItemArray[28].ToString();
                cli.FretePadrao = linha.ItemArray[29].ToString();

                CLI.Add(cli);

            }

            return CLI;
        }



    }
}
