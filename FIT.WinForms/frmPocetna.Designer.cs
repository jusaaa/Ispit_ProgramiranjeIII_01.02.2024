namespace FIT.WinForms
{
    partial class frmPocetna
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
            btnIzvjestaj = new Button();
            lblKonekcijaInfo = new Label();
            btnDrzaveGradovi = new Button();
            btnPretraga = new Button();
            SuspendLayout();
            // 
            // btnIzvjestaj
            // 
            btnIzvjestaj.Location = new Point(158, 140);
            btnIzvjestaj.Margin = new Padding(3, 4, 3, 4);
            btnIzvjestaj.Name = "btnIzvjestaj";
            btnIzvjestaj.Size = new Size(207, 31);
            btnIzvjestaj.TabIndex = 1;
            btnIzvjestaj.Text = "Izvještaj";
            btnIzvjestaj.UseVisualStyleBackColor = true;
            btnIzvjestaj.Click += btnIzvjestaj_Click;
            // 
            // lblKonekcijaInfo
            // 
            lblKonekcijaInfo.AutoSize = true;
            lblKonekcijaInfo.Font = new Font("Segoe UI", 13F);
            lblKonekcijaInfo.Location = new Point(126, 86);
            lblKonekcijaInfo.Name = "lblKonekcijaInfo";
            lblKonekcijaInfo.Size = new Size(0, 30);
            lblKonekcijaInfo.TabIndex = 2;
            // 
            // btnDrzaveGradovi
            // 
            btnDrzaveGradovi.Location = new Point(99, 178);
            btnDrzaveGradovi.Name = "btnDrzaveGradovi";
            btnDrzaveGradovi.Size = new Size(160, 55);
            btnDrzaveGradovi.TabIndex = 3;
            btnDrzaveGradovi.Text = "Države i gradovi";
            btnDrzaveGradovi.UseVisualStyleBackColor = true;
            btnDrzaveGradovi.Click += btnDrzaveGradovi_Click;
            // 
            // btnPretraga
            // 
            btnPretraga.Location = new Point(265, 178);
            btnPretraga.Name = "btnPretraga";
            btnPretraga.Size = new Size(160, 55);
            btnPretraga.TabIndex = 4;
            btnPretraga.Text = "Pretraga";
            btnPretraga.UseVisualStyleBackColor = true;
            btnPretraga.Click += btnPretraga_Click;
            // 
            // frmPocetna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 245);
            Controls.Add(btnPretraga);
            Controls.Add(btnDrzaveGradovi);
            Controls.Add(lblKonekcijaInfo);
            Controls.Add(btnIzvjestaj);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPocetna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Template 2023/24";
            Load += frmPocetna_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIzvjestaj;
        private Label lblKonekcijaInfo;
        private Button btnDrzaveGradovi;
        private Button btnPretraga;
    }
}