using ris.Modeli;
using ris.Repo;
using ris.Repo.OK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ris.Forme.Slozene
{
    public partial class FrmNarudzbe : Form
    {
        public FrmNarudzbe()
        {
            InitializeComponent();
            UčitajNarudzbe();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var frmNarudzbaDodaj = new frmNarudzbaDodaj(null);
            frmNarudzbaDodaj.ShowDialog();
            UčitajNarudzbe();

        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            var frmNarudzbaDodaj = new frmNarudzbaDodaj(dgvNarudzbe.CurrentRow.DataBoundItem as Narudzba);
            frmNarudzbaDodaj.ShowDialog();
            UčitajNarudzbe();

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            var narudzba = dgvNarudzbe.CurrentRow.DataBoundItem as Narudzba;
            MessageBox.Show("Brišete odabranu narudžbu. Jeste li sigurni?", "Obavijest", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            NarudzbaRepo.Delete(narudzba);

        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            UčitajNarudzbe();
        }

        private void UčitajNarudzbe()
        {
            var narudzbe = NarudzbaRepo.GetNarudzbe();
            dgvNarudzbe.DataSource = narudzbe;
        }
    }
}
