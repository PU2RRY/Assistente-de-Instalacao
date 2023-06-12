namespace Assistente_de_Instalação.Forms
{
    partial class MaquinasDCSPDV
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
            lbMaquiansDCS = new Label();
            dgvMaquinasDCS = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMaquinasDCS).BeginInit();
            SuspendLayout();
            // 
            // lbMaquiansDCS
            // 
            lbMaquiansDCS.AutoSize = true;
            lbMaquiansDCS.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaquiansDCS.Location = new Point(206, 9);
            lbMaquiansDCS.Name = "lbMaquiansDCS";
            lbMaquiansDCS.Size = new Size(263, 37);
            lbMaquiansDCS.TabIndex = 0;
            lbMaquiansDCS.Text = "Maquinas DCS PDV";
            // 
            // dgvMaquinasDCS
            // 
            dgvMaquinasDCS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaquinasDCS.Location = new Point(12, 57);
            dgvMaquinasDCS.Name = "dgvMaquinasDCS";
            dgvMaquinasDCS.RowTemplate.Height = 25;
            dgvMaquinasDCS.Size = new Size(656, 247);
            dgvMaquinasDCS.TabIndex = 1;
            // 
            // MaquinasDCSPDV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(681, 321);
            Controls.Add(dgvMaquinasDCS);
            Controls.Add(lbMaquiansDCS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MaquinasDCSPDV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MaquinasDCSPDV";
            Load += MaquinasDCSPDV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaquinasDCS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMaquiansDCS;
        private DataGridView dgvMaquinasDCS;
    }
}