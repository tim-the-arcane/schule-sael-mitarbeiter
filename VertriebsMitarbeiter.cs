using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEL_Vertriebsmitarbeiter
{
    public class Vertriebsmitarbeiter : Mitarbeiter, IVertriebsmitarbeiter
    {
        private double umsatz;
        private int prozent;
        private double grenze;

        public Vertriebsmitarbeiter(int nr, string name, double gehalt) : base(nr, name, gehalt)
        {
            this.personalNummer = nr;
            this.name = name;
            this.grundGehalt = gehalt;
        }

        public void setUmsatz(double betrag)
        {
            this.umsatz = betrag;
        }

        public void setProzent(int prozent)
        {
            this.prozent = prozent;
        }

        public void setGrenze(double betrag)
        {
            this.grenze = betrag;
        }

        public override double ermittleGehalt()
        {
            double umsatzprovision = 0;

            if(this.umsatz > this.grenze)
            {
                umsatzprovision = umsatz * prozent / 100;
            }

            double gehalt = this.grundGehalt + umsatzprovision;

            return gehalt;
        }
    }
}
