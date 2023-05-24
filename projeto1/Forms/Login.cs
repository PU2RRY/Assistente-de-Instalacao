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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string senhaDigitada = "";
        string senhaCorreta = "217493220";
        private void btnEntrarSenha_Click(object sender, EventArgs e)
        {
            ValidarSenha();
        }
        private void ValidarSenha()
        {
            if (senhaDigitada == senhaCorreta)
            {
                DialogResult = DialogResult.Continue;
            }
            else
            {
                MessageBox.Show("SENHA INCORRETA");
                senhaDigitada = "";
            }
        }
        private void tbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ValidarSenha();
        }

        private void tbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                senhaDigitada += e.KeyChar;
                e.KeyChar = '•';
            }
        }
        private void btnSenhaSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

