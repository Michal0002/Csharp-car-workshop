using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    [Serializable]
    class Naprawa
    {
        public string Nr_rejestracyjny;
        public DateTime data_naprawy;
        public Mechanik mechan;
        public decimal koszt_części;
        public decimal czas_pracy;
        public decimal należność;
        public static List<Naprawa> Naprawy = new List<Naprawa>();

    }

}
