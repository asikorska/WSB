using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_tablice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] liczby = new int[3, 3];
          
            
            for(int i = 0; i < liczby.GetLength(0);i++)
            {
                for(int j = 0; j < liczby.GetLength(1);j++)
                {
                    liczby[i, j] = i * 3 + j;
                }
            }

            for (int i = 0; i < liczby.GetLength(0); i++)
            {
                for (int j = 0; j < liczby.GetLength(1); j++)
                {
                    Console.Write("{0}\t", liczby[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
