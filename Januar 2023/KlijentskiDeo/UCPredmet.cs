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
    public partial class UCPredmet : UserControl
    {
        private BindingList<Angazovanje> angazovanja = new BindingList<Angazovanje>();
        public UCPredmet()
        {
            InitializeComponent();
            Poruka poruka = new Poruka
            {
                Operacija = Operacija.VratiProfesore
            };
            Komunikacija.Instanca.Salji(poruka);
            Poruka odgovor = Komunikacija.Instanca.Citaj();
            cbProfesori.DataSource = odgovor.Profesori;
        }

        private void btnDodajAngazovanje_Click(object sender, EventArgs e)
        {
            Profesor profesor = (Profesor)cbProfesori.SelectedItem;
            profesor.BrojAngazovanja++;
            if(profesor.BrojAngazovanja > 3)
            {
                MessageBox.Show("Profesor ne moze biti angazovan na vise od 3 predmeta!");
                btnDodajAngazovanje.Enabled = false;
                return;
            }
            Angazovanje angazovanje = new Angazovanje
            {
                Profesor = profesor,
                Datum = dtpDatum.Value.ToShortDateString(),
                EmailKorisnika = Komunikacija.Instanca.UlogovaniRadnik.Email
            };
            angazovanja.Add(angazovanje);
            dgvAngazovanja.DataSource = angazovanja;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Predmet predmet = new Predmet
            {
                SifraPredmeta = txtSifraPredmeta.Text,
                NazivPredmeta = txtNazivPredmeta.Text,
                KodPredmeta = txtKodPredmeta.Text,
                BrojESPB = Convert.ToInt32(txtBrojESPB.Text),
                Angazovanja = angazovanja.ToList()
            };
            Poruka poruka = new Poruka
            {
                Predmet = predmet,
                Operacija = Operacija.SacuvajPredmet
            };
            Komunikacija.Instanca.Salji(poruka);
            
        }
    }
}
