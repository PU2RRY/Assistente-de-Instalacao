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
            progressBar1 = new ProgressBar();
            label4 = new Label();
            SuspendLayout();
            // 
            // btSelecionaArquivoBkp
            // 
            btSelecionaArquivoBkp.Location = new Point(335, 41);
            btSelecionaArquivoBkp.Name = "btSelecionaArquivoBkp";
            btSelecionaArquivoBkp.Size = new Size(72, 23);
            btSelecionaArquivoBkp.TabIndex = 0;
            btSelecionaArquivoBkp.Text = "Selecionar";
            btSelecionaArquivoBkp.UseVisualStyleBackColor = true;
            btSelecionaArquivoBkp.Click += button1_Click;
            // 
            // tbCaminhoBkp
            // 
            tbCaminhoBkp.Location = new Point(12, 41);
            tbCaminhoBkp.Name = "tbCaminhoBkp";
            tbCaminhoBkp.ReadOnly = true;
            tbCaminhoBkp.Size = new Size(306, 23);
            tbCaminhoBkp.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(258, 15);
            label1.TabIndex = 2;
            label1.Text = "1 - Selecione o arquivo de backup a ser incluído";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(200, 15);
            label2.TabIndex = 3;
            label2.Text = "2 - Descreva o problema para análise";
            // 
            // tbDescricaoDoProblema
            // 
            tbDescricaoDoProblema.AcceptsReturn = true;
            tbDescricaoDoProblema.Location = new Point(12, 104);
            tbDescricaoDoProblema.Multiline = true;
            tbDescricaoDoProblema.Name = "tbDescricaoDoProblema";
            tbDescricaoDoProblema.Size = new Size(395, 98);
            tbDescricaoDoProblema.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 222);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 5;
            label3.Text = "3 - Nomeie o arquivo";
            // 
            // tbNomeDoArquivoZip
            // 
            tbNomeDoArquivoZip.Location = new Point(12, 240);
            tbNomeDoArquivoZip.Name = "tbNomeDoArquivoZip";
            tbNomeDoArquivoZip.Size = new Size(395, 23);
            tbNomeDoArquivoZip.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(12, 278);
            button1.Name = "button1";
            button1.Size = new Size(395, 26);
            button1.TabIndex = 7;
            button1.Text = "Preparar arquivo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 310);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(395, 23);
            progressBar1.TabIndex = 8;
            // 
            // label4
            // 
            label4.Location = new Point(12, 340);
            label4.Name = "label4";
            label4.Size = new Size(392, 15);
            label4.TabIndex = 9;
            label4.Text = "label4";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BackupLogsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 364);
            Controls.Add(label4);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(tbNomeDoArquivoZip);
            Controls.Add(label3);
            Controls.Add(tbDescricaoDoProblema);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbCaminhoBkp);
            Controls.Add(btSelecionaArquivoBkp);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BackupLogsForm";
            Text = "Reunir Logs e Backup";
            ResumeLayout(false);
            PerformLayout();
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
        private ProgressBar progressBar1;
        private Label label4;
    }
}