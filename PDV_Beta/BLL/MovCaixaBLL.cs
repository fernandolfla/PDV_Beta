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
    class MovCaixaBLL
    {
        public bool Abrir(string cx, decimal vlinicial)
        {
            MovCaixaDAO DAO = new MovCaixaDAO();
            DataTable Result = new DataTable();
            int cxs;
            try { cxs = Convert.ToInt32(cx); } catch { cxs = 0; }

            Result = DAO.AbreCaixa(cxs, vlinicial, Autenticacao.GetCodFilial() ,Autenticacao.GetCodUsuario());
            if (Result != null)
                if (Result.Rows.Count > 0)
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        Autenticacao.SetCaixa(cxs);
                        try { Autenticacao.SetCaixa_Situacao((int)Result.Rows[0].ItemArray[0]); } catch { }
                        Autenticacao.SetCaixaStatus(true);
                        return true;
                    }
            return false;
        }

        public bool Fechar()
        {
            if (Autenticacao.GetCaixa_Status())
            {
                MovCaixaDAO DAO = new MovCaixaDAO();
                DataTable Result = new DataTable();
                var c = new Caixa_Situacao();

                c = Busca(Autenticacao.GetCaixa().ToString());

                Result = DAO.FechaCaixa(c.Id, Autenticacao.GetCodUsuario());
                if (Result != null)
                    if (Result.Rows.Count > 0)
                        if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                        {
                            Autenticacao.SetCaixaStatus(false);
                            return true;
                        }
            }
            return false;
        }

        public Caixa_Situacao Busca(string caixa)
        {
            MovCaixaDAO DAO = new MovCaixaDAO();
            DataTable Result = new DataTable();

            Result = DAO.Busca(caixa, Autenticacao.GetCodFilial());

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        return DataToEntity(Result);
                        
                    }
                    else return null;
                }

            return null;
        }

        public List<Caixa> ListaCaixa()
        {
            MovCaixaDAO DAO = new MovCaixaDAO();
            DataTable Result = new DataTable();

            Result = DAO.ListaCaixa(Autenticacao.GetCodFilial());
            if (Result != null)
                if (Result.Rows.Count > 0)
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                        return DataToEntityList(Result);

            return null;
        }


        private Caixa_Situacao DataToEntity(DataTable data)
        {
            Caixa_Situacao cx = new Caixa_Situacao();
            cx.Id = data.Rows[0].ItemArray[0].ToString();
            cx.caixa.Id = data.Rows[0].ItemArray[1].ToString();
            try { cx.SituacaoId = (int)data.Rows[0].ItemArray[2]; }catch { }
            cx.SituacaoNome = data.Rows[0].ItemArray[3].ToString();
            try { cx.ValorInicial = (decimal)data.Rows[0].ItemArray[4]; } catch { }
            try {cx.TotalSaidas = (decimal)data.Rows[0].ItemArray[5]; } catch { }
            try {cx.DataAbertura = (DateTime)data.Rows[0].ItemArray[6]; } catch { }
            try {cx.DataFechamento = (DateTime)data.Rows[0].ItemArray[7]; } catch { }

            return cx;
        }


        private List<Caixa> DataToEntityList(DataTable data)
        {
            List<Caixa> caixas = new List<Caixa>();
            
            foreach(DataRow linha in data.Rows)
            {
                Caixa caixa = new Caixa();

                caixa.Id = linha.ItemArray[0].ToString();
                caixa.Nome = linha.ItemArray[3].ToString();
                caixa.Usuario = linha.ItemArray[5].ToString();

                caixas.Add(caixa);
            }

            return caixas;
        }



    }
}
