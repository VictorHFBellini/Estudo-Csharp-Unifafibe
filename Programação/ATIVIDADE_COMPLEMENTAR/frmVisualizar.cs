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

namespace ATIVIDADE_COMPLEMENTAR
{
    public partial class frmVisualizar : Form
    {
        public frmVisualizar()
        {
            InitializeComponent();
        }

        private void btnSelecionarBusca_Click(object sender, EventArgs e)
        {
            DialogResult resultado = folderBrowserDialog1.ShowDialog();
            if (resultado == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
            {
                txtBusca.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCARREGAR_Click(object sender, EventArgs e)
        {
            if (!ValidarDiretorio())
                return;

            string diretorioCompleto = GetDiretorioCompleto();
            if (!File.Exists(diretorioCompleto))
            {
                MessageBox.Show("Arquivo não Existe!");
            }
            else
            {
                ListaPedidos.Text = File.ReadAllText(diretorioCompleto);
                MessageBox.Show("Conteúdo Carregado!");
            }
        }

        bool ValidarDiretorio()
        {
            string diretorio = txtBusca.Text;

            if (string.IsNullOrEmpty(diretorio))
            {
                MessageBox.Show("Por favor, informar os dados corretamente!");
                return false;
            }

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
                Path.Combine(txtBusca.Text, txtNomeRep.Text + ".txt");
        }
    }
}
