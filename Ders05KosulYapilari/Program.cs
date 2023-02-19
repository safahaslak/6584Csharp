// See https://aka.ms/new-console-template for more information
Console.WriteLine("Koşul Yapıları!");

int sayi = -10;

Console.WriteLine("Lütfen Bir Sayı Giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine()); //İnput girişi. Ekrandan veri alabilmek için Readline metodu kullanılır. ReadLine metodu ekrandan verileri string olarak alır ve sayısal işlem yapılacaksa convert(dönüştürmek) etmek gerekir. Casting metodu ile "(int)" şeklinde de çevrilebilir fakat program bazen kabul etmez, bu yüzden convert metodu kullandık burada.


if (sayi > 0) //eğer sayı 0'dan büyükse
{
    Console.WriteLine("Sayı Pozitif");
}

else if (sayi < 0)
{
    Console.WriteLine("Sayı Negatif");
}

else
{
    Console.WriteLine("Sayı 0");
}

Console.WriteLine(); //Bir satır boşluk
Console.WriteLine("Kullanıcı Adını Giriniz: ");

string kullaniciadi = Console.ReadLine();

Console.WriteLine("Şifrenizi Giriniz: ");

string sifre = Console.ReadLine();

if (kullaniciadi == "admin" && sifre == "123")
{
    Console.WriteLine("Giriş Başarılı! \n Hoşgeldin!: "+ kullaniciadi);
}
else
{
    Console.WriteLine("Giriş Başarısız!");
}

int saat = DateTime.Now.Hour; // DateTime ile tarih ve saat bilgilerine ulaşırız.(.NET kütüphanesinden)
if (saat > 19)
    Console.WriteLine("İyi Akşamlar!"); //tek satırlı kodlarda süslü parantez kullanılmayabilir.

else
    Console.WriteLine("Saat:"+ saat +" İyi Günler!");

Console.WriteLine();

Console.WriteLine("Ternary Operatörü"); //bu operatör ile tek satırla da halledilebilir.

Console.WriteLine((saat > 19)? "Saat:" + saat + " İyi Akşamlar!" : "Saat:" + saat + " İyi Günler!"); //ternary operatörü ile tek satır da halledilebilir.

Console.WriteLine();

Console.WriteLine("Switch Case Kullanımı");

int ay = DateTime.Now.Month; //bulunduğumuz ay değerine ulaştık.

switch (ay)  //switch de parantez içi kontrol edilecek alandır. (Deneme yanılma)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Mevsim Kış");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Mevsim İlkbahar");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Mevsim Yaz");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Mevsim Sonbahar");
        break;

    default:
        Console.WriteLine("Hiçbir şart uymadıysa deault çalışır.");
        break;
}

