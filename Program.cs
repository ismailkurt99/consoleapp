using System.Globalization;
using System.IO.Compression;
using Microsoft.VisualBasic;

namespace test;
class Program
{
    static void Main(string[] args)
    {

        // 1-) Girilen 2 sayıdan hangisi büyüktür?

        // System.Console.Write("1. sayı: ");
        // int sayi1 = int.Parse(Console.ReadLine());

        // System.Console.Write("2. sayı: ");
        // int sayi2 = int.Parse(Console.ReadLine());

        // var result = (sayi1>sayi2);

        // System.Console.WriteLine("sayı1>sayı2: "+ result);

        // 2-) Parola ve email bilgisini isteyip doğruluğunu kontrol edin.

        // string _email = "ismail@gmail.com";
        // string _sifre = "123456";

        // System.Console.Write("email: ");
        // string email = Console.ReadLine();

        // System.Console.Write("şifre: ");
        // string sifre = Console.ReadLine();

        // var result = (email == _email) && (sifre == _sifre);
        // System.Console.Write("giriş başarılı: "+ result);

        // 3-) Girilen sayının pozitif çift sayı olup olmadığını kontrol edin.

        // System.Console.Write("sayı girin: ");
        // int sayi = int.Parse(Console.ReadLine());

        // var result = (sayi>0) && (sayi%2==0);
        // System.Console.WriteLine("sayi pozitif ve çift: "+ result);

        // 4-) Girilen 3 sayıyı büyüklük açısından karşılaştırın.

        // System.Console.Write("1. sayı: ");
        // int sayi1 = int.Parse(Console.ReadLine());

        // System.Console.Write("2. sayı: ");
        // int sayi2 = int.Parse(Console.ReadLine());

        // System.Console.Write("3. sayı: ");
        // int sayi3 = int.Parse(Console.ReadLine());

        // var result = (sayi1>sayi2) && (sayi1>sayi3);
        // System.Console.WriteLine("ilk sayı en büyük sayıdır: "+ result);

        // result = (sayi2>sayi1) && (sayi2>sayi3);
        // System.Console.WriteLine("ikinci sayı en büyük sayıdır: "+ result);

        // result = (sayi3>sayi2) && (sayi3>sayi1);
        // System.Console.WriteLine("üçüncü sayı en büyük sayıdır: "+ result);

        // 5-) Kullanıcıdan 2 vize (%60) ve final (%40) notunu alıp ortalama hesaplayınız.
        // Eğer ortalama 50 ve üstündeyse geçti değilse kaldı yazdırın.
        // a-) Ortalama 50 olsa bile final notu en az 50 olmalıdır.
        // b-) Finalden 70 alındığında ortalamanın önemi olmasın.

        // System.Console.Write("vize 1: ");
        // int vize1 = int.Parse(Console.ReadLine());

        // System.Console.Write("vize 2: ");
        // int vize2 = int.Parse(Console.ReadLine());

        // System.Console.Write("final: ");
        // int final = int.Parse(Console.ReadLine());

        // int ortalama = ((vize1+vize2)*6/10 + (final*4/10))/2;

        // System.Console.WriteLine("sonuc: "+ ortalama);
        // System.Console.WriteLine(((ortalama>=50) && (final >= 50) || final>=70)?"geçti":"kaldı");

        // 6-) Kişinin ad, kilo ve boy bilgilerini alıp kilo indekslerini hesaplayın.
        // Formül: Kilo / boy uzunluğunun karesi
        // Aşağıdaki tabloya göre kişi hangi gruba girmektedir.
        // 0-18.4       => Zayıf
        // 18.5-24.9    => Normal
        // 25.0-29.9    => Fazla Kilolu
        // 30.0-34.9    => Şişman (Obez)

        System.Console.Write("Adınız: ");
        string ad = Console.ReadLine();

        System.Console.Write("Kilonuz: ");
        float kilo = int.Parse(Console.ReadLine());

        System.Console.Write("Boyunuz: ");
        float boy = int.Parse(Console.ReadLine());

        float indeks = (kilo) / (boy * boy);

        var Zayif = (indeks >= 0) && (indeks<=18.4);
        var Normal = (indeks >= 18.5) && (indeks <= 24.9);
        var Kilolu = (indeks >= 25.0) && (indeks <= 29.9);
        var Obez = (indeks >= 30.0) && (indeks <= 34.9);

        System.Console.WriteLine($"{ad} ,indkesiniz: {indeks} ve zayıfsınız {Zayif}");
        System.Console.WriteLine($"{ad} ,indkesiniz: {indeks} ve normalsiniz {Normal}");
        System.Console.WriteLine($"{ad} ,indkesiniz: {indeks} ve kilolusunuz {Kilolu}");
        System.Console.WriteLine($"{ad} ,indkesiniz: {indeks} ve obezsiniz {Obez}");



    }
}