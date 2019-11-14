using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_funkcje2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz funkcję, który wyświetli czy liczba jest parzysta/nieparzysta
            //Funkcja zwraca string (Liczba parzysta / Liczba nieparzysta)

            int x = 10;
            int y = 7;
            Console.WriteLine("x to: {0}",checkEven(x));
            Console.WriteLine("y to: {0}",checkEven(y));
            Console.WriteLine();

            //Napisz funkcję, który wyświetli sumę cyfr w liczbie
            Console.WriteLine(Suma(123));

        }

        static string checkEven(int x)
        {
            if (x%2==0)
            {
              return "Liczba parzysta";
            }
            else
            {
              return "Liczba nieparzysta";
            }
        }
            
        static int Suma(int x)
        {
            int sum = 0;
            do
            {
                sum = sum + x % 10;
                x /= 10;
            } while (x!=0);
            return sum;
        }
    }
}
