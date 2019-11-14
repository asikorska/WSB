using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_funkcje3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine("Wartość zmiennej a przed wywołaniem funkcji: {0}",a);
            increment(ref a);
            Console.WriteLine("Wartość zmiennej a po wywołaniu funkcji: {0}",a);


            Console.ReadKey();
        }

        static void increment(ref int x)
        {
            x += 10;
            Console.WriteLine("Zmienna x wewnątrz funkcji: {0}",x);
        }
    }
}
