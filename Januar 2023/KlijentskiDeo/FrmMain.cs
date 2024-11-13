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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            lblKorisnik.Text = Komunikacija.Instanca.UlogovaniRadnik.Ime + " " + Komunikacija.Instanca.UlogovaniRadnik.Prezime;
        }

        private void dodajProfesoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCDodajProfesora());
        }

        private void dodajPredmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCPredmet());
        }

        private void prikazPredmetaNaKojimaJeAngazovanProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCPredmeti());
        }

        private void angazovanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCAngazovanja());
        }
    }
}
