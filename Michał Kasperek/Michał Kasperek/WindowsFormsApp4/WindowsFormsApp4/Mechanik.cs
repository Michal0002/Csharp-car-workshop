using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    [Serializable]
    class Mechanik
    {
        public string Imię_naziwsko;
        public decimal Stawka;
        public DateTime data_rozpoczęcia;
        static public List<Mechanik> Mechanicy = new List<Mechanik>();
        //statsic wspólna lista np/ jedno pole wspólne dla wszystkich obiektów klasy

        public override string ToString()//Polimorfizm  metoda dla typu obiektu 
        {
            return Imię_naziwsko + " (" + Stawka.ToString("0.00") + "zł/godz)";
        }

        public Mechanik ( string imienazwisko, decimal stawwka, DateTime data) // konstruktor
        {
            Imię_naziwsko = imienazwisko;
            Stawka = stawwka;
            data_rozpoczęcia = data;
        }
    }
}
