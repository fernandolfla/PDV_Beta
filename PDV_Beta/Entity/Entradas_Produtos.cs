using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.Entity
{
    public class Entradas_Produtos
    {
        public string Id { get; set; }
        public int Ativo { get; set; }
        public int Id_Entrada { get; set; }
        public int Linha { get; set; }
        public string Cod_Produto { get; set; }
        public string Nome_Produto { get; set; }
        public decimal Qtde { get; set; }
        public decimal PrecoUnit { get; set; }
        public decimal Preco_Total { get; set; }
        public decimal Desconto_Total { get; set; }
        public decimal Preco_Final { get; set; }

    }
}
