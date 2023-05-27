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
        string datum;
        string nemzettseg;
        int rajtSzam;
        int ev;

        public Pilotak(string nev, string datum, string nemzettseg, int rajtSzam)
        {
            this.nev = nev;
            this.datum = datum;
            this.nemzettseg = nemzettseg;
            this.rajtSzam = rajtSzam;

        }

        public string Nev { get => nev; set => nev = value; }
        public string Datum { get => datum; set => datum = value; }
        public string Nemzettseg { get => nemzettseg; set => nemzettseg = value; }
        public int RajtSzam { get => rajtSzam; set => rajtSzam = value; }
        public int Ev { get => ev; set => ev= value; }
    }
}
