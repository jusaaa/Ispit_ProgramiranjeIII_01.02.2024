using FIT.Data.IB210156;
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
using Microsoft.EntityFrameworkCore;

namespace FIT.WinForms.IB210156
{
    public partial class frmGradoviIB210156 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private DrzaveIB210156? drzava;

        public frmGradoviIB210156(DrzaveIB210156? drzava)
        {
            InitializeComponent();
            this.drzava = drzava;
            lblNazivDrzave.Text = drzava.Naziv;
            pbZastava.Image = Helpers.Ekstenzije.ToImage(drzava.Zastava);
            UnesiGradoveUDgv();
        }

        private void UnesiGradoveUDgv()
        {
            var gradovi = db.GradoviIB210156.Where(g => g.DrzavaId == drzava.Id).ToList();

            dgvGradovi.Rows.Clear();
            foreach (var g in gradovi)
            {
                dgvGradovi.Rows.Add(
                    g.Id,
                    g.Naziv,
                    g.Status
                    );
            }

            dgvGradovi.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNazivGrada.Text))
            {
                MessageBox.Show("Unesite validan naziv grada!", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var postojeciGrad = db.GradoviIB210156.FirstOrDefault(g => g.Naziv.ToLower().Equals(txtNazivGrada.Text.ToLower()));
            if (postojeciGrad != null)
            {
                MessageBox.Show($"Grad {txtNazivGrada.Text} je već pohranjen!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            GradoviIB210156 gradoviIB210156 = new GradoviIB210156
            {
                Naziv = txtNazivGrada.Text,
                Status = true,
                DrzavaId = drzava.Id
            };
            db.GradoviIB210156.Add(gradoviIB210156);
            db.SaveChanges();
            UnesiGradoveUDgv();
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            int brojGradova = Convert.ToInt32(txtBrojGradova.Text);
            int aktivan = cbStatus.Checked ? 1 : 0;

            await (Task.Run(() => DodajGrad(brojGradova, aktivan)));

            UnesiGradoveUDgv();
        }

        private void DodajGrad(int brojGradova, int aktivan)
        {
            for (int i = 0; i < brojGradova; i++)
            {
                GradoviIB210156 grad = new GradoviIB210156
                {
                    Naziv = $"Grad {i + 1}.",
                    Status = cbStatus.Checked,
                    DrzavaId = drzava.Id
                };
                db.GradoviIB210156.Add(grad);
                db.SaveChanges();

                string novaPoruka = $"{DateTime.Now.ToString("dd:MM HH:mm:ss")} dodat grad Grad{i + 1}. za državu {drzava.Naziv}{Environment.NewLine}";
                Task.Delay(300).Wait();

                Invoke(new Action(() =>
                {
                    txtInfo.Text += novaPoruka;
                    txtInfo.SelectionStart = txtInfo.Text.Length;
                    txtInfo.ScrollToCaret();
                }));
            }
            MessageBox.Show($"Dodavanje novih gradova za državu {drzava.Naziv} je završeno.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvGradovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvGradovi.Columns["PromijeniStatus"].Index)
            {
                int gradId = Convert.ToInt32(dgvGradovi.Rows[e.RowIndex].Cells["Id"].Value);

                var grad=db.GradoviIB210156.FirstOrDefault(x => x.Id == gradId);
                if (grad != null)
                {
                    grad.Status = !grad.Status;
                    db.Entry(grad).State=EntityState.Modified;
                    db.SaveChanges();

                    UnesiGradoveUDgv();
                }
            }
        }
    }
}
