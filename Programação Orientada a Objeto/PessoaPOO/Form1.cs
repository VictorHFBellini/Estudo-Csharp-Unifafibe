using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PessoaPOO
{
    public partial class Form1 : Form
    {
        // Criar uma instancia global
        // para acessar a classe de manipulation
        UsuarioExecucao usuarioExecucao = new UsuarioExecucao();
        public Form1()
        {
            InitializeComponent();
        }

        private void AdicionarUsuario()
        {
            // Variaveis auxiliares para cada campo
            string cpf, nome, email, senha;
            DateTime dtnascimento;

            // Iremos popular as variaveis
            // de acordo as informações
            // inseridas pelo usuario final

            cpf = txtCPF.Text;
            nome = txtNome.Text;
            email = txtEmail.Text;
            senha = txtSenha.Text;
            dtnascimento = dtpDataNascimento.Value;

            // VAlidação simples
            // apenas de exemplo

            if(string.IsNullOrEmpty(cpf) && string.IsNullOrEmpty(nome))
                return; // aborta a execução

            // Criamos a instancia das classes
            Usuario usuario = new Usuario();
            Pessoa pessoa = new Pessoa();

            // Popular o objeto pessoa
            pessoa.Nome = nome;
            pessoa.CPF = cpf;
            pessoa.DtNascimento = dtnascimento;

            // Popular objeto usuario
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.Pessoa = pessoa;

            // Aqui finalizamos a atribuição de valores
            // Agora precisamos manipular os registros
            usuarioExecucao.Adicionar(usuario);
            // Nesse momento o objeto usuario
            // já foi adicionado a lista

            // Atualizar a listbox para exibir
            // os registros
            AtualizarListaUsuarios();

            // Após inserir os dados
            // vamos limpar os campos
            txtCPF.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            dtpDataNascimento.Value = DateTime.Now;
        }

        // Método atualizar o Listbox

        private void AtualizarListaUsuarios()
        {
            // Limpar listbox
            lsbUsuarios.DataSource = null;
            //Vou popular a listbox com
            // a listaUsuarios
            lsbUsuarios.DataSource =
                usuarioExecucao.ListarUsuarios();

            // Definir qual execução será exibida
            lsbUsuarios.DisplayMember = "NomeEmail";
        }

        // Método para remover um registro na lista
        private void RemoverUsuario()
        {
            // Primeiro identificar o registro selecionado na listbox
            Usuario usuarioSelecionado =
                lsbUsuarios.SelectedItem as Usuario;
            
            // Após coletar o objeto preciso validar se está nulo
            if(usuarioSelecionado != null)
            {
                // Se for diferente de nulo posso remove-lo
                usuarioExecucao.Remover(usuarioSelecionado);

                AtualizarListaUsuarios();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarUsuario();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            RemoverUsuario();
        }

        // Método para exibir os detalhes do registro selecionado
        private void ExibirUsuario()
        {
            Usuario usuarioSelecionado =
                lsbUsuarios.SelectedItem as Usuario;

            if(usuarioSelecionado != null)
            {
                txtVisCPF.Text = usuarioSelecionado.Pessoa.CPF;
                txtVisNome.Text = usuarioSelecionado.Pessoa.Nome;
                txtVisDtNac.Text = usuarioSelecionado.Pessoa.DtNascimento.ToShortDateString();
                txtVisIdade.Text = usuarioSelecionado.Pessoa.Idade.ToString();
                txtVisEmail.Text = usuarioSelecionado.Email;
                txtVisSenha.Text = usuarioSelecionado.Senha;
            }
        }

        private void lsbUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ExibirUsuario();
        }
    }
}