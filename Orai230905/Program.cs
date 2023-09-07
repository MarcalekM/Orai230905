using System;

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
                string sor = sr.ReadLine();
                var kat = new Kategoria(sor);
                kategoriak.Add(kat);
            }

            Console.WriteLine($"2. feladat: {kategoriak.Count} db");
        }
    }
}
