using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Assistente_de_Instalação.Forms;
using Assistente_de_Instalação.Models;
using Assistente_de_Instalação.Properties;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using Microsoft.Win32;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace projeto1
{
    public partial class MenuPrincipal : Form
    {
        private BackgroundWorker backgroundWorkerBackup;
        private BackgroundWorker backgroundWorkerRestore;
        public string dirbkp = "";
        public string url = "";
        public string destino = "";
        private WebClient webClient;

        private void OcultaExibForm(bool exibe)
        {
            Visible = exibe;
        }
        public MenuPrincipal()
        {
            InitializeComponent();

            backgroundWorkerRestore = new BackgroundWorker();
            backgroundWorkerRestore.DoWork += new DoWorkEventHandler(BackgroundWorkerRestore_DoWork);
            backgroundWorkerRestore.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorkerRestore_RunWorkerCompleted);

            backgroundWorkerBackup = new BackgroundWorker();
            backgroundWorkerBackup.DoWork += new DoWorkEventHandler(BackgroundWorkerBackup_DoWork);
            backgroundWorkerBackup.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorkerBackup_RunWorkerCompleted);

        }
        private List<FileInfo> ListaArquivoPorExt(string dir, string ext)
        {
            DirectoryInfo diSource = new(dir);
            return diSource.GetFiles().Where(w => w.Extension.Equals(ext, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        private void impressorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre painel de impressoras do Windows 
            string impWin = "control printers";
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe", $"/C {impWin}");
            process.StartInfo = startInfo;
            startInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit();
        }
        private void painelDeControleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "control.exe";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }
        private void energiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;
            Process.Start("control.exe", "powercfg.cpl");
        }
        private void descriçãoDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "msinfo32.exe";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }
        private void reiniciaSpoolerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string serviço = "spooler";
            Spooler("net stop " + serviço);
            Spooler("net start " + serviço);
            MessageBox.Show("Serviço reiniciado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Spooler(string command)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = false;
            using (Process process = new Process())
            {
                process.StartInfo = processInfo;
                process.Start();
                process.WaitForExit();
            }
        }
        private void recursosDoWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("optionalfeatures");
        }
        private void pastaInicializarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "shell:Startup");
        }
        private void renomeiaNomeMaquinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenomeiaMaquinaForm form3 = new RenomeiaMaquinaForm();
            OcultaExibForm(false);
            form3.ShowDialog();
            OcultaExibForm(true);
        }
        private void ativadorMASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "obj", "MAS.cmd");
            Process.Start(mas);
        }
        private void apagaTXTVicommerceimpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var txtFiles = ListaArquivoPorExt(@"C:\Vicommerce\Imp\", ".txt");
            txtFiles.ForEach(f => { System.IO.File.Delete(f.FullName); });
            MessageBox.Show("Arquivos apagados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void apagaTXTTempSATimpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var txtFiles = ListaArquivoPorExt(@"C:\Vicommerce\TempSAT\Imp\", ".txt");
            txtFiles.ForEach(f => { System.IO.File.Delete(f.FullName); });
            MessageBox.Show("Arquivos apagados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void maquinasDCSPDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaquinasDCSPDV form = new MaquinasDCSPDV();
            OcultaExibForm(false);
            form.ShowDialog();
            OcultaExibForm(true);
        }
        private void fazerBackupELogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupLogsForm form = new BackupLogsForm();
            OcultaExibForm(false);
            form.ShowDialog();
            OcultaExibForm(true);
        }
        private void btnGravarApontamento_Click(object sender, EventArgs e)
        {
            registraOdbc();
        }
        private void registraOdbc()
        {
            try
            {
                if (string.IsNullOrEmpty(tbNomehost.Text))
                {
                    MessageBox.Show("Host não informado!", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string servidor = tbNomehost.Text;
                Microsoft.Win32.Registry.SetValue(@"HKEY_CURRENT_USER\Software\ODBC\ODBC.INI\vc", "Server", servidor);
                MessageBox.Show("Host apontado com sucesso");
                tbNomehost.Clear();
                tbNomehost.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro não foi possivel gravar o ODBC" + ex.Message);
            }
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            tsslEvicommerce.Image = Assistente_de_Instalação.Properties.Resources.off_24x24;
            lbHostName.Text = Environment.MachineName;
            lbOS.Text = RetornaOsVersao();
            pBackupload.Visible = false;
        }
        public static string RetornaOsVersao()
        {
            var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                        select x.GetPropertyValue("Caption")).FirstOrDefault();
            return name != null ? name.ToString() : "Desconhecido";
        }
        private void DownloadSistema()
        {
            webClient = new WebClient();
            webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
            try
            {
                webClient.DownloadFileAsync(new Uri(url), destino);
                lbStatusDownload.Text = "Iniciando o download...";
            }
            catch (Exception ex)
            {
                lbStatusDownload.Text = "Erro durante o download:" + ex.Message;
            }
        }
        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesInMegabytes = e.BytesReceived / (1024.0 * 1024.0);
            lbStatusDownload.Text = $"Progresso: {e.ProgressPercentage}% - {bytesInMegabytes:F2} MB de {e.TotalBytesToReceive / (1024.0 * 1024.0):F2} MB";
        }
        private void WebClient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                lbStatusDownload.Text = "Download concluído com sucesso.";
                btDownloadPDV.Enabled = true;
                btDownloadAtualizador.Enabled = true;
                url = "";
                FimDownload();
            }
            else
            {
                lbStatusDownload.Text = "Erro durante o download: " + e.Error.Message;
                btDownloadPDV.Enabled = true;
                btDownloadAtualizador.Enabled = true;
            }
            webClient.Dispose();
            webClient = null;
        }
        private void btDownloadPDV_Click(object sender, EventArgs e)
        {
            btDownloadPDV.Enabled = false;
            btDownloadAtualizador.Enabled = false;
            destino = "C:\\InstaladorDcsPDV_x86_x64.exe";
            url = "https://filedn.com/llHAOgAJ3vNzjybV42spbG8/Instaladores/PDV/InstaladorDcsPDV_x86_x64.exe";
            DownloadSistema();
        }
        private void btDownloadAtualizador_Click(object sender, EventArgs e)
        {
            btDownloadPDV.Enabled = false;
            btDownloadAtualizador.Enabled = false;
            destino = "C:\\AtualizadorDcsPDV_x86_x64.exe";
            url = "https://filedn.com/llHAOgAJ3vNzjybV42spbG8/Instaladores/PDV/AtualizadorDcsPDV_x86_x64.exe";
            DownloadSistema();
        }
        private void FimDownload()
        {
            DialogResult result = MessageBox.Show("Deseja abrir o aplicativo baixado ?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Process.Start(destino);
                destino = "";
                webClient.Dispose();
                webClient = null;
            }
            destino = "";
            return;
        }
        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void redesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PingForm form2 = new PingForm();
            OcultaExibForm(false);
            form2.ShowDialog();
            OcultaExibForm(true);
        }
        private void fazerBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.InitialDirectory = @"C:\Vicommerce\Backup";
                DialogResult res = dialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    pBackupload.Visible = true;
                    backgroundWorkerBackup.RunWorkerAsync(dialog.FileName + ".bak");
                }
            }
        }
        private void BackgroundWorkerBackup_DoWork(object sender, DoWorkEventArgs e)
        {
            // Este método é executado em segundo plano
            string backupPath = e.Argument as string;
            ExecutarBackup(backupPath);
        }
        private void BackgroundWorkerRestore_DoWork(object sender, DoWorkEventArgs e)
        {
            string backupFilePath = e.Argument as string;
            // Execute a restauração do banco de dados em segundo plano
            RestauraBackup(backupFilePath);
        }
        private void BackgroundWorkerBackup_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Este método é executado na thread da interface do usuário após a conclusão do trabalho em segundo plano
            if (e.Error != null)
                MessageBox.Show("Ocorreu um erro ao fazer o backup.");

            else if (e.Cancelled);

            else
            {
                MessageBox.Show("Backup concluído com sucesso.");
                pBackupload.Visible = false;
            }
        }
        private void BackgroundWorkerRestore_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {            
            if (e.Error != null)
                MessageBox.Show("Ocorreu um erro ao restaurar o backup.");

            else if (e.Cancelled);

            else
            {
                MessageBox.Show("Restauração concluída com sucesso.");
                pBackupload.Visible = false;
                lbBackupLoad.Text = "Fazendo Backup...";
            }
        }
        public void ExecutarBackup(string backupPath)
        {
            SqlConnectionManager connectionManager = new SqlConnectionManager();
            if (connectionManager.OpenConnection())
            {
                if (!connectionManager.BackupDatabase(backupPath))
                {
                    // Reporte um erro se o backup falhar
                    throw new Exception("Erro ao fazer o backup.");
                }
                connectionManager.CloseConnection();
            }
        }
        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = @"C:\Vicommerce\Backup";
                DialogResult res = dialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    lbBackupLoad.Text = "Restaurando Backup...";
                    pBackupload.Visible = true;
                    backgroundWorkerRestore.RunWorkerAsync(dialog.FileName);
                }
            }
        }
        public void RestauraBackup(string backupFilePath)
        {
            SqlConnectionManager connectionManager = new SqlConnectionManager();
            if (connectionManager.OpenConnection())
            {
                if (connectionManager.RestoreDatabase(backupFilePath))
                {
                    connectionManager.killConection();
                    connectionManager.CriaUsuarioSql();
                    connectionManager.DefinirPermissoes();
                }
                else
                {
                    throw new Exception("Erro ao restaurar o backup.");
                }
                
                connectionManager.CloseConnection();
            }
        }
    }
}