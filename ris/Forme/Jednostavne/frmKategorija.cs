using ris.Modeli;
using ris.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ris.Forme.Jednostavne
{
    public partial class frmKategorija : Form
    {
        public frmKategorija()
        {
            InitializeComponent();
        }

        private void UčitajKategorije()
        {
            List<Kategorija> kategorije = KategorijaRepo.GetKategorije();
            dgvKategorija.DataSource = kategorije;
        }

        private void frmKategorija_Load(object sender, EventArgs e)
        {
            UčitajKategorije();
        }

        private void btnDodajNovu_Click(object sender, EventArgs e)
        {
            frmKategorijaDodaj frmKategorijaDodaj = new frmKategorijaDodaj();
            frmKategorijaDodaj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UčitajKategorije();
        }
    }
}
