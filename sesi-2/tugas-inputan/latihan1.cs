using System;

class Project3
{
    static void Main(String[] args)
    {
        //membuat variabel kosong
        string username, jenkel, status;
        int age, x, y, z, total_nilai, rata2_nilai;

        Console.WriteLine("=== BIODATA DIRI ===");
        Console.Write("Masukan Username: ");
        username = Console.ReadLine();
        Console.Write("Masukan Password: ");
        var password = Console.ReadLine();
        Console.Write("Masukan umur: ");
        age = int.Parse(Console.ReadLine());
        Console.WriteLine("Jenis Kelamin (Pria/Wanita):");
        jenkel = Console.ReadLine();

        if (jenkel == "Pria")
        {
            Console.WriteLine(" Jenis kelamin Pria");
        }
        else
        {
            Console.WriteLine(" Jenis Kelamin Wanita");
        }

        Console.WriteLine("Status Pernikahan (true/false):");
        status = Console.ReadLine();

        if (status == "false")
        {
            Console.WriteLine(" Status : false");
        }
        else
        {
            Console.WriteLine(" Status : False");
        }

        Console.WriteLine(" === Aritmatika === ");
        Console.Write("Masukan nilai pertama : ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Masukan nilai kedua : ");
        y = int.Parse(Console.ReadLine());
        Console.Write("Masukan nilai ketiga : ");
        z = int.Parse(Console.ReadLine());

        total_nilai = x+y+z ;
        rata2_nilai = total_nilai/3;

        Console.WriteLine();
        Console.WriteLine("Terimakasih!");
        Console.WriteLine("Data Diri Berikut");
        Console.WriteLine($"Nama: {username}");
        Console.WriteLine($"Alamat: {password}");
        Console.WriteLine($"Umur: {age} tahun");
        Console.WriteLine($"Jenis Kelamin: {jenkel} ");
        Console.WriteLine($"Status: {status} ");
        Console.WriteLine("Data Aritmatika Berikut");
        Console.WriteLine($"Total Nilai: {total_nilai}");
        Console.WriteLine($"Rata-rata Nilai: {rata2_nilai}");


        Console.WriteLine("SUDAH DISIMPAN!");
    }
}