namespace Assistente_de_Instalação.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnEntrarSenha = new Button();
            tbSenha = new TextBox();
            lbSenha = new Label();
            btnSenhaSair = new Button();
            SuspendLayout();
            // 
            // btnEntrarSenha
            // 
            btnEntrarSenha.BackColor = Color.CornflowerBlue;
            btnEntrarSenha.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrarSenha.Location = new Point(108, 75);
            btnEntrarSenha.Name = "btnEntrarSenha";
            btnEntrarSenha.Size = new Size(178, 46);
            btnEntrarSenha.TabIndex = 0;
            btnEntrarSenha.Text = "ENTRAR";
            btnEntrarSenha.UseVisualStyleBackColor = false;
            btnEntrarSenha.Click += btnEntrarSenha_Click;
            // 
            // tbSenha
            // 
            tbSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbSenha.Location = new Point(13, 40);
            tbSenha.Multiline = true;
            tbSenha.Name = "tbSenha";
            tbSenha.Size = new Size(273, 29);
            tbSenha.TabIndex = 1;
            tbSenha.KeyDown += tbSenha_KeyDown;
            tbSenha.KeyPress += tbSenha_KeyPress;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.BackColor = Color.Transparent;
            lbSenha.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbSenha.Location = new Point(13, 9);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(135, 28);
            lbSenha.TabIndex = 2;
            lbSenha.Text = "Digite a senha";
            // 
            // btnSenhaSair
            // 
            btnSenhaSair.BackColor = Color.CornflowerBlue;
            btnSenhaSair.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSenhaSair.Location = new Point(13, 75);
            btnSenhaSair.Name = "btnSenhaSair";
            btnSenhaSair.Size = new Size(89, 46);
            btnSenhaSair.TabIndex = 3;
            btnSenhaSair.Text = "SAIR";
            btnSenhaSair.UseVisualStyleBackColor = false;
            btnSenhaSair.Click += btnSenhaSair_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 128);
            Controls.Add(btnSenhaSair);
            Controls.Add(lbSenha);
            Controls.Add(tbSenha);
            Controls.Add(btnEntrarSenha);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            KeyDown += Login_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Login_KeyEventArgs(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnEntrarSenha;
        private TextBox tbSenha;
        private Label lbSenha;
        private Button btnSenhaSair;
    }
}