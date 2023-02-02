using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.Entity
{
    public class Caixa
    {
        public string Id { get; set; }
        public int Ativo { get; set; }
        public int Filial { get; set; }
        public string Nome { get; set; }
        public string Descicao { get; set; }
        public string Usuario { get; set; }

    }
}
