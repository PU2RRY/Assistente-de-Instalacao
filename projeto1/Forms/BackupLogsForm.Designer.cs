namespace Assistente_de_Instalação.Forms
{
    partial class BackupLogsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupLogsForm));
            btSelecionaArquivoBkp = new Button();
            tbCaminhoBkp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbDescricaoDoProblema = new TextBox();
            label3 = new Label();
            tbNomeDoArquivoZip = new TextBox();
            button1 = new Button();
            progressBar = new ProgressBar();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btSelecionaArquivoBkp
            // 
            btSelecionaArquivoBkp.Location = new Point(308, 32);
            btSelecionaArquivoBkp.Name = "btSelecionaArquivoBkp";
            btSelecionaArquivoBkp.Size = new Size(72, 23);
            btSelecionaArquivoBkp.TabIndex = 0;
            btSelecionaArquivoBkp.Text = "Selecionar";
            btSelecionaArquivoBkp.UseVisualStyleBackColor = true;
            btSelecionaArquivoBkp.Click += button1_Click;
            // 
            // tbCaminhoBkp
            // 
            tbCaminhoBkp.Location = new Point(8, 32);
            tbCaminhoBkp.Name = "tbCaminhoBkp";
            tbCaminhoBkp.ReadOnly = true;
            tbCaminhoBkp.Size = new Size(294, 23);
            tbCaminhoBkp.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 5);
            label1.Name = "label1";
            label1.Size = new Size(376, 21);
            label1.TabIndex = 2;
            label1.Text = "1 - Selecione o arquivo de backup a ser incluído";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 4);
            label2.Name = "label2";
            label2.Size = new Size(297, 21);
            label2.TabIndex = 3;
            label2.Text = "2 - Descreva o problema para análise";
            // 
            // tbDescricaoDoProblema
            // 
            tbDescricaoDoProblema.AcceptsReturn = true;
            tbDescricaoDoProblema.Location = new Point(3, 28);
            tbDescricaoDoProblema.Multiline = true;
            tbDescricaoDoProblema.Name = "tbDescricaoDoProblema";
            tbDescricaoDoProblema.Size = new Size(381, 63);
            tbDescricaoDoProblema.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 5);
            label3.Name = "label3";
            label3.Size = new Size(174, 21);
            label3.TabIndex = 5;
            label3.Text = "3 - Nomeie o arquivo";
            // 
            // tbNomeDoArquivoZip
            // 
            tbNomeDoArquivoZip.Location = new Point(3, 31);
            tbNomeDoArquivoZip.Name = "tbNomeDoArquivoZip";
            tbNomeDoArquivoZip.Size = new Size(299, 23);
            tbNomeDoArquivoZip.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(308, 31);
            button1.Name = "button1";
            button1.Size = new Size(71, 23);
            button1.TabIndex = 7;
            button1.Text = "Preparar arquivo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(4, 60);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(375, 23);
            progressBar.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(tbCaminhoBkp);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btSelecionaArquivoBkp);
            panel1.Location = new Point(3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 65);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Controls.Add(tbDescricaoDoProblema);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 95);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cyan;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(tbNomeDoArquivoZip);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(progressBar);
            panel3.Location = new Point(3, 173);
            panel3.Name = "panel3";
            panel3.Size = new Size(387, 92);
            panel3.TabIndex = 12;
            // 
            // BackupLogsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(393, 268);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BackupLogsForm";
            Text = "Reunir Logs e Backup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btSelecionaArquivoBkp;
        private TextBox tbCaminhoBkp;
        private Label label1;
        private Label label2;
        private TextBox tbDescricaoDoProblema;
        private Label label3;
        private TextBox tbNomeDoArquivoZip;
        private Button button1;
        private ProgressBar progressBar;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}