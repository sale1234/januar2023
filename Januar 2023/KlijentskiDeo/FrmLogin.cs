using Biblioteka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlijentskiDeo
{
    public partial class FrmLogin : Form
    {
        private int brojac = 0;
        public FrmLogin()
        {
            InitializeComponent();
            try
            {
                Komunikacija.Instanca.Connect();
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "" || txtLozinka.Text == "")
            {
                MessageBox.Show("Niste uneli sve podatke");
                return;
            }
            Radnik radnik = new Radnik
            {
                Email = txtEmail.Text,
                Sifra = txtLozinka.Text
            };
            Poruka poruka = new Poruka
            {
                Radnik = radnik,
                Operacija = Operacija.Login
            };
            Komunikacija.Instanca.Salji(poruka);
            Poruka odgovor = Komunikacija.Instanca.Citaj();
            if(odgovor.Uspesno)
            {
                MessageBox.Show($"Dobrodosli, {odgovor.Radnik.Ime} {odgovor.Radnik.Prezime}");
                Komunikacija.Instanca.UlogovaniRadnik = odgovor.Radnik;
                DialogResult = DialogResult.OK;
            }
            else
            {
                brojac++;
                MessageBox.Show($"Neuspesna prijava, pokusajte ponovo, imate jos {3-brojac} pokusaja");
                if(brojac == 3)
                {
                    MessageBox.Show("Maksimalan broj prijava, program ce se ugasiti");
                    this.Dispose();
                }
            }
        }
    }
}
