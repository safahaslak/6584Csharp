namespace Ders11YapilarStruct
{
    /*
     * C#'da değişkenler değer(value) ve referans tipler olmak üzere 2'ye ayrılır.
     * Değişkenler ana bellek içerisinde stack ve heap denilen 2 ayrı bölge de tutulur.
     * string dışındaki tüm veri tipleri değer tiplidir ve stack alanında tutulur.
     * string ve class gibi yapılar ise bellekte heap alanında tutulur.
     * stack'de tutulan veriler işleri bittiğinde otomatik olarak bellekten atılır.
     * referans tipliler ise garbage collector (çöp toplayıcı) tarafından belirli aralıklarla temizlenir ve açılan alan belleğe katılır.
     */
    public struct Yapi
    {
        public int sayi;
        public string metin;
        public void Metod()
        {
            Console.WriteLine("Yapı içindeki metot çalıştı.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapilar - Struct!"); //Sınıflara benzeyen bir yapı.
        }
    }
}