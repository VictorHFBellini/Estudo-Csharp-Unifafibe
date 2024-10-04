using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTabuada_Victor_Bellini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Criando o Botão Calcular para executar a Tabuada
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txtTermino.Text != "" || txtInicio.Text != "")
            {
                if (Inteiros(txtTermino.Text) && Inteiros(txtInicio.Text) && Inteiros(txtIntervalo.Text))
                {
                    int valorInicio = int.Parse(txtInicio.Text);
                    int valorTermino = int.Parse(txtTermino.Text);
                    int Intervalo = txtIntervalo.Text != "" ? int.Parse(txtIntervalo.Text) : 10;

                    if(ValidarIntervalo(valorInicio) && ValidarIntervalo(valorTermino) && ValidarIntervalo(Intervalo))
                    {
                        if(valorInicio < valorTermino)
                        {
                            MetodoTabuada(valorInicio, valorTermino, Intervalo);
                        }
                        else
                        {
                            MessageBox.Show("O valor Início tem que ser maior que o valor Término!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("O intervalo da Tabuada deve estar entre: 0 até 99!");
                    }
                }
                else
                {
                    MessageBox.Show("Apenas Números Inteiros e Sem Letras!");
                }
            }
            else
            {
                MessageBox.Show("Insira os Valores!");
            }
        }

        // Criação da Declaração de somente Inteiros
        bool Inteiros(string valor)
        {
            for(int i = 0; i < valor.Length; i++)
            {
                if (!char.IsDigit(valor[i]))
                    return false;
            }
            return true;
        }

        // Validar se a Tabuada vai estar
        // dentro do Intervalo do código.
        bool ValidarIntervalo(int valor)
        {
            if(valor < 1 || valor > 99)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Criação do Metodo Tabuada para a execução da mesma
        void MetodoTabuada(int inicio, int termino,  int intervalo)
        {
            for(int i = inicio; i <= termino; i++)
            {
                lstTela.Items.Add($"Tabuada do {i}: ");

                for(int j = 1; j <= intervalo; j++)
                {
                    lstTela.Items.Add($"{i} X {j} = {i * j}");
                }

                lstTela.Items.Add("==============");
            }
        }

        // Criação do Botão Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtInicio.Text = string.Empty;
            txtTermino.Text = string.Empty;
            txtIntervalo.Text = string.Empty;
            lstTela.Items.Clear();
        }
    }
}