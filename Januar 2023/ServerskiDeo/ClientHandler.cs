using Biblioteka;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerskiDeo
{
    public class ClientHandler
    {
        private Socket klijentSoket;
        private List<ClientHandler> clients;
        private List<Radnik> radnici;
        private CommunicationHelper helper;

        public ClientHandler(Socket klijentSoket, List<ClientHandler> clients, List<Radnik> radnici)
        {
            this.klijentSoket = klijentSoket;
            this.clients = clients;
            this.radnici = radnici;
            helper = new CommunicationHelper(klijentSoket);
        }

        internal void HandleRequests()
        {
            try
            {
                while(true)
                {
                    Poruka poruka = helper.ReadMessage<Poruka>();
                    switch (poruka.Operacija)
                    {
                        case Operacija.Login:
                            Login(poruka);
                            break;
                        case Operacija.DodajProfesora:
                            DodajProfesora(poruka);
                            break;
                        case Operacija.VratiProfesore:
                            VratiProfesore();
                            break;
                        case Operacija.SacuvajPredmet:
                            SacuvajPredmet(poruka);
                            break;
                        case Operacija.VratiPredmete:
                            VratiPredmete(poruka);
                            break;
                        case Operacija.VratiAngazovanja:
                            VratiAngazovanja();
                            break;
                        case Operacija.VratiSvePredmete:
                            VratiSvePredmete();
                            break;
                        case Operacija.DodajAngazovanja:
                            DodajAngazovanja(poruka);
                            break;
                        case Operacija.UpdateAngazovanje:
                            UpdateAngazovanje(poruka);
                            break;
                        case Operacija.ObrisiAngazovanje:
                            ObrisiAngazovanje(poruka);
                            break;
                        default:
                            break;
                    }

                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>> " + ex.Message);
            }
            finally
            {
                klijentSoket.Shutdown(SocketShutdown.Both);
                klijentSoket.Close();
            }
        }

        private void ObrisiAngazovanje(Poruka poruka)
        {
            Kontroler.Instanca.ObrisiAngazovanje(poruka.Predmet);
        }

        private void UpdateAngazovanje(Poruka poruka)
        {
            Kontroler.Instanca.UpdateAngazovanje(poruka.Predmet);
        }

        private void DodajAngazovanja(Poruka poruka)
        {
            Kontroler.Instanca.DodajAngazovanja(poruka.Predmet);
        }

        private void VratiSvePredmete()
        {
            List<Predmet> predmeti = Kontroler.Instanca.VratiSvePredmete();
            Poruka odgovor = new Poruka
            {
                Predmeti = predmeti
            };
            helper.SendRequest(odgovor);
        }

        private void VratiAngazovanja()
        {
            List<Angazovanje> angazovanja = Kontroler.Instanca.VratiAngazovanja();
            Poruka odgovor = new Poruka
            {
                Angazovanja = angazovanja
            };
            helper.SendRequest(odgovor);
        }

        private void VratiPredmete(Poruka poruka)
        {
            Profesor profesor = poruka.Profa;
            List<Predmet> predmeti = Kontroler.Instanca.VratiPredmete(profesor);
            Poruka odgovor = new Poruka
            {
                Predmeti = predmeti
            };
            helper.SendRequest(odgovor);
        }

        private void SacuvajPredmet(Poruka poruka)
        {
            Predmet predmet = poruka.Predmet;
            Kontroler.Instanca.SacuvajPredmet(predmet);
        }

        private void VratiProfesore()
        {
            List<Profesor> profesori = Kontroler.Instanca.VratiProfesore();
            Poruka odgovor = new Poruka
            {
                Profesori = profesori
            };
            helper.SendRequest(odgovor);
        }

        private void DodajProfesora(Poruka poruka)
        {
            Profesor profesor = poruka.Profa;
            Kontroler.Instanca.DodajProfesora(profesor);
        }

        public Radnik UlogovaniRadnik { get; set; }

        private void Login(Poruka poruka)
        {
            bool postoji = false;
            foreach (var radnik in radnici)
            {
                if(poruka.Radnik.Email == radnik.Email && poruka.Radnik.Sifra == radnik.Sifra)
                {
                    postoji = true;
                    UlogovaniRadnik = radnik;
                }
            }
            if(postoji)
            {
                radnici.Remove(UlogovaniRadnik);
                Poruka odgovor = new Poruka
                {
                    Uspesno = true,
                    Radnik = UlogovaniRadnik
                };
                helper.SendRequest(odgovor);
            }
            else
            {
                Poruka odgovor = new Poruka
                {
                    Uspesno = false
                };
                helper.SendRequest(odgovor);
            }
        }
    }
}
