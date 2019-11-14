using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Second_name;
using Outer.Middle.Inner;

namespace _6_przestrzenie_nazw
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine(  );

            First_name.name_1 ob1 = new First_name.name_1();
            ob1.Show();

            name_1 ob2 = new name_1();
            ob2.Show();

            Prog ob = new Prog();
            Console.WriteLine(ob.Add(3,5);

            Console.ReadKey();
        }
    }
}

namespace First_name
{
    class name_1
    {
        public void Show()
        {
            Console.WriteLine("Pierwsza przestrzeń nazw");
        }
    }
}

namespace Second_name
{
    class name_1
    {
        public void Show()
        {
            Console.WriteLine("Druga przestrzeń nazw");
        }
    }
}

namespace Outer
{
    namespace Middle
    {
        namespace Inner
        {
            class Prog
            {
                public int x, y;

                public int Add(int x, int y)
                {
                    return x + y;
                }
            }
        }
    }
}
