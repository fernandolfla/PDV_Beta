using PDV_Beta.Entity;
using PDV_Beta.Seguranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.Component
{
    static class LerArquivo
    {
        public static ConfiTxt confi = new ConfiTxt();
        public static ConfiTxt Ler()
        {
            
            try {
                string[] lines = System.IO.File.ReadAllLines(Environment.CurrentDirectory + "\\Confi.txt");

                confi.Server = lines[0];
                confi.Instancia = lines[1];
                confi.User = lines[2];
                confi.Password = lines[3];
                try { confi.Impressora = Convert.ToInt32(lines[4]); } catch { confi.Impressora = 7; }
                Autenticacao.SetServidor(lines[0]);
            }
            catch {
                confi.Server = "localhost";
                confi.Instancia = "sqlexpress";
                confi.User = "sa";
                confi.Password = "masterkey";
                confi.Impressora = 7; // Padrão MP-4200 TH
                Autenticacao.SetServidor("localhost");
            }
            return confi;
        }


    }
}
