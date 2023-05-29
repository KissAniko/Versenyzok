using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versenyzők
{
    public class Pilotak
    {
        // név;születési_dátum;nemzetiség;rajtszám

        string nev;
        DateTime datum;
        string nemzettseg;
        string rajtSzam;
       

        public Pilotak(string nev, DateTime datum, string nemzettseg, string rajtSzam)
        {
            this.nev = nev;
            this.datum = datum;
            this.nemzettseg = nemzettseg;
            this.rajtSzam = rajtSzam;
            
        }

        public string Nev { get => nev; set => nev = value; }
        public string Nemzettseg { get => nemzettseg; set => nemzettseg = value; }
        public string RajtSzam { get => rajtSzam; set => rajtSzam = value; }       
        internal DateTime Datum { get => datum; set => datum = value; }
    }
      
}
