using ris.Forme;
using ris.Dll;

namespace ris
{
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
            MyDB.OpenConn();

            
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {

            string text = "";
            if (txtKorime.Text == "") text = "Korisnièko ime nije uneseno";
            else if (txtLozinka.Text == "") text = "Lozinka nije unesena";
            
            if (text != "") MessageBox.Show("Korisnièko ime nije uneseno", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

            string korime = "admin";
            string lozinka = "admin";

            if (txtKorime.Text == korime && txtLozinka.Text == lozinka)
            {
                //MessageBox.Show("Prijava uspješna", "Prijava uspješna", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmIzbornik frmIzbornik = new FrmIzbornik();
                Hide();
                frmIzbornik.ShowDialog();
                Close();
            }
            else MessageBox.Show("Korisnièki podatci neispravni", "Neuspjela prijava", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
