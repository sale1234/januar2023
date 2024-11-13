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
    public partial class UCPredmeti : UserControl
    {
        private BindingList<Predmet> predmeti;
        
        public UCPredmeti()
        {
            InitializeComponent();
            Poruka poruka = new Poruka
            {
                Operacija = Operacija.VratiProfesore
            };
            Komunikacija.Instanca.Salji(poruka);
            Poruka odgovor = Komunikacija.Instanca.Citaj();
            cbProfesori.DataSource = odgovor.Profesori;
            Poruka poruka1 = new Poruka
            {
                Operacija = Operacija.VratiSvePredmete
            };
            Komunikacija.Instanca.Salji(poruka1);
            Poruka odgovor1 = Komunikacija.Instanca.Citaj();
            cbSviPredmeti.DataSource = odgovor1.Predmeti;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            Poruka poruka = new Poruka
            {
                Profa = (Profesor)cbProfesori.SelectedItem,
                Operacija = Operacija.VratiPredmete
            };
            Komunikacija.Instanca.Salji(poruka);
            Poruka odgovor = Komunikacija.Instanca.Citaj();
            predmeti = new BindingList<Predmet>(odgovor.Predmeti);
            dgvPredmeti.DataSource = predmeti;
            dgvPredmeti.Columns[0].Visible = false;
            if(predmeti.Count == 3)
            {
                btnDodaj.Enabled = false;
                MessageBox.Show("Profesor je angazovan na maksimalnom broju predmeta");
            }
            else
            {
                btnDodaj.Enabled = true;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Angazovanje angazovanje = new Angazovanje
            {
                Predmet = (Predmet)cbSviPredmeti.SelectedItem,
                Profesor = (Profesor)cbProfesori.SelectedItem,
                Datum = dtpDatum.Value.ToString(),
                EmailKorisnika = Komunikacija.Instanca.UlogovaniRadnik.Email
            };
            
            Predmet predmet = (Predmet)cbSviPredmeti.SelectedItem;
            predmet.Angazovanja = new List<Angazovanje>();
            predmet.Angazovanja.Add(angazovanje);
            Poruka poruka = new Poruka
            {
                Predmet = predmet,
                Operacija = Operacija.DodajAngazovanja
            };
            Komunikacija.Instanca.Salji(poruka);
            Poruka poruka1 = new Poruka
            {
                Profa = (Profesor)cbProfesori.SelectedItem,
                Operacija = Operacija.VratiPredmete
            };
            Komunikacija.Instanca.Salji(poruka1);
            Poruka odgovor = Komunikacija.Instanca.Citaj();
            predmeti = new BindingList<Predmet>(odgovor.Predmeti);
            dgvPredmeti.DataSource = predmeti;
            dgvPredmeti.Columns[0].Visible = false;
            if (predmeti.Count == 3)
            {
                btnDodaj.Enabled = false;
                MessageBox.Show("Profesor je angazovan na maksimalnom broju predmeta");
            }
            else
            {
                btnDodaj.Enabled = true;
            }
        }

        
    }
}
