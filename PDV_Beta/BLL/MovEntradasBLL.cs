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
    class MovEntradasBLL
    {

        public int Cadastra(Entradas ent)
        {
            if (ent.NumNota.Length > 0 && ent.NumNota.Length <= 20)
                if (ent.listagrid.Count > 0)
                    if(!string.IsNullOrEmpty(ent.Fornecedor))
                    {

                        MovEntradasDAO DAO = new MovEntradasDAO();
                        DataTable Result = new DataTable();
                        ent.Filial = Autenticacao.GetCodFilial();
                        Result = DAO.Cadastra(ent, Autenticacao.GetCodUsuario());
                        if (Result != null)
                            if (Result.Rows.Count > 0)
                                if(!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                                    {
                                        DataTable Result2 = new DataTable();
                                    try { ent.Id = (int)Result.Rows[0].ItemArray[0]; } catch (Exception) { }
                                        if(ent.listagrid != null)
                                            foreach (var l in ent.listagrid)
                                            {
                                                Result2 = DAO.CadastraProdutos(ent,l, Autenticacao.GetCodUsuario());
                                                if (Result2 == null)
                                                    return 3;
                                                if (Result2.Rows.Count <= 0)
                                                    return 3;
                                                if (Result2.Rows[0].ItemArray[0].ToString().Equals("-1"))
                                                    return 3;

                                            }
                                        return 1;
                                    } return 2;
                    } return 0;
        }




        public bool CancelaNF(int ID, string motivo)
        {

            MovEntradasDAO DAO = new MovEntradasDAO();
            DataTable Result = new DataTable();

            Result = DAO.CancelaNota(Autenticacao.GetCodUsuario(), ID , motivo);
            if (Result != null)
                if (Result.Rows.Count > 0)
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                        return true;
            return false;

        }




        public List<Operacoes> ListaOperacoes()
        {
            MovEntradasDAO DAO = new MovEntradasDAO();
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
    }
}
