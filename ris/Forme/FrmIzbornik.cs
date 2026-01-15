using ris.Forme.Jednostavne;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ris.Forme
{
    public partial class FrmIzbornik : Form
    {
        public FrmIzbornik()
        {
            InitializeComponent();
        }

        private void btnPregledDjelatnika_Click(object sender, EventArgs e)
        {
            var frmDjelatnici = new FrmDjelatnici();
            frmDjelatnici.ShowDialog();

        }

        private void btnPregledStolova_Click(object sender, EventArgs e)
        {
            var frmStolovi = new frmStolovi();
            frmStolovi.ShowDialog();
        }

        private void btnNovaNarudzba_Click(object sender, EventArgs e)
        {
            btnNovaNarudzba.Enabled = false;
        }

        private void btnNovaNarudzba_Click_1(object sender, EventArgs e)
        {
            btnNovaNarudzba.Enabled = false;
        }

        private void btnPregledNarudzbi_Click(object sender, EventArgs e)
        {
            btnPregledNarudzbi.Enabled = false;
        }

        private void btnNaplata_Click(object sender, EventArgs e)
        {
            btnNaplata.Enabled = false;
        }

        private void btnNovaRezervacija_Click(object sender, EventArgs e)
        {
            btnNovaRezervacija.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnPregledRezervacija.Enabled = false;
        }

        private void btnPregledKategorija_Click(object sender, EventArgs e)
        {
            frmKategorija frmKategorija = new frmKategorija();
            frmKategorija.ShowDialog();
        }

        private void btnPregledArtikla_Click(object sender, EventArgs e)
        {
            FrmArtikli frmArtikli = new FrmArtikli();
            frmArtikli.ShowDialog();
        }
    }
}
