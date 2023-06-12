using Assistente_de_Instalação.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            dgvMaquinasDCS.Columns.Clear();
            dgvMaquinasDCS.AutoGenerateColumns = false;
            string[] colunas =
            {
                "NOMECOMP",
                "TIPOIMP",
                "TERMINAL",
                "DataCad",
                "CHAVE",
            };
            foreach (string s in colunas)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.DataPropertyName = s;
                col.HeaderText = s;
                dgvMaquinasDCS.Columns.Add(col);
            }
            dgvMaquinasDCS.DataSource = vc.VcMaquinas.ToList();

            //dgvMaquinasDCS.DataSource = vc.VcCupfecha.ToList();
        }
        private void MaquinasDCSPDV_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
