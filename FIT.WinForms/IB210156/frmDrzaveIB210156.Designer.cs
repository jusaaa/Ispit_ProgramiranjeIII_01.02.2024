namespace FIT.WinForms.IB210156
{
    partial class frmDrzaveIB210156
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
            components = new System.ComponentModel.Container();
            btnNovaDrzava = new Button();
            dgvDrzave = new DataGridView();
            btnPrintaj = new Button();
            lblTrenutnoVrijeme = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Id = new DataGridViewTextBoxColumn();
            Zastava = new DataGridViewImageColumn();
            Drzava = new DataGridViewTextBoxColumn();
            BrojGradova = new DataGridViewTextBoxColumn();
            Aktivna = new DataGridViewCheckBoxColumn();
            Gradovi = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).BeginInit();
            SuspendLayout();
            // 
            // btnNovaDrzava
            // 
            btnNovaDrzava.Location = new Point(830, 12);
            btnNovaDrzava.Name = "btnNovaDrzava";
            btnNovaDrzava.Size = new Size(132, 29);
            btnNovaDrzava.TabIndex = 0;
            btnNovaDrzava.Text = "Nova država";
            btnNovaDrzava.UseVisualStyleBackColor = true;
            btnNovaDrzava.Click += btnNovaDrzava_Click;
            // 
            // dgvDrzave
            // 
            dgvDrzave.AllowUserToAddRows = false;
            dgvDrzave.AllowUserToDeleteRows = false;
            dgvDrzave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrzave.Columns.AddRange(new DataGridViewColumn[] { Id, Zastava, Drzava, BrojGradova, Aktivna, Gradovi });
            dgvDrzave.Location = new Point(12, 62);
            dgvDrzave.Name = "dgvDrzave";
            dgvDrzave.ReadOnly = true;
            dgvDrzave.RowHeadersWidth = 51;
            dgvDrzave.RowTemplate.Height = 29;
            dgvDrzave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrzave.Size = new Size(950, 282);
            dgvDrzave.TabIndex = 1;
            dgvDrzave.CellContentClick += dgvDrzave_CellContentClick;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(830, 350);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(132, 29);
            btnPrintaj.TabIndex = 2;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // lblTrenutnoVrijeme
            // 
            lblTrenutnoVrijeme.AutoSize = true;
            lblTrenutnoVrijeme.Location = new Point(12, 421);
            lblTrenutnoVrijeme.Name = "lblTrenutnoVrijeme";
            lblTrenutnoVrijeme.Size = new Size(50, 20);
            lblTrenutnoVrijeme.TabIndex = 3;
            lblTrenutnoVrijeme.Text = "label1";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Zastava
            // 
            Zastava.DataPropertyName = "Zastava";
            Zastava.HeaderText = "Zastava";
            Zastava.MinimumWidth = 6;
            Zastava.Name = "Zastava";
            Zastava.ReadOnly = true;
            Zastava.Width = 125;
            // 
            // Drzava
            // 
            Drzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Drzava.DataPropertyName = "Drzava";
            Drzava.HeaderText = "Država";
            Drzava.MinimumWidth = 6;
            Drzava.Name = "Drzava";
            Drzava.ReadOnly = true;
            // 
            // BrojGradova
            // 
            BrojGradova.DataPropertyName = "BrojGradova";
            BrojGradova.HeaderText = "Broj gradova";
            BrojGradova.MinimumWidth = 6;
            BrojGradova.Name = "BrojGradova";
            BrojGradova.ReadOnly = true;
            BrojGradova.Width = 125;
            // 
            // Aktivna
            // 
            Aktivna.DataPropertyName = "Aktivna";
            Aktivna.HeaderText = "Aktivna";
            Aktivna.MinimumWidth = 6;
            Aktivna.Name = "Aktivna";
            Aktivna.ReadOnly = true;
            Aktivna.Width = 125;
            // 
            // Gradovi
            // 
            Gradovi.DataPropertyName = "Gradovi";
            Gradovi.HeaderText = "";
            Gradovi.MinimumWidth = 6;
            Gradovi.Name = "Gradovi";
            Gradovi.ReadOnly = true;
            Gradovi.Text = "Gradovi";
            Gradovi.UseColumnTextForButtonValue = true;
            Gradovi.Width = 125;
            // 
            // frmDrzaveIB210156
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(974, 450);
            Controls.Add(lblTrenutnoVrijeme);
            Controls.Add(btnPrintaj);
            Controls.Add(dgvDrzave);
            Controls.Add(btnNovaDrzava);
            Name = "frmDrzaveIB210156";
            Text = "Države";
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovaDrzava;
        private DataGridView dgvDrzave;
        private Button btnPrintaj;
        private Label lblTrenutnoVrijeme;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewImageColumn Zastava;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn BrojGradova;
        private DataGridViewCheckBoxColumn Aktivna;
        private DataGridViewButtonColumn Gradovi;
    }
}