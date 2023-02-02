using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.Component
{
    static class Erros
    {
        static Exception ErroBanco;
        static bool HaErro = false;
        static string MsgPadrao = "Houve um erro a conectar ao banco de dados, reinicie o programa, caso persista entre em contato com o suporte.ERRO = ";
        

        public static Exception GetErroBanco()
        {
            return ErroBanco;
        }
        public static void SetErroBanco(Exception erro)
        {
            ErroBanco = erro;
        }
        public static void SetHaErro(bool haerro)
        {
            HaErro = haerro;
        }
        public static bool GetHaErro()
        {
            return HaErro;
        }

        public static string GetMensagemErro()
        {
            return MsgPadrao;
        }
    }
}
