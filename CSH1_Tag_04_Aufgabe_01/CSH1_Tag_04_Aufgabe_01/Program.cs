using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_04_Aufgabe_01
{
    class Program
    {
        static string[] deutsch = {"Januar", "Februar", "März", "April", "Mai", "Juni", "Juli",
                                "August", "September", "Oktober", "November", "Dezember"};

        static string[] englisch = {"January", "February", "March", "April", "May", "June", "July",
                                "August", "September", "October", "November", "December"};
        static void Main(string[] args)
        {
            char auswahl;

            while(true)
            {
                Console.WriteLine("1 - Übersetzung\n2 - Monatsnummer");
                Console.Write(">>> ");

                auswahl = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if(auswahl == '1')
                {
                    Console.WriteLine(Übersetzung());
                }
                else if(auswahl == '2')
                {
                    int monat = Monatsnummer();
                    if (monat == -1)
                        Console.WriteLine("Monat nicht gefunden!");
                    else
                        Console.WriteLine($"Monatsnummer ist die {monat}!");
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe!");
                }
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;
                Console.Clear();
            }
        }

        static string Übersetzung()
        {
            Console.Write("Monat eingeben: ");
            string suche = Console.ReadLine();

            for(int i = 0; i < deutsch.Length; i++)
            {
                if(deutsch[i].ToLower() == suche.ToLower())
                {
                    return englisch[i];
                }
            }
            return "Monat nicht gefunden";
        }

        static int Monatsnummer()
        {
            Console.Write("Monat eingeben: ");
            string suche = Console.ReadLine();

            for(int i = 0; i < deutsch.Length; i++)
            {
                if(deutsch[i].ToLower() == suche.ToLower())
                {
                    return i + 1;
                }
            }
            return -1;
        }
    }
}
