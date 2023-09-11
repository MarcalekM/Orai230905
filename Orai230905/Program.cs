using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Orai230905
{
    class Program
    {
        static void Main(string[] args)
        {
            var kategoriak = new List<Kategoria>();
            var sr = new StreamReader(
                path: @"..\..\..\src\titanic.txt",
                encoding: Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                //string sor = sr.ReadLine();
                //var kat = new Kategoria(sor);
                //kategoriak.Add(kat);
                kategoriak.Add(new Kategoria(sr.ReadLine()));
            }

            Console.WriteLine($"2. feladat: {kategoriak.Count} db");

            //var f3 = kategoriak.Sum(k => k.UtasokSzama);
            int f3 = 0;
            foreach(Kategoria k in kategoriak)
            {
                f3 += k.UtasokSzama;
            }
            Console.WriteLine($"3. feladat: {f3} fő");

            Console.Write("4. feladat kulcsszó:  ");
            string ksz = Console.ReadLine();

            //bool f4 = kategoriak.Any(k => k.KategoriaNev.Contains(ksz));
            //Console.WriteLine($"\t{(f4 ? "VAN" : "NINCS")} találat");

            int i = 0;
            while (i < kategoriak.Count() && !kategoriak[i].KategoriaNev.Contains(ksz))
            {
                i++;
            }
            if (i < kategoriak.Count())
            {
                Console.WriteLine("\tVAN találat");
            }
            else Console.WriteLine("\tNincs találat");
        }
    }
}
