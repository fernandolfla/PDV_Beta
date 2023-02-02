using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.Entity
{
    public class Saida_Produtos
    {
        public int ID { get; set; }
        public int Ativo { get; set; }
        public string ID_Saida { get; set; }
        public int Linha { get; set; }
        public string CodProduto { get; set; }
        public string NomeProduto { get; set; }
        public int Tabela_Preco { get; set; }
        public decimal Qtde { get; set; }
        public decimal Preco_Unit { get; set; }
        public decimal Preco_Total { get; set; }
        public decimal Desconto { get; set; }
        public decimal Preco_Final { get; set; }
        
    }
}
