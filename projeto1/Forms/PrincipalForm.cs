using System.Diagnostics;
using System.Windows.Forms;
using Assistente_de_Instalação.Forms;

namespace projeto1
{
    public partial class MenuPrincipal : Form
    {
        public object ServiceControllerStatus { get; private set; }
        public FormClosedEventHandler PediSenha_FormClosed { get; private set; }
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
        private void BT6_Click(object sender, EventArgs e)
        {

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
        private void tbBackupLogs_Click(object sender, EventArgs e)
        {
            BackupLogsForm form = new BackupLogsForm();
            OcultaExibForm(false);
            form.ShowDialog();
            OcultaExibForm(true);
        }
        private List<FileInfo> ListaArquivoPorExt(string dir, string ext)
        {
            DirectoryInfo diSource = new(dir);
            return diSource.GetFiles().Where(w => w.Extension.Equals(ext, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        private void Mensagem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seja Feliz", "BOLETO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
                MessageBox.Show("teste");
            else
                Application.Restart();
        }
        private void btnMaquinasPDV_Click(object sender, EventArgs e)
        {
            MaquinasDCSPDV form = new MaquinasDCSPDV();
            OcultaExibForm(false);
            form.ShowDialog();
            OcultaExibForm(true);
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
            var txtFiles = ListaArquivoPorExt(@"C:\Vicommerce\Imp\", ".txt");
            txtFiles.AddRange(ListaArquivoPorExt(@"C:\Vicommerce\TempSAT\Imp\", ".txt"));
            txtFiles.ForEach(f => { File.Delete(f.FullName); });
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

        private void btnReinicia_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0");
        }
    }
}