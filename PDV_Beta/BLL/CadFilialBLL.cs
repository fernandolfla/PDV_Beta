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
    class CadFilialBLL
    {
        public bool Cadastra(Filial fi)
        {
            if (fi.Nome.Length > 0 && fi.Nome.Length <= 20)
                if (string.IsNullOrEmpty(fi.Codigo))
                {
                    fi.CNPJ = fi.CNPJ.Replace(",", ".");
                    CadFilialDAO DAO = new CadFilialDAO();
                    DataTable Result = new DataTable();

                    Result = DAO.Cadastra(fi, Autenticacao.GetCodUsuario());
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                            if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                                return true;
                            else return false;
                }
            return false;
        }


        public bool Apaga(string cod)
        {

            CadFilialDAO DAO = new CadFilialDAO();
            if (!string.IsNullOrEmpty(cod))
            {

                DataTable Result = new DataTable();

                Result = DAO.Apaga(cod);
                if (Result != null)
                    if (Result.Rows.Count > 0)
                        if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                            return true;
            }
            return false;
        }



        public Filial BuscaProx(Filial fi)
        {

            CadFilialDAO DAO = new CadFilialDAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaProx(fi);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        fi = DataToFilial(Result, fi);
                        return fi;
                    }
                    else return null;
                }
                else
                {
                    fi.Codigo = null;
                    Result = DAO.BuscaProx(fi);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                fi = DataToFilial(Result, fi);
                                return fi;
                            }
                        }
                }
            return null;
        }


        public Filial BuscaAnt(Filial fi)
        {
            CadFilialDAO DAO = new CadFilialDAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaAnt(fi);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        fi = DataToFilial(Result, fi);
                        return fi;
                    }
                    else return null;
                }
                else
                {
                    fi.Codigo = null;
                    Result = DAO.BuscaAnt(fi);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                fi = DataToFilial(Result, fi);
                                return fi;
                            }
                        }
                }
            return null;
        }


        private Filial DataToFilial(DataTable data, Filial fi)
        {
            fi.Codigo = data.Rows[0].ItemArray[0].ToString();
            try { fi.Ativo = (int)data.Rows[0].ItemArray[1]; }
            catch (Exception) { }
            fi.Nome = data.Rows[0].ItemArray[2].ToString();
            fi.CNPJ = data.Rows[0].ItemArray[3].ToString();

            fi.Endereco = data.Rows[0].ItemArray[4].ToString();
            fi.Complemento = data.Rows[0].ItemArray[5].ToString();
            fi.Bairro = data.Rows[0].ItemArray[6].ToString();
            fi.Cidade = data.Rows[0].ItemArray[7].ToString();
            fi.Estado = data.Rows[0].ItemArray[8].ToString();
            fi.Cep = data.Rows[0].ItemArray[9].ToString();
            fi.NumRua = data.Rows[0].ItemArray[10].ToString();
            fi.Inscricao = data.Rows[0].ItemArray[11].ToString();
            fi.InscricaoMunicipal = data.Rows[0].ItemArray[12].ToString();
            fi.Fone1 = data.Rows[0].ItemArray[13].ToString();
            fi.Fone2 = data.Rows[0].ItemArray[14].ToString();
            fi.Email = data.Rows[0].ItemArray[15].ToString();
            fi.Rua_Proxima1 = data.Rows[0].ItemArray[16].ToString();
            fi.Rua_Proxima2 = data.Rows[0].ItemArray[17].ToString();
            fi.Observacoes = data.Rows[0].ItemArray[18].ToString();

            return fi;
        }


        public bool ValidaCnpj(string cnpj)
        {
            if (string.IsNullOrEmpty(cnpj))
                return false;

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

    }
}
