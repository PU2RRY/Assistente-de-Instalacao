using System;
using System.Diagnostics;
using System.IO.Enumeration;
using System.Reflection;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;
using Assistente_de_Instalação.Forms;
using System.ServiceProcess;

namespace projeto1
{

    public partial class MenuPrincipal : Form
    {
        public object ServiceControllerStatus { get; private set; }

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
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void BT2_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "msinfo32.exe";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }
        private void BT3_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "control.exe";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }
        private void button1_Click_1(object sender, EventArgs e)
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
        private void button1_Click_2(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;
            Process.Start("control.exe", "powercfg.cpl");
        }
        private void BT6_Click(object sender, EventArgs e)
        {
            RenomeiaMaquinaForm form3 = new RenomeiaMaquinaForm();
            OcultaExibForm(false);
            form3.ShowDialog();
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

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tbBackupLogs_Click(object sender, EventArgs e)
        {
            BackupLogsForm form = new BackupLogsForm();
            OcultaExibForm(false);
            form.ShowDialog();
            OcultaExibForm(true);
        }
        private void ColocaAppIniciarWin_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "shell:Startup");
        }
        private void AtivaRecursos_Click(object sender, EventArgs e)
        {
            Process.Start("optionalfeatures");
        }

        private void MasAtivador_Click(object sender, EventArgs e)
        {
            string mas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "obj", "MAS.bat");
            Process.Start(mas);
            
        }

        private void ReiniciaSpooler_Click(object sender, EventArgs e)
        {
            lbSpooler.Text = "AGUARDE..";
            string serviço = "spooler";

            Spooler("net stop " + serviço);
            Spooler("net start " + serviço);

            // MessageBox.Show("Serviço reiniciado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            lbSpooler.Text = "FINALIZADO";
        }
        private void Spooler(string command)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            using (Process process = new Process())
            {
                process.StartInfo = processInfo;
                process.Start();
                process.WaitForExit();
            }
        }

        private void Mensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TESTE DE ICONE DA MANSAGEM", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}