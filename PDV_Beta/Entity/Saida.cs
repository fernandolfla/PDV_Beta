using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.Entity
{
    public class Saida
    {
        public List<Saida_Produtos> Lista_produtos = new List<Saida_Produtos>();
        public string Id { get; set; }
        public int Ativo { get; set; }
        public string NumNota { get; set; }
        public string Comanda { get; set; }
        public string Mesa { get; set; }
        public string Painel { get; set; }
        public int Filial { get; set; }
        public DateTime Data { get; set; }
        public string CFOP { get; set; }
        public int Caixa { get; set; }
        public string Cliente { get; set; }
        public string CPF { get; set; }
        public string Vendedor { get; set; }
        public string Observacoes { get; set; }
        public decimal Produtos { get; set; }
        public decimal Desconto { get; set; }
        public decimal Frete { get; set; }
        public decimal Total { get; set; }
        public int Efetivada_estoque { get; set; }
        public int Efetivada_Financ { get; set; }
        public int Nota_Impressa { get; set; }
        public int Nota_cancelada { get; set; }
        public int Tiket_Impresso { get; set; }
        public decimal Recebe_Dinheiro { get; set; }
        public decimal Recebe_Credito_Cliente { get; set; }
        public decimal Recebe_Cartao_Debito { get; set; }
        public decimal Recebe_cartao_Credito { get; set; }
        public decimal Recebe_Cartao_Convenio { get; set; }
        public decimal Recebe_Total { get; set; }
        public string Endereco_Entrega { get; set; }
        public string Complemento_Entrega { get; set; }
        public string Cidade_Entrega { get; set; }
        public string Estado_Entrega { get; set; }
        public string Bairro_Entrega { get; set; }
        public string CEP_Entrega { get; set; }
        public string Transportadora { get; set; }
        public decimal Peso { get; set; }
        public int Volumes { get; set; }
        public DateTime Data_Nota_Impressa { get; set; }
        public string Motivo_cancelamento { get; set; }
        public string Usuario_Cancelamento { get; set; }
        public int ParaEntrega { get; set; }
        public string NumRua_Entrega { get; set; }

        public decimal Troco_Entrega { get; set; }
        public string Pagamento_Entrega { get; set; }


        //SOMENTE CONSULTA EM SAIDAS

        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public int TabelaPreco { get; set; }
        public int Result { get; set; }
        public string NomeCliente { get; set; }
        public string NomeTransportadora { get; set; }
        public string NomeVendedor { get; set; }

        public Saida()
        {
            Recebe_Cartao_Convenio = 0;
            Recebe_cartao_Credito = 0;
            Recebe_Cartao_Debito = 0;
            Recebe_Credito_Cliente = 0;
            Recebe_Dinheiro = 0;
        }

        
    }
}
