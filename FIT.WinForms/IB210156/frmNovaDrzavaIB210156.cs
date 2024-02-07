using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIT.WinForms.Helpers;
using FIT.Data.IB210156;

namespace FIT.WinForms.IB210156
{
    public partial class frmNovaDrzavaIB210156 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovaDrzavaIB210156()
        {
            InitializeComponent();
        }
        bool ValidirajFormu()
        {
            if (!Validator.ProvjeriUnos(pbZastava, errorProvider1, "Unesite sliku zastave!"))
            {
                return false;
            }
            if (!Validator.ProvjeriUnos(txtNaziv, errorProvider1, "Unesite naziv države!"))
            {
                return false;
            }
            return true;
        }
        private void pbZastava_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbZastava.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(!ValidirajFormu())
            {
                MessageBox.Show("Molimo Vas da unesete sve obavezne podatke.","Pogrešan unos",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                return;
            }
            DrzaveIB210156 novaDrzava = new DrzaveIB210156 {
                Naziv = txtNaziv.Text,
                Status = cbStatus.Checked ? 1 :0,
            Zastava=Helpers.Ekstenzije.ToByteArray(pbZastava.Image)
            };
            db.DrzaveIB210156.Add(novaDrzava);
            db.SaveChanges();
            this.Close();
        }
    }
}
