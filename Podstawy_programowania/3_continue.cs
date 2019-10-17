using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 1;
            /*for (; j <= 10; j++)
            {
                if (j == 2 || j == 5 || j == 7)
                    continue;
                else
                {
                    Console.Write("{0} ", j);
                }
            }*/

          
            for(;j<=10;j++)
            {
                if (j == 2 || j == 5 || j == 7)
                    break;
                else
                {
                    Console.Write("{0} ",j);
                }
            }
        }
    }
}
