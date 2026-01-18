using ris.Modeli.OK;
using ris.Repo.OK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Forms;

namespace ris.Forme.Jednostavne
{
    public partial class frmKategorijaDodaj : Form
    {
        public Kategorija kategorija;
        public frmKategorijaDodaj(Kategorija _kategorija)
        {
            InitializeComponent();
            kategorija = _kategorija;
            if (kategorija != null)
            {
                txtNaziv.Text = kategorija.Naziv;
                txtOpis.Text = kategorija.Opis;
                this.Text = "Uredi podatke o kategoriji";
            }
            else {
                this.Text = "Dodaj novu kategoriju";
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (kategorija == null) dodajKategoriju();
            else urediKategoriju();
            this.Close();
        }

        void dodajKategoriju() {
            Kategorija novaKategorija;

            if (txtNaziv.Text == "" || txtOpis.Text == "")
            {
                MessageBox.Show("Potrebno unijeti sve podatke!");
                return;
            }

            novaKategorija = new Kategorija
            {
                Naziv = txtNaziv.Text,
                Opis = txtOpis.Text,
            };

            KategorijaRepo.Insert(novaKategorija);
        }

        void urediKategoriju()
        {
            kategorija.Naziv = txtNaziv.Text;
            kategorija.Opis = txtOpis.Text;
            KategorijaRepo.Update(kategorija);
        }
    }
}
