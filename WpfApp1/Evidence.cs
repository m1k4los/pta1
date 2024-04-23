using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Evidence
    {
        private List<Polozka> Polozky;

        public Evidence()
        {
            Polozky = new List<Polozka>();
        }

        public void PridatPolozku(Polozka polozka)
        {
            Polozky.Add(polozka);
        }
    }
}
