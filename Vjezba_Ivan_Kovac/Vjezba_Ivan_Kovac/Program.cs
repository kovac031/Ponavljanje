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
            string[] mainIzbornik = { "1. PARNOST", "2. KVADRATNA", "3. PROSJEK", "4. ZNAMENKE", "5. LOTO", "6. LISTIC", "7. OSOBA", "8. PDF", "\n" };
            izbornik:
            Console.WriteLine("\nOdaberite jednu opciju:\n");
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
///////////////////////////////////////////////////////////////////////////////////////////////
                case "2":
                    Console.WriteLine("Unesi tri broja a, b, c kao parametre kvadratne jednadzbe:\n");
                    
                    double a, b, c;
                    double disc, deno, x1, x2;
                    
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    c = Convert.ToDouble(Console.ReadLine());

                    if (a == 0)
                    {
                        x1 = -c / b;
                        Console.WriteLine("The roots are Linear:", x1);
                    }
                    else
                    {
                        disc = (b * b) - (4 * a * c);
                        deno = 2 * a;
                        if (disc > 0)
                        {
                            Console.WriteLine("THE ROOTS ARE REAL AND DISTINCT ROOTS");
                            x1 = (-b / deno) + (Math.Sqrt(disc) / deno);
                            x2 = (-b / deno) - (Math.Sqrt(disc) / deno);
                            Console.WriteLine("THE ROOTS ARE... " + x1 + " and " + x2);
                        }
                        else if (disc == 0)
                        {
                            Console.WriteLine("THE ROOTS ARE REPEATED ROOTS");
                            x1 = -b / deno;
                            Console.WriteLine("THE ROOT IS...: " + x1);
                        }
                        else
                        {
                            Console.WriteLine("THE ROOTS ARE IMAGINARY ROOTS\n");
                            x1 = -b / deno;
                            x2 = ((Math.Sqrt((4 * a * c) - (b * b))) / deno);
                            Console.WriteLine("THE ROOT 1: " + x1 + "+i" + x2);
                            Console.WriteLine("THE ROOT 2:" + x1 + "-i" + x2);
                        }
                    }
                    goto izbornik;
//////////////////////////////////////////////////////////////////////////////////////////////
                case "3":
                    Console.WriteLine("Unosite ocjene jednu po jednu za izračun prosjeka. Unosom nule se završi unos.\n");
                    List<int> unosOcjena = new List<int>();

                    do
                    {
                        string ocjenaStr = Console.ReadLine();
                        int ocjenaInt = Int32.Parse(ocjenaStr);
                        if (ocjenaInt != 0 && ocjenaInt <= 5 && ocjenaInt % 1 == 0)
                        {
                            unosOcjena.Add(ocjenaInt);
                        }
                        else if (ocjenaInt == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("To nije ocjena. Probaj drugi broj:\n");
                        }
                    }while (true);
                    double prosjek = unosOcjena.Average();
                    string decimala = String.Format("{0:0.00}", prosjek);
                    Console.WriteLine($"Prosjek unesenih ocjena je {decimala}\n");
                    goto izbornik;
/////////////////////////////////////////////////////////////////////////////////////////
                case "4":
                    Console.WriteLine("Prvo unesi n za n broj znamenki od kojih ću pozbrajti samo njihove zadnje znamenke:\n");
                    string nStr = Console.ReadLine();
                    int nInt = Int32.Parse(nStr);
                    int zbroj = 0;
                    i = 0;
                    while(i < nInt)
                    {
                        Console.WriteLine($"\nUnesi {i+1}. broj:");
                        string brojStr = Console.ReadLine();
                        string lastStr = brojStr.Substring(brojStr.Length - 1,1);
                        int lastInt = Int32.Parse(lastStr);
                        zbroj = zbroj + lastInt;
                        i++;
                    }
                    Console.WriteLine($"Zbroj svih zadnjih znamenki je: {zbroj}!\n");
                    goto izbornik;
/////////////////////////////////////////////////////////////////////////////////////////

                default: Console.WriteLine("Nije unesen dobar broj:\n");
                    goto izbornik;
            }


            Console.ReadLine();
        }
    }
}
