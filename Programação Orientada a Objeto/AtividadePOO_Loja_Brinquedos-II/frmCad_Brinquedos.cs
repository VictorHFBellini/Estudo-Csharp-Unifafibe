using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadePOO_Loja_Brinquedos_II
{
    public partial class frmCad_Brinquedos : Form
    {
        Fabricante fabricante = new Fabricante();
        Produto produto = new Produto();
        BrinquedoExecucao brinquedoExecucao = new BrinquedoExecucao();
        public frmCad_Brinquedos()
        {
            InitializeComponent();
        }

        private void AdicionarBrinquedo()
        {
            string Nome_Fabri, CNPJOTO, Cod_Barras,
                Descricao, Valor, Categoria, Faixa_Etaria;

            Nome_Fabri = txtNome_Fabricante.Text;
            CNPJOTO = mtbCNPJOTO.Text;
            Cod_Barras = mtbCod_Barras.Text;
            Descricao = txtDescricao.Text;
            Valor = mtbValor.Text;
            Categoria = txtCategoria.Text;
            Faixa_Etaria = txtIdade.Text;

            if (string.IsNullOrEmpty(Nome_Fabri) && string.IsNullOrEmpty(CNPJOTO))
                return;

            Fabricante fabricante = new Fabricante();
            Produto produto = new Produto();
            Brinquedo brinquedo = new Brinquedo();

            fabricante.Nome = Nome_Fabri;
            fabricante.CNPJOTO = CNPJOTO;

            produto.Cod_Barras = Cod_Barras;
            produto.Descricao = Descricao;
            produto.Preco = Valor;
            produto.Fabricante = fabricante;

            brinquedo.Categoria = Categoria;
            brinquedo.IdadeMinima = Faixa_Etaria;
            brinquedo.Produto = produto;

            brinquedoExecucao.Adicionar(brinquedo);

            AtualizarListaBrinquedos();

            txtNome_Fabricante.Clear();
            mtbCNPJOTO.Clear();
            mtbCod_Barras.Clear();
            txtDescricao.Clear();
            mtbValor.Clear();
            txtCategoria.Clear();
            txtIdade.Clear();
        }

        private void AtualizarListaBrinquedos()
        {
            lsbBrinquedo.DataSource = null;
            lsbBrinquedo.DataSource =
                brinquedoExecucao.ListarBrinquedos();

            lsbBrinquedo.DisplayMember = "CodDescCatFabri";
        }

        private void RemoverBrinquedo()
        {
            Brinquedo brinquedoSelecionado =
                lsbBrinquedo.SelectedItem as Brinquedo;

            if (brinquedoSelecionado != null)
            {
                brinquedoExecucao.Remover(brinquedoSelecionado);
                AtualizarListaBrinquedos();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarBrinquedo();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            RemoverBrinquedo();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmVis_Brinquedos form = new frmVis_Brinquedos(lsbBrinquedo.SelectedItem as Brinquedo);
            form.ShowDialog();
        }
    }
}
