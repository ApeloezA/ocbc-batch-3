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
            int i, j, k, l, m;
 
            for (i=1; i<=5; i++)
            {
                for (j = 1; j<= 5; j++)
                {
                    Console.Write(" ");
                }
                m = 1;
                for (k = 1; k <= i; k++)
                {
                    Console.Write("%d",m++);
                }
                m = m -2;
                for (l = 1; l < i ;l++)
                {
                    Console.Write("%d",m--);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}