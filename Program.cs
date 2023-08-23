using System.Globalization;
using System.IO.Compression;
using Microsoft.VisualBasic;

namespace test;
class Program
{
    static void Main(string[] args)
    {
        
    string username = "ismailkurt";
    string password = "123456";

        if (username == "ismailkurt")
        {
            if (password == "123456")
            {
                System.Console.WriteLine("Bilgileriniz doğru");
                System.Console.WriteLine("Hoş geldiniz");
            }
            else
            {
                System.Console.WriteLine("Şifreniz yanlış");
            }
        }
        else
        {
            System.Console.WriteLine("Username yanlış");
        }
    }
}