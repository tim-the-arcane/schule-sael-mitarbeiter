using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEL_Vertriebsmitarbeiter
{
    class Sachbearbeiter : Mitarbeiter, ISachbearbeiter
    {
        private string sachgebiet;

        public Sachbearbeiter(int nr, string name, double gehalt, string gebiet) : base(nr, name, gehalt)
        {
            this.personalNummer = nr;
            this.name = name;
            this.grundGehalt = gehalt;
            this.sachgebiet = gebiet;
        }

        public override double ermittleGehalt()
        {
            return grundGehalt;
        }
    }
}
