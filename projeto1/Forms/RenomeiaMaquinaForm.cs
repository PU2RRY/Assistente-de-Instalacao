using System;
using System.Net;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace projeto1
{
    public partial class RenomeiaMaquinaForm : Form
    {
        public RenomeiaMaquinaForm()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            label3.Text = Environment.MachineName;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Newname = textBox1.Text;
            try
            {
                IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                if (host != null && host.AddressList.Length > 0)
                {
                    // Altera o nome da máquina:
                    bool success = NativeMethods.SetComputerName(Newname);
                    if (success)
                    {
                        // MessageBox.Show("nome alterado para :" + Newname + "Porfavor reinicia a maquina para concluir.");
                        DialogResult dr = MessageBox.Show(@"Nome alterado para :" + Newname + " Você deve reiniciar o computador para validar", "Confirmação", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            Process.Start("shutdown", "/r /t 0");
                        }
                        else
                            this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao alterar o nome da máquina.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, abra o sistema como adiministrador: " + ex.Message);
            }
        }
    }
    public static class NativeMethods
    {
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetComputerName(string computerName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool ExitWindowsEx(ExitFlags uFlags, int dwReason);

        [Flags]
        public enum ExitFlags : uint
        {
            EWX_LOGOFF = 0x00000000,
            EWX_SHUTDOWN = 0x00000001,
            EWX_REBOOT = 0x00000002,
            EWX_FORCE = 0x00000004,
            EWX_POWEROFF = 0x00000008,
            EWX_FORCEIFHUNG = 0x00000010
        }
    }
}
