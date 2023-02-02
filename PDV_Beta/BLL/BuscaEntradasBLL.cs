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
    class BuscaEntradasBLL
    {

        public List<Entradas> BuscaEntrada(DateTime inicio, DateTime fim) 
        {
            if (inicio > fim)
                inicio = fim;

            DataTable Result = new DataTable();
            BuscaEntradasDAO DAO = new BuscaEntradasDAO();

            Result = DAO.BuscaEntrada(inicio,fim, Autenticacao.GetCodFilial());

            if (Result != null)
                if (Result.Rows.Count > 0)
                {

                    return DataToEntity(Result);
                }

            return null;
        }

        public List<Entradas> BuscaEntradaNF(string NF)
        {

            DataTable Result = new DataTable();
            BuscaEntradasDAO DAO = new BuscaEntradasDAO();

            Result = DAO.BuscaEntradaNF(NF, Autenticacao.GetCodFilial());

            if (Result != null)
                if (Result.Rows.Count > 0)
                {

                    return DataToEntity(Result);
                }

            return null;
        }

        public List<Entradas_Produtos> BuscaLinhas(int entrada)
        {
            DataTable Result = new DataTable();
            BuscaEntradasDAO DAO = new BuscaEntradasDAO();

            Result = DAO.BuscaEntrada_Produtos(entrada);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    List<Entradas_Produtos> ent = new List<Entradas_Produtos>();

                    return DataToEntity2(Result);
                }

            return null;
        }


        private List<Entradas> DataToEntity(DataTable data)
        {

            List<Entradas> ENT = new List<Entradas>();

            foreach (DataRow linha in data.Rows)
            {
                Entradas ent = new Entradas();

                try {ent.Id = Convert.ToInt32(linha.ItemArray[0].ToString()); } catch (Exception) { }
                ent.NumNota = linha.ItemArray[1].ToString();
                try {ent.Filial = Convert.ToInt32(linha.ItemArray[2].ToString()); } catch (Exception) { }
                ent.Data = linha.ItemArray[3].ToString();
                ent.Cod_Operacao = linha.ItemArray[4].ToString();
                ent.Fornecedor = linha.ItemArray[5].ToString();
                ent.NomeFornecedor = linha.ItemArray[6].ToString();
                ent.Observacoes = linha.ItemArray[7].ToString();
                try {ent.Produtos = Convert.ToDecimal(linha.ItemArray[8].ToString()); } catch (Exception) { }
                try {ent.Descontos = Convert.ToDecimal(linha.ItemArray[9].ToString()); } catch (Exception) { }
                try {ent.Frete = Convert.ToDecimal(linha.ItemArray[10].ToString()); } catch (Exception) { }
                try {ent.Total = Convert.ToDecimal(linha.ItemArray[11].ToString()); } catch (Exception) { }
                try {ent.Efetivado_Estoque = Convert.ToInt32(linha.ItemArray[12].ToString()); } catch (Exception) { }
                try {ent.Nota_Cancelada = Convert.ToInt32(linha.ItemArray[13].ToString()); } catch (Exception) { }
                ent.Transportadora = linha.ItemArray[14].ToString();
                try {ent.Peso_bruto = Convert.ToDecimal(linha.ItemArray[15].ToString());}catch (Exception) { }
                try {ent.Volumes = Convert.ToInt32(linha.ItemArray[16].ToString());}catch (Exception) { }
                ent.Motivo_Cancelamento = linha.ItemArray[17].ToString();

                ENT.Add(ent);
            }

            return ENT;
        }

        private List<Entradas_Produtos> DataToEntity2(DataTable data)
        {

            List<Entradas_Produtos> ENT = new List<Entradas_Produtos>();

            foreach (DataRow linha in data.Rows)
            {
                Entradas_Produtos ent = new Entradas_Produtos();

                ent.Id = linha.ItemArray[0].ToString();
                try {  ent.Id_Entrada = Convert.ToInt32(linha.ItemArray[1].ToString()); } catch (Exception) { }
                ent.Linha = Convert.ToInt32(linha.ItemArray[2].ToString());
                ent.Cod_Produto = linha.ItemArray[3].ToString();
                ent.Nome_Produto = linha.ItemArray[4].ToString();
                try { ent.Qtde = Convert.ToDecimal(linha.ItemArray[5].ToString());} catch (Exception) { }
                try {ent.PrecoUnit = Convert.ToDecimal(linha.ItemArray[6].ToString()); } catch (Exception) { }
                try {ent.Preco_Total = Convert.ToDecimal(linha.ItemArray[7].ToString()); } catch (Exception) { }
                try {ent.Desconto_Total = Convert.ToDecimal(linha.ItemArray[8].ToString()); } catch (Exception) { }
                try {ent.Preco_Final = Convert.ToDecimal(linha.ItemArray[9].ToString()); } catch (Exception) { }

                ENT.Add(ent);
            }

            return ENT;
        }




    }
}
