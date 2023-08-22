using Microsoft.VisualBasic;

namespace test;
class Program
{
    static void Main(string[] args)
    {   
        int[] numaralar = {5,3,6,1,2};

        // isimler [0] = "Ali";
        //isimler.SetValue("Ali",0);

        // System.Console.WriteLine(isimler.GetValue(0));
        // System.Console.WriteLine(Array.IndexOf(isimler,"Çınar"));
        // System.Console.WriteLine(isimler.Length);

        //Array.Sort(isimler);
        //Array.Sort(numaralar);
        
        //Array.Reverse(isimler);
        //Array.Reverse(numaralar);

        //Array.Clear(isimler,0,2);
        //Array.Clear(numaralar,0,2);

        // System.Console.WriteLine(isimler.GetValue(0));
        // System.Console.WriteLine(numaralar.GetValue(0));

        // System.Console.WriteLine(isimler[0]);
        // System.Console.WriteLine(isimler[^2]);

        string[] isimler = {"Ahmet","Çınar","Ada","Yiğit","Sena"};

        // var result = isimler [1..4];
        // var result = isimler [1..];
        var result = isimler [..3];


        foreach (var isim in result)
        {
            System.Console.WriteLine(isim);
        }

        string msg = "Hello there";
        System.Console.WriteLine(msg[0..5]);

    }
}