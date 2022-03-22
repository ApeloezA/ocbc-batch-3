using System;
public class Logika2
{
    public static void Main()
    {
        string nama;

        Console.Write("input nama: ")
        nama = Console.ReadLine();
        int nilai = 75;
        if (nilai <60) {
            Console.WriteLine("nilai kamu C");}
        else if (nilai <80) {
            Console.WriteLine("nilai kamu B");}
        else{
            Console.WriteLine("nilai kamu A");}

    }
}