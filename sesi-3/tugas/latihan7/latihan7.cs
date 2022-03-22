using System;
public class logika7
{
    public static void Main()
    {
        for (int a=10;      a<20;         a= a +1)
        {
            Console.WriteLine($"Iterasi ke - {a}");
            if(a == 19)
            for(int b = a; b > 15; --b)
            {
                Console.WriteLine($"Iterasi ke - {b}");
            }
        }
    }
}