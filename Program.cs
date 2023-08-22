using Microsoft.VisualBasic;

namespace test;
class Program
{
    static void Main(string[] args)
    {
        //string[] isimler = new string [5];
        
        string[] isimler = {"Ahmet","Çınar","Ada","Yiğit","Sena"};

        // isimler [0] = "Ahmet";
        // isimler [1] = "Çınar";
        // isimler [2] = "Ada";
        // isimler [3] = "Yiğit";
        // isimler [4] = "Sena";

        // int [] numaralar = new int [5];

        int [] numaralar = {101,102,103,104,105};

        // numaralar [0] = 101;
        // numaralar [1] = 102;
        // numaralar [2] = 103;
        // numaralar [3] = 104;
        // numaralar [4] = 105;
    
    System.Console.WriteLine($"öğrenci adı: {isimler [0]} öğrenci numarası: {numaralar [0]}");
    System.Console.WriteLine($"öğrenci adı: {isimler [1]} öğrenci numarası: {numaralar [1]}");
    System.Console.WriteLine($"öğrenci adı: {isimler [2]} öğrenci numarası: {numaralar [2]}");
    System.Console.WriteLine($"öğrenci adı: {isimler [3]} öğrenci numarası: {numaralar [3]}");
    System.Console.WriteLine($"öğrenci adı: {isimler [4]} öğrenci numarası: {numaralar [4]}");

    }
}