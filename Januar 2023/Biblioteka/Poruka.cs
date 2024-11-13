using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    [Serializable]
    public class Poruka
    {
        public Operacija Operacija { get; set; }
        public Radnik Radnik { get; set; }
        public bool Uspesno { get; set; }

        public List<Profesor> Profesori { get; set; }
        public List<Predmet> Predmeti { get; set; }
        public Profesor Profa { get; set; }
        public List<Angazovanje> Angazovanja { get; set; }
        public Predmet Predmet { get; set; }
    }

    public enum Operacija
    {
        Login,
        DodajProfesora,
        VratiProfesore,
        SacuvajPredmet,
        VratiPredmete,
        VratiAngazovanja,
        VratiSvePredmete,
        DodajAngazovanja,
        UpdateAngazovanje,
        ObrisiAngazovanje
    }
}
