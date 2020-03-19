using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEL_Vertriebsmitarbeiter
{
    public class Arbeiter : Mitarbeiter
    {
        private double stundenlohn;

        public Arbeiter(int nr, string name, double stundenlohn, double urlaubsgeld) : base(nr, name, urlaubsgeld)
        {
            this.persNr = nr;
            this.name = name;
            this.stundenlohn = stundenlohn;
            this.urlaubsgeld = urlaubsgeld;
        }

        public double getGehalt(int stunden)
        {
            return this.stundenlohn * stunden;
        }
    }
}
