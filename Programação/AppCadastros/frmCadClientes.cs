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
    public partial class frmCadClientes : Form
    {
        public frmCadClientes()
        {
            InitializeComponent();

            // Iremos desativar a validação automatica
            AutoValidate = AutoValidate.Disable;
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            // Nesse evento queremos validar o campo txtNome

            // Validar se o campo está preenchido

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                // Caso o campo esteja vazio
                // sera cancelado a operação da tela
                // Ou seja, irei cancelar o processo
                // de cadastro do registro
                e.Cancel = true;

                // Definir a mensagem a ser exibida
                // Vincular o campo na mensagem

                errorProvider1.SetError(txtNome, "Preencha o nome.");
            }
            else
            {
                // Aqui resetamos a modificação de erro

                // Cancelar o cancelamento
                e.Cancel = false;

                //Resetar a mensagem
                errorProvider1.SetError(txtNome, "");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(
                "É necessário o preenchimento" +
                "de todos os campos, obrigatórios",
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
            }
            else
            {
                MessageBox.Show("Registro salvo com sucesso");
            }

        }



    }
}