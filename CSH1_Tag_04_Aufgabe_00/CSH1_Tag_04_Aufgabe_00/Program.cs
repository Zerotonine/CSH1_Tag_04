using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_04_Aufgabe_00
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Album = {"Lied 1", "Lied 2", "Lied 3", "Lied 4", "Lied 5"};

            foreach (string s in Album)
            {
                Console.WriteLine(s);
            }

            #region for schleife
            //for (int i = 0; i < Album.Length; i++)
            //{
            //    Console.WriteLine(Album[i]);
            //}
            #endregion

            Console.ReadKey();
        }
    }
}
