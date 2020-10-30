using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_04_Aufgabe_02
{
    class Program
    {
        static int[] tipp = new int[6];
        static void Main(string[] args)
        {
            
            int i = 0;
            do
            {
                Console.WriteLine($"Bitte Tipp {i+1} abgeben: ");
                if(!validate(Console.ReadLine(), out int zahl))
                {
                    Console.Clear();
                    continue;
                }
                tipp[i] = zahl;
                i++;
                Console.Clear();
            } while (i < 6);

            Array.Sort(tipp);

            for(int j = 0; j < tipp.Length; j++)
            {
                Console.WriteLine($"Tipp Nr. {j+1}: {tipp[j]}");
            }
            Console.ReadKey();
        }

        static bool validate(string eingabe, out int zahl)
        {
            if (!Int32.TryParse(eingabe, out zahl))
                return false;
            if (tipp.Contains(zahl))
                return false;
            if (zahl < 1 || zahl > 49)
                return false;

            return true;
        }
    }
}
