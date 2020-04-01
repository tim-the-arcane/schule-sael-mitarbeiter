using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEL_Vertriebsmitarbeiter
{
    interface IVertriebsmitarbeiter : IMitarbeiter
    {
        void setUmsatz(double betrag);
        
        void setProzent(int prozent);

        void setGrenze(double betrag);
    }
}
