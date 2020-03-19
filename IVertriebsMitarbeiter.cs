using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEL_Vertriebsmitarbeiter
{
    interface IVertriebsMitarbeiter : IMitarbeiter
    {
        double getFixGehalt();
        void setFixGehalt(double betrag);
        double ermittleGehalt(double umsatz);
    }
}
