using Assistente_de_Instalação.Models;
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
    public partial class MaquinasDCSPDV : Form
    {
        private readonly vcContext vc;
        public MaquinasDCSPDV()
        {
            InitializeComponent();
            vc = new vcContext();
        }
        private void CarregaGrid()
        {
            dgvMaquinasDCS.DataSource = vc.VcMaquinas.ToList();

        }
        private void MaquinasDCSPDV_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
