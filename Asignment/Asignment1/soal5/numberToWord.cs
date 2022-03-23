using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, nextDigit, numDigit;

            int[] n = new int[20];

            string[] digits = 
            {
                "zero","one","two","three","four","five","six","seven","eight","nine"
            };

            Console.WriteLine("Enter any number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers in words you entered: ");
            nextDigit = 0;
            numDigit = 0;

            do
            {
                nextDigit = number % 10;
                n[numDigit] = nextDigit;
                numDigit++;

                number = number / 10;

            } 
            while (number > 10);
            numDigit--;
            for(; numDigit >= 0; numDigit--)
                Console.Write(digits[n[numDigit]] + " ");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}