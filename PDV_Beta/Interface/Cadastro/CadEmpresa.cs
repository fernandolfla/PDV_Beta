using PDV_Beta.BLL;
using PDV_Beta.Component;
using PDV_Beta.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV_Beta.Interface
{
    public partial class CadEmpresa : Form
    {
        public CadEmpresa()
        {
            InitializeComponent();

            CadEmpresaBLL BLL = new CadEmpresaBLL();
            Empresa empresa = new Empresa();
            empresa = BLL.Busca();
            if (empresa != null)
                EntityToTela(empresa);
            else MessageBox.Show("Erro ao consultar Banco de Dados");

            MensagemErro();

    }
        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show(Erros.GetMensagemErro() + " " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Empresa emp = new Empresa();
            CadEmpresaBLL BLL = new CadEmpresaBLL();
            emp = TelaToEntity();

            if(BLL.Atualiza(emp))
                MessageBox.Show("Cadastro Atualizado");
            else MessageBox.Show("Falha ao Atualizar, confira os dados corretamente");
  
            MensagemErro();
        }



        private Empresa TelaToEntity()
        {
            Empresa emp = new Empresa();

            emp.Razao = txtRazao.Text;
            emp.Fantasia = txtFantasia.Text;
            emp.Endereco = txtEndereco.Text;
            emp.Complemento = txtComplemento.Text;
            emp.Bairro = txtBairro.Text;
            emp.Cidade = txtCidade.Text;
            emp.Estado = txtEstado.Text;
            emp.Cep = txtCep.Text;
            emp.NumRua = txtNumRua.Text;
            emp.CNPJ = txtCNPJ.Text;
            emp.Inscricao = txtInscricao.Text;
            emp.InscricaoMunicipal = txtInscricaoMunicipal.Text;
            emp.Fone1 = txtTelefone.Text;
            emp.Fone2 = txtTelefone2.Text;
            emp.Email = txtEmail.Text;
            emp.Rua_Proxima1 = txtRuaProx.Text;
            emp.Rua_Proxima2 = txtReferencia.Text;
            emp.Observacoes = txtObservacoes.Text;

            return emp;
        }

        public void EntityToTela(Empresa emp)
        {

            txtRazao.Text = emp.Razao;
            txtFantasia.Text = emp.Fantasia;
            txtEndereco.Text = emp.Endereco;
            txtComplemento.Text = emp.Complemento;
            txtBairro.Text = emp.Bairro;
            txtCidade.Text = emp.Cidade;
            txtEstado.Text = emp.Estado;
            txtCep.Text = emp.Cep;
            txtNumRua.Text = emp.NumRua;
            txtCNPJ.Text = emp.CNPJ;
            txtInscricao.Text = emp.Inscricao;
            txtInscricaoMunicipal.Text = emp.InscricaoMunicipal;
            txtTelefone.Text = emp.Fone1;
            txtTelefone2.Text = emp.Fone2;
            txtEmail.Text = emp.Email;
            txtRuaProx.Text = emp.Rua_Proxima1;
            txtReferencia.Text = emp.Rua_Proxima2;
            txtObservacoes.Text = emp.Observacoes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscaCep busca = new BuscaCep(null, null, this,null,null);

            busca.ShowDialog();
        }
    }
}
