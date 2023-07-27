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
            menuStrip1 = new MenuStrip();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
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
            redesToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            dgvClientes = new DataGridView();
            panel6 = new Panel();
            btnApagar = new Button();
            btnGravar = new Button();
            rbNao = new RadioButton();
            rbSim = new RadioButton();
            btnVerificar = new Button();
            txbTell = new TextBox();
            txbCpf = new TextBox();
            txbNome = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            btnGravarApontamento = new Button();
            tbNomehost = new TextBox();
            label2 = new Label();
            lbOS = new Label();
            label4 = new Label();
            label3 = new Label();
            lbHostName = new Label();
            panel5 = new Panel();
            btDownloadAtualizador = new Button();
            lbStatusDownload = new Label();
            btDownloadPDV = new Button();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            tssLabel = new ToolStripStatusLabel();
            tsslEvicommerce = new ToolStripStatusLabel();
            panel4 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.Items.AddRange(new ToolStripItem[] { configuraçõesToolStripMenuItem, toolStripMenuItem1, pDVToolStripMenuItem, redesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(883, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Image = Assistente_de_Instalação.Properties.Resources.ico_Engrena;
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(112, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            configuraçõesToolStripMenuItem.Click += configuraçõesToolStripMenuItem_Click;
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
            // redesToolStripMenuItem
            // 
            redesToolStripMenuItem.Name = "redesToolStripMenuItem";
            redesToolStripMenuItem.Size = new Size(50, 20);
            redesToolStripMenuItem.Text = "Redes";
            redesToolStripMenuItem.Click += redesToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(dgvClientes);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(181, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 396);
            panel1.TabIndex = 4;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(6, 142);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(681, 251);
            dgvClientes.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gray;
            panel6.Controls.Add(btnApagar);
            panel6.Controls.Add(btnGravar);
            panel6.Controls.Add(rbNao);
            panel6.Controls.Add(rbSim);
            panel6.Controls.Add(btnVerificar);
            panel6.Controls.Add(txbTell);
            panel6.Controls.Add(txbCpf);
            panel6.Controls.Add(txbNome);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(264, 7);
            panel6.Name = "panel6";
            panel6.Size = new Size(423, 129);
            panel6.TabIndex = 5;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(285, 78);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(126, 23);
            btnApagar.TabIndex = 13;
            btnApagar.Text = "APAGAR";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(285, 50);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(126, 22);
            btnGravar.TabIndex = 12;
            btnGravar.Text = "GRAVAR";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click_1;
            // 
            // rbNao
            // 
            rbNao.AutoSize = true;
            rbNao.Location = new Point(132, 96);
            rbNao.Name = "rbNao";
            rbNao.Size = new Size(47, 19);
            rbNao.TabIndex = 11;
            rbNao.TabStop = true;
            rbNao.Text = "Não";
            rbNao.UseVisualStyleBackColor = true;
            // 
            // rbSim
            // 
            rbSim.AutoSize = true;
            rbSim.Location = new Point(80, 96);
            rbSim.Name = "rbSim";
            rbSim.Size = new Size(45, 19);
            rbSim.TabIndex = 10;
            rbSim.TabStop = true;
            rbSim.Text = "Sim";
            rbSim.UseVisualStyleBackColor = true;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(285, 22);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(126, 22);
            btnVerificar.TabIndex = 9;
            btnVerificar.Text = "VERIFICAR";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txbTell
            // 
            txbTell.Location = new Point(80, 66);
            txbTell.Name = "txbTell";
            txbTell.Size = new Size(169, 23);
            txbTell.TabIndex = 6;
            // 
            // txbCpf
            // 
            txbCpf.Location = new Point(80, 39);
            txbCpf.Name = "txbCpf";
            txbCpf.Size = new Size(169, 23);
            txbCpf.TabIndex = 5;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(80, 10);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(169, 23);
            txbNome.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 95);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 3;
            label8.Text = "Ativo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 67);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 2;
            label7.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 38);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 1;
            label6.Text = "Cpf";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 11);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 0;
            label5.Text = "Nome";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(btnGravarApontamento);
            panel2.Controls.Add(tbNomehost);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(6, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 75);
            panel2.TabIndex = 0;
            // 
            // btnGravarApontamento
            // 
            btnGravarApontamento.Location = new Point(166, 40);
            btnGravarApontamento.Name = "btnGravarApontamento";
            btnGravarApontamento.Size = new Size(76, 24);
            btnGravarApontamento.TabIndex = 2;
            btnGravarApontamento.Text = "Gravar";
            btnGravarApontamento.UseVisualStyleBackColor = true;
            btnGravarApontamento.Click += btnGravarApontamento_Click;
            // 
            // tbNomehost
            // 
            tbNomehost.Location = new Point(5, 40);
            tbNomehost.Name = "tbNomehost";
            tbNomehost.Size = new Size(157, 23);
            tbNomehost.TabIndex = 0;
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
            // lbOS
            // 
            lbOS.AutoSize = true;
            lbOS.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbOS.Location = new Point(74, 28);
            lbOS.Name = "lbOS";
            lbOS.Size = new Size(20, 17);
            lbOS.TabIndex = 0;
            lbOS.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 30);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 1;
            label4.Text = "Windows : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 13);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 3;
            label3.Text = "Nome Host Local : ";
            // 
            // lbHostName
            // 
            lbHostName.AutoSize = true;
            lbHostName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbHostName.Location = new Point(121, 11);
            lbHostName.Name = "lbHostName";
            lbHostName.Size = new Size(20, 17);
            lbHostName.TabIndex = 2;
            lbHostName.Text = "...";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(btDownloadAtualizador);
            panel5.Controls.Add(lbStatusDownload);
            panel5.Controls.Add(btDownloadPDV);
            panel5.Location = new Point(6, 524);
            panel5.Name = "panel5";
            panel5.Size = new Size(865, 37);
            panel5.TabIndex = 5;
            // 
            // btDownloadAtualizador
            // 
            btDownloadAtualizador.BackColor = Color.Azure;
            btDownloadAtualizador.FlatStyle = FlatStyle.Flat;
            btDownloadAtualizador.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btDownloadAtualizador.ForeColor = SystemColors.ControlText;
            btDownloadAtualizador.Location = new Point(125, 8);
            btDownloadAtualizador.Name = "btDownloadAtualizador";
            btDownloadAtualizador.Size = new Size(148, 23);
            btDownloadAtualizador.TabIndex = 4;
            btDownloadAtualizador.Text = "Download Atualizador";
            btDownloadAtualizador.UseVisualStyleBackColor = false;
            btDownloadAtualizador.Click += btDownloadAtualizador_Click;
            // 
            // lbStatusDownload
            // 
            lbStatusDownload.AutoSize = true;
            lbStatusDownload.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbStatusDownload.Location = new Point(279, 11);
            lbStatusDownload.Name = "lbStatusDownload";
            lbStatusDownload.Size = new Size(18, 20);
            lbStatusDownload.TabIndex = 3;
            lbStatusDownload.Text = "...";
            // 
            // btDownloadPDV
            // 
            btDownloadPDV.BackColor = Color.Azure;
            btDownloadPDV.FlatStyle = FlatStyle.Flat;
            btDownloadPDV.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btDownloadPDV.ForeColor = SystemColors.ControlText;
            btDownloadPDV.Location = new Point(6, 8);
            btDownloadPDV.Name = "btDownloadPDV";
            btDownloadPDV.Size = new Size(113, 23);
            btDownloadPDV.TabIndex = 2;
            btDownloadPDV.Text = "Download PDV";
            btDownloadPDV.UseVisualStyleBackColor = false;
            btDownloadPDV.Click += btDownloadPDV_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(285, 33);
            label1.Name = "label1";
            label1.Size = new Size(298, 24);
            label1.TabIndex = 3;
            label1.Text = "ASSISTENTE DE INSTALAÇÃO";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tssLabel, tsslEvicommerce });
            statusStrip1.Location = new Point(0, 566);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(883, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // tssLabel
            // 
            tssLabel.BackColor = Color.White;
            tssLabel.Name = "tssLabel";
            tssLabel.Size = new Size(90, 17);
            tssLabel.Text = "EviCommerce : ";
            // 
            // tsslEvicommerce
            // 
            tsslEvicommerce.BackColor = SystemColors.ButtonFace;
            tsslEvicommerce.Image = Assistente_de_Instalação.Properties.Resources.off_24x24;
            tsslEvicommerce.Name = "tsslEvicommerce";
            tsslEvicommerce.Size = new Size(16, 17);
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(lbHostName);
            panel4.Controls.Add(lbOS);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(10, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(861, 54);
            panel4.TabIndex = 6;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(883, 588);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(statusStrip1);
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
            Load += MenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private TextBox tbNomehost;
        private Label label1;
        private Label lbHostName;
        private Label label3;
        private Label label4;
        private Label lbOS;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tssLabel;
        private ToolStripStatusLabel tsslEvicommerce;
        private Panel panel4;
        private Panel panel5;
        private Label lbStatusDownload;
        private Button btDownloadPDV;
        private Button btDownloadAtualizador;
        private Panel panel6;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem redesToolStripMenuItem;
        private DataGridView dgvClientes;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnVerificar;
        private TextBox txbTell;
        private TextBox txbCpf;
        private TextBox txbNome;
        private Label label8;
        private RadioButton rbNao;
        private RadioButton rbSim;
        private Button btnGravar;
        private Button btnApagar;
    }
}