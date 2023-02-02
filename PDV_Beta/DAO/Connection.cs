using PDV_Beta.Component;
using PDV_Beta.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.DAO
{
    public class Connection
    {
        //private string _conexao = "Data Source=.\\SQLEXPRESS;Initial Catalog=PDV_Real;Integrated Security=FALSE;User ID=sa;Password=masterkey;Connect Timeout=30";
        //private string _conexao2 = "Data Source=.\\SQLEXPRESS;Initial Catalog=CEP;Integrated Security=FALSE;User ID=sa;Password=masterkey;Connect Timeout=30";

        public SqlConnection con = null;

        private string _conexao;
        private string _conexao2;
        public Connection()
        {
            //ConfiTxt confi = new ConfiTxt();
            //confi = LerArquivo.Ler();

            _conexao = "Data Source=" + LerArquivo.confi.Server + "\\"+ LerArquivo.confi.Instancia+";Initial Catalog=PDV_Real;Integrated Security=FALSE;User ID="+ LerArquivo.confi.User+";Password="+ LerArquivo.confi.Password+";Connect Timeout=30";
            _conexao2 = "Data Source=" + LerArquivo.confi.Server + "\\"+ LerArquivo.confi.Instancia+ ";Initial Catalog=CEP;Integrated Security=FALSE;User ID=" + LerArquivo.confi.User + ";Password=" + LerArquivo.confi.Password + ";Connect Timeout=30";
        }
        


       

        public void CriarConexao()
        {
            con = new SqlConnection(_conexao);
        }

        public void CriarConexaoCep()
        {
            con = new SqlConnection(_conexao2);
        }

        public void Abrir()
        {

            if (con != null)
            {
                con.Close();
                con.Open();
            }
            else
                con.Open();
        }

        public void Fechar()
        {
            con.Close();
        }


    }
}
