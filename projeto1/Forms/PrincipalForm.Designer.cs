﻿namespace projeto1
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
            panel5 = new Panel();
            btDownloadAtualizador = new Button();
            lbStatusDownload = new Label();
            btDownloadPDV = new Button();
            panel3 = new Panel();
            lbOS = new Label();
            label4 = new Label();
            label3 = new Label();
            lbHostName = new Label();
            panel2 = new Panel();
            btnGravarApontamento = new Button();
            tbNomehost = new TextBox();
            label2 = new Label();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            tssLabel = new ToolStripStatusLabel();
            tsslEvicommerce = new ToolStripStatusLabel();
            panel4 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BT1REDE
            // 
            BT1REDE.BackColor = Color.DodgerBlue;
            BT1REDE.FlatStyle = FlatStyle.Flat;
            BT1REDE.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BT1REDE.ForeColor = SystemColors.ControlText;
            BT1REDE.Location = new Point(10, 131);
            BT1REDE.Name = "BT1REDE";
            BT1REDE.Size = new Size(165, 31);
            BT1REDE.TabIndex = 1;
            BT1REDE.Text = "Redes";
            BT1REDE.UseVisualStyleBackColor = false;
            BT1REDE.Click += button1_Click;
            BT1REDE.MouseEnter += BTNEnter;
            BT1REDE.MouseLeave += BTNLeave;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, pDVToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(883, 24);
            menuStrip1.TabIndex = 0;
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
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(lbOS);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbHostName);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(181, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 389);
            panel1.TabIndex = 4;
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
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(264, 7);
            panel3.Name = "panel3";
            panel3.Size = new Size(174, 66);
            panel3.TabIndex = 4;
            // 
            // lbOS
            // 
            lbOS.AutoSize = true;
            lbOS.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbOS.Location = new Point(444, 57);
            lbOS.Name = "lbOS";
            lbOS.Size = new Size(20, 17);
            lbOS.TabIndex = 0;
            lbOS.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 42);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 1;
            label4.Text = "Windows : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 8);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 3;
            label3.Text = "Nome Host Local : ";
            // 
            // lbHostName
            // 
            lbHostName.AutoSize = true;
            lbHostName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbHostName.Location = new Point(444, 23);
            lbHostName.Name = "lbHostName";
            lbHostName.Size = new Size(20, 17);
            lbHostName.TabIndex = 2;
            lbHostName.Text = "...";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(btnGravarApontamento);
            panel2.Controls.Add(tbNomehost);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(6, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 66);
            panel2.TabIndex = 0;
            // 
            // btnGravarApontamento
            // 
            btnGravarApontamento.Location = new Point(166, 31);
            btnGravarApontamento.Name = "btnGravarApontamento";
            btnGravarApontamento.Size = new Size(76, 23);
            btnGravarApontamento.TabIndex = 2;
            btnGravarApontamento.Text = "Gravar";
            btnGravarApontamento.UseVisualStyleBackColor = true;
            btnGravarApontamento.Click += btnGravarApontamento_Click;
            // 
            // tbNomehost
            // 
            tbNomehost.Location = new Point(3, 32);
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
            panel4.Location = new Point(10, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(861, 63);
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
            Controls.Add(BT1REDE);
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
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BT1REDE;
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
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label lbStatusDownload;
        private Button btDownloadPDV;
        private Button btDownloadAtualizador;
    }
}