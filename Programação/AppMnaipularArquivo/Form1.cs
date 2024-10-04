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

namespace AppMnaipularArquivo
{
    public partial class Form1 : Form
    {
        public Form1()
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

        //função para validar o diretório
        bool ValidarDiretorio()
        {
            // Recuperar os dados informados pelo usuario (string)
            string diretorio = txtCaminho.Text;
            string nomeArquivo = txtNome.Text;

            // Validar o preenchimento dos campos
            if (string.IsNullOrEmpty(diretorio) || string.IsNullOrEmpty(nomeArquivo))
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

        // função para retornar o diretorio completo
        string GetDiretorioCompleto()
        {
            // Diretório + Nome + Extensão
            // C:
            // Teste
            // .txt
            // C:/Teste.txt
            return
                Path.Combine(txtCaminho.Text, txtNome.Text + "");
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            // Antes de criar o arquivo precisamos validar o projeto
            // Se verdadeiro, OK || se falso temos problemas
            // interromper a execução
            if (!ValidarDiretorio())
                return;

            // Recuperar o diretório completo
            string diretorioCompleto = GetDiretorioCompleto();

            // Verificar se o arquivo existe
            if (File.Exists(diretorioCompleto))
            {
                MessageBox.Show("O arquivo já existe!");
            }
            else
            {
                // Criar arquivo vazio
                File.WriteAllText(diretorioCompleto, "");

                MessageBox.Show("Arquivo criado com sucesso!");
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!ValidarDiretorio())
                return;

            string diretorioCompleto = GetDiretorioCompleto();

            // Gravar o conteudo do textbox no arquivo
            // Todo o conteudo do arquivo será substituido
            // Sempre adicionaremos uma linha em branco ao final do arquivo
            // Environment.NewLine serve para quebrar/adicionar linhas
            File.WriteAllText(diretorioCompleto, txtTexto.Text + Environment.NewLine);

            MessageBox.Show("Dados gravados com sucesso!");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ValidarDiretorio())
                return;

            string diretorioCompleto = GetDiretorioCompleto();

            // Iremos adicionar o conteudo do textbox dentro do arquivo
            // Será adicionado o novo conteudo, dentro do conteudo já existente no arquivo
            File.AppendAllText(diretorioCompleto, txtTexto.Text + Environment.NewLine);

            MessageBox.Show("Dados adicionados com sucesso!");
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
