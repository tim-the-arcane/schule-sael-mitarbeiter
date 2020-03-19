using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEL_Vertriebsmitarbeiter
{
    public class Mitarbeiter : IMitarbeiter
    {
        protected int persNr;
        protected string name;
        protected double urlaubsgeld;

        public Mitarbeiter(int nr, string name, double urlaubsgeld)
        {
            this.persNr = nr;
            this.name = name;
            this.urlaubsgeld = urlaubsgeld;
        }

        public int getPersNr()
        {
            return this.persNr;
        }

        public string getName()
        {
            return this.name;
        }
    }
}
