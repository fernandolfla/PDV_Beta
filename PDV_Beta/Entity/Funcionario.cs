using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.Entity
{
    public class Funcionario
    {
        public Funcionario()
        {
            Sexo = "M";
            Admissao = "";
            Nascimento = "";
            Endereco = "";
            Bairro = "";
            Cidade = "";
            Estado = "";
            Cep = "";
            Telefone  = "";
            Cargo = "";
            Identidade = "";
            CPF = "";
            Carteira_Trabalho = "";
            Email = "";
            Filial_Todas = 1;
            Observacoes = "";
            Comissao_Venda = "0";
            Qtde_Filhos = "0";
            Estado_Civil = "";
            Celular = "";
            SuperUsuario = 1;
            PerCadastro = 0;
            PerMovimento = 0;
            PerFinanceiro = 0;
            PerConfiguracao = 0;
            Filial = "1";
            Salario = "0";
            Comissionado = 1;
            ProxFun = 0;
            NumRua = "0";

    }

        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Senha { get; set; }
        public int Ativo { get; set; }
        public string Sexo { get; set; }
        public string Admissao { get; set; }
        public string Nascimento { get; set; }
        public string Endereco { get; set; }
        public string Bairro  { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Cargo { get; set; }
        public string Identidade { get; set; }
        public string CPF { get; set; }
        public string Carteira_Trabalho { get; set; }
        public string Email { get; set; }
        public int Filial_Todas { get; set; }
        public string Observacoes { get; set; }
        public string Comissao_Venda { get; set; }
        public string Qtde_Filhos { get; set; }
        public string Estado_Civil { get; set; }
        public string Celular { get; set; }
        public int SuperUsuario { get; set; }
        public int PerCadastro { get; set; }
        public int PerMovimento { get; set; }
        public int PerFinanceiro { get; set; }
        public int PerConfiguracao { get; set; }
        public string Filial { get; set; }
        public string Salario { get; set; }
        public int Comissionado { get; set; }
        public int ProxFun { get; set; }
        public string  NumRua { get; set; }
    }

   
}
