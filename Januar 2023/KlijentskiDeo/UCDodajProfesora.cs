using Biblioteka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlijentskiDeo
{
    public partial class UCDodajProfesora : UserControl
    {
        public UCDodajProfesora()
        {
            InitializeComponent();
            txtEmail.Text = Komunikacija.Instanca.UlogovaniRadnik.Email;
            cbZvanje.DataSource = Enum.GetValues(typeof(ZvanjeProfesora));
        }

        private void btnDodajProfesora_Click(object sender, EventArgs e)
        {
            if(txtIme.Text == "" || txtPrezime.Text == "")
            {
                MessageBox.Show("Niste uneli sve podatke probajte ponovo");
                return;
            }
            Poruka poruka = new Poruka
            {
                Profa = new Profesor
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Zvanje = (ZvanjeProfesora)cbZvanje.SelectedItem,
                    EmailKorisnika = txtEmail.Text
                },
                Operacija = Operacija.DodajProfesora
            };
            Komunikacija.Instanca.Salji(poruka);
        }
    }
}
