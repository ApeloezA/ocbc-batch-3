using System;
namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, remainder, revNumber = 0;

            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            while (number > 0)
            {
                remainder = number %10;
                number = number / 10;
                revNumber = (revNumber * 10) + remainder;
            }
            Console.Write("Reversed Number : {0}", revNumber);
        }
    }
}