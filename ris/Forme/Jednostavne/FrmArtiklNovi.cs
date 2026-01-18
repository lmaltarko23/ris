using ris.Modeli.OK;
using ris.Repo.OK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ris.Forme.Jednostavne
{
    public partial class FrmArtiklNovi : Form
    {
        public FrmArtiklNovi()
        {
            InitializeComponent();
            List<Kategorija> kategorije = new List<Kategorija>();
            kategorije = KategorijaRepo.GetKategorije();
            cboKategorija.DataSource = kategorije;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "" || txtOpis.Text == "" || txtCijena.Text == "")
                MessageBox.Show("Potrebno unijeti sve podatke!");
            else
            {
                var novi = new Artikl
                {
                    Cijena = float.Parse(txtCijena.Text),
                    Naziv = txtNaziv.Text,
                    Opis = txtOpis.Text,
                };
                ArtiklRepo.Insert(novi);
            }

        }

        private void cboKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            var odabranaKat = cboKategorija.SelectedItem as Kategorija;
            
        }
    }
}
