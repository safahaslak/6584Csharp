namespace Ders14KalitimInheritance
{
    class Arac
    {
        public string AracTuru;
        public void KornaCal()
        {
            Console.WriteLine("Biip!");
        }
    }
    class Test
    {
        public int Id { get; set; }
    }
    class Otomobil : Arac // : Arac ile arac sınıfından içindekileri miras alırız.
    {  // artık otomobil sınıfında arac sınıfındaki içeriklere sahibiz.
        public string Marka { get; set; }
        public string Model { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalıtım - Miras Alma - Inheritance!");
            Arac arac= new Arac();
            arac.AracTuru = "Otomobil";
            Console.WriteLine("arac.AracTuru'nden geliyor : " + arac.AracTuru);
            Otomobil otomobil = new Otomobil();
            otomobil.AracTuru = "Otomobil";  //normalde Otomobil classında AracTuru yok fakat miras alındığı için kullanabiliriz.
            Console.WriteLine("otomobil.AracTuru'nden geliyor : " + otomobil.AracTuru);
            otomobil.KornaCal(); // KornaCal metodu bir üst sınıf olan Arac sınıfından geliyor.
            Kategori kategori = new()
            {
                Name = "Elektronik", UstMenudeGoster = true, EklenmeTarihi = DateTime.Now
            };
            Console.WriteLine($"Kategori Bilgileri : \nAdı :{kategori.Name} - Eklenme Tarihi : {kategori.EklenmeTarihi}");
            Urun urun = new()
            {
                Name = "Klavye", Fiyat = 299, Kdv = 18 
            };
            Console.WriteLine($"Ürün Bilgileri : \nAdı :{urun.Name} - Fiyat : {urun.Fiyat} - kdv : {urun.Kdv}");

            Cizici[] birCizici = new Cizici[4];
            birCizici[0] = new DogruCiz();
            birCizici[1] = new DaireCiz();
            birCizici[2] = new KareCiz();
            birCizici[3] = new Cizici();

            foreach (var item in birCizici)
            {
                item.Ciz();
            }
        }
        
        
        
        
        // POLİMORFİZM - ÇOKBİÇİMLİLİK
        public class Cizici
        {
            public virtual void Ciz() // virtual keyword'ü ile bu metodu override-ezilebilir hale getiriyoruz.
            {
                Console.WriteLine("Çizici");
            }
        }
        public class DogruCiz : Cizici
        {
            public override void Ciz() // Cizici sınıfındaki Ciz metodunu override keyword'ünü kullanarak eziyoruz ve ekrana yeni çıktı yazdırmasını sağlıyoruz.
            {
                Console.WriteLine("Düz Çizgi");
            }
        }
        public class DaireCiz : Cizici
        {
            public override void Ciz()
            {
                Console.WriteLine("DaireCiz");
            }
        }
        public class KareCiz : Cizici
        {
            public override void Ciz()
            {
                Console.WriteLine("KareCiz");
            }
        }
    }
}