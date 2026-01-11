using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ris.Modeli;
using ris.Repo;

namespace ris.Forme.Jednostavne
{
    public partial class frmStolovi : Form
    {
        public frmStolovi()
        {
            InitializeComponent();
        }

        private void frmStolovi_Load(object sender, EventArgs e)
        {
            DohvatiStolove();
        }

        private void DohvatiStolove()
        {
            List<Stol> stolovi = StolRepo.GetStolovi();
            dgvStolovi.DataSource = stolovi;
        }
    }
}
