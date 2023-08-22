using System.Globalization;
using Microsoft.VisualBasic;

namespace test;
class Program
{
    static void Main(string[] args)
    {   

        int x = 6;
        int hak = 0;
        char devammi='e';

        var result = (x>5) && (x<10);
        result = (hak>0) && (devammi=='e');

        result = (x > 0) || (x % 2 == 0);

        result = !(x>0);

        //x, 5 ile 10 arasındaki bir çift sayı mı?

        result = ((x>5) && (x<10)) && (x%2==0);

        System.Console.WriteLine(result);
    }
}