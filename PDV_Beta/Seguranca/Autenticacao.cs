using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.Seguranca
{
    static class Autenticacao
    {
        static int CodUsuario;
        static string NomeUsuario;
        static int CodFilial;
        static string NomeFilial;
        static int Caixa;
        static bool Caixa_Status;
        static int Caixa_Situacao;

        static int SuperUsuario;
        static int PerCadastros;
        static int PerMovimento;
        static int PerFinanceiro;
        static int PerConfiguracoes;
        static int Filial_Todas;

        static string Serial;
        static string Versao;
        static string Atualizacao;

        static string Servidor;

        

        public static void Login(int codUsuario , string nomeUsuario , int codFilial, string nomeFilial)
        {

            CodUsuario = codUsuario;
            NomeUsuario = nomeUsuario;
            CodFilial = codFilial;
            NomeFilial = nomeFilial;
            Serial = "AAAA-999999";
            Versao = "Pizzaria" ;
            Atualizacao = "Beta.v.0.01";

        }

        public static void Permissoes(int filialT, int superUsuario, int perCadastro, int perMovimento, int perFinanceiro, int perConfiguracoes)
        {
            SuperUsuario = superUsuario;
            PerCadastros = perCadastro;
            PerMovimento = perMovimento;
            PerFinanceiro = perFinanceiro;
            PerConfiguracoes = perConfiguracoes;
            Filial_Todas = filialT;
        }
        public static void Logout()
        {
            CodUsuario = 0;
            NomeUsuario = "";
            CodFilial = 0;
            NomeFilial = "";
        }

        public static string GetNomeUsuario()
        {
            return NomeUsuario;
        }

        public static int GetCodUsuario()
        {
            return CodUsuario;
        }

        public static int GetCodFilial()
        {
            return CodFilial;
        }

        public static string GetNomeFilial()
        {
            return NomeFilial;
        }

        public static string GetVersao()
        {
            return Versao;
        }
        public static string GetAtualizacao()
        {
            return Atualizacao;
        }
        public static string GetSerial()
        {
            return Serial;
        }
        public static int GetFilial_Todas()
        {
            return Filial_Todas;
        }
        public static int GetCaixa()
        {
            return Caixa;
        }
        public static void SetCaixa(int caixa)
        {
           Caixa = caixa;
        }
       
        public static bool GetCaixa_Status()
        {
            return Caixa_Status;
        }
        public static void SetCaixaStatus(bool s)
        {
            Caixa_Status = s;
        }
        public static int GetCaixa_Situacao()
        {
            return Caixa_Situacao;
        }
        public static void SetCaixa_Situacao(int cs)
        {
            Caixa_Situacao = cs;
        }

        public static void SetServidor(string servidor)
        {
            Servidor = servidor;
        }
        public static string GetServidor()
        {
            return Servidor;
        }
    }
}
