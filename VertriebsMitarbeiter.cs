using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEL_Vertriebsmitarbeiter
{
    public class VertriebsMitarbeiter : Mitarbeiter, IVertriebsMitarbeiter
    {
        private double fixGehalt;

        public VertriebsMitarbeiter(int nr, string name, double betrag, double urlaubsgeld) : base(nr, name, urlaubsgeld)
        {
            this.persNr = nr;
            this.name = name;
            this.fixGehalt = betrag;
        }

        public double getFixGehalt()
        {
            return this.fixGehalt;
        }

        public void setFixGehalt(double betrag)
        {
            this.fixGehalt = betrag;
        }

        public double ermittleGehalt(double umsatz)
        {
            return this.fixGehalt + umsatz * 0.01;
        }
    }
}
