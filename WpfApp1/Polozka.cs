using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Polozka
    {
        private string Nazev;
        private int Cena;
        private int Id;

        public Polozka(string nazev, int cena, int id)
        {
            Nazev = nazev;
            Cena = cena;
            Id = id;
        }
    }
}
