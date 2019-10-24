
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_inicjalizacja_uproszczona
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            Console.WriteLine(vowels[0]);           //a

            byte[,] age =
              {
                {20,30 },
                {15,35 },
                {25,35 }
              };
            Console.WriteLine(age[2,0]);            //25

            string[][] name =
            {
                new string[] {"Katrzyna"},
                new string[] {"Krzysztof","Anna"},
                new string[] {"Paweł"}
            };
            Console.WriteLine(name[1][1]);          //Anna

            Console.WriteLine();

            Console.WriteLine("Samogłoski: {0}",vowels.Rank);
            Console.WriteLine("Wiek: {0}", age.Rank);
            Console.WriteLine("Imiona: {0}", name.Rank);
        }
    }
}
