using System.Collections.Generic;

namespace SAEL_Vertriebsmitarbeiter
{
    class Azubi : Mitarbeiter, IAzubi
    {
        private int lehrjahr;
        private Dictionary<int, int> gehaltFuerLehrjahr = new Dictionary<int, int>()
        {
            { 1, 500 },
            { 2, 600 },
            { 3, 700 }
        };

        public Azubi(int nr, string name) : base(nr, name, gehalt: 0)
        {
            this.personalNummer = nr;
            this.name = name;
            this.lehrjahr = 1;
        }

        public void naechstesLehrjahr()
        {
            this.lehrjahr += 1;
        }

        public override double ermittleGehalt()
        {
            return this.gehaltFuerLehrjahr[this.lehrjahr];
        }
    }
}
