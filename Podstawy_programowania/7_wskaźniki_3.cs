using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_wskaźniki_3
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int[] tab = { 10, 20, 30, 40, 50 };

            fixed (int* x = tab) 

            for(int i=0;i<tab.Length;i++)
                {
                    Console.WriteLine("Adres tab[{0}] = {1}, wartość {2}", i, (int)x+i,tab[i]);
                }
        }
    }
}
