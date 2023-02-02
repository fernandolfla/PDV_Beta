using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.Entity
{
    public class Entradas
    {
        public int Id { get; set; }
        public int Ativo { get; set; }
        public string NumNota { get; set; }
        public int Filial { get; set; }
        public string Data { get; set; }
        public string Cod_Operacao { get; set; }
        public string Fornecedor { get; set; }
        public string Observacoes { get; set; }
        public decimal Produtos { get; set; }
        public decimal Descontos { get; set; }
        public decimal Frete { get; set; }
        public decimal Total { get; set; }
        public int Efetivado_Estoque { get; set; }
        public int Nota_Cancelada { get; set; }
        public string Transportadora { get; set; }
        public decimal Peso_bruto { get; set; }
        public int Volumes { get; set; }
        public string Motivo_Cancelamento { get; set; }
        public string Usuario_Cancelamento { get; set; }

        public string NomeFornecedor { get; set; }

        public List<Entradas_Produtos> listagrid { get; set; }
        
    }
}
