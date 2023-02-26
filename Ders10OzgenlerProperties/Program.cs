// See https://aka.ms/new-console-template for more information

// Kisi class ını aç.
using Ders10OzgenlerProperties;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Özgenler - Properties!");
        Skorlar skorlar = new Skorlar();
        skorlar.Skor = 5;
        Console.WriteLine("Skor değeri : " + skorlar.Skor);
        Kisi kisi = new Kisi();
        kisi.Adi = "Memati";
        kisi.Soyadi = "Baş";
        kisi.Maas = 8000; //burada Maas properties'ine veri gönderdiğimizde set bloğu çalışır.
        kisi.Yas = 17;

        Console.WriteLine();
        Console.WriteLine("Personel Bilgileri : ");
        Console.WriteLine($"Adı : {kisi.Adi} Soyadı : {kisi.Soyadi}");
        Console.WriteLine($"Maaş : {kisi.Maas} Yaşı : {kisi.Yas}"); //burada Maas ve Kisi properties'lerini çağırdığımızda property'deki get bloğu çalışır.
        
        kisi.Maas = 18000; //burada Maas properties'ine veri gönderdiğimizde set bloğu çalışır.
        kisi.Yas = 39;
        
        Console.WriteLine();
        Console.WriteLine($"Maaş : {kisi.Maas} Yaşı : {kisi.Yas}");

        //User class'ı oluşturduktan sonra;
        User kullanici = new()
        {
            Name = "Alp",
            Email = "alparslan.net",
            Password = "2023",
        };
        kullanici.KayitTarihi = DateTime.Now;
        Console.WriteLine();
        Console.WriteLine("Kullanıcı Bilgileri : ");
        Console.WriteLine($"Adı : {kullanici.Name} \nEmail : {kullanici.Email} ");

        User user = new(); //bu user'in email,password bilgilerini ekrandan girdir. user'in içerisindeki metotu kullanarak ekrana giriş başarılı veya başarısız mesajı verdir.
        Console.WriteLine("E-mail adresinizi giriniz : ");
        var email = Console.ReadLine();
        Console.WriteLine("Şifrenizi giriniz : ");
        var sifre = Console.ReadLine();
        var sonuc = user.kullaniciGiris(email, sifre); //ekrandan aldığımız değerleri kullaniciGiris metoduna gönderiyoruz ve o metottan dönen true veya false değerini sonuc değişkenine aktarıyoruz.
        if (sonuc == true)
        {
            Console.WriteLine("Giriş Başarılı!");
        }
        else Console.WriteLine("Giriş Başarısız!");

    }
}
class Skorlar
{
    private int skor;

    public int Skor
    {
        get { return skor;}
        set { skor = value; }
        
    }
    
}













