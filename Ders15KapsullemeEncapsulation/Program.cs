namespace Ders15KapsullemeEncapsulation
{
    internal class Program
    {
        // Metot kullanarak kapsülleme
        public class Bolum
        {
            private string BolumAdi;
            public string GetBolumAdi() // Accessor - Getter
            {
                return BolumAdi;
            }
            public void SetBolumAdi(string a)
            {
                if (a == "Yazılım Mühendisliği") //eğer metoda gönderilen değer geçersizse
                {
                    Console.WriteLine("Okulumuzda bu bölüm bulunmamaktadır.");
                }
                else BolumAdi = a; //geçerliyse private değişkene değeri ata. 

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kapsulleme - Encapsulation!");
            //Console.WriteLine("C#'da özgen yapısı kullanılarak verileri kapsülleyebilir, istemediğimiz veriye engel olabiliriz.");
            Bolum bolum = new Bolum();
            Console.WriteLine("Tercih Ettiğiniz Bölümü Giriniz: ");
            var secilenbolum = Console.ReadLine();
            bolum.SetBolumAdi(secilenbolum);
            Console.WriteLine("Seçtiğiniz Bölüm : " + bolum.GetBolumAdi());
        }
        class Fakulte
        {
            private string bolum;
            public string Bolum
            {
                get { return bolum; }
                set 
                {
                    if (value == "Yazılım Mühendisliği")
                    {
                        Console.WriteLine("Okulumuzda bu bölüm bulunmamaktadır.");
                    }
                    else bolum = value;
                }
            }

        }
    }
}