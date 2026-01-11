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
    public partial class FrmDjelatnici : Form
    {
        public FrmDjelatnici()
        {
            InitializeComponent();
        }

        private void FrmDjelatnici_Load(object sender, EventArgs e)
        {
            UčitajDjelatnike();
        }

        private void UčitajDjelatnike()
        {
            List<Djelatnik> djelatnici = DjelatnikRepo.GetDjelatnici();
            dgvDjelatnici.DataSource = djelatnici;
        }
    }
}
