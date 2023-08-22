using System.Globalization;
using Microsoft.VisualBasic;

namespace test;
class Program
{
    static void Main(string[] args)
    {   

        int a=5,b=5,c=10,d=4;
        string username = "ismailkurt";
        string password = "123456";

        var result = (a==b); // true
        result = (a==c); // false
        result = (username == "ismlkrt");
        result = (username == "123456");
        result = (a != b);
        result = (a != c);
        result = (a > c);
        result = (c > a);
        result = (a >= b);
        result = (a <= b);
        string sonuc = (a == b)?"a=b":"a!=b";
        sonuc = (username == "ismailkurt")?
            sonuc = (password == "123456")?"username ve password doğru":"username doğru, password yanlış":
            sonuc = (password == "123456")?"username yanlış, password doğru":"username ve password yanlış";

        System.Console.WriteLine("sonuc: " +sonuc);
        System.Console.WriteLine("result: "+result);

    }
}