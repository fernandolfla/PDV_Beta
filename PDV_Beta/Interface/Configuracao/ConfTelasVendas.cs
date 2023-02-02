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
    public partial class ConfTelasVendas : Form
    {
        private int indice = 1;
        private int Id;
        public ConfTelasVendas()
        {
            InitializeComponent();
            MovSaidasBLL BLL = new MovSaidasBLL();

            List<Operacoes> CFOP = new List<Operacoes>();
            CFOP = BLL.ListaOperacoes();

            if (CFOP != null)
            {
                foreach (Operacoes op in CFOP)
                {
                    if (op.Tipo == 1)
                        comboOperacao.Items.Add(op.CFOP);
                }
            }

            ConfTelasVendasBLL BLL2 = new ConfTelasVendasBLL();
            Saidas_zConf conf = new Saidas_zConf();
            conf = BLL2.Busca(1);

            if (conf != null)
                EntityToTela(conf);

            Id = 1;
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
            ConfTelasVendasBLL BLL2 = new ConfTelasVendasBLL();
            if(BLL2.Atualiza(TelaToEntity()))
            {
                MessageBox.Show("Atualizado");
            }
            else
                MessageBox.Show("Problema ao gravar");
            MensagemErro();
        }

      
        private void EntityToTela(Saidas_zConf conf)
        {
            Id = conf.Id;
            txtNome.Text = conf.Nome;
            comboOperacao.SelectedItem = conf.CFOP;
            txtCodCliente.Text = conf.ClientePadrao;
            txtNomeCliente.Text = conf.ClientePadraoNome;
            if(conf.ClientePadraoAtivo == 1)
                checkClientePadrao.Checked = true;
            else checkClientePadrao.Checked = false;
            comboTabelaPreco.SelectedIndex = (conf.TabelaPadrao - 1);
        }

        private Saidas_zConf TelaToEntity()
        {
            Saidas_zConf conf = new Saidas_zConf();

            conf.Id = Id;
            conf.CFOP = comboOperacao.Text;
            conf.ClientePadrao = txtCodCliente.Text;
            conf.ClientePadraoNome = txtNomeCliente.Text;
            if(checkClientePadrao.Checked)
                conf.ClientePadraoAtivo = 1;
            else conf.ClientePadraoAtivo = 0;
            conf.TabelaPadrao = (comboTabelaPreco.SelectedIndex + 1);

            return conf;
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            BuscaClienteFornecedor busca = new BuscaClienteFornecedor(null,null,null,0, null);
            busca.ShowDialog();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                if (indice > 1)
                    indice--;
                ConfTelasVendasBLL BLL2 = new ConfTelasVendasBLL();
                Saidas_zConf conf = new Saidas_zConf();
                conf = BLL2.Busca(indice);

                if (conf != null)
                    EntityToTela(conf);
            }
            MensagemErro();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (indice <= 3)
            {
                if (indice < 3)
                    indice++;
                ConfTelasVendasBLL BLL2 = new ConfTelasVendasBLL();
                Saidas_zConf conf = new Saidas_zConf();
                conf = BLL2.Busca(indice);

                if (conf != null)
                    EntityToTela(conf);
               
            }
            MensagemErro();
        }

        private void btnBuscaCliente_Click_1(object sender, EventArgs e)
        {
            BuscaClienteFornecedor busca = new BuscaClienteFornecedor(null,null,null,0,this);
            busca.ShowDialog();
        }
    }
}
