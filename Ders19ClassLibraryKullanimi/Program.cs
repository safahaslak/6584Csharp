using Entities;

namespace Ders19ClassLibraryKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ClassLibrary Kullanımı!");
            // Bu projede Entities ClassLibrary kütüphanesinin kullanabilmek için Dependencies'e sağ tıklayıp Add Project References diyerek açılan pencereden Entities projesini seçip Ok diyerek pencereyi kapattık. Artık Entities içerisindeki class lara erişim belirteçleri izin veriyorsa erişip kullanabiliriz.
            Kategori kategori= new() 
            {
                Id = 1, Name = "Bilgisayar"
            };
            var urunler = new List<Urun>();

            urunler.Add(new Urun() { Name = "Klavye", Image = "urun1.jpg", Price = 199});
            urunler.Add(new Urun() { Name = "Mouse", Image = "urun2.jpg", Price = 149} );
            urunler.Add(new Urun() { Name = "Monitör", Image = "urun3.jpg", Price = 3333});
            Console.WriteLine("Kategori : " + kategori.Name);
            Console.WriteLine("Urunler : ");
            foreach (var item in urunler)
            {
                Console.WriteLine($"Urun Adı : {item.Name} - Fiyatı : {item.Price}");
            }
        }
    }
}