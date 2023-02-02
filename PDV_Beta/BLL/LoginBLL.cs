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
    class LoginBLL
    {

        public string VerificaFilial(string filial)
        {
            if(!string.IsNullOrEmpty(filial) || !filial.Equals(""))
            {
                //int CodFilial = Convert.ToInt32(filial);

                LoginDAO DAO = new LoginDAO();

                DataTable Filial =  DAO.VerificaFilial(filial);

                if(Filial != null)
                    if(Filial.Rows.Count > 0)
                    {
                       return  Filial.Rows[0].ItemArray[1].ToString();
                        //model.Nome = data.Rows[0].ItemArray[1].ToString();
                        //model.Url_foto = data.Rows[0].ItemArray[2].ToString();
                    }
            }
            

            return "";
        }

        public void VerificaCaixaAberto()
        {
            LoginDAO DAO = new LoginDAO();
            DataTable Result = new DataTable();

            Result = DAO.VerifiCaixaAberto(Autenticacao.GetCodUsuario(), Autenticacao.GetCodFilial());
            if (Result != null)
            {
                if (Result.Rows.Count > 0)
                {
                    try { Autenticacao.SetCaixa((int)Result.Rows[0].ItemArray[0]); } catch { }
                    try { Autenticacao.SetCaixa_Situacao((int)Result.Rows[0].ItemArray[1]); } catch { }
                    Autenticacao.SetCaixaStatus(true);
                }
                else
                    Autenticacao.SetCaixaStatus(false);              
            }
            else
                Autenticacao.SetCaixaStatus(false);
        }


        public string VerificaUsuario(string usuario)
        {
            if (!string.IsNullOrEmpty(usuario) || !usuario.Equals(""))
            {
                int CodUsuario = Convert.ToInt32(usuario);

                LoginDAO DAO = new LoginDAO();

                DataTable Usuario = DAO.VerificaUsuario(CodUsuario);
                if(Usuario != null)
                    if (Usuario.Rows.Count > 0)
                    {
                        return Usuario.Rows[0].ItemArray[1].ToString();

                    }
                
            }
            return "";
        }

        public int Logar(string filial,string nomeFilial,string usuario, string senha)
        {

            if (!string.IsNullOrEmpty(usuario) || !usuario.Equals("")) //0
            {
                if (!string.IsNullOrEmpty(filial) || !filial.Equals("")) //1
                {
                    if (!string.IsNullOrEmpty(senha) || !senha.Equals("")) //2
                    {
                        int CodUsuario = Convert.ToInt32(usuario);

                        LoginDAO DAO = new LoginDAO();

                        DataTable Usuario = DAO.EfetuaLogin(CodUsuario, Crypto.MD5(senha));
                        if (Usuario != null)
                            if (Usuario.Rows.Count > 0) // 3 senha incorreta
                            {
                                try { Autenticacao.Login(Convert.ToInt32(usuario), Usuario.Rows[0].ItemArray[3].ToString(), Convert.ToInt32(filial), nomeFilial); }
                                catch (Exception) { }
                                try { Autenticacao.Permissoes((int)Usuario.Rows[0].ItemArray[4], (int)Usuario.Rows[0].ItemArray[6], (int)Usuario.Rows[0].ItemArray[7], (int)Usuario.Rows[0].ItemArray[9], (int)Usuario.Rows[0].ItemArray[9], (int)Usuario.Rows[0].ItemArray[10]); }
                                catch (Exception) { }

                                if (Autenticacao.GetFilial_Todas() != 1)
                                {
                                    if ((int)Usuario.Rows[0].ItemArray[11] == Autenticacao.GetCodFilial())
                                        return 5; //permite acesso
                                    else return 4; // 4 Usuario nao tem acesso a filial
                                }
                                else return 5;
                            }
                             return 3;
                    }
                    return 2;
                }
                return 1;
            }
            return 0;
        }

        
        

    }
}
