using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ris.Repo;
using ris.Modeli;

namespace ris.Forme.Jednostavne
{
    public partial class FrmArtikli : Form
    {
        public FrmArtikli()
        {
            InitializeComponent();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void Ucitaj() { 
            List<Artikl> artikli = ArtiklRepo.GetArtikli();
            dgvArtikli.DataSource = artikli;
        }
    }
}
