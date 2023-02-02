using Impressora;
using PDV_Beta.BLL;
using PDV_Beta.Component;
using PDV_Beta.Entity;
using PDV_Beta.Interface.Ajuda;
using PDV_Beta.Interface.Configuracao;
using PDV_Beta.Interface.Movimento;
using PDV_Beta.Interface.Relatorios;
using PDV_Beta.Seguranca;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            CarregaPrincipal();

            ConfTelaInicialBLL BLL = new ConfTelaInicialBLL();
            XConfiguracoes conf = new XConfiguracoes();
            conf = BLL.Busca();

            if(conf != null)
            {
                lblTituloLogo.Text = conf.Titulo;
                pictureLogo.ImageLocation = conf.Imagem;
            }

            MensagemErro();


            IniciaImpressora();


            switch(LerArquivo.confi.Impressora)
            { //INTEIRO 0 = MP-20 TH, MP-2000 CI ou MP-2000 TH, 1 = MP-20 MI, MP-20 CI ou MP-20 S,
                //2 = Blocos térmicos (com comunicacao serial DTR/DSR), 3 = Bloco 112 mm, 4 = ThermalKiosk, 5 = MP-4000 TH, 7 = MP-4200 TH, 8 = MP-2500 TH 0 = Default
                case 0: txtImpressora.Text = "MP 20 TH/ MP-2000 CI/TH";
                    break;
                case 1: txtImpressora.Text = "MP 20 MI/CI/S";
                    break;
                case 2: txtImpressora.Text = "DTR/DSR";
                    break;
                case 3:
                    txtImpressora.Text = "Bloco 112mn";
                    break;
                case 4:
                    txtImpressora.Text = "ThermalKiosk";
                    break;
                case 5:
                    txtImpressora.Text = "MP-4000 TH";
                    break;
                case 6:
                    txtImpressora.Text = "ERRO NA IMPRESSORA";
                    break;
                case 7:
                    txtImpressora.Text = "MP-4200 TH";
                    break;
                case 8:
                    txtImpressora.Text = "MP-2500 TH";
                    break;
                default: txtImpressora.Text = "ERRO NA IMPRESSORA";
                    break;
            }
            
        }


        private void IniciaImpressora()
        {

            //MP2032.PrinterReset();

            MP2032.ConfiguraModeloImpressora(LerArquivo.confi.Impressora);
            MP2032.IniciaPorta("USB");

            //MP2032.PrinterReset();
        }

        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show(Erros.GetMensagemErro() + " " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }




        private void CarregaPrincipal()
        {
            txtUsuarioAtivo.Text = Autenticacao.GetNomeUsuario();
            txtFilialAtiva.Text = Autenticacao.GetNomeFilial();
            txtServidor.Text = Autenticacao.GetServidor();
            txtSerial.Text = Autenticacao.GetSerial();
            txtVersao.Text = Autenticacao.GetVersao();
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
        }

        private void menuCadClientes_Click(object sender, EventArgs e)
        {
            CadClientesFornecedores Cliente = new CadClientesFornecedores("","");
            Cliente.ShowDialog();
        }

        private void menuCadFuncionarios_Click(object sender, EventArgs e)
        {
            CadFuncionarios Funcionario = new CadFuncionarios();
            Funcionario.ShowDialog();
        }

        private void menuCadProdutos_Click(object sender, EventArgs e)
        {
            CadProdutos Produto = new CadProdutos();
            Produto.ShowDialog();
        }

        private void tipoTamanhoPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadProdutoTipoTamanhoPreco Tipo = new CadProdutoTipoTamanhoPreco();
            Tipo.ShowDialog();
        }

        private void menuCadCaixa_Click(object sender, EventArgs e)
        {
           

        }

        private void menuCadFiliais_Click(object sender, EventArgs e)
        {
            bool _found = false;
            foreach (Form _openForm in Application.OpenForms)
            {
                string i = _openForm.GetType().ToString();
                if (_openForm.GetType().ToString().Equals("PDV_Beta.Interface.CadFilial"))
                {
                    _openForm.Focus();
                    _found = true;
                }
            }
            if (!_found)
            {
                CadFilial filial = new CadFilial();
                filial.Show();
            }
        }

        private void menuCadastroDeCaixa_Click(object sender, EventArgs e)
        {
            bool _found = false;
            foreach (Form _openForm in Application.OpenForms)
            {
                string i = _openForm.GetType().ToString();
                if (_openForm.GetType().ToString().Equals("PDV_Beta.Interface.CadCaixa"))
                {
                    _openForm.Focus();
                    _found = true;
                }
            }
            if (!_found)
            {
                CadCaixa caixa = new CadCaixa();
                caixa.Show();
            }
        }

        private void menuEmpresa_Click(object sender, EventArgs e)
        {
            CadEmpresa empresa = new CadEmpresa();
            empresa.ShowDialog();
        }

        private void menuCadOperacoes_Click(object sender, EventArgs e)
        {
            CadOperacoes operacao = new CadOperacoes();
            operacao.ShowDialog();
        }

        private void menuEntradas_Click(object sender, EventArgs e)
        {
            bool _found = false;
            foreach (Form _openForm in Application.OpenForms)
            {
                string i = _openForm.GetType().ToString();
                if (_openForm.GetType().ToString().Equals("PDV_Beta.Interface.MovEntradas"))
                {
                    _openForm.Focus();
                    _found = true;
                }
            }
            if (!_found)
            {
                MovEntradas entrada = new MovEntradas();
                entrada.Show();
            }
        }

        private void vendaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Autenticacao.GetCaixa_Status())
            {              
                bool _found = false;
                foreach (Form _openForm in Application.OpenForms)
                {
                    string i = _openForm.GetType().ToString();
                    if (_openForm.GetType().ToString().Equals("PDV_Beta.Interface.MovSaidasCompleto"))
                    {
                        _openForm.Focus();
                        _found = true;
                    }
                }
                if (!_found)
                {
                    MovSaidasCompleto saida = new MovSaidasCompleto();
                    saida.Show();
                }
            } else
                MessageBox.Show("Para Vender é Necessario Abrir um caixa para seu usuário, Entre em 'Movimento' Após selecione 'Abrir / Fechar Caixa' e Abra um caixa");

        }

        private void menuAbriFechaCaixa_Click(object sender, EventArgs e)
        {
            MovCaixa caixa = new MovCaixa();
            caixa.ShowDialog();
        }

        private void telasDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfTelasVendas conf = new ConfTelasVendas();
            conf.ShowDialog();
        }

        private void vendaMercadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Autenticacao.GetCaixa_Status())
            {
                bool _found = false;
                foreach (Form _openForm in Application.OpenForms)
                {
                    string i = _openForm.GetType().ToString();
                    if (_openForm.GetType().ToString().Equals("PDV_Beta.Interface.Movimento.MovSaidasMercado"))
                    {
                        _openForm.Focus();
                        _found = true;
                    }
                }
                if (!_found)
                {
                    MovSaidasMercado saida = new MovSaidasMercado();
                    saida.Show();
                }
            }
            else
                MessageBox.Show("Para Vender é Necessario Abrir um caixa para seu usuário, Entre em 'Movimento' Após selecione 'Abrir / Fechar Caixa' e Abra um caixa");

        }

        private void vendaPiazzariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Autenticacao.GetCaixa_Status())
            {
                bool _found = false;
                foreach (Form _openForm in Application.OpenForms)
                {
                    string i = _openForm.GetType().ToString();
                    if (_openForm.GetType().ToString().Equals("PDV_Beta.Interface.Movimento.MovSaidasPizzaria"))
                    {
                        _openForm.Focus();
                        _found = true;
                    }
                }
                if (!_found)
                {
                    MovSaidasPizzaria saida = new MovSaidasPizzaria();
                    saida.Show();
                }
            }
            else
                MessageBox.Show("Para Vender é Necessario Abrir um caixa para seu usuário, Entre em 'Movimento' Após selecione 'Abrir / Fechar Caixa' e Abra um caixa");

        }

        private void relatorioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rel_Vendas rel = new Rel_Vendas();
            rel.ShowDialog();
        }

        private void relatórioDeCaixasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rel_Caixa_Atual rel = new Rel_Caixa_Atual();
            rel.ShowDialog();
        }

        private void relatórioDeEntregasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rel_Entregas rel = new Rel_Entregas();
            rel.ShowDialog();
        }

        private void telaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfTelaInicial conf = new ConfTelaInicial();
            conf.ShowDialog();
        }

        private void suporteELicençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuporteAjuda ajuda = new SuporteAjuda();
            ajuda.Show();
        }

        private void impressorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfImpressoras imp = new ConfImpressoras();
            imp.ShowDialog();
        }

        private void EncerraToasVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Realmente deseja encerrar todas as vendas? Na tela de saídas existe o botão 'RECEBER' para encerrar vendas \n Este processo prejudica" +
                "os relatórios e sua contabilidade, deseja continuar mesmo assim? ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {

                MovSaidasBLL BLL = new MovSaidasBLL();
                if (BLL.FechaVendasTodas())
                    MessageBox.Show("Todas as vendas foram fechadas");
                else
                    MessageBox.Show("Erro ao encerrar as vendas, tente novamente mais tarde ou contacte o suporte");
            }
            else
                MessageBox.Show("Encerre manualmente, qualquer duvida ligue para o suporte");




        }
    }
}
