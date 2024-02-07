namespace FIT.WinForms.IB210156
{
    partial class frmGradoviIB210156
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
            pbZastava = new PictureBox();
            lblNazivDrzave = new Label();
            label1 = new Label();
            txtNazivGrada = new TextBox();
            btnDodaj = new Button();
            dgvGradovi = new DataGridView();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            label3 = new Label();
            btnGenerisi = new Button();
            cbStatus = new CheckBox();
            txtBrojGradova = new TextBox();
            label2 = new Label();
            Id = new DataGridViewTextBoxColumn();
            NazivGrada = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            PromijeniStatus = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 21);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(153, 93);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            // 
            // lblNazivDrzave
            // 
            lblNazivDrzave.AutoSize = true;
            lblNazivDrzave.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNazivDrzave.Location = new Point(171, 49);
            lblNazivDrzave.Name = "lblNazivDrzave";
            lblNazivDrzave.Size = new Size(0, 37);
            lblNazivDrzave.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 140);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 2;
            label1.Text = "Unesite naziv novog grada:";
            // 
            // txtNazivGrada
            // 
            txtNazivGrada.Location = new Point(206, 136);
            txtNazivGrada.Name = "txtNazivGrada";
            txtNazivGrada.Size = new Size(259, 27);
            txtNazivGrada.TabIndex = 3;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(483, 136);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvGradovi
            // 
            dgvGradovi.AllowUserToAddRows = false;
            dgvGradovi.AllowUserToDeleteRows = false;
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { Id, NazivGrada, Aktivan, PromijeniStatus });
            dgvGradovi.Location = new Point(12, 185);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.ReadOnly = true;
            dgvGradovi.RowHeadersWidth = 51;
            dgvGradovi.RowTemplate.Height = 29;
            dgvGradovi.Size = new Size(565, 157);
            dgvGradovi.TabIndex = 5;
            dgvGradovi.CellContentClick += dgvGradovi_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(cbStatus);
            groupBox1.Controls.Add(txtBrojGradova);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 357);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(565, 192);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(6, 87);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(553, 99);
            txtInfo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 64);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 8;
            label3.Text = "Info:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(359, 26);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 7;
            btnGenerisi.Text = "Generiši";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(257, 29);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(76, 24);
            cbStatus.TabIndex = 2;
            cbStatus.Text = "Aktivni";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // txtBrojGradova
            // 
            txtBrojGradova.Location = new Point(110, 29);
            txtBrojGradova.Name = "txtBrojGradova";
            txtBrojGradova.Size = new Size(125, 27);
            txtBrojGradova.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 32);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 0;
            label2.Text = "Broj gradova:";
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
            // NazivGrada
            // 
            NazivGrada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NazivGrada.DataPropertyName = "NazivGrada";
            NazivGrada.HeaderText = "Naziv grada";
            NazivGrada.MinimumWidth = 6;
            NazivGrada.Name = "NazivGrada";
            NazivGrada.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Width = 125;
            // 
            // PromijeniStatus
            // 
            PromijeniStatus.DataPropertyName = "PromijeniStatus";
            PromijeniStatus.HeaderText = "";
            PromijeniStatus.MinimumWidth = 6;
            PromijeniStatus.Name = "PromijeniStatus";
            PromijeniStatus.ReadOnly = true;
            PromijeniStatus.Text = "Promijeni status";
            PromijeniStatus.UseColumnTextForButtonValue = true;
            PromijeniStatus.Width = 125;
            // 
            // frmGradoviIB210156
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 561);
            Controls.Add(groupBox1);
            Controls.Add(dgvGradovi);
            Controls.Add(btnDodaj);
            Controls.Add(txtNazivGrada);
            Controls.Add(label1);
            Controls.Add(lblNazivDrzave);
            Controls.Add(pbZastava);
            Name = "frmGradoviIB210156";
            Text = "Podaci o gradu";
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label lblNazivDrzave;
        private Label label1;
        private TextBox txtNazivGrada;
        private Button btnDodaj;
        private DataGridView dgvGradovi;
        private GroupBox groupBox1;
        private CheckBox cbStatus;
        private TextBox txtBrojGradova;
        private Label label2;
        private Button btnGenerisi;
        private TextBox txtInfo;
        private Label label3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NazivGrada;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn PromijeniStatus;
    }
}