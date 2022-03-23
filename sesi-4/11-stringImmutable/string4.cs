using System;
class string4
{
    static void Main()
    {
        string stringAwal = "C# membuat string mudah";

        //menciptakan sebuah string.
        string substr = stringAwal.Substring(5, 12);

        Console.WriteLine("stringAwal: "+ stringAwal);
        Console.WriteLine("substring: "+ substr);
    }
}