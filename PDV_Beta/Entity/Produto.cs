using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.Entity
{
    public class Produto
    {
        public int Ativo { get; set; }
        public string Codigo { get; set; }
        public int Fracionado { get; set; }
        public int Tipo { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public string Unidade_Venda { get; set; }
        public string Codigo_Fornecedor { get; set; }
        public string Fabricante { get; set; }
        public string Foto { get; set; }
        public string Peso { get; set; }
        public string Obs { get; set; }
        public string Preco1 { get; set; }
        public string Preco2 { get; set; }
        public string Preco3 { get; set; }
        public string Custo { get; set; }
        public string QTD { get; set; }


        public Produto()
        {
            Ativo = 1;
            Codigo = "";
            Fracionado = 1;
            Tipo = 1;
            Nome = "";
            Estoque = 1;
            Unidade_Venda = "Un";
            Codigo_Fornecedor = "";
            Fabricante = "";
            Foto = "";
            Peso = "0";
            Obs = "";
            Preco1 = "0";
            Preco2 = "0";
            Preco3 = "0";
            Custo = "0";
            QTD = "0";
        }  
    }
}
