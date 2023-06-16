namespace projeto1
{
    partial class PingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingForm));
            startping = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            meuip = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ipsrede = new Button();
            SuspendLayout();
            // 
            // startping
            // 
            startping.Location = new Point(195, 86);
            startping.Name = "startping";
            startping.Size = new Size(76, 26);
            startping.TabIndex = 0;
            startping.Text = "START";
            startping.UseVisualStyleBackColor = true;
            startping.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Digite o IP :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 23);
            textBox1.TabIndex = 2;
            // 
            // meuip
            // 
            meuip.Location = new Point(12, 86);
            meuip.Name = "meuip";
            meuip.Size = new Size(75, 26);
            meuip.TabIndex = 5;
            meuip.Text = "Meu IP";
            meuip.UseVisualStyleBackColor = true;
            meuip.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(12, 118);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 53);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(47, 23);
            textBox3.TabIndex = 8;
            textBox3.Text = "5";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(12, 59);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(104, 21);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ping infinito";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(113, 59);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(105, 21);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nª de vezes :";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // ipsrede
            // 
            ipsrede.Location = new Point(93, 86);
            ipsrede.Name = "ipsrede";
            ipsrede.Size = new Size(96, 26);
            ipsrede.TabIndex = 11;
            ipsrede.Text = "IPs em rede";
            ipsrede.UseVisualStyleBackColor = true;
            ipsrede.Click += button1_Click_1;
            // 
            // PingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(282, 179);
            Controls.Add(ipsrede);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(meuip);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(startping);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ping";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startping;
        private Label label1;
        private TextBox textBox1;
        private Button meuip;
        private TextBox textBox2;
        private TextBox textBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button ipsrede;
    }
}