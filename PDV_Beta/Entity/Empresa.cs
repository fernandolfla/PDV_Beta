using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.Entity
{
    public class Empresa
    {
        public int Ativo { get; set; }
        public string Razao { get; set; }
        public string Fantasia { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string NumRua { get; set; }
        public string Rua_Proxima1 { get; set; }
        public string Rua_Proxima2 { get; set; }
        public string CNPJ { get; set; }
        public string Inscricao { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string Fone1 { get; set; }
        public string Fone2 { get; set; }
        public string Email { get; set; }
        public string Observacoes { get; set; }

        public Empresa()
        {
            Ativo = 1;
            NumRua = "0";
        }

    }
}
