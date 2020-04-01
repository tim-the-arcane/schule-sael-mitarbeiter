using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEL_Vertriebsmitarbeiter
{
    interface IMitarbeiter
    {
        int getPersonalnummer();
        string getName();
        void setName(string name);
        void setGrundgehalt(double betrag);
        abstract double ermittleGehalt();
    }
}
