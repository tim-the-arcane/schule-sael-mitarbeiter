using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEL_Vertriebsmitarbeiter
{
    class Program
    {
        static void Main(string[] args)
        {
            Abteilung computer = new Abteilung("Computer");

            Sachbearbeiter horst = new Sachbearbeiter(4, "Horst Müller", 2750, "Betriebssysteme");
            Vertriebsmitarbeiter eva = new Vertriebsmitarbeiter(3, "Eva Meier", 1500);
            Azubi stefan = new Azubi(7, "Stefan Kaufmann");

            eva.setGrenze(15000);
            eva.setUmsatz(35000);
            eva.setProzent(5);

            computer.neuerMitarbeiter(horst);
            computer.neuerMitarbeiter(eva);
            computer.neuerMitarbeiter(stefan);

            Console.WriteLine(computer.ermittlePersonalkosten());

            Console.Read();
        }
    }
}
