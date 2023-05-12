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
            button1 = new Button();
            tbCaminhoBkp = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(335, 41);
            button1.Name = "button1";
            button1.Size = new Size(72, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbCaminhoBkp
            // 
            tbCaminhoBkp.Location = new Point(12, 41);
            tbCaminhoBkp.Name = "tbCaminhoBkp";
            tbCaminhoBkp.Size = new Size(306, 23);
            tbCaminhoBkp.TabIndex = 1;
            tbCaminhoBkp.TextChanged += tbCaminhoBkp_TextChanged;
            // 
            // BackupLogsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 214);
            Controls.Add(tbCaminhoBkp);
            Controls.Add(button1);
            Name = "BackupLogsForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbCaminhoBkp;
    }
}