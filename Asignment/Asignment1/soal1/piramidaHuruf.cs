using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace piramidaHuruf
{
    class piramidaHuruf
    {
        static void Main(string[] args)
        {
            int i, j, k;
            int l = 5;
 
            for (i=l; i>=0; i--)
            {
                for (j = i; j>= 0; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k<=l - i; k++)
                {
                    Console.Write("A");
                }
                for (k =1; k<l-i;k++)
                {
                    Console.Write("A");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}