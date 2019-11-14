using System;


namespace _6_funkcje5_tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[2];
            tab[0] = 5;
            tab[1] = 10;

            Console.WriteLine("Wartości tablicy przed wywołaniem funkcji: {0} i {1}", tab[0],tab[1]);
            Tab1(tab);
            Console.WriteLine("Wartości tablicy po wywołaniu funkcji: {0} i {1}", tab[0],tab[1]);
            Console.WriteLine();

            ShowTab(tab);


            Console.ReadKey();
        }

        static void Tab1(int[] tab)
        {
            tab[0] = 50;
            tab[1] = 100;
            Console.WriteLine("Wartości tablicy wewnątrz funkcji: {0} i {1}", tab[0],tab[1]);
        }

        static void ShowTab(int[] tab)
        {
            Console.WriteLine("Wartości w tablicy: ");
            foreach (var item in tab)
            {
                Console.Write("{0} ",item);
            }
        }
    }
}
