using System.Globalization;
using System.IO.Compression;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace test;
class Program
{
    static void Main(string[] args)
    {
        // System.Console.WriteLine("x sayısı:");
        // int x = int.Parse(Console.ReadLine());

        // System.Console.WriteLine("y sayısı:");

        // int y = int.Parse(Console.ReadLine());

        // if (x>y)
            // System.Console.WriteLine("x y den büyük");
        // else if (x==y)
            // System.Console.WriteLine("x ile y eşit");
        // else
            // System.Console.WriteLine("y x den büyük");

            System.Console.Write("sayı: ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi > 0)
                System.Console.WriteLine("sayı pozitif");
            else if (sayi == 0)
                System.Console.WriteLine("sayı sıfır");
            else
                System.Console.WriteLine("sayı negatif");
    }
}