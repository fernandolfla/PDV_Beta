using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.Entity
{
    public class ClienteFornecedor
    {


        public ClienteFornecedor()
        {

            Ativo = 1;
            Tipo = "C";
            Fisica_Juridica = "F";
            Fantasia = "";
            Endereco = "";
            Complemento = "";
            Bairro = "";
            Cidade = "";
            Estado = "";
            Cep = "";
            NumRua = "0";
            CNPJ = "";
            Inscricao = "";
            InscricaoMunicipal = "";
            Fone1 = "";
            Fone2 = "";
            TemConta = 0;
            DiaFechamentoConta = "1";
            CompraParcelado = 0;
            Email = "";
            EmailFinanceiro = "";
            LimiteCredito = "0";
            Rua_Proxima1 = "";
            Rua_Proxima2 = "";
            OperacaoPadraoSaida = "0";
            OperacaoPadraoEntrada = "0";
            Observacoes = "";

        }

        public string Codigo { get; set; }
        public int Ativo { get; set; }
        public string Tipo { get; set; }
        public string Fisica_Juridica { get; set; }
        public string Nome { get; set; }
        public string Fantasia { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string NumRua { get; set; }
        public string CNPJ { get; set; }
        public string Inscricao { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string Fone1 { get; set; }
        public string Fone2 { get; set; }
        public int TemConta { get; set; }
        public string DiaFechamentoConta { get; set; }
        public int CompraParcelado { get; set; }
        public string Email { get; set; }
        public string EmailFinanceiro { get; set; }
        public string LimiteCredito { get; set; }
        public string Rua_Proxima1 { get; set; }
        public string Rua_Proxima2 { get; set; }
        public string OperacaoPadraoSaida { get; set; }
        public string OperacaoPadraoEntrada { get; set; }
        public string Observacoes { get; set; }
        public string FretePadrao { get; set; }
    }
}
