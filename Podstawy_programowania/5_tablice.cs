﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_tablice
{
    class Program
    {
        static void Main(string[] args)
        {

            //typ wartosciowy
            int a = 10;
            int b = a;
            a--;
            b++;

            Console.WriteLine("Zmienna a: {0}",a);
            Console.WriteLine("Zmienna b: {0}", b);

            //typ referencyjny
            int[] tabA = { 2, 2, 2 };
            int[] tabB = tabA;
            
            tabA[2] = 10;
            tabB[0] = 8;

            Console.WriteLine("Wyświetlenie tablicy A: ");
            foreach(int item in tabA)
            {
                Console.Write("{0} ",item);
            }

            Console.WriteLine();

            Console.WriteLine("Wyświetlenie tablicy B: ");
            foreach (int item in tabB)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine("\n");

            //kopiowanie tablc
            int[] tab = { 1, 2, 3, 4, 5 };
            int[] tabCopy = new int[5];

            foreach (int item in tabCopy)
            {
                Console.Write("{0} ",item);
            }

            Console.WriteLine();

            tab.CopyTo(tabCopy, 0);

            foreach(int item in tabCopy)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();

            //sposób 2
            Array.Copy(tab, tabCopy, tab.Length);

            foreach (int item in tabCopy)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
