using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choinka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj wysokość choinki: ");
            string h = Console.ReadLine();
            int h1;

            if (int.TryParse(h, out h1))
            {
                if (h1 > 0)
                {
                    for (int i = 0; i <= h1; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("*");
                         }
                        Console.Write("\n");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
        }
    }
}
