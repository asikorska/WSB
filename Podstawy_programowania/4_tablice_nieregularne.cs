using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_tablice_nieregularne
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] country = new string[4][];

            Console.WriteLine("Rozmiar zewnętrzneo wymiaru tablicy nieregularnej: {0}\n",country.Length);

            int[][] numbers = new int[3][]
            {
                new int[] {1,2},
                new int[] {3,4,5,6},
                new int[] {7}
            };

            for(int i=0; i < numbers.GetLength(0);i++)
            {
                for(int j=0; j < numbers[i].Length;j++)
                {
                    Console.Write("{0}\t",numbers[i][j]);
                }
                Console.WriteLine();
            }

        }
    }
}
