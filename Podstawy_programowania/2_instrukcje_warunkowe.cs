using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_instrukcjewarunkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 5;
            if(x>3)
            {
                Console.WriteLine("prawda");
            } else if(x==5)
            {
                Console.WriteLine("x równy 5");
            }
            else
            {
                Console.WriteLine("inna");
            }

            Console.ReadKey();
            */

           

            Console.Write("Proszę podać wysokość trójkąta: " );
            string wysokosc = Console.ReadLine();
            // double wysokosc1 = double.Parse(wysokosc);
            double wysokosc1;

            Console.Write("Proszę podać podstawę trójkąta: ");
            string podstawa = Console.ReadLine();
            //double podstawa1 = double.Parse(podstawa);
            double podstawa1;

            if(double.TryParse(wysokosc,out wysokosc1) && double.TryParse (podstawa,out podstawa1))
            {
                if(wysokosc1>0 && podstawa1>0)
                {
                    Console.WriteLine("Pole tego trójkąta:" + 0.5*wysokosc1*podstawa1);
                } else
                {
                    Console.WriteLine("ERROR");
                }
            }
        }
    }
}
