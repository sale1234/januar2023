using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    [Serializable]
    public class Profesor
    {
        public int ProfesorId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public ZvanjeProfesora Zvanje { get; set; }
        public string EmailKorisnika { get; set; }

        public int BrojAngazovanja { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }

    public enum ZvanjeProfesora
    {
        Docent,
        VanredniProfesor,
        RedovniProfesor
    }
}
