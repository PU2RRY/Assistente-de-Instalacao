using Assistente_de_Instalação.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assistente_de_Instalação.Forms
{
    public partial class MaquinasDCSPDV : Form
    {
        string conexãoVC = "vc";
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

            var lista = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>(nameof(VcMaquinas.Nomecomp), "Nome Maquina"),
                new KeyValuePair<string, string>(nameof(VcMaquinas.Tipoimp), "Tipo SAT"),
                new KeyValuePair<string, string>(nameof(VcMaquinas.Terminal), "Terminal"),
                new KeyValuePair<string, string>(nameof(VcMaquinas.DataCad), "Data de Cadastro"),
                new KeyValuePair<string, string>(nameof(VcMaquinas.Chave), "Chave")
            };
            foreach (var s in lista)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.DataPropertyName = s.Key;
                col.HeaderText = s.Value;
                dgvMaquinasDCS.Columns.Add(col);
            }
            dgvMaquinasDCS.DataSource = vc.VcMaquinas.ToList();
        }
        private void MaquinasDCSPDV_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
