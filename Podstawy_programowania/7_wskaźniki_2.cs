using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_wskaźniki_2
{
    class Program
    {
        unsafe static void Swap(int* a,int* b)
        {            
            int pomoc = *a;
            *a = *b;
            *b = pomoc;

        }

        unsafe static void Main(string[] args)
        {
            int x = 2;
            int y = 5;

            Console.WriteLine("Wartości przed zamianą:\nX = {0} \nY = {1}",x,y);
            Swap(&x, &y);
            Console.WriteLine("Wartości po zamianie:\nX = {0} \nY = {1}\n",x,y);

            int a = 100;
            int b = 200;

            int* a1 = &a;
            int* b1 = &b;

            Console.WriteLine("Wartości przed zamianą:\na = {0} \nb = {1}",a,b);
            Swap(a1, b1);
            Console.WriteLine("Wartości po zamianie:\na = {0} \nb = {1}\n",a,b);
        }
    }
}
