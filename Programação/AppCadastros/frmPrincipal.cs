using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCadastros
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Neste momento ao fechar a tela
            // será realizada uma mensagem
            // de confirmação de fechamento
            // para o usuário.

            // Encerrar a aplicação por completo.
            // Utilizar apenas na Tela Principal.
            //(Application.Exit();)

            // Encerra apenas o Forms
            // Utilizar apenas no Forms
            //Close(); 

            if (MessageBox.Show(
                "Deseja realmente sair?", // Mensagem
                "Atenção!", // Titulo Mensagem
                MessageBoxButtons.YesNo, // Definição de Botões
                MessageBoxIcon.Warning, // Icone da Mensagem
                MessageBoxDefaultButton.Button2 //Botão Padrão
                ) == DialogResult.No)
            {

                // Aqui no evento FormClossing
                // Precisamos cancelar o fechamento
                e.Cancel = true;

            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar a chamada de uma nova tela
            // Primeiro é preciso carregar a tela em memória

            // Definir o que será chamado
            // Definir a variavel que receberá a instancia
            // Criamos a instância em memôria

            // Utilizando a palavra NEW
            // para criar na memôria.

            frmCadClientes form = new frmCadClientes();

            // Utilizando a variável form
            // iremos apresentar a tela
            // para o usuario.

            // Será apresentado uma tela separada
            // da tela principal
            // podendo manipular a tela mãe
            // separa da tela filha
            //form.Show();

            // A tela é apresentada vinculada
            // a tela mãe
            // portanto não é possivel mexer
            // na tela mãe, enquanto a filha estiver
            // sendo apresentada
            form.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadProdutos form = new frmCadProdutos();

            form.ShowDialog();
        }
    }
}
