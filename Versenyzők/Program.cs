using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Versenyzők;


namespace Versenyzők
{

    internal class Program
    {

        static List<Pilotak> pilotak2;
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



           List<Pilotak> newPilotak = pilotak2.Where(x => x.Datum <  new DateTime(1901, 1, 1))
                                               .ToList();

            newPilotak.ForEach(x => Console.WriteLine($"5.feladat:{x.Nev}" + " (" + x.Datum.ToShortDateString() + ")"));  
//------------------------------------------------------------------------------------------------------

            //6. feladat: A legkisebb értékű rajtszám pilótájának mi a nemzettsége?

           
            var legkRSzamNemz = pilotak2
                .Where(x => !string.IsNullOrEmpty(x.RajtSzam))    // A Pilotak.cs-ben át kellett írni a rajtSzam int-t stringgé, csak így nem jelez hibát.
                .OrderBy(x => int.Parse(x.RajtSzam))
                .First()
                .Nemzettseg;
            Console.WriteLine($" 6.feladat:{legkRSzamNemz}");

//--------------------------------------------------------------------------------------------------------

            // 7. feladat: Egy-egy rajtszámot több pilóta is megkaphat az idényben.
            //             Határozza meg és írja ki, melyek ezek a rajtszámok.

        }

        private static int DateTime(string v)
        {
            throw new NotImplementedException();
        } 
    

   /*     static List<Pilotak> BeolvasPilotak(string fajlnev)
        {
            List<Pilotak> pilotak2 = new List<Pilotak>();

            string[] adatok = File.ReadAllLines(fajlnev);
            for (int i = 1; i < adatok.Length; i++)
            {
                string[] pilotak = adatok[i].Split(';');
                string nev = adatok[0];
                DateTime szuletesiDatum = DateTime.Parse(pilotak[1]);
                string nemzettseg = pilotak[2];
                string rajtszam = pilotak[3];

                
            }

            return pilotak2;
        }
    */
        
    }
    }

