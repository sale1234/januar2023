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
    public partial class UCAngazovanja : UserControl
    {
        private BindingList<Angazovanje> angazovanja;
        public UCAngazovanja()
        {
            InitializeComponent();
            Poruka poruka = new Poruka
            {
                Operacija = Operacija.VratiAngazovanja
            };
            Komunikacija.Instanca.Salji(poruka);
            Poruka odgovor = Komunikacija.Instanca.Citaj();
            angazovanja = new BindingList<Angazovanje>(odgovor.Angazovanja);
            dgvAngazovanja.DataSource = angazovanja;
            dgvAngazovanja.Columns[2].Visible = false;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if(dgvAngazovanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali nijedno angazovanje");
                return;
            }
            else
            {
                Angazovanje angazovanje = (Angazovanje)dgvAngazovanja.SelectedRows[0].DataBoundItem;
                angazovanje.Datum = dtpDatum.Value.ToShortDateString();
                angazovanje.Predmet.Angazovanja = new List<Angazovanje>();
                angazovanje.Predmet.Angazovanja.Add(angazovanje);
                Poruka poruka = new Poruka
                {
                    Predmet = angazovanje.Predmet,
                    Operacija = Operacija.UpdateAngazovanje
                };
                Komunikacija.Instanca.Salji(poruka);
            }
            dgvAngazovanja.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvAngazovanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali nijedno angazovanje");
                return;
            }
            else
            {
                Angazovanje angazovanje = (Angazovanje)dgvAngazovanja.SelectedRows[0].DataBoundItem;
                angazovanje.Predmet.Angazovanja = new List<Angazovanje>();
                angazovanje.Predmet.Angazovanja.Add(angazovanje);
                Poruka poruka = new Poruka
                {
                    Predmet = angazovanje.Predmet,
                    Operacija = Operacija.ObrisiAngazovanje
                };
                Komunikacija.Instanca.Salji(poruka);
                Poruka poruka1 = new Poruka
                {
                    Operacija = Operacija.VratiAngazovanja
                };
                Komunikacija.Instanca.Salji(poruka1);
                Poruka odgovor = Komunikacija.Instanca.Citaj();
                angazovanja = new BindingList<Angazovanje>(odgovor.Angazovanja);
                dgvAngazovanja.DataSource = angazovanja;
                dgvAngazovanja.Columns[2].Visible = false;
            }
        }
    }
}
