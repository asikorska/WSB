using System;


namespace _6_przestrzenie_nazw2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args[0]);
            //Console.WriteLine(args[1]);

            Show();
            Console.WriteLine(Show1());

            Add(4, 8);
            Add(1, 2, 3);
            Console.WriteLine("\nWywołanie funkcji 4-argumentowej: ");
            Console.WriteLine(Add(d:3, a:2, b:1));

            Console.ReadKey();
        }
        static void Show()
        {
            Console.WriteLine("WSB");
        }

        static int Show1()
        {
            return 0;
        }

        static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Wynik dodawania {1} i {2} = {0}",result,a,b);
        }

        static void Add(int a,int b,int c)
        {
            int result = a + b + c;
            Console.WriteLine("Wynik dodawania {1} + {2} + {3} = {0}",result,a,b,c);
        }

        static int Add(int a,int b, int d, int c=5)
        {
            return a + b + c + d;
        }
    }
}
