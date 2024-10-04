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
    public partial class frmMedicamentos : Form
    {
        public frmMedicamentos()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
        }

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
                e.Cancel = true;
                errorProvider1.SetError(txtNome, "Preencha o nome.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNome, "");
            }
        }

        private void mskCod_Validating(object sender, CancelEventArgs e)
        {
            string Cod = "";
            foreach (char i in mskCod.Text)
            {
                if (char.IsNumber(i))
                    Cod += i;
            }

            if (string.IsNullOrEmpty(Cod))
            {

                e.Cancel = true;

                errorProvider1.SetError(mskCod, "Informe o Código de Barras");
            }
            else if (Cod.Length != 13)
            {
                e.Cancel = true;
                errorProvider1.SetError(mskCod, "São 13 digitos!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mskCod, "");
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

                errorProvider1.SetError(mskPreco, "Informe o valor!");
            }
            else if (int.Parse(Preco) <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(mskPreco, "Somente Números!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mskPreco, "");
            }
        }

        private void txtPrincipio_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrincipio.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPrincipio, "Preencha a Principio Ativo.");
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

                errorProvider1.SetError(txtQtd, "Informe a Quantidade!");
            }
            else if (int.Parse(Qtd) <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtQtd, "Somente números!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtQtd, "");
            }
        }
        private void bntSALVAR_Click(object sender, EventArgs e)
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

            string diretorioCompleto = GetDiretorioCompleto();
            if (File.Exists(diretorioCompleto))
            {
                MessageBox.Show("O arquivo já existe!");
            }
            else
            {
                File.WriteAllText(diretorioCompleto, "");

                MessageBox.Show("Arquivo criado com sucesso!");
            }

            if (!ValidarDiretorio())
                return;

            File.AppendAllText(diretorioCompleto, mskCNPJOTO.Text + Environment.NewLine);
            File.AppendAllText(diretorioCompleto, txtNome.Text + Environment.NewLine);
            File.AppendAllText(diretorioCompleto, mskCod.Text + Environment.NewLine);
            File.AppendAllText(diretorioCompleto, txtDescricao.Text + Environment.NewLine);
            File.AppendAllText(diretorioCompleto, mskPreco.Text + Environment.NewLine);
            File.AppendAllText(diretorioCompleto, txtPrincipio.Text + Environment.NewLine);
            File.AppendAllText(diretorioCompleto, txtQtd.Text + Environment.NewLine);
        }

        private void bntLIMPAR_Click(object sender, EventArgs e)
        {
            mskCNPJOTO.Text = string.Empty;
            txtNome.Text = string.Empty;

            mskCod.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            mskPreco.Text = string.Empty;

            txtPrincipio.Text = string.Empty;
            txtQtd.Text = string.Empty;

            txtBusca.Text = string.Empty;
        }

        private void bntCANCELAR_Click(object sender, EventArgs e)
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

        private void btnSelecionarBusca_Click(object sender, EventArgs e)
        {
            DialogResult resultado = folderBrowserDialog1.ShowDialog();
            if (resultado == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
            {
                txtBusca.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        bool ValidarDiretorio()
        {
            string diretorio = txtBusca.Text;
            string nomeArquivo = mskCNPJOTO.Text;

            if (string.IsNullOrEmpty(diretorio) || string.IsNullOrEmpty(nomeArquivo))
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
                Path.Combine(txtBusca.Text, mskCNPJOTO.Text + ".txt");
        }
    }
}
