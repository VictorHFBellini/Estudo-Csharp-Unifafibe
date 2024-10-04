using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliação_Luquinhas
{
    public partial class frmVisualizarBrinquedos : Form
    {
        public frmVisualizarBrinquedos()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

            // Utilizar o componente Folder
            // para selecionar uma pasta de diretório
            // para o usuário e iremos coletar o resultado (Resolução)
            DialogResult resultado = folderBrowserDialog1.ShowDialog();

            // Verificar se foi escolhido o botão ok ou cancelado
            // se escolhido foi cancelar, iremos ignorar
            // se escolhido foi ok, iremos validar
            // após a validação e estiver tudo certo
            // iremos apresentar pro usuário
            if (resultado == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
            {
                txtCaminho.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        bool ValidarDiretorio()
        {
            // Recuperar os dados informados pelo usuario (string)
            string diretorio = txtCaminho.Text;
            string nomeArquivo = mksCNPJ.Text;

            // Validar o preenchimento dos campos
            if (string.IsNullOrEmpty(diretorio))
            {
                MessageBox.Show("Por favor, informar os dados corretamente!");

                // Encerrar a execução da rotina
                return false;
            }

            // Validar a existencia do diretorio
            // using System.IO
            if (!Directory.Exists(diretorio))
            {
                MessageBox.Show("O diretorio especificado não existe!");

                return false;
            }
            return true;
        }

        string GetDiretorioCompleto()
        {
            // Diretório + Nome + Extensão
            // C:
            // Teste
            // .txt
            // C:/Teste.txt
            return
                Path.Combine(txtCaminho.Text + ".txt");
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (!ValidarDiretorio())
                return;

            string diretorioCompleto = GetDiretorioCompleto();

            if (!File.Exists(diretorioCompleto))
            {
                MessageBox.Show("O arquivo não existe!");
            }
            else
            {
                // Iremos carregar o conteudo do arquivo
                txtArquivo.Text = File.ReadAllText(diretorioCompleto);

                MessageBox.Show("Conteudo carregado com sucesso!");
            }
        }
    }
}

