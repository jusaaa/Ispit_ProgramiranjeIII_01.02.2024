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

namespace FIT.WinForms.IB210156
{
    public partial class frmDrzaveIB210156 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmDrzaveIB210156()
        {
            InitializeComponent();
            UnesiDrzaveUDgv();

            lblTrenutnoVrijeme.Text = $"Trenutno vrijeme: {DateTime.Now.ToString("HH:mm:ss")}";
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Start();

        }

        private void UnesiDrzaveUDgv()
        {
            var drzave = db.DrzaveIB210156.ToList();

            dgvDrzave.Rows.Clear();
            foreach (var dr in drzave)
            {
                var brojGradova = db.GradoviIB210156.Where(g => g.DrzavaId == dr.Id).Count();

                dgvDrzave.Rows.Add(
                    dr.Id,
                    dr.Zastava,
                    dr.Naziv,
                    brojGradova,
                    dr.Status
                    );
            }
            dgvDrzave.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTrenutnoVrijeme.Text = $"Trenutno vrijeme: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            frmNovaDrzavaIB210156 frmNovaDrzavaIB210156 = new frmNovaDrzavaIB210156();
            DialogResult rezultat = frmNovaDrzavaIB210156.ShowDialog();
            if (rezultat == DialogResult.Cancel)
            {
                UnesiDrzaveUDgv();
            }
        }

        private void dgvDrzave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDrzave.Columns["Gradovi"].Index)
            {
                    var drzavaId = Convert.ToInt32(dgvDrzave.Rows[e.RowIndex].Cells["Id"].Value);
                    var drzava = db.DrzaveIB210156.Find(drzavaId);
              
                    frmGradoviIB210156 frmGradoviIB210156 = new frmGradoviIB210156(drzava);
                    frmGradoviIB210156.ShowDialog();
            }
        }
    }
}
