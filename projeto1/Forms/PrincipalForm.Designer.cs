namespace projeto1
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            BT1REDE = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            impressorasToolStripMenuItem = new ToolStripMenuItem();
            painelDeControleToolStripMenuItem = new ToolStripMenuItem();
            energiaToolStripMenuItem = new ToolStripMenuItem();
            descriçãoDoSistemaToolStripMenuItem = new ToolStripMenuItem();
            reiniciaSpoolerToolStripMenuItem = new ToolStripMenuItem();
            recursosDoWindowsToolStripMenuItem = new ToolStripMenuItem();
            pastaInicializarToolStripMenuItem = new ToolStripMenuItem();
            renomeiaNomeMaquinaToolStripMenuItem = new ToolStripMenuItem();
            ativadorMASToolStripMenuItem = new ToolStripMenuItem();
            pDVToolStripMenuItem = new ToolStripMenuItem();
            apagaTXTVicommerceimpToolStripMenuItem = new ToolStripMenuItem();
            apagaTXTTempSATimpToolStripMenuItem = new ToolStripMenuItem();
            maquinasDCSPDVToolStripMenuItem = new ToolStripMenuItem();
            fazerBackupELogsToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            btnGravarApontamento = new Button();
            tbNomeserverapontamento = new TextBox();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BT1REDE
            // 
            BT1REDE.BackColor = Color.DodgerBlue;
            BT1REDE.FlatStyle = FlatStyle.Flat;
            BT1REDE.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BT1REDE.ForeColor = SystemColors.ControlText;
            BT1REDE.Location = new Point(311, 7);
            BT1REDE.Name = "BT1REDE";
            BT1REDE.Size = new Size(165, 31);
            BT1REDE.TabIndex = 0;
            BT1REDE.Text = "Redes";
            BT1REDE.UseVisualStyleBackColor = false;
            BT1REDE.Click += button1_Click;
            BT1REDE.MouseEnter += BTNEnter;
            BT1REDE.MouseLeave += BTNLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(97, 30);
            label1.Name = "label1";
            label1.Size = new Size(298, 24);
            label1.TabIndex = 1;
            label1.Text = "ASSISTENTE DE INSTALAÇÃO";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, pDVToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(501, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { impressorasToolStripMenuItem, painelDeControleToolStripMenuItem, energiaToolStripMenuItem, descriçãoDoSistemaToolStripMenuItem, reiniciaSpoolerToolStripMenuItem, recursosDoWindowsToolStripMenuItem, pastaInicializarToolStripMenuItem, renomeiaNomeMaquinaToolStripMenuItem, ativadorMASToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(68, 20);
            toolStripMenuItem1.Text = "Windows";
            // 
            // impressorasToolStripMenuItem
            // 
            impressorasToolStripMenuItem.Name = "impressorasToolStripMenuItem";
            impressorasToolStripMenuItem.Size = new Size(211, 22);
            impressorasToolStripMenuItem.Text = "Impressoras";
            impressorasToolStripMenuItem.Click += impressorasToolStripMenuItem_Click;
            // 
            // painelDeControleToolStripMenuItem
            // 
            painelDeControleToolStripMenuItem.Name = "painelDeControleToolStripMenuItem";
            painelDeControleToolStripMenuItem.Size = new Size(211, 22);
            painelDeControleToolStripMenuItem.Text = "Painel de Controle";
            painelDeControleToolStripMenuItem.Click += painelDeControleToolStripMenuItem_Click;
            // 
            // energiaToolStripMenuItem
            // 
            energiaToolStripMenuItem.Name = "energiaToolStripMenuItem";
            energiaToolStripMenuItem.Size = new Size(211, 22);
            energiaToolStripMenuItem.Text = "Energia";
            energiaToolStripMenuItem.Click += energiaToolStripMenuItem_Click;
            // 
            // descriçãoDoSistemaToolStripMenuItem
            // 
            descriçãoDoSistemaToolStripMenuItem.Name = "descriçãoDoSistemaToolStripMenuItem";
            descriçãoDoSistemaToolStripMenuItem.Size = new Size(211, 22);
            descriçãoDoSistemaToolStripMenuItem.Text = "Descrição do sistema";
            descriçãoDoSistemaToolStripMenuItem.Click += descriçãoDoSistemaToolStripMenuItem_Click;
            // 
            // reiniciaSpoolerToolStripMenuItem
            // 
            reiniciaSpoolerToolStripMenuItem.Name = "reiniciaSpoolerToolStripMenuItem";
            reiniciaSpoolerToolStripMenuItem.Size = new Size(211, 22);
            reiniciaSpoolerToolStripMenuItem.Text = "Reinicia Spooler";
            reiniciaSpoolerToolStripMenuItem.Click += reiniciaSpoolerToolStripMenuItem_Click;
            // 
            // recursosDoWindowsToolStripMenuItem
            // 
            recursosDoWindowsToolStripMenuItem.Name = "recursosDoWindowsToolStripMenuItem";
            recursosDoWindowsToolStripMenuItem.Size = new Size(211, 22);
            recursosDoWindowsToolStripMenuItem.Text = "Recursos do Windows";
            recursosDoWindowsToolStripMenuItem.Click += recursosDoWindowsToolStripMenuItem_Click;
            // 
            // pastaInicializarToolStripMenuItem
            // 
            pastaInicializarToolStripMenuItem.Name = "pastaInicializarToolStripMenuItem";
            pastaInicializarToolStripMenuItem.Size = new Size(211, 22);
            pastaInicializarToolStripMenuItem.Text = "Inicializar do Windows";
            pastaInicializarToolStripMenuItem.Click += pastaInicializarToolStripMenuItem_Click;
            // 
            // renomeiaNomeMaquinaToolStripMenuItem
            // 
            renomeiaNomeMaquinaToolStripMenuItem.Name = "renomeiaNomeMaquinaToolStripMenuItem";
            renomeiaNomeMaquinaToolStripMenuItem.Size = new Size(211, 22);
            renomeiaNomeMaquinaToolStripMenuItem.Text = "Renomeia nome Maquina";
            renomeiaNomeMaquinaToolStripMenuItem.Click += renomeiaNomeMaquinaToolStripMenuItem_Click;
            // 
            // ativadorMASToolStripMenuItem
            // 
            ativadorMASToolStripMenuItem.Name = "ativadorMASToolStripMenuItem";
            ativadorMASToolStripMenuItem.Size = new Size(211, 22);
            ativadorMASToolStripMenuItem.Text = "Ativador M.A.S";
            ativadorMASToolStripMenuItem.Click += ativadorMASToolStripMenuItem_Click;
            // 
            // pDVToolStripMenuItem
            // 
            pDVToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { apagaTXTVicommerceimpToolStripMenuItem, apagaTXTTempSATimpToolStripMenuItem, maquinasDCSPDVToolStripMenuItem, fazerBackupELogsToolStripMenuItem });
            pDVToolStripMenuItem.Name = "pDVToolStripMenuItem";
            pDVToolStripMenuItem.Size = new Size(41, 20);
            pDVToolStripMenuItem.Text = "PDV";
            // 
            // apagaTXTVicommerceimpToolStripMenuItem
            // 
            apagaTXTVicommerceimpToolStripMenuItem.Name = "apagaTXTVicommerceimpToolStripMenuItem";
            apagaTXTVicommerceimpToolStripMenuItem.Size = new Size(225, 22);
            apagaTXTVicommerceimpToolStripMenuItem.Text = "Apaga TXT vicommerce/imp";
            apagaTXTVicommerceimpToolStripMenuItem.Click += apagaTXTVicommerceimpToolStripMenuItem_Click;
            // 
            // apagaTXTTempSATimpToolStripMenuItem
            // 
            apagaTXTTempSATimpToolStripMenuItem.Name = "apagaTXTTempSATimpToolStripMenuItem";
            apagaTXTTempSATimpToolStripMenuItem.Size = new Size(225, 22);
            apagaTXTTempSATimpToolStripMenuItem.Text = "Apaga TXT TempSAT/imp";
            apagaTXTTempSATimpToolStripMenuItem.Click += apagaTXTTempSATimpToolStripMenuItem_Click;
            // 
            // maquinasDCSPDVToolStripMenuItem
            // 
            maquinasDCSPDVToolStripMenuItem.Name = "maquinasDCSPDVToolStripMenuItem";
            maquinasDCSPDVToolStripMenuItem.Size = new Size(225, 22);
            maquinasDCSPDVToolStripMenuItem.Text = "Maquinas DCS PDV";
            maquinasDCSPDVToolStripMenuItem.Click += maquinasDCSPDVToolStripMenuItem_Click;
            // 
            // fazerBackupELogsToolStripMenuItem
            // 
            fazerBackupELogsToolStripMenuItem.Name = "fazerBackupELogsToolStripMenuItem";
            fazerBackupELogsToolStripMenuItem.Size = new Size(225, 22);
            fazerBackupELogsToolStripMenuItem.Text = "Fazer Backup e Logs";
            fazerBackupELogsToolStripMenuItem.Click += fazerBackupELogsToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(BT1REDE);
            panel1.Location = new Point(10, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 423);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(btnGravarApontamento);
            panel2.Controls.Add(tbNomeserverapontamento);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(6, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 61);
            panel2.TabIndex = 1;
            // 
            // btnGravarApontamento
            // 
            btnGravarApontamento.Location = new Point(220, 26);
            btnGravarApontamento.Name = "btnGravarApontamento";
            btnGravarApontamento.Size = new Size(75, 23);
            btnGravarApontamento.TabIndex = 3;
            btnGravarApontamento.Text = "Gravar";
            btnGravarApontamento.UseVisualStyleBackColor = true;
            btnGravarApontamento.Click += btnGravarApontamento_Click;
            // 
            // tbNomeserverapontamento
            // 
            tbNomeserverapontamento.Location = new Point(3, 26);
            tbNomeserverapontamento.Name = "tbNomeserverapontamento";
            tbNomeserverapontamento.Size = new Size(213, 23);
            tbNomeserverapontamento.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(176, 17);
            label2.TabIndex = 2;
            label2.Text = "Apontamento de Servidor :";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(501, 491);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BT1REDE;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem impressorasToolStripMenuItem;
        private ToolStripMenuItem painelDeControleToolStripMenuItem;
        private ToolStripMenuItem energiaToolStripMenuItem;
        private ToolStripMenuItem descriçãoDoSistemaToolStripMenuItem;
        private ToolStripMenuItem reiniciaSpoolerToolStripMenuItem;
        private ToolStripMenuItem recursosDoWindowsToolStripMenuItem;
        private ToolStripMenuItem pastaInicializarToolStripMenuItem;
        private ToolStripMenuItem renomeiaNomeMaquinaToolStripMenuItem;
        private ToolStripMenuItem ativadorMASToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem pDVToolStripMenuItem;
        private ToolStripMenuItem apagaTXTVicommerceimpToolStripMenuItem;
        private ToolStripMenuItem apagaTXTTempSATimpToolStripMenuItem;
        private ToolStripMenuItem maquinasDCSPDVToolStripMenuItem;
        private ToolStripMenuItem fazerBackupELogsToolStripMenuItem;
        private Panel panel2;
        private Label label2;
        private Button btnGravarApontamento;
        private TextBox tbNomeserverapontamento;
    }
}