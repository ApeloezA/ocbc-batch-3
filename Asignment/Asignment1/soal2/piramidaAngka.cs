using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace piramidaAngka
{
    class piramidaAngka
    {
        static void Main(string[] args)
        {
            int i, j, k, l;
            Console.Write("Enter the range = ");
            l = int.Parse(Console.ReadLine());

            for (i=l; i>=0; i--)
            {
                for (j = i; j>= 0; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k<=l - i; k++)
                {
                    Console.Write("1");
                }
                for (k =1; k<l-i;k++)
                {
                    Console.Write("1");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}