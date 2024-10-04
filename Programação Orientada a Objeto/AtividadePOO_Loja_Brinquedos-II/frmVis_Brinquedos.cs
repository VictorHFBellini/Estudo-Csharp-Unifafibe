using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadePOO_Loja_Brinquedos_II
{
    public partial class frmVis_Brinquedos : Form
    {
        private Brinquedo brinquedo1;
        public frmVis_Brinquedos(Brinquedo brinquedo)
        {
            InitializeComponent();
            brinquedo1 = brinquedo;
        }

        private void frmVis_Brinquedos_Load(object sender, EventArgs e)
        {
            txtNome_Fabricante.Text = brinquedo1.Produto.Fabricante.Nome;
            mtbCNPJOTO.Text = brinquedo1.Produto.Fabricante.CNPJOTO;
            mtbCod_Barras.Text = brinquedo1.Produto.Cod_Barras;
            txtDescricao.Text = brinquedo1.Produto.Descricao;
            mtbValor.Text = brinquedo1.Produto.Preco;
            txtCategoria.Text = brinquedo1.Categoria;
            txtIdade.Text = brinquedo1.IdadeMinima;
        }
    }
}
