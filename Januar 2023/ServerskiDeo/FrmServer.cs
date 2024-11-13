using Biblioteka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerskiDeo
{
    public partial class FrmServer : Form
    {
        private Server server;
        private BindingList<Profesor> profesori = new BindingList<Profesor>(Kontroler.Instanca.VratiProfesoreSaBrojemPredmeta());
        private BindingList<Profesor> brojProfesoraPoZvanju = new BindingList<Profesor>(Kontroler.Instanca.VratiBrojPoZvanju());
        public FrmServer()
        {
            InitializeComponent();
            dgvProfesori.DataSource = profesori;
            dgvProfesori.Columns[0].Visible = false;
            dgvProfesori.Columns["EmailKorisnika"].Visible = false;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();
            dgvZvanje.DataSource = brojProfesoraPoZvanju;
            dgvZvanje.Columns[0].Visible = false;
            dgvZvanje.Columns[1].Visible = false;
            dgvZvanje.Columns[2].Visible = false;
            dgvZvanje.Columns[4].Visible = false;
            dgvZvanje.Columns[5].HeaderText = "Broj profesora";
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 5000;
            timer1.Tick += Timer_Tick1;
            timer1.Start();
        }

        private void Timer_Tick1(object sender, EventArgs e)
        {
            dgvZvanje.DataSource = null;
            brojProfesoraPoZvanju = new BindingList<Profesor>(Kontroler.Instanca.VratiBrojPoZvanju());
            dgvZvanje.DataSource = brojProfesoraPoZvanju;
            dgvZvanje.Columns[0].Visible = false;
            dgvZvanje.Columns[1].Visible = false;
            dgvZvanje.Columns[2].Visible = false;
            dgvZvanje.Columns[4].Visible = false;
            dgvZvanje.Columns[5].HeaderText = "Broj profesora";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dgvProfesori.DataSource = null;
            profesori = new BindingList<Profesor>(Kontroler.Instanca.VratiProfesoreSaBrojemPredmeta());
            dgvProfesori.DataSource = profesori;
            dgvProfesori.Columns[0].Visible = false;
            dgvProfesori.Columns["EmailKorisnika"].Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new Server();
            try
            {
                server.Start();
                MessageBox.Show("Server je pokrenut");
                Thread nit = new Thread(server.HandleClients);
                nit.Start();
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
