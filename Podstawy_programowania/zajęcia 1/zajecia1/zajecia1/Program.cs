using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia1
{
    class Program
    {
        static void Main(string[] args)
        {
            // komentarz
            Console.WriteLine("Janusz");
            Console.ReadKey();
            //zmienne i typy danych
            int x;
            x = 10;
            Console.WriteLine(x);
            int y = 15, z = 20;

            int x1 = 19;
            Console.WriteLine(x1);

            //konkatenacja
            Console.WriteLine("y=" + y + " x1=" + x1+"\nz="+z);
            // \n - nowa linia

            int a = 10;
            int b = a;
            b = 15;
            Console.WriteLine(a + " " + b);

            //alternatywny sposób deklaracji zmiennej
            //int c = 0;

            int E = new int(); //wartosc domyslna ==> null (brak referencji)
            Console.WriteLine(E);

            Console.Write("Podaj swoje imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("Twoje imie podane z klawiatury: " + name);

           

            //oblicz pole prostokąta, dane uzytkownik podaje z klawiatury
            Console.WriteLine("\n\n\nPodaj wymiar boku a: ");
            int bok1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wymiar boku b: ");
            int bok2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Pole prostokąta wynosi: " + bok1* bok2);
        }
    }
}
