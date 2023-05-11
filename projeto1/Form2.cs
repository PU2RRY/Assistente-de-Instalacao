using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Comando de Ping :
            string IPDigitado = textBox1.Text;
            string QNunPing = textBox3.Text;
            string comandoPing = "";
            if (radioButton1.Checked == true && radioButton2.Checked == false)
            {
                comandoPing = "/C ping -t " + IPDigitado;
            }
            else
            {
                if (radioButton2.Checked == true && radioButton1.Checked == false)
                {
                    comandoPing = "/C ping " + IPDigitado + " -n " + QNunPing;
                }
                else
                {
                    comandoPing = "/C ping " + IPDigitado;
                }
            }
            // Abre o CMD e executa o "coamando de Ping" :
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = comandoPing;
            process.StartInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string meuGateway = string.Empty;
            string meuip = string.Empty;
            try
            {
                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in interfaces)
                {
                    if (adapter.OperationalStatus == OperationalStatus.Up && adapter.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                    {
                        GatewayIPAddressInformationCollection gatewayAddresses = adapter.GetIPProperties().GatewayAddresses;
                        foreach (GatewayIPAddressInformation gateway in gatewayAddresses)
                        {
                            if (gateway.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                meuGateway = gateway.Address.ToString();
                                break;
                            }
                        }
                        if (!string.IsNullOrEmpty(meuGateway))
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter o endereço do gateway: " + ex.Message);
            }
            try
            {
                IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());
                foreach (IPAddress ip in ips)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        meuip = ip.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter o endereço IP: " + ex.Message);
            }
            textBox2.Text = $"IP v4: {meuip}{Environment.NewLine}Gateway: {meuGateway}";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void QuantBox_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            // Cria um novo processo do CMD
            Process processo = new Process();
            processo.StartInfo.FileName = "cmd.exe";
            processo.StartInfo.UseShellExecute = false;
            processo.StartInfo.RedirectStandardInput = true;
            processo.StartInfo.RedirectStandardOutput = false;
            processo.StartInfo.RedirectStandardError = true;
            // Inicia o processo
            processo.Start();
            // Executa um comando no CMD
            processo.StandardInput.WriteLine("arp -a");
            // Aguarda a saída do comando
            //string output = processo.StandardOutput.ReadToEnd();            
            processo.WaitForExit();
            processo.Close();

        }
    }
}
