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

namespace Tarefinha_Farmacia
{
    public partial class frmMedicamentos : Form
    {
        public frmMedicamentos()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
        }

        // Fabricante
        private void mskCNPJOTO_Validating(object sender, CancelEventArgs e)
        {
            string cnpjoto = "";

            foreach (char c in mskCNPJOTO.Text)
            {
                if (char.IsNumber(c))
                    cnpjoto += c;
            }

            if (string.IsNullOrEmpty(cnpjoto))
            {
                e.Cancel = true;
                errorProvider1.SetError(mskCNPJOTO, "Preencha o CNPJ.");
            }
            else if (cnpjoto.Length != 14)
            {
                e.Cancel = true;
                errorProvider1.SetError(mskCNPJOTO, "Preencha com 14 digitos.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mskCNPJOTO, "");
            }
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                //Marca que a execução da rotina precisa ser cancelada
                e.Cancel = true;
                errorProvider1.SetError(txtNome, "Preencha o nome.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNome, "");
            }
        }

        // Produto
        private void mskCod_Barras_Validating(object sender, CancelEventArgs e)
        {
            string Cod = "";
            foreach (char i in mskCod_Barras.Text)
            {
                if (char.IsNumber(i))
                    Cod += i;
            }

            if (string.IsNullOrEmpty(Cod))
            {

                e.Cancel = true;

                errorProvider1.SetError(mskCod_Barras, "Informe o Código de Barras");
            }
            else if (Cod.Length != 13)
            {
                e.Cancel = true;
                errorProvider1.SetError(mskCod_Barras, "São 13 digitos!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mskCod_Barras, "");
            }
        }

        private void txtDescricao_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescricao, "Preencha a Descrição.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDescricao, "");
            }
        }

        private void mskPreco_Validating(object sender, CancelEventArgs e)
        {
            string Preco = "";
            foreach (char i in mskPreco.Text)
            {
                if (char.IsNumber(i))
                    Preco += i;
            }

            if (string.IsNullOrEmpty(Preco))
            {
                e.Cancel = true;

                errorProvider1.SetError(mskPreco, "Informe o preço");
            }
            else if (int.Parse(Preco) <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(mskPreco, "Não é possivel registrar");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mskPreco, "");
            }
        }

        // Medicamentos
        private void txtPrincipio_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrincipio.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPrincipio, "Preencha a Principio Activo.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPrincipio, "");
            }
        }

        private void txtQtd_Validating(object sender, CancelEventArgs e)
        {
            string Qtd = "";
            foreach (char i in txtQtd.Text)
            {
                if (char.IsNumber(i))
                    Qtd += i;
            }

            if (string.IsNullOrEmpty(Qtd))
            {

                e.Cancel = true;

                errorProvider1.SetError(txtQtd, "Informe a Quantidade:");
            }
            else if (Qtd.Length != 13)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtQtd, "O limite é R$ 9999,99!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtQtd, "");
            }
        }

        // Botões
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren
               (ValidationConstraints.Enabled))
            {
                MessageBox.Show("Registro salvo com Sucesso!", "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "É nescessario o preenchimento " + "correto de todos os campos.", "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

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

            if (!ValidarDiretorio())
                return;

            File.AppendAllText(diretorioCompleto, mskCNPJOTO.Text + Environment.NewLine);
            File.AppendAllText(diretorioCompleto, txtNome.Text + Environment.NewLine);
            File.AppendAllText(diretorioCompleto, mskCod_Barras.Text + Environment.NewLine);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskCNPJOTO.Text = string.Empty;
            txtNome.Text = string.Empty;

            mskCod_Barras.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            mskPreco.Text = string.Empty;

            txtPrincipio.Text = string.Empty;
            txtQtd.Text = string.Empty;

            txtCaminho.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente descartar as alterações?", "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) ==
                DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = folderBrowserDialog1.ShowDialog();

            if (resultado == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
            {
                txtCaminho.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        bool ValidarDiretorio()
        {
            // Recuperar os dados informados pelo usuario (string)
            string diretorio = txtCaminho.Text;
            string nomeArquivo = mskCNPJOTO.Text;

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

        string GetDiretorioCompleto()
        {
            // Diretório + Nome + Extensão
            // C:
            // Teste
            // .txt
            // C:/Teste.txt
            return
                Path.Combine(txtCaminho.Text, mskCNPJOTO.Text + "");
        }
    }
}
