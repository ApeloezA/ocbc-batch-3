using System;
namespace Program
{
    class Program
    {
        static void Main(string[] arg)
        {
            char a = 'A';
            int n, cnt = 1;
            Console.WriteLine("Enter no character to print");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<=n; i++)
            {
                for (int j=0; j <=cnt/2; j++)
                {
                    Console.Write("{0} ",a++);
                }
                a--;
                a--;
                for (int j = 0; j<(cnt/2); j++)
                {
                    Console.Write("{0} ", a--);
                }
                cnt = cnt + 2;
                a = 'A';
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}