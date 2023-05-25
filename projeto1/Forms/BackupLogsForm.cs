using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;

namespace Assistente_de_Instalação.Forms
{
    public partial class BackupLogsForm : Form
    {
        //
        //Informe aquie os diretórios onde ficam os Logs no formato abaixo:
        //
        //[diretorio]#[descrição do log]
        //
        string[] caminhosDeLog =
        {
            @"C:\Vicommerce\Log#PDVeGerenciadorDeImpressao",
            @"C:\Vicommerce\Apis\GestorDePedidos\Logs#GestorDePedidos",
            @"C:\Vicommerce\Apis\IntegradorDePedidos\Logs#IntegradorDePedidos",
            @"C:\ApiComanda\Logs#ApiComanda",
            @"C:\VirtualDCS\Log#SincronizadorERP"
        };
        public BackupLogsForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                DialogResult res = dialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string diretorio = dialog.FileName;
                    tbCaminhoBkp.Text = diretorio;
                }
            }
        }
        public void CopyDirectory(string sourceDir, string destinoDir, bool recursive)
        {
            var dir = new DirectoryInfo(sourceDir);
            if (!dir.Exists)
                return;
            DirectoryInfo[] dirs = dir.GetDirectories();
            Directory.CreateDirectory(destinoDir);
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinoDir, file.Name);
                file.CopyTo(targetFilePath);
            }
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinoDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
            return;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string dirTEMP = @".\TEMP";
            if (Directory.Exists(dirTEMP))
                Directory.Delete(dirTEMP, true);
            foreach (string item in caminhosDeLog)
            {
                var itemIndexOf = item.IndexOf("#");
                string dirOrigem = item.Substring(0, itemIndexOf);
                string nomeDir = @".\TEMP\" + item.Substring(itemIndexOf + 1);
                CopyDirectory(dirOrigem, nomeDir, true);
            }
            var origemCopiaIndexOf = tbCaminhoBkp.Text.LastIndexOf(@"\");
            string destinoCopia = @".\TEMP" + tbCaminhoBkp.Text.Substring(origemCopiaIndexOf);
            File.Copy(tbCaminhoBkp.Text, destinoCopia);
            using (StreamWriter sw = new StreamWriter(@".\TEMP\Descritivo_do_problema.txt"))
            {
                sw.WriteLine(tbDescricaoDoProblema.Text);
            }
            string startPath = @".\TEMP";
            string zipPath = @".\" + tbNomeDoArquivoZip.Text + ".zip";
            ZipFile.CreateFromDirectory(startPath, zipPath);
            Directory.Delete(@".\TEMP", true);
            MessageBox.Show("Arquivo zip criado.");
        }
    }
}
