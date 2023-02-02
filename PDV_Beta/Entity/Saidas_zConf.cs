using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.Entity
{
    public class Saidas_zConf
    {
        public int Id { get; set; }
        public string CFOP { get; set; }
        public string ClientePadrao { get; set; }
        public int ClientePadraoAtivo { get; set; }
        public string Nome { get; set; }
        public string ClientePadraoNome { get; set; }
        public int TabelaPadrao { get; set; }

    }
}
