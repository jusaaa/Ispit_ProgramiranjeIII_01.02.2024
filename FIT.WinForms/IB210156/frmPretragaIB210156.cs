using FIT.Data;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB210156
{
    public partial class frmPretragaIB210156 : Form
    {
        DLWMSDbContext db=new DLWMSDbContext();
        public frmPretragaIB210156()
        {
            InitializeComponent();
            PopuniDrzaveCmb();
            cmbDrzava.SelectedIndex = 0;
            PretraziGradoveDrzave(null, EventArgs.Empty);
            cmbDrzava.SelectedIndexChanged += PretraziGradoveDrzave;
            OsvjeziRezultate(null,EventArgs.Empty);
            cmbDrzava.SelectedIndexChanged += OsvjeziRezultate;
            cmbGrad.SelectedIndexChanged += OsvjeziRezultate;
        }

        private void OsvjeziRezultate(object sender,EventArgs E)
        {
            int gradId = Convert.ToInt32(cmbGrad.SelectedValue);
            List<Student> rezultati=PretraziStudenteUBazi(gradId);
            var drzavaId=Convert.ToInt32(cmbDrzava.SelectedValue);
            if(rezultati.Count == 0)
            {
                MessageBox.Show($"U bazi podataka nije evidentiran niti jedan student rođen u gradu {PronadjiNazivGrada(gradId)},{PronadjiNazivDrzave(drzavaId)}","Nema rezultata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            AzurirajRezultateUDgv(rezultati);
        }
        private string PronadjiNazivDrzave(int drzavaId)
        {
            var Drzava = db.DrzaveIB210156.Find(drzavaId);

            return $"{Drzava.Naziv}";
        }
        private string PronadjiNazivGrada(int gradId)
        {
            var Grad = db.GradoviIB210156.Find(gradId);

            return $"{Grad.Naziv}";
        }
        private void PopuniDrzaveCmb()
        {
            var drzave=db.DrzaveIB210156.ToList();
            cmbDrzava.ValueMember = "Id";
            cmbDrzava.DisplayMember = "Naziv";
            cmbDrzava.DataSource = drzave;
        }
        private void PretraziGradoveDrzave(object sender, EventArgs e)
        {
            int drzavaId=Convert.ToInt32(cmbDrzava.SelectedValue);

            var gradoviDrzave=db.GradoviIB210156.Where(g=>g.DrzavaId==drzavaId).ToList();

            cmbGrad.ValueMember = "Id";
            cmbGrad.DisplayMember= "Naziv";
            cmbGrad.DataSource = gradoviDrzave;
        }
        private List<Student> PretraziStudenteUBazi(int gradId)
        {
            var studentiGradovi=db.Studenti.Where(g=>g.GradId==gradId)
                .Include(s=>s.grad)
                .ToList();
            return studentiGradovi;
        }
        private void AzurirajRezultateUDgv(List<Student> studentiGradovi)
        {
        

            dgvPretraga.Rows.Clear();
            foreach (var st in studentiGradovi)
            {
                var ocjene=db.PolozeniPredmeti.Where(s=>s.StudentId==st.Id).Select(s=>s.Ocjena).ToList();

                double prosjecnaOcjena = ocjene.Any()?ocjene.Average():5;
                double roundProsjecna = Math.Round(prosjecnaOcjena, 2);

                dgvPretraga.Rows.Add(
                    st.Ime,
                    st.Prezime,
                    st.grad.Naziv,
                    st.grad.drzava.Naziv,
                    roundProsjecna
                    );
            }
            dgvPretraga.Refresh();

        }
    }
}
