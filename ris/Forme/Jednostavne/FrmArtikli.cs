using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ris.Modeli.OK;
using ris.Repo.OK;

namespace ris.Forme.Jednostavne
{
    public partial class FrmArtikli : Form
    {
        public FrmArtikli()
        {
            InitializeComponent();
            Ucitaj();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void Ucitaj()
        {
            List<Artikl> artikli = ArtiklRepo.GetArtikli();
            dgvArtikli.DataSource = artikli;
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            FrmArtiklNovi frmArtiklNovi = new FrmArtiklNovi();
            frmArtiklNovi.ShowDialog();
            Ucitaj();
        }
    }
}
