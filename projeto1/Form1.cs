using System.Diagnostics;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;

namespace projeto1
{
    public partial class MenuPrincipal : Form
    {
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
            Form2 form2 = new Form2();
            form2.FormClosed += Form2_FormClosed; // Assine o evento FormClosed            
            OcultaExibForm(false);
            form2.ShowDialog();
            OcultaExibForm(true);
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //   this.Show(); // Exibe o Form1 novamente quando o Form2 for fechado
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
            Form3 form3 = new Form3();
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
    }
}