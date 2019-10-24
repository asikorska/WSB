

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_tablice_prostokątne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] values = new int[,]
            {
                {1,2,3,4 },
                {5,6,7,8 },
                {9,10,11,12 },
                {13,14,15,16 }
            };

            for(int i=0; i<4; i++)                  //j < value.GetLength(0)
            {
                for(int j=0;j<4;j++)                //j < value.GetLength(1)
                {
                    Console.Write(values[i,j]+"\t");        
                }
                Console.WriteLine();
            }
        }
    }
}
