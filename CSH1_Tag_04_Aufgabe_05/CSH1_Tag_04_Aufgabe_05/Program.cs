using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_04_Aufgabe_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] uncompressed = { "A", "A", "A", "A", "2", "2", "7", "7", "7", "7", "7", "7", "7", "7", "O", "P", "P", "P", "P", "P", "9", "9", "9" };
            string[] compressed = new string[0];
            int counter = 1, positionStart = 0, positionEnd = 1;
            string buffer = uncompressed[0];

            for(int i = 1; i < uncompressed.Length; i++)
            {
                if(buffer == uncompressed[i])
                {
                    counter++;
                    positionEnd++;
                }
                if(counter < 5 && (buffer != uncompressed[i] || i == uncompressed.Length-1))
                {
                    for(int j = positionStart; j < positionEnd; j++)
                    {
                        compressed = Add(compressed, uncompressed[j]);
                    }
                    positionStart = positionEnd;
                    positionEnd++;
                    counter = 1;
                }
                else if(counter >= 5 && (buffer != uncompressed[i] || i == uncompressed.Length - 1))
                {
                    compressed = Add(compressed, "$");
                    compressed = Add(compressed, counter.ToString());
                    compressed = Add(compressed, uncompressed[i - 1]);
                    positionStart = positionEnd;
                    positionEnd++;
                    counter = 1;
                }
                buffer = uncompressed[i];
            }

            foreach (string s in compressed)
                Console.Write(s + ", ");
            Console.ReadKey();
        }

        static string[] Add(string[] arr, string str)
        {
            string[] newArr = new string[arr.Length + 1];
            Array.Copy(arr, newArr, arr.Length);
            newArr[newArr.Length -1] = str;
            return newArr;
        }
    }
}
