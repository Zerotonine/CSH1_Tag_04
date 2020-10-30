using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_04_Aufgabe_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] wuerfel = new int[5];
            int[] gs1 = {1, 2, 3, 4, 5 };
            int[] gs2 = {2, 3, 4, 5, 6 };
            int durchlaeufe = 0;

            do
            {
                durchlaeufe++;
                fuelleWuerfelArray(ref wuerfel, 1, 6);
                Array.Sort(wuerfel);
                ausgabeWuerfel(wuerfel);
            } while (!wuerfel.SequenceEqual(gs1) && !wuerfel.SequenceEqual(gs2));

            Console.WriteLine($"Große Straße gewürfelt!\nBenötigte Durchläufe: {durchlaeufe}");

            Console.ReadKey();
        }

        static void fuelleWuerfelArray(ref int[] arr, int min, int max)
        {
            Random rnd = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max + 1);
            }
        }

        static void ausgabeWuerfel(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine();
        }
    }
}
