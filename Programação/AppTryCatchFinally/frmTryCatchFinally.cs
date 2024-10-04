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

namespace AppTryCatchFinally
{
    public partial class frmTryCatchFinally : Form
    {
        public frmTryCatchFinally()
        {
            InitializeComponent();
        }

        private void btnTome_Click(object sender, EventArgs e)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader("Luquinhas.txt");
                string content = reader.ReadToEnd();
                MessageBox.Show(content, "Conteúdo do Arquivo");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Erro: Arquivo não encontrado.\nDetalhes do erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Erro: Ocorreu um erro de E/S.\nDetalhes do erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: Ocorreu um erro inesperado.\nDetalhes do erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
    }
}
