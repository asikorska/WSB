using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_tablice_zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zapisz w tablicy tłumaczenia słów
            //  1       Poniedziałek        Monday
            //  2       Wtorek              Tuesday
            //Użytkownik wprowadza z klawiatury polskie słowo i angielskie tłumaczenie


            string[,] week = new string[7, 2];
            string[] day = { "pierwszy", "drugi", "trzeci", "czwarty", "piąty", "szósty", "siódmy" };
            string word;

            for (int i = 0; i < week.GetLength(0); i++)
            {          
                
                for (int j = 0; j < week.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.Write("Podaj {0} dzień tygodnia (j.polski): ",day[i]);
                    }
                    else
                    {
                        Console.Write("Podaj {0} dzień tygodnia (j.angielski): ",day[i]);
                    }
                    word = Console.ReadLine();
                    week[i, j] = word;                    
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("L.p"+"\t"+"polski"+"\t\t\t"+"angielski");
            for (int i = 0; i < week.GetLength(0); i++)
            {
                Console.Write(i + "\t\t");
                for (int j = 0; j < week.GetLength(1); j++)
                {
                    
                    Console.Write(week[i, j]+"\t\t\t");
                }
                Console.WriteLine();


            }
        }
    }
}
