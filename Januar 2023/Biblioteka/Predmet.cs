using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    [Serializable]
    public class Predmet
    {
        public int PredmetId { get; set; }
        public string SifraPredmeta { get; set; }
        public string NazivPredmeta { get; set; }
        public string KodPredmeta { get; set; }
        public int BrojESPB { get; set; }
        public List<Angazovanje> Angazovanja { get; set; }

        public override string ToString()
        {
            return NazivPredmeta;
        }
    }
}
