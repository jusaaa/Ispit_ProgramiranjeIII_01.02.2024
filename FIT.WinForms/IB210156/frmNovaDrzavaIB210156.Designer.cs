namespace FIT.WinForms.IB210156
{
    partial class frmNovaDrzavaIB210156
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
            label1 = new Label();
            pbZastava = new PictureBox();
            label2 = new Label();
            txtNaziv = new TextBox();
            cbStatus = new CheckBox();
            btnSacuvaj = new Button();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Zastava:";
            // 
            // pbZastava
            // 
            pbZastava.BorderStyle = BorderStyle.FixedSingle;
            pbZastava.Location = new Point(12, 49);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(345, 176);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 1;
            pbZastava.TabStop = false;
            pbZastava.DoubleClick += pbZastava_DoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 249);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(12, 272);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(345, 27);
            txtNaziv.TabIndex = 3;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(12, 333);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(80, 24);
            cbStatus.TabIndex = 4;
            cbStatus.Text = "Aktivna";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(263, 366);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovaDrzavaIB210156
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 409);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbStatus);
            Controls.Add(txtNaziv);
            Controls.Add(label2);
            Controls.Add(pbZastava);
            Controls.Add(label1);
            Name = "frmNovaDrzavaIB210156";
            Text = "Podaci o državi";
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbZastava;
        private Label label2;
        private TextBox txtNaziv;
        private CheckBox cbStatus;
        private Button btnSacuvaj;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}