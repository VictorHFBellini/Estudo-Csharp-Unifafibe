using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTipoDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliqueAqui_Click(object sender, EventArgs e)
        {
            int idade;

            string texto;

            idade = int.Parse(txtIdade.Text);

            /*
            if (idade >= 18)
                texto = "Você é maior de idade!";
            else
                texto = "Você é menor de idade!";
            */

            texto = idade >= 18 ? "Você é maior de idade!" : "Você é menor de idade!"; // If Ternário

            // Código para quebrar linha
            // \n
            // Environment.NewLine

            MessageBox.Show("Sua idade é: " + idade.ToString() + "\n" + texto); 
            // ToString transforma a String em texto
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            // string retorno;

            /*
            if (ckbBeber.Checked)
                retorno = "Sim";
            else
                retorno = "Não";
            */

            // retorno = ckbBeber.Checked ? "Sim" : "Não";

            MessageBox.Show("Você bebe? " + "\n" + "Resposta: " + (ckbBeber.Checked ? "Sim" : "Não"));
        }

        private void ckbBeber_CheckedChanged(object sender, EventArgs e)
        {
            lblRetorno.Text = ckbBeber.Checked ? "Sim" : "Não";
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckbSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar =! ckbSenha.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" && txtSenha.Text == "Admin")
                MessageBox.Show("Usuário Logado");
            else
                MessageBox.Show("Usuário Incorreto");
        }
    }
}
