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

namespace PDV_Beta.Interface.Configuracao
{
    public partial class ConfTelaInicial : Form
    {
        //private string IMG_Inicial;
        XConfiguracoes conf = new XConfiguracoes();
        string foto;

        public ConfTelaInicial()
        {
            InitializeComponent();

            ConfTelaInicialBLL BLL = new ConfTelaInicialBLL();

            conf = BLL.Busca();

            if (conf != null)
            {
                pictureFotoInicio.ImageLocation = conf.Imagem;
                txtTitulo.Text = conf.Titulo;
                foto = conf.Imagem;
            }
            else
                foto = Environment.CurrentDirectory + "\\Imagens\\PIZZAIOLO.png";

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
            ConfTelaInicialBLL BLL = new ConfTelaInicialBLL();
            if (BLL.Atualiza(txtTitulo.Text, foto))
                MessageBox.Show("Atualizado com sucesso!");
            else
                MessageBox.Show("Erro ao Atualizar!");

            MensagemErro();
        }

        private void btnAddImagem_Click(object sender, EventArgs e)
        {
            //Copiar Imagem para local e jogar para imagem 

            OpenFileDialog BuscaIMG = new OpenFileDialog();
            BuscaIMG.Filter = "Imagem|*.jpg;*.png;*.png";
            try
            {
                if (BuscaIMG.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(BuscaIMG.FileName);

                    string origem = BuscaIMG.FileName;
                    string destino = string.Concat(Environment.CurrentDirectory + "\\Imagens\\", System.IO.Path.GetFileName(origem));

                    System.IO.File.Delete(destino);
                    System.IO.File.Copy(origem, destino);

                    ResizeIMG.ResizeImage(destino, destino, 400, 330);
                    //salvar Destino no banco =)
                    sr.Close();

                    pictureFotoInicio.ImageLocation = destino;

                    foto = destino;
                    //pictureProduto.ImageLocation = destino;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A imagem já existe na pasta com o mesmo nome, abra novamente e mude o nome. ERRO = " + ex);
            }
        }
    }
}
