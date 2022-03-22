using System;

public class logika4
{
    public static void Main()
    {
        double Nilai;
        Console.Write("Nilai: ");
        Nilai = Convert.ToDouble(Console.ReadLine());

        if (Nilai >= 85)
        {
            Console.WriteLine("kamu mendapat grade A");
        }
        else if (Nilai >= 65)
        {
            Console.WriteLine("kamu mendapat grade B");
        }
        else if (Nilai >= 45)
        {
            Console.WriteLine("kamu mendapat grade C");
        }
        else if (Nilai >= 25)
        {
            Console.WriteLine("kamu mendapat grade D");
        }
    }
}
