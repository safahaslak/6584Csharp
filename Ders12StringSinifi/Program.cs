// See https://aka.ms/new-console-template for more information

namespace Ders12StringSinifi
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("String Sınıfı!");

            string metin = "degisken";

            char karakter = 'K';
            Ornek1();
            StringMetotlari();
        }
        static void Ornek1()
        {
            string birMetin = "Ankara başkenttir";
            String birSayi = "123456789"; //bu da bir string ifadesi fakat system kütüphanesi adı altında.
            System.String birTarih = "04.03.2023";
            string s = "C# Eğitimi"; //string yan yana dizilmiş char'lardan oluşur ve bir dizidir.
            
            Console.WriteLine("s'yi for ile yazdırma: ");
            
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("s[" + i + "]" + s[i]);
            }
            
            Console.WriteLine("s'yi foreach ile yazdırma: ");
            
            foreach (var item in s) // s değişkeni içindeki her bir karakter için dön.
            {
                Console.WriteLine(item); //her karakteri bir satıra yazdır.
            }
        }
        static void StringMetotlari()
        {
            string metin = "String'in Birçok Metodu Vardır";
            Console.WriteLine("Metin' in karakter sayısı(metin.Lenght) : " + metin.Length); //metin karakterinin uzunluğu (sayısı).
            var klon = metin.Clone();
            Console.WriteLine("metnin klonu : " + klon);
            metin = "My name is Ali";
            Console.WriteLine(metin + "metin.EndsWith(\"i\") metin i ile mi bitiyor : " + metin.EndsWith("i"));
            Console.WriteLine(metin + "metin.EndsWith(\"r\") metin r ile mi bitiyor : " + metin.EndsWith("r"));
            Console.WriteLine(metin + "metin.StartsWith(\"r\") metin r ile mi başlıyor : " + metin.StartsWith("r"));
            Console.WriteLine(metin + "metin.StartsWith(\"M\") metin M ile mi başlıyor : " + metin.StartsWith("M"));
            Console.WriteLine(metin + "metin.Indexof(name) metin içindeki name in index değeri : " + metin.IndexOf("name"));
            Console.WriteLine(metin + "metin.LastIndexof(\"i\") metin içindeki i nin index değeri : " + metin.LastIndexOf("i"));
            Console.WriteLine(metin + "metin.Insert(0 ,\"Merhaba : \") metin'e Merhaba ekleme : " + metin.Insert(0 ,"Merhaba ")); //insert metodu kullanıldığı anda Merhaba'yı ekledi fakat metin değeri değişmiyor.Sadece başına merhaba eklendi.
            Console.WriteLine(metin); //"My name is Ali" ekrana gelir.
            Console.WriteLine(metin.Substring(6, 3)); // Substring metinden bir parça alır, kaçıncı karakterden itibaren kaç karakter alacağımızı belirtiyoruz. (6, 3) ise 6.karakterden sonraki 3 karakteri alır.
            Console.WriteLine(metin.ToLower()); //metini küçük harfe çevirir.
            Console.WriteLine(metin.ToUpper()); //metini büyük harfe çevirir.
            Console.WriteLine(metin.ToLower().Replace(" ", "-")); //metini küçük harfe çevir ve replae ile içindeki boşlukları "-" ile değiştir. Replace parantez içindeki indekslerden 1.si değiştirilecek karakter, 2.si ise yerine koyulacak karakterdir.
            Console.WriteLine(metin.Remove(2, 5)); //Remove metodu ise metinde seçili alanı silmek için kullanılır.

        }
        

    }

}
