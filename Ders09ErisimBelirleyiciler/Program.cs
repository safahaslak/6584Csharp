// See https://aka.ms/new-console-template for more information

/*
 *  public : Yazdığımız kod bloğuna projenin her yerinden erişebilmemizi sağlar.
 *  protected : Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir.
 *  internal : Etkin proje ye ait sınıflardan erişilebilir.
 *  private : Yalnızca bulunduğu sınıftan erişilebilir. 
 *  1 öğe sadece 1 tane erişim belirteci alabilir.
 */
//!!!Bir projeden (Ders09ErisimBelirleyiciler) solution içerisindeki başka bir projeye (örneğin Ders08Classlar) erişmek için 2 proje arasında bağlantı kurmalıyız!!!
//Bu bağlantıyı projemizdeki dependencies'e sağ tıklayıp add project reference'a tıklayıp açılan pencereden bağlamak istediğimiz projeye tik atıp tamam diyerek pencereyi kapatıp bağlantı kurabiliriz.  

using Ders08Classes;
using Ders09ErisimBelirleyiciler; //bu satır Kullanici class ını bu sayfada kullanabilmemiz için yazılır.

internal class Program //internal ile erişebilirlik katıyoruz. Erişim belirteci.
{
    static void Main(string[] args)
    {
        Console.WriteLine("Erişim Belirleyiciler!");
        Kategori kategori = new Kategori();
        //kategori, Kategori class'ı içindeki değişkene erişim belirteci verilmediği için burada erişemiyoruz.
        kategori.Adi = "Bilgisayar";

        Urun urun = new Urun();
        urun.Adi = "Monitör";
        urun.Fiyati = 9999;
        //urun. diğerlerine burada erişemiyoruz.
        Console.WriteLine($"Ürün Bilgileri : \nÜrün Kategorisi : {kategori.Adi} \nÜrün Adı : {urun.Adi} \nÜrün Fiyatı : {urun.Fiyati}TL");
        
        Console.WriteLine();

        Kullanici kullanici = new()
        {
            Adi = "Ali",
            Soyadi = "Can"
        };
        SınıftaMetotKullanimi siniftaMetot = new(); //bu class 
        var sonuc = siniftaMetot.LoginKontrol;
    }
}

class Kategori
{
    public string Adi;   // her yerden erişilebilir.
    string Aciklamasi;   // sadece bu class içerisinde erişilebilir.
}

class Urun
{
    private int Id; // gizli , sadece bu class da erişilebilir.
    internal string Adi;  // bu projede erişilebilir.
    protected string Aciklamasi; // bu sınıf ve miras alındığı yerde.
    public decimal Fiyati; // her yerden erişilebilir.

}






















