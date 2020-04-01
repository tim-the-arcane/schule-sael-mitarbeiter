using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEL_Vertriebsmitarbeiter
{
    public abstract class Mitarbeiter : IMitarbeiter
    {
        protected int personalNummer;
        protected string name;
        protected double grundGehalt;

        public Mitarbeiter(int nr, string name, double gehalt)
        {
            this.personalNummer = nr;
            this.name = name;
            this.grundGehalt = gehalt;
        }

        public int getPersonalnummer()
        {
            return this.personalNummer;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setGrundgehalt(double betrag)
        {
            this.grundGehalt = betrag;
        }

        public abstract double ermittleGehalt();
    }
}
