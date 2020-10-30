using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_04_Aufgabe_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] maximusPrime = new int[Int32.MaxValue / 10];
            double[] durchschnittFor = new double[10];
            double[] durchschnittForEach = new double[10];

            int buffer;
            TimeSpan spanFor, spanForEach;
            DateTime start, end;

            for(int i = 0; i < durchschnittFor.Length; i++)
            {
                start = DateTime.Now;
                for (int j = 0; j < maximusPrime.Length; j++)
                {
                    buffer = maximusPrime[j];
                }
                end = DateTime.Now;
                spanFor = end.Subtract(start);
                durchschnittFor[i] = Convert.ToDouble(spanFor.TotalSeconds);
                Console.WriteLine($"For Messung {i+1}: {spanFor.TotalSeconds}");
            }

            for(int i = 0; i < durchschnittForEach.Length; i++)
            {
                start = DateTime.Now;
                foreach (int j in maximusPrime)
                {
                    buffer = j;
                }
                end = DateTime.Now;
                spanForEach = end.Subtract(start);
                durchschnittForEach[i] = Convert.ToDouble(spanForEach.TotalSeconds);
                Console.WriteLine($"ForEach Messung {i + 1}: {spanForEach.TotalSeconds}");
            }
            

            
            Console.WriteLine($"Durchschnitt For-Schleife (sek): {durchschnittFor.Sum() / durchschnittFor.Length}");
            Console.WriteLine($"Durchschnitt ForEach-Schleife (sek): {durchschnittForEach.Sum() / durchschnittForEach.Length}");

            Console.ReadKey();
        }
    }
}
