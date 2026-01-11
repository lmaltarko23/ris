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
            FrmDjelatnici frmDjelatnici = new FrmDjelatnici();
            frmDjelatnici.ShowDialog();

        }
    }
}
