using System;
public class Logika3
{
    public static void Main()
    {
        string Username;
        String Password;

        Console.Write("Username: ");
        Username = Console.ReadLine();
        Console.Write("Password: ");
        Password = Console.ReadLine();

        if (Username == "ocbc" && Password == "bootcamp")
        Console.WriteLine("anda berhasil login");

        else   
        Console.WriteLine("Username atau Password anda salah");
    }
}
