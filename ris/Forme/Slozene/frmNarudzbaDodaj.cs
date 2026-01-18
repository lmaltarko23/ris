using ris.Modeli;
using ris.Modeli.OK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ris.Forme.Slozene
{
    public partial class frmNarudzbaDodaj : Form
    {
        public Narudzba narudzba;
        public frmNarudzbaDodaj(Narudzba _narudzba)
        {
            InitializeComponent();
            if (_narudzba != null)
            {
                txtSifra.Text = _narudzba.Id.ToString();
                cboStatus.SelectedItem = _narudzba.Status.ToString();
                cboStol.SelectedItem = _narudzba.Stol.ToString();
                cboZaprimio.SelectedItem = _narudzba.Zaprimio.ToString();
                dtpZaprimljena.Value = _narudzba.Zaprimljena;
                this.Text = "Uredi narudžbu";
            }
            else {
                txtSifra.Text = "Nedodijeljena";
                dtpZaprimljena.Value = DateTime.Now;
                this.Text = "Dodaj narudžbu";
            }

            cboStatus.DataSource = Enum.GetNames(typeof(Narudzba.StatusEnum));
            cboStol.DataSource = ris.Repo.OK.StolRepo.GetStolovi();
            cboZaprimio.DataSource = ris.Repo.OK.DjelatnikRepo.GetDjelatnici();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (cboZaprimio.SelectedItem == null || cboStol.SelectedItem == null || cboStatus.SelectedItem == null)
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }

            if (narudzba == null) dodajNarudzbu();
            else urediNarudzbu();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajNarudzbu()
        {
            Narudzba nova;

            nova = new Narudzba()
            {
                Zaprimio = cboZaprimio.SelectedItem as Djelatnik,
                Zaprimljena = dtpZaprimljena.Value,
                Status = (Narudzba.StatusEnum)Enum.Parse(typeof(Narudzba.StatusEnum), cboStatus.SelectedItem.ToString()),
                Stol = cboStol.SelectedItem as Stol
            };

            ris.Repo.NarudzbaRepo.Insert(nova);
        }

        private void urediNarudzbu()
        {
            Narudzba stara;

            stara = new Narudzba()
            {
                Zaprimio = cboZaprimio.SelectedItem as Djelatnik,
                Zaprimljena = dtpZaprimljena.Value,
                Status = (Narudzba.StatusEnum)Enum.Parse(typeof(Narudzba.StatusEnum), cboStatus.SelectedItem.ToString()),
                Stol = cboStol.SelectedItem as Stol
            };

            ris.Repo.NarudzbaRepo.Insert(stara);
        }
    }
}
