using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, space;

        while (true)
        {
            Console.Write(" Enter a number between 1 to 9: ");
            number = Convert.ToInt32(Console.ReadLine());
            space = number - 1 ;

            for(int i = 1; i <= number; i++)
            {
                for (space = 1; space <= (number - i); space++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (int k = ( i - 1); k >= 1; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }
        }
    }
}