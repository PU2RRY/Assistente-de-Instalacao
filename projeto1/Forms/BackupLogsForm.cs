using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assistente_de_Instalação.Forms
{
    public partial class BackupLogsForm : Form
    {
        public BackupLogsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                DialogResult res = dialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string diretorio = dialog.SelectedPath;
                    tbCaminhoBkp.Text = diretorio;
                }
            }
        }

        private void tbCaminhoBkp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
