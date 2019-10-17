using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_tabliczka_mnożenia
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, row, col;
            row = 1;
                do
                {
                  col = 1;
                do
                {
                    Console.Write(row * col + "\t");
                    col++;
                }
                while (col <= x);
                    row++;
                Console.WriteLine();
                 }
                while (row<=x) ;
           
        }
    }
}
