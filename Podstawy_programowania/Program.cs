using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_pętle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program, który za pomocą instrukcji do..while 
            //dla danych wartosci zmieniających sie w przedziale d 0 do 15 
            //oblicza wartosc funkcji y=4x

            int x = 0, y = 0;
          
                do
                {
                y = 4 * x;
                    Console.WriteLine("Wartość funkcji f("+x+"):" + y);
                x++;

                }
                while (x <= 15);
          
        }
    }
}
