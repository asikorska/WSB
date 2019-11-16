using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz kalkulator, uwzględnij wyjątki
            //Dodaj menu wyboru działania
            //użytkownik może zamknąć program wpisując x

            Console.WriteLine(" 1 - dodawanie \n 2 - odejmowanie \n 3 - mnożenie \n 4 - dzielenie \n x - wyjście z programu");

            Console.WriteLine("\nWybierz działanie (1-4): ");
            string str = Console.ReadLine();
            if (str=="x")
                {
                return;                
                Console.ReadKey();
            }
            int x = int.Parse(str);
            int a1, b1;
            
            
            switch (x)
            {
                case 1:
                    while (true)
                    {
                        Console.Write("\nPodaj liczbę a: ");
                        string a = Console.ReadLine();


                        try
                        {
                            a1 = int.Parse(a);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Wprowadź liczbę w poprawnym formacie np. 4 \n");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                            Console.WriteLine("Zakres liczb: <-2 147 483 648 ; 2 147 483 647> \n");
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Wartość nie może być pusta \n");
                        }
                    }

                    while (true)
                    {
                        Console.Write("Podaj liczbę b: ");
                        string b = Console.ReadLine();

                        try
                        {
                            b1 = int.Parse(b);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Wprowadź liczbę w poprawnym formacie np. 4 \n");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                            Console.WriteLine("Zakres liczb: <-2 147 483 648 ; 2 147 483 647> \n");
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Wartość nie może być pusta \n");
                        }
                    }
                    int suma = a1 + b1;
                    Console.Write(a1 + " + " + b1 + " = " + suma + "\n\n");
                    break;

                case 2:
                    while (true)
                    {
                        Console.Write("\nPodaj liczbę a: ");
                        string a = Console.ReadLine();


                        try
                        {
                            a1 = int.Parse(a);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Wprowadź liczbę w poprawnym formacie np. 4 \n");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                            Console.WriteLine("Zakres liczb: <-2 147 483 648 ; 2 147 483 647> \n");
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Wartość nie może być pusta \n");
                        }
                    }

                    while (true)
                    {
                        Console.Write("Podaj liczbę b: ");
                        string b = Console.ReadLine();

                        try
                        {
                            b1 = int.Parse(b);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Wprowadź liczbę w poprawnym formacie np. 4 \n");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                            Console.WriteLine("Zakres liczb: <-2 147 483 648 ; 2 147 483 647> \n");
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Wartość nie może być pusta \n");
                        }
                    }
                    int różnica = a1 - b1;
                    Console.Write(a1 + " - " + b1 + " = " + różnica + "\n\n");
                    break;

                case 3:
                    while (true)
                    {
                        Console.Write("\nPodaj liczbę a: ");
                        string a = Console.ReadLine();


                        try
                        {
                            a1 = int.Parse(a);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Wprowadź liczbę w poprawnym formacie np. 4 \n");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                            Console.WriteLine("Zakres liczb: <-2 147 483 648 ; 2 147 483 647> \n");
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Wartość nie może być pusta \n");
                        }
                    }

                    while (true)
                    {
                        Console.Write("Podaj liczbę b: ");
                        string b = Console.ReadLine();

                        try
                        {
                            b1 = int.Parse(b);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Wprowadź liczbę w poprawnym formacie np. 4 \n");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                            Console.WriteLine("Zakres liczb: <-2 147 483 648 ; 2 147 483 647> \n");
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Wartość nie może być pusta \n");
                        }
                    }
                    int iloczyn = a1 * b1;
                    Console.Write(a1 + " * " + b1 + " = " + iloczyn + "\n\n");
                    break;

                case 4:
                    double a2,b2;
                    while (true)
                    {
                        Console.Write("\nPodaj liczbę a: ");
                        string a = Console.ReadLine();
                        
                        try
                        {
                            a2 = double.Parse(a);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Wprowadź liczbę w poprawnym formacie np. 4 \n");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                            Console.WriteLine("Zakres liczb: <-2 147 483 648 ; 2 147 483 647> \n");
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Wartość nie może być pusta \n");
                        }
                    }

                    while (true)
                    {
                        Console.Write("Podaj liczbę b: ");
                        string b = Console.ReadLine();

                        try
                        {
                            b2 = double.Parse(b);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Wprowadź liczbę w poprawnym formacie np. 4 \n");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                            Console.WriteLine("Zakres liczb: <-2 147 483 648 ; 2 147 483 647> \n");
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Wartość nie może być pusta \n");
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Pamiętaj cholero, nie dziel przez ZERO!");
                        }
                    }
                    double iloraz = a2 / b2;
                    Console.Write("{1} : {2} = {0}",iloraz,a2,b2);
                    Console.WriteLine();
                    break;                
                default:
                    break;
            }
        }
    }
}
