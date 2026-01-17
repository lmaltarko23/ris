using ris.Modeli;
using ris.Repo;
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
        public enum ModEnum { Dodaj, Uredi};
        public ModEnum Mod { get; set; }
        public frmKategorijaDodaj()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
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
    }
}
