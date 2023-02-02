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
    class CadEmpresaBLL
    {


        public bool Atualiza(Empresa emp)
        {
            if (emp.Razao.Length > 0 && emp.Razao.Length <= 60)
                {
                if (string.IsNullOrEmpty(emp.NumRua))
                    emp.NumRua = "0";
                    CadEmpresaDAO DAO = new CadEmpresaDAO();
                    DataTable Result = new DataTable();

                    Result = DAO.Atualiza(emp,Autenticacao.GetCodUsuario());
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                            if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                                return true;
                            else return false;

                }
            return false;
        }

        public Empresa Busca()
        {
            Empresa emp = new Empresa();
            CadEmpresaDAO DAO = new CadEmpresaDAO();
            DataTable Result = new DataTable();

            Result = DAO.Busca();

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        emp = DataToClienteFornecedor(Result,emp);
                        return emp;
                    }
                    else return null;
                }              
            return null;
        }

        private Empresa DataToClienteFornecedor(DataTable data, Empresa emp)
        {


            try { emp.Ativo = (int)data.Rows[0].ItemArray[0]; }
            catch (Exception) { }
            emp.Razao = data.Rows[0].ItemArray[1].ToString();
            emp.Fantasia = data.Rows[0].ItemArray[2].ToString();
            emp.Endereco = data.Rows[0].ItemArray[3].ToString();
            emp.Complemento = data.Rows[0].ItemArray[4].ToString();
            emp.Bairro = data.Rows[0].ItemArray[5].ToString();
            emp.Cidade = data.Rows[0].ItemArray[6].ToString();
            emp.Estado = data.Rows[0].ItemArray[7].ToString();
            emp.Cep = data.Rows[0].ItemArray[8].ToString();
            emp.NumRua = data.Rows[0].ItemArray[9].ToString();
            emp.CNPJ = data.Rows[0].ItemArray[10].ToString();
            emp.Inscricao = data.Rows[0].ItemArray[11].ToString();
            emp.InscricaoMunicipal = data.Rows[0].ItemArray[12].ToString();
            emp.Fone1 = data.Rows[0].ItemArray[13].ToString();
            emp.Fone2 = data.Rows[0].ItemArray[14].ToString();
            emp.Email = data.Rows[0].ItemArray[15].ToString();
            emp.Rua_Proxima1 = data.Rows[0].ItemArray[16].ToString();
            emp.Rua_Proxima2 = data.Rows[0].ItemArray[17].ToString();
            emp.Observacoes = data.Rows[0].ItemArray[18].ToString();

            return emp;
        }

    }
}
