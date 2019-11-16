using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program, który w 10-elementowej tablicy jednowymiarowej
            //o nazwie tab umieszcza liczby całkowice z przedziału od 1 do 10
            /*
            int n = 10, i;
            //deklaracja tablicy o nazwie tab typu całkowitego o rozmiarze n=10
            int[] tab = new int[n];
            for(i=0; i<tab.Length;i++)
            {
                tab[i] = i;
            }
            //wyswietlenie zawartosci tablicy
            for (i = 0; i < tab.Length; i++)
            {
                Console.Write("{0} ", tab[i]);
            }
            */


            //Napisz program, który w 5-elementowej tablicy jednowymiarowej o nazwie colors 
            //umieszcza nazwy kolorów podane z klawiatury przez użytkownika. 
            //wyświetl kolory w formacie:
            //kolor1: red
            //kolor2: blue
            //...

            int n = 5, i;
            string[] colors = new string[n];


            for (i = 0; i < colors.Length; i++)
            {
                Console.Write("Proszę podać kolor: ");
                string col = Console.ReadLine();

                colors[i] = col;

            }

            Console.WriteLine();

            for (i = 0; i < colors.Length; i++)
            {
                Console.Write("kolor" + i + ":" + colors[i] + "\n");
            }

            Console.ReadKey();
        }
    }
}