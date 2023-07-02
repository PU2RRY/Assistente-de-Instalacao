using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Assistente_de_Instala��o.Forms;
using Assistente_de_Instala��o.Properties;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.Logging;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace projeto1
{
    public partial class MenuPrincipal : Form
    {
        String hostName, strConn, strConnTrusted, strConnEViCommerce;

        [DllImport("ODBCCP32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern bool SQLConfigDataSource(IntPtr parent, OdbcConfigDsnFlags request, string driver, string attributes);
        [Flags]
        enum OdbcConfigDsnFlags : int
        {
            ODBC_ADD_DSN = 1,
            ODBC_CONFIG_DSN = 2,
            ODBC_REMOVE_DSN = 3,
            ODBC_ADD_SYS_DSN = 4,
            ODBC_CONFIG_SYS_DSN = 5,
            ODBC_REMOVE_SYS_DSN = 6
        }
        private void OcultaExibForm(bool exibe)
        {
            Visible = exibe;
        }
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PingForm form2 = new PingForm();
            OcultaExibForm(false);
            form2.ShowDialog();
            OcultaExibForm(true);
        }
        private void BTNEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = Color.Red;
        }
        private void BTNLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = Color.DodgerBlue;
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
        private void descri��oDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
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
            string servi�o = "spooler";
            Spooler("net stop " + servi�o);
            Spooler("net start " + servi�o);
            MessageBox.Show("Servi�o reiniciado com sucesso.", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtFiles.ForEach(f => { File.Delete(f.FullName); });
            MessageBox.Show("Arquivos apagados.", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void apagaTXTTempSATimpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var txtFiles = ListaArquivoPorExt(@"C:\Vicommerce\TempSAT\Imp\", ".txt");
            txtFiles.ForEach(f => { File.Delete(f.FullName); });
            MessageBox.Show("Arquivos apagados.", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Host n�o informado!", "Erro de valida��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Erro n�o foi possivel gravar o ODBC" + ex.Message);
            }
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            tsslEvicommerce.Image = Assistente_de_Instala��o.Properties.Resources.off_24x24;
            lbHostName.Text = Environment.MachineName;
            lbOS.Text = RetornaOsVersao();
        }
        public static string RetornaOsVersao()
        {
            var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                        select x.GetPropertyValue("Caption")).FirstOrDefault();
            return name != null ? name.ToString() : "Desconhecido";
        }
        private void btTeste_Click(object sender, EventArgs e)
        {

        }
    }
}