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
            BT2infsis = new Button();
            BT3PainelControle = new Button();
            BT4Imp = new Button();
            BT5OpsEnergia = new Button();
            BT6TNMaquina = new Button();
            tbBackupLogs = new Button();
            SuspendLayout();
            // 
            // BT1REDE
            // 
            BT1REDE.BackColor = Color.DodgerBlue;
            BT1REDE.FlatStyle = FlatStyle.Flat;
            BT1REDE.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BT1REDE.ForeColor = SystemColors.ControlText;
            BT1REDE.Location = new Point(12, 70);
            BT1REDE.Name = "BT1REDE";
            BT1REDE.Size = new Size(482, 40);
            BT1REDE.TabIndex = 0;
            BT1REDE.Text = "Testes de REDE ";
            BT1REDE.UseVisualStyleBackColor = false;
            BT1REDE.Click += button1_Click;
            BT1REDE.MouseEnter += BTNEnter;
            BT1REDE.MouseLeave += BTNLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(482, 37);
            label1.TabIndex = 1;
            label1.Text = "ASSISTENTE DE INSTALAÇÃO";
            // 
            // BT2infsis
            // 
            BT2infsis.BackColor = Color.DodgerBlue;
            BT2infsis.FlatStyle = FlatStyle.Flat;
            BT2infsis.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BT2infsis.Location = new Point(12, 116);
            BT2infsis.Name = "BT2infsis";
            BT2infsis.Size = new Size(482, 40);
            BT2infsis.TabIndex = 2;
            BT2infsis.Tag = "";
            BT2infsis.Text = "Informações do Sistema";
            BT2infsis.UseVisualStyleBackColor = false;
            BT2infsis.Click += BT2_Click;
            BT2infsis.MouseEnter += BTNEnter;
            BT2infsis.MouseLeave += BTNLeave;
            // 
            // BT3PainelControle
            // 
            BT3PainelControle.BackColor = Color.DodgerBlue;
            BT3PainelControle.FlatStyle = FlatStyle.Flat;
            BT3PainelControle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BT3PainelControle.Location = new Point(12, 162);
            BT3PainelControle.Name = "BT3PainelControle";
            BT3PainelControle.Size = new Size(482, 40);
            BT3PainelControle.TabIndex = 3;
            BT3PainelControle.Tag = "";
            BT3PainelControle.Text = "Painel de Controle";
            BT3PainelControle.UseVisualStyleBackColor = false;
            BT3PainelControle.Click += BT3_Click;
            BT3PainelControle.MouseEnter += BTNEnter;
            BT3PainelControle.MouseLeave += BTNLeave;
            // 
            // BT4Imp
            // 
            BT4Imp.BackColor = Color.DodgerBlue;
            BT4Imp.FlatStyle = FlatStyle.Flat;
            BT4Imp.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BT4Imp.ForeColor = SystemColors.ControlText;
            BT4Imp.Location = new Point(12, 208);
            BT4Imp.Name = "BT4Imp";
            BT4Imp.Size = new Size(482, 40);
            BT4Imp.TabIndex = 4;
            BT4Imp.Text = "Dispositivos e Impressoras";
            BT4Imp.UseVisualStyleBackColor = false;
            BT4Imp.Click += button1_Click_1;
            BT4Imp.MouseEnter += BTNEnter;
            BT4Imp.MouseLeave += BTNLeave;
            // 
            // BT5OpsEnergia
            // 
            BT5OpsEnergia.BackColor = Color.DodgerBlue;
            BT5OpsEnergia.FlatStyle = FlatStyle.Flat;
            BT5OpsEnergia.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BT5OpsEnergia.ForeColor = SystemColors.ControlText;
            BT5OpsEnergia.Location = new Point(12, 254);
            BT5OpsEnergia.Name = "BT5OpsEnergia";
            BT5OpsEnergia.Size = new Size(482, 40);
            BT5OpsEnergia.TabIndex = 5;
            BT5OpsEnergia.Text = "Opções de Energia ";
            BT5OpsEnergia.UseVisualStyleBackColor = false;
            BT5OpsEnergia.Click += button1_Click_2;
            BT5OpsEnergia.MouseEnter += BTNEnter;
            BT5OpsEnergia.MouseLeave += BTNLeave;
            // 
            // BT6TNMaquina
            // 
            BT6TNMaquina.BackColor = Color.DodgerBlue;
            BT6TNMaquina.FlatStyle = FlatStyle.Flat;
            BT6TNMaquina.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BT6TNMaquina.ForeColor = SystemColors.ControlText;
            BT6TNMaquina.Location = new Point(12, 300);
            BT6TNMaquina.Name = "BT6TNMaquina";
            BT6TNMaquina.Size = new Size(482, 40);
            BT6TNMaquina.TabIndex = 6;
            BT6TNMaquina.Text = "Trocar nome de Maquina";
            BT6TNMaquina.UseVisualStyleBackColor = false;
            BT6TNMaquina.Click += BT6_Click;
            BT6TNMaquina.MouseEnter += BTNEnter;
            BT6TNMaquina.MouseLeave += BTNLeave;
            // 
            // tbBackupLogs
            // 
            tbBackupLogs.BackColor = Color.DodgerBlue;
            tbBackupLogs.FlatStyle = FlatStyle.Flat;
            tbBackupLogs.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbBackupLogs.ForeColor = SystemColors.ControlText;
            tbBackupLogs.Location = new Point(12, 346);
            tbBackupLogs.Name = "tbBackupLogs";
            tbBackupLogs.Size = new Size(482, 40);
            tbBackupLogs.TabIndex = 7;
            tbBackupLogs.Text = "Rufaz Fazer Backup e Logs";
            tbBackupLogs.UseVisualStyleBackColor = true;
            tbBackupLogs.Click += tbBackupLogs_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(507, 494);
            Controls.Add(tbBackupLogs);
            Controls.Add(BT6TNMaquina);
            Controls.Add(BT5OpsEnergia);
            Controls.Add(BT4Imp);
            Controls.Add(BT3PainelControle);
            Controls.Add(BT2infsis);
            Controls.Add(label1);
            Controls.Add(BT1REDE);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BT1REDE;
        private Label label1;
        private Button BT2infsis;
        private Button BT3PainelControle;
        private Button BT4Imp;
        private Button BT5OpsEnergia;
        private Button BT6TNMaquina;
        private Button tbBackupLogs;
    }
}