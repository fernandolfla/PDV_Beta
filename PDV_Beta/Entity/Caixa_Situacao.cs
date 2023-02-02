using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.Entity
{
    public class Caixa_Situacao
    {
        public Caixa caixa = new Caixa();

        public string Id { get; set; }
        public string SituacaoNome { get; set; }
        public int SituacaoId { get; set; }
        public decimal ValorInicial { get; set; }
        public decimal TotalSaidas { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }


        

    }
}
