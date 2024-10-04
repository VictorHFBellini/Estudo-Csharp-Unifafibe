using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefinha_Farmacia
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void brinquedosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedicamentos form = new frmMedicamentos();
            form.ShowDialog();
        }

        private void visualizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizar form = new frmVisualizar();
            form.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
