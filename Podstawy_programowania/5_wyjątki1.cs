using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_wyjątki1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            while (true)
            {
                Console.Write("Wprowadź liczbę całkowitą: ");
                string x = Console.ReadLine();

                try                                  //blok instrukcji
                {
                    number = uint.Parse(x);
                    break;
                }

                catch (SystemException e)            //obsługuje blok dotyczący wyjątków
                {
                    //Console.WriteLine("Error");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);    //rozbudowany komunikat z automatu        
                    Console.WriteLine("Podałeś błędne dane: {0}\n",x);
                    Console.ResetColor();
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;           //kolor tekstu
            Console.WriteLine("Prawidłowe dane: {0}",number);
            Console.ResetColor();                                   //zamknięcie koloru


            Console.ReadKey();
        }
    }
}
