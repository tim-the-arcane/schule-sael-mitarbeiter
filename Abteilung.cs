using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEL_Vertriebsmitarbeiter
{
    class Abteilung : IAbteilung
    {
        private string name;
        private List<Mitarbeiter> mitarbeiterListe = new List<Mitarbeiter>();

        public Abteilung(string name)
        {
            this.name = name;
        }

        public void neuerMitarbeiter(Mitarbeiter mitarbeiter)
        {
            this.mitarbeiterListe.Add(mitarbeiter);
        }

        public double ermittlePersonalkosten()
        {
            double personalkosten = 0;

            foreach(Mitarbeiter mitarbeiter in mitarbeiterListe)
            {
                personalkosten += mitarbeiter.ermittleGehalt();
            }

            return personalkosten;
        }
    }
}
