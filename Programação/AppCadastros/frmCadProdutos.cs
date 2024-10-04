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
    public partial class frmCadProdutos : Form
    {
        private object errProvider;
        public frmCadProdutos()
        {
            InitializeComponent();

            // Iremos desativar a validação automatica
            AutoValidate = AutoValidate.Disable;
        }

        private void txtDescricao_Validating(object sender, CancelEventArgs e)
        {
            // Validar se o campo (DESCRIÇÃO), está preenchido.

            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                // Criar a notificação para o Usuário.
                e.Cancel = true;

                errorProvider1.SetError(txtDescricao, "Informe a descrição do Produto");
            }
            else
            {
                //Desabilitar a notificação
                e.Cancel = false;

                errorProvider1.SetError(txtDescricao, "");
            }
        }

        private void txtCodBarras_Validating(object sender, CancelEventArgs e)
        {
            string Luquinhas = "";
            foreach (char i in txtCodBarras.Text)
            {
                if (char.IsNumber(i))
                Luquinhas += i;
            }

            if (string.IsNullOrEmpty(Luquinhas))
            {
                // Criar a notificação para o Usuário.
                e.Cancel = true;

                errorProvider1.SetError(txtCodBarras, "Informe o Código de Barras");
            }
            else if (Luquinhas.Length != 13)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCodBarras, "Informe o Código de Barras");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(txtCodBarras, "");
            }
        }

        private void cboUnidade_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cboUnidade.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(cboUnidade, "Selecione uma Unidade.");
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(cboUnidade, "");
            }
        }



        private void cboGrupo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cboGrupo.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(cboGrupo, "Selecione uma Unidade.");
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(cboGrupo, "");
            }
        }

        private void txtPrecoVenda_Validating(object sender, CancelEventArgs e)
        {
            string Preco = "";
            foreach (char i in txtPrecoVenda.Text)
            {
                if (char.IsNumber(i))
                    Preco += i;
            }

            if (string.IsNullOrEmpty(Preco))
            {
                // Criar a notificação para o Usuário.
                e.Cancel = true;

                errorProvider1.SetError(txtPrecoVenda, "Informe o valor da Venda");
            }
            else if (int.Parse(Preco) <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPrecoVenda, "Não é possivel registrar");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPrecoVenda, "");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren
                (ValidationConstraints.Enabled))
            {
                MessageBox.Show("Registro salvo com Sucesso!", "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
            else
            {
                MessageBox.Show(
                    "É nescessario o preenchimento " + "correto de todos os campos.", "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
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

        private void cboUnidade_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }
    }
}
