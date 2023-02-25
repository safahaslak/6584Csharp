// See https://aka.ms/new-console-template for more information



using Ders08Classes;
using Microsoft.Win32.SafeHandles;
using System; //system kütüphanesi, istenilirse silinebilir. Şuan da kullanmıyoruz çünkü.

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program //internal ile erişebilirlik katıyoruz. Erişim belirteci.
    {
        static void Main(string[] args)  //Main asıl çalışan yani kodu çalıştıran bloktur.
        {
            Console.WriteLine("Sınıflar - Classes!");
            Ev ilkEv = new Ev(); //soyut bir yapı olan ev sınıfından, somut bir nesne olan ilkEv'i oluşturduk.
            ilkEv.sokakAdi = "Okul sk.";
            ilkEv.kapiNo = 10;
            Console.WriteLine("İlk ev sokak adı : " + ilkEv.sokakAdi);
            Console.WriteLine("İlk ev kapı numarası : " + ilkEv.kapiNo);

            Ev yazlikEv = new(); //yazlik ev oluşturalım.
            yazlikEv.sokakAdi = "Deniz sk.";
            yazlikEv.kapiNo = 18;
            Console.WriteLine("Yazlık ev sokak adı : " + yazlikEv.sokakAdi);
            Console.WriteLine("Yazlık ev kapı numarası : " + yazlikEv.kapiNo);

            Ev koyEvi = new() // Diğer bir oluşturma tarzı ile köy evi oluşturalım.
            {
                sokakAdi = "Kavak Sk.", // Bu kullanımda ";" yerine "," kullanılır.
                kapiNo = 30

            };
            Console.WriteLine("Köy evi sokak adı : " + koyEvi.sokakAdi);
            Console.WriteLine("Köy evi kapı numarası : " + koyEvi.kapiNo);

            Console.WriteLine();

            /*Kullanici kullanici = new()
            {
                Adi = "Deniz",
                Soyadi = "Çoban",
                Email = "deniz@coban.com",
                Id = 1,
                KullaniciAdi = "deniz",
                Sifre = "1234"

            };
            */
            Kullanici kullanici = new()
            {
                Adi = "Safa",
                Soyadi = "Haşlak",
                Sifre = "12345",
                Id = 2,
                KullaniciAdi = "safa",
                Email = "safa@google.com"

            };

            Console.WriteLine("Kendi Kullanıcımız :\n Adı : {0} Soyadı : {1}", kullanici.Adi, kullanici.Soyadi);

            Araba mycar = new()
            {
                Id = 3,
                Marka = "Audi",
                Model = "A3",
                KasaTipi = "Sedan",
                VitesTipi = "Yarı Otomatik",
                YakitTipi = "Dizel",
                Renk = "Siyah",

            };
            Console.WriteLine("Araç Bilgisi : ");
            Console.WriteLine($"Marka : {mycar.Marka}\n Model : {mycar.Model}\n Renk : {mycar.Renk}\n KasaTipi : {mycar.KasaTipi}");

            Araba araba = new()
            {
                Id = 1,
                Marka = "Dacia",
                Model = "Logan",
                KasaTipi = "Sedan",
                VitesTipi = "Manuel",
                YakitTipi = "Dizel",
                Renk = "Bordo"

            };
            /*
            Console.WriteLine("Araç Bilgisi : ");
            Console.WriteLine($"Marka : {araba.Marka} \n Model : {araba.Model} \n Renk : {araba.Renk}");

            Console.WriteLine("Kullanici Adiniz : ");
            var kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifreniz : ");
            var sifre = Console.ReadLine();

            if (kullaniciAdi == kullanici.KullaniciAdi && sifre == kullanici.Sifre)
            {
                Console.WriteLine("Hoşgeldin! : " + kullanici.Adi + " " + kullanici.Soyadi);
            }
            else Console.WriteLine("Giriş Başarısız!");
            */
            Kategori kategori = new()
            {
                Id = 1, KategoriAdi = "Elektronik"
            }; 
            Kategori kategori2 = new()
            {
                Id = 2, KategoriAdi = "Bilgisayar"
            };
            Kategori kategori3 = new()
            {
                Id = 3, KategoriAdi = "Telefon"
            };

            Console.WriteLine("Kategori : " + kategori.KategoriAdi);
            Console.WriteLine("Kategori : " + kategori2.KategoriAdi);
            Console.WriteLine("Kategori : " + kategori3.KategoriAdi);
        }   //main metodunun bitişi
class Ev // Sınıf (Class) Tanımlama 
        {
           internal string sokakAdi;  //burada internal olmasaydı eğer yukarıda "ilkEv.sokakAdi" gelmeyecekti.
           internal int kapiNo;     
        }
        Ev ilkEv = new Ev();
        }
    class Kullanici
    {
        internal int Id;
        internal string KullaniciAdi;
        internal string Sifre;
        internal string Email;
        internal string Adi;
        internal string Soyadi;

    }
    class Araba
    {
        internal int Id;
        internal string Marka;
        internal string Model;
        internal string KasaTipi;
        internal string YakitTipi;
        internal string VitesTipi;
        internal string Renk;
    }
   }

