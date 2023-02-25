// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Döngüler!");

Console.WriteLine("For Döngüsü!");

int veritabanindangelenurunsayisi = 5;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("i'nin değeri : " + i);
}

Console.WriteLine("While Döngüsü!");

int j = 0; //değişken dışarda tanımlanır.
while (j < 5) //şart while() içinde yazılır.
{
    Console.WriteLine("j'nin değeri : " + j);
    j++; //değişkenin değerini 1 artırıyoruz ki sonsuz döngüye girmesin.
}

Console.WriteLine("Do While Döngüsü!");

int toplam = 10; // Herhangi bir değer verilseydi 10'a kadar sayıp döngüden çıkacaktı.
do //bu kısımda kodlar çalışır.
{
    Console.WriteLine("toplamın değeri : " + toplam);
    toplam++;
} while (toplam<10);

Console.WriteLine("Foreach Döngüsü");

string[] kategoriler = { "Elektronik", "Bilgisayar", "Telefon" };

foreach (var item in kategoriler) //Diziler için en kullanışlı döngü: "foreach". Buradaki "item" kategorinin içerisindeki elemanları sırasıyla gösterir. İstenildiği zaman bu "item" ismi değiştirilebilir.
{
    Console.WriteLine("Kategori Adı : " + item);
}

string[] urunler = { "Ürün 1", "Ürün 2", "Ürün 3" };

foreach (var kategori in kategoriler)  //iç içe döngüler de oluşturulabilir.
{
    Console.WriteLine("Kategori Adı : " + kategori);
    foreach (var urun in urunler)
    {
        Console.WriteLine("\tÜrün Adı : " + urun);
    }
}






