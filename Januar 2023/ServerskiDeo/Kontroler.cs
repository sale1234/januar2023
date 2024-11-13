using Biblioteka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerskiDeo
{
    public class Kontroler
    {
        private static Kontroler instanca;
        private List<Radnik> radnici = new List<Radnik>();

        private Kontroler()
        {
            PopuniPodatke();
        }

        public static Kontroler Instanca
        {
            get
            {
                if (instanca == null) instanca = new Kontroler();
                return instanca;
            }
        }

        internal List<Profesor> VratiBrojPoZvanju()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiBrojPoZvanju();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal List<Profesor> VratiProfesoreSaBrojemPredmeta()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiProfesoreSaBrojemPredmeta();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal List<Radnik> VratiRadnike()
        {
            return radnici;
        }

        private void PopuniPodatke()
        {
            Radnik radnik = new Radnik
            {
                Ime = "Filip",
                Prezime = "Jovanovic",
                Email = "fico@gmail.com",
                Sifra = "fico"
            };
            Radnik radnik1 = new Radnik
            {
                Ime = "Vuk",
                Prezime = "Djedovic",
                Email = "djedara@gmail.com",
                Sifra = "djedara"
            };
            radnici.Add(radnik);
            radnici.Add(radnik1);
        }
        private Broker broker = new Broker();
        internal void DodajProfesora(Profesor profesor)
        {
            try
            {
                broker.OpenConnection();
                broker.DodajProfesora(profesor);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal List<Profesor> VratiProfesore()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiProfesore();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal List<Predmet> VratiSvePredmete()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiSvePredmete();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal void UpdateAngazovanje(Predmet predmet)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();
                foreach (var angazovanje in predmet.Angazovanja)
                {
                    broker.UpdateAngazovanje(angazovanje);
                }
                broker.Commit();
            }
            catch (Exception ex)
            {
                broker.Rollback();
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal void ObrisiAngazovanje(Predmet predmet)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();
                foreach (var angazovanje in predmet.Angazovanja)
                {
                    broker.ObrisiAngazovanje(angazovanje);
                }
                broker.Commit();
            }
            catch (Exception ex)
            {
                broker.Rollback();
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal void DodajAngazovanja(Predmet predmet)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();
                foreach (var angazovanje in predmet.Angazovanja)
                {
                    broker.DodajAngazovanje(angazovanje);
                }
                broker.Commit();
            }
            catch (Exception)
            {
                broker.Rollback();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal List<Angazovanje> VratiAngazovanja()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiAngazovanja();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal void SacuvajPredmet(Predmet predmet)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();
                broker.DodajPredmet(predmet);
                foreach (var angazovanje in predmet.Angazovanja)
                {
                    angazovanje.Predmet.PredmetId = broker.VratiPredmetId();
                    broker.DodajAngazovanje(angazovanje);
                }
                broker.Commit();
            }
            catch (Exception)
            {
                broker.Rollback();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal List<Predmet> VratiPredmete(Profesor profesor)
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiPredmete(profesor);
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
