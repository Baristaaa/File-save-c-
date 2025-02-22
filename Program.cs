using System;
using System.Linq;

namespace CdInputUmurDLL;

public static class Program
{
    public static void Main()
    {
        Console.Write("Masukkan nama: ");
        string a = Console.ReadLine();

        Console.Write("Masukkan umur: ");
        string b = Console.ReadLine();

        Console.Write("Masukkan tinggi: ");
        string c = Console.ReadLine();

        Console.Write("Masukkan kesukaan: ");
        string d = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(a))
        {
            Console.WriteLine($"Nama anda: {a}");
        }
        else
        {
            Console.WriteLine("Input tidak boleh kosong");
        }
        if (int.TryParse(b, out int f))
        {
            Console.WriteLine($"Umur anda: {f} tahun");
        }
        else
        {
            Console.WriteLine("Input tidak boleh dengan angka dan simbol");
        }
        if (double.TryParse(c, out double g))
        {
            Console.WriteLine($"Tinggi anda: {g} cm");
        }
        else
        {
            Console.WriteLine("Input tidak boleh dengan angka dan simbol");
        }
        if (!string.IsNullOrWhiteSpace(d))
        {
            Console.WriteLine($"Kesukaan anda: {d}");
        }
        else
        {
            Console.WriteLine("Input tidak boleh kosong");
        }
    }
}