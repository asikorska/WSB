using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_wyjątki2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            while(true)
            {
                Console.WriteLine("Wprowadź liczbę całkowitą: ");
                string x = Console.ReadLine();
                try
                {
                    number = uint.Parse(x);
                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Wprowadź liczbę w poprawnym formacie np. 4 \n");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                    Console.WriteLine("Zakres liczb: <0;4 294 967 295> \n");
                }
                catch(ArgumentException)
                {
                    Console.WriteLine("Wartość nie może być pusta \n");
                }
                Console.WriteLine("Wprowadź poprawną wartość \n");
            }
                Console.WriteLine("Liczba całkowita: {0}", number);
        }
    }
}
