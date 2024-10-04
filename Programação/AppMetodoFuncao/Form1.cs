using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMetodoFuncao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIf_Click(object sender, EventArgs e)
        {
            string opcao;

            if (cbbOpcao.SelectedIndex == 0)
                opcao = "Primeiro item selecionado";
            else if (cbbOpcao.SelectedIndex == 1)
                opcao = "Segundo item selecionado";
            else if (cbbOpcao.SelectedIndex == 2)
                opcao = "Terceiro item selecionado";
            else if (cbbOpcao.SelectedIndex == 3)
                opcao = "Quarto item selecionado";
            else
                opcao = "Nenhum selecionado";
            MessageBox.Show(opcao);
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            string opcao;

            switch (cbbOpcao.SelectedIndex)
            {
                case 0:
                    opcao = "Primeiro Item";
                    break;
                case 1:
                    opcao = "Segundo Item";
                    break;
                case 2:
                    opcao = "Terceiro Item";
                    break;
                case 3:
                    opcao = "Quarto Item";
                    break;
                default:
                    opcao = "Nenhum Selecionado";
                    break;
            }

            MessageBox.Show(opcao);
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            MetodoSomar();
        }

        // Método
        //Void - não retorna nada

        void MetodoSomar()
        {
            int v1, v2, resultado;

            v1 = int.Parse(txtV1.Text);
            v2 = int.Parse(txtV2.Text);

            resultado = v1 + v2;

            MessageBox.Show("O resultado da soma é:" + resultado.ToString());
        }

        // Função
        // int define o tipo de retorno
        // obrigatório usar a palavra return

        int FuncaoSomar()
        {
            int v1, v2;

            v1 = int.Parse(txtV1.Text);
            v2 = int.Parse(txtV2.Text);

            return v1 + v2;
        }

        private void btnFuncao_Click(object sender, EventArgs e)
        {
            int resultado;
            resultado = FuncaoSomar();

            MessageBox.Show("O resultado é: " + resultado);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Calcular(int.Parse(txtV1.Text), int.Parse(txtV2.Text), txtOperacao.Text).ToString();
        }

        int Calcular(int v1, int v2, string operacao)
        {
            switch (operacao)
            {
                case "+": return v1 + v2;
                case "-": return v1 - v2;
                case "*": return v1 * v2;
                case "/": return v1 / v2;
                default: return 0;
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Calcular(2, 2, "*").ToString();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Calcular(int.Parse(txtV1.Text), int.Parse(txtV2.Text), "+").ToString();
        }

        private void bntIniciar_Click(object sender, EventArgs e)
        {

        }

        private void bntFor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                lstFor.Items.Add(i.ToString());
            }
        }

        private async void bntWhile_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 10)
            {
                lstFor.Items.Add(i.ToString());
                await Task.Delay(500);
                i++;
            }
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            lstFor.Items.Clear();
        }

        private void bntSonumero_Click(object sender, EventArgs e)
        {
            txtSonumero.Text = SoNumero(txtValor.Text).ToString();
        }

        int SoNumero(string valor)
        {
            string resultado = "";

            for(int i = 0; i < valor.Length; i++) 
            {
                if (char.IsDigit(valor[i])) // !Char.IsDigit = Mostra só letras
                    resultado += valor[i];
            }

            return int.Parse(resultado);
        }

        private void bntSoletra_Click(object sender, EventArgs e)
        {
            txtSonumero.Text = SoLetra(txtValor.Text);
        }

        string SoLetra(string valor)
        {
            // Criei uma variável auxiliar
            // que vai receber o texto final
            // Já início a variável como vazia

            string resultado = "";

            // Um laço de repetição, passando
            // por cara caracter do texto
            // Ex: V1ct0r
            // Possui 5 caracteres
            // Onde cada passado o loop
            // passará por um caracter

            for (int i = 0; i < valor.Length; i++)
            {
                // Verificar se o caracter é um digito
                // Se For digito é número
                // Se não é letra
                // Onde o Vaalor[i]
                // o caracter na posição do loop
                // Ou seja se estamos no loop 3
                // i = 3
                // Recuperamos o t de v1ct0r

                // Nesse estou negando com "!"
                // Pois eu quero o caracter diferente
                // de número

                if (!char.IsDigit(valor[i])) // !Char.IsDigit = Mostra só letras
                    resultado += valor[i];
            }

            // ao terminar o loop o texto sem número, de v1ct0r
            // retorna VCTR
            return resultado;
        }
    }
}