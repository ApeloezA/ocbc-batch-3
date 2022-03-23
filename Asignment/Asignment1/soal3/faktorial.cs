using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Factorial
{
    class program
    {
        static void Main()
        {
            int a;
            Console.Write("Enter any Number : ");
            a = int.Parse(Console.ReadLine());

            int faktorial = 1;
            for (int x = 1; x <= a; x++)
            {
                faktorial *= x;
            }
            Console.WriteLine(faktorial);
            Console.ReadLine();
        }
    }
}