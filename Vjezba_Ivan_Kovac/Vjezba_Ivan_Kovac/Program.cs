using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_Ivan_Kovac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mainIzbornik = { "1. PARNOST", "2. KVADRATNA", "3. PROSJEK", "4. ZNAMENKE", "5. LOTO", "6. LISTIC", "7. OSOBA", "8. PDF" };
            izbornik:
            Console.WriteLine("Odaberite jednu opciju:\n");
            int i = 0;
            do
            {
                Console.WriteLine(mainIzbornik[i]);
                i++;
            }
            while (i < mainIzbornik.Length);

            string mainIzbor = Console.ReadLine();
            switch(mainIzbor) 
            {
                case "1":
                    Console.WriteLine("Unesi broj po zelji da vidimo je li paran ili neparan:\n");
                    string parnost = Console.ReadLine();
                    int broj = Int32.Parse(parnost);
                    string result = (broj % 2 == 0) ? $"Broj {broj} je paran!\n" : $"Broj {broj} je neparan!\n";
                    Console.WriteLine(result);
                    goto izbornik;

                case "2":
                    Console.WriteLine("Unesi tri broja a, b, c kao parametre kvadratne jednadzbe:\n");
                    Console.WriteLine("Unesi a:");
                    string a = Console.ReadLine();
                    Console.WriteLine("Unesi b:");
                    string b = Console.ReadLine();
                    Console.WriteLine("Unesi c:");
                    string c = Console.ReadLine();

                    int aa = Int32.Parse(a);
                    int bb = Int32.Parse(b);
                    int cc = Int32.Parse(c);

                    var sqrt = Math.Sqrt(bb * bb - 4 * aa * cc);
                    var x1 = (-bb + sqrt) / (2 * aa);
                    var x2 = (-bb - sqrt) / (2 * aa);

                    Console.WriteLine($"Rjesenja su {x1} i {x2}");
                    goto izbornik;

                case "3":
                    Console.WriteLine("Unosite ocjene jednu po jednu za izračun prosjeka. Unosom nule se završi unos.\n");
                    List<int> unosOcjena = new List<int>();

                    string ocjenaStr = Console.ReadLine();
                    int ocjenaInt = Int32.Parse(ocjenaStr);
                    do
                    {
                        if (ocjenaInt != 0 && ocjenaInt <= 5 && ocjenaInt % 1 == 0)
                        {
                            unosOcjena.Add(ocjenaInt);
                        }
                        else
                        {
                            Console.WriteLine("To nije ocjena. Probaj drugi broj:\n");
                        }
                    }
                    while (ocjenaStr != "0");
                    double prosjek = unosOcjena.Average();
                    Console.WriteLine($"Procjek unesenih ocjena je {prosjek}\n");
                    goto izbornik;

                default: Console.WriteLine("Nije unesen dobar broj:\n");
                    break;
            }


            Console.ReadLine();
        }
    }
}
