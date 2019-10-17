using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_duże_litery
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program, który wyświetli duże litery alfabetu
            //od A do Z i od Z do A z wykorzystaniem funkcji for
            //np. A,B,C,...,Z.

            char x= 'A';
            for(int i=0;i<26;i++)
            {
                Console.Write(" "+x);           //Console.Write("{0}, "
                x++;
            }
            Console.Write(".");
            Console.WriteLine();

            char y = 'Z';
            for (int i = 0; i < 26; i++)
            {
                Console.Write(" " + y);
                y--;
            }
            Console.Write(".");
            Console.WriteLine();

        }
    }
}
