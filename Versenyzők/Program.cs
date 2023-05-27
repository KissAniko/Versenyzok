using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Versenyzők
{


    internal class Program
    {


        static void Main(string[] args)
        {
            // Ellenőrzés:

            /*    var sorok = File.ReadAllLines("pilotak.csv");

                  foreach (var sor in sorok)
                  {
                      Console.WriteLine(sor);

                  }
               */
//----------------------------------------------------------------------------------------------

            // 2.feladat: Olvassa be a 'pilotak.csv' állományban található adatokat és tárolja el egy 
            //            megfelelően megválasztott adatszerkezetben.

            List<string> pilotak = new List<string>();
            pilotak = File.ReadAllLines("pilotak.csv")
                             .Skip(1)
                             .ToList();

//-----------------------------------------------------------------------------------

            // 3.Feladat: Az állomány hány adatsort tartlamaz?

            Console.WriteLine($" 3.feladat: {pilotak.Count()}");

//-----------------------------------------------------------------------------------

            // 4.feladat: Az állomány utolsó sorában melyik pilóta neve szerepel?

            pilotak = File.ReadAllLines("pilotak.csv")
                          .Skip(1)
                          .Select(sor => sor.Split(';')[0])
                          .ToList();

            Console.WriteLine($"4. feladat: {pilotak.Last()}");

//---------------------------------------------------------------------------------------

            // 5.feladat: mely pilóták születtek a XIX.században, azaz 1901. január 1-je előtt?         


            List<Pilotak> pilota = new List<Pilotak>();
            pilotak = File.ReadAllLines("pilotak.csv")
                          .Skip(1)                                                   
                          .ToList();

            IList list = pilota;
            for (int i = 0; i < list.Count; i++)
            {
                string versenyzo = (string)list[i];
                string[] adatok = versenyzo.Split(';');
                string nev = adatok[0];
                DateTime szuletesiDatum = DateTime.Parse(adatok[1]);

                if (szuletesiDatum.Year < 1901)
                {

                    Console.WriteLine($"{nev} ({szuletesiDatum.ToString("yyyy.MM.dd")})");
                }
//--------------------------------------------------------------------------------------------------------

                //6. feladat: A legkisebb értékű rajtszám pilótájának mi a nemzettsége?

//--------------------------------------------------------------------------------------------------------

                // 7. feladat: Egy-egy rajtszámot több pilóta is megkaphat az idényben.
                //             Határozza meg és írja ki, melyek ezek a rajtszámok.

            }
        }
    }
}
