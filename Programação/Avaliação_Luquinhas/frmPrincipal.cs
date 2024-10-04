using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliação_Luquinhas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void brinquedosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBrinquedos form = new frmBrinquedos();
            form.ShowDialog();
        }

        private void visualizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizarBrinquedos form = new frmVisualizarBrinquedos();
            form.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
