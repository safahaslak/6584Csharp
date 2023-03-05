using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Specialized;

namespace Ders18Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koleksiyonlar!");
            //Ornek1();
            Console.WriteLine();
            //Ornek2();
            Console.WriteLine();
            //Ornek3();
            //Ornek4();
            //Ornek5();
            //Ornek6();
            //Ornek7();
            //Ornek8();
            ListKullanimi();

        }
        static void Ornek1()
        {
            ArrayList arrayList= new ArrayList();
            arrayList.Add(1); //arrayList'e add metodu ile veri eklenir.
            arrayList.Add(2);
            arrayList.Add(3);

            foreach(int item in arrayList) 
            {
                Console.WriteLine(item); // Listedeki elemanları ekrana yazdır.
            }
            Console.WriteLine("ArrayList ilk eleman: " + arrayList[0]); // Listede index ini verdiğimiz elemana ulaşma.
        }
        static void Ornek2()
        {
            ArrayList arrayList = new ArrayList(); 
            arrayList.Add("İstanbul"); //arrayList'e add metodu ile veri eklenir.
            arrayList.Add("Ankara");  //arrayList string veri de alabilir.
            arrayList.Add("İzmir");
            arrayList.Add("Zonguldak");
            arrayList.Add("Çankırı");


            foreach (var item in arrayList)
            {
                Console.WriteLine(item); // Listedeki elemanları ekrana yazdır.
            }
            Console.WriteLine("ArrayList ilk eleman: " + arrayList[0]); // Listede index ini verdiğimiz elemana ulaşma.
            Console.WriteLine("ArrayList'de sıralama yapabiliriz.");
            arrayList.Sort(); //listeyi sıralama.
            foreach (var item in arrayList)
            {
                Console.WriteLine(item); //listedeki elemanları ekrana yazdır.
            }
            Console.WriteLine();
            arrayList.Reverse(); // tersten sıralama.
            foreach (var item in arrayList)
            {
                Console.WriteLine(item); //listedeki elemanları ekrana yazdır.
            }
        }
        static void Ornek3()
        {
            int tamSayi = 18;
            double kesirli = 18.8;
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Ankara");
            arrayList.Add(tamSayi);
            arrayList.Add(kesirli);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine();
            
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]); // arraylist'in i. satırındaki eleman.
            }
        }
        static void Ornek4()
        {
            StringCollection strings = new StringCollection(); //bir diğer collection yöntemi
            //strings.Add(5); // StringCollection' da sadece string değer eklenebilir.
            strings.Add("istanbul");
            strings.Add("Ankara");
            strings.Add("Bursa");
            Console.WriteLine("String Collection: ");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek5()
        {
            StringDictionary dictionary = new StringDictionary(); // key value şeklinde veri saklayabilir.
            dictionary.Add("18"," Çankırı ");
            dictionary.Add("06"," Ankara ");
            dictionary.Add("34"," İstanbul ");
            dictionary.Add("01"," Adana ");
            dictionary.Add("42"," Konya ");
            Console.WriteLine("String Dictionary");
            Console.WriteLine(dictionary["42"]);
            Console.WriteLine("String Dictionary Values: ");
            foreach (var item in dictionary.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("String Dictionary Keys: ");
            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("String Dictionary Keys-Values");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek6()
        {
            Stack stack = new Stack(); // Stack sınıfı programlama da LIFO - son giren ilk çıkar kuralıyla çalışır.
            //stack.add(); // stack de listeye add metoduyla ekleme yapılmaz.
            stack.Push("Çankırı");
            stack.Push("Ankara");
            stack.Push("İstanbul");
            stack.Push("Karabük");
            stack.Push(34);
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop()); //stack de nesneler üst üste koyulmuş gibidir verilere de üstten çekerek ulaşılır.
            }
        }
        static void Ornek7()
        {
            Queue queue = new Queue(); //   Queue sınıfı programlama da FIFO - ilk giren ilk çıkar mantığıyla çalışır.
            queue.Enqueue("Lale");
            queue.Enqueue("Gül");
            queue.Enqueue("Zambak");
            queue.Enqueue(18);         //   obje aldığı için her türlü veri kabul eder. 
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
        static void Ornek8()
        {
            Dictionary<string, string> dictionary = new();  //hangi veri tipinden oluşacağını bizim belirleyebildiğimiz liste sistemi.
            dictionary.Add("book","kitap");
            dictionary.Add("18","Çankırı");
            dictionary.Add("34","İstanbul");
            Console.WriteLine(dictionary["book"]);
            
            Dictionary<int, string> dictionary2 = new();
            dictionary2.Add(1, "kitap");
            dictionary2.Add(18, "Çankırı");
            dictionary2.Add(34, "İstanbul");
            Console.WriteLine(dictionary2[18]);

            Console.WriteLine("dictionary2 values: ");
            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Value);  //her bir itemin değerini ekrana yazdırıyoruz.
            }
            Console.WriteLine("dictionary2 keys: ");
            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Key); 
            }
            Console.WriteLine("dictionary2 keys-values: ");
            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Key + "= " + item.Value); 
            }

        }
        static void ListKullanimi()
        {
            List<string> sehirler = new();  // string veri tipi alabilen bir liste. en çok kullanacağımız liste tipi.
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("Kocaeli");

            Console.WriteLine("Şehirler : ");

            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            List<User> users = new(); // List yazarken "<T>"  yazıldığı görülür bu T işareti Generictir yani her şey kullanabiliriz. Burada User sınıfını kullandık.
            users.Add(new User
            {
                Id = 1, Name = "Gül", Password = "123"

            });
            users.Add(new User
            {
                Id = 2, Name = "Deniz", Password = "456"

            });
            Console.WriteLine("Kullanıcılar : ");
            foreach (var item in users)
            {
                Console.WriteLine(item.Name); //istediğimiz item'in bir özelliğini ekrana yazdırabiliriz.
            }
            List<User> kullanicilar = new()
            {
                new User
                {
                Id = 3, Name = "İrem", Password = "123"

                },
                new User
                {
                Id = 4, Name = "Safa", Password = "456"

                }

            };
            Console.WriteLine();
            Console.WriteLine("Kullanıcılar(kullanicilar) : ");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name); //istediğimiz item'in bir özelliğini ekrana yazdırabiliriz.
            }
            Console.WriteLine();

            Console.WriteLine("AddRange metodu: ");
            
            kullanicilar.AddRange(users); //kullanıcılar listesine çoklu ekleme için AddRange metodu kullanılır.
            Console.WriteLine("Kullanıcılar(kullanicilar) : ");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name); //istediğimiz item'in bir özelliğini ekrana yazdırabiliriz.
            }
            
            var yeniKullanici = new User()
            {
                Name = "Alp", Password = "789"
            };
            Console.WriteLine("kullanicilar listesinde yeni kullanıcı var mı? " + kullanicilar.Contains(yeniKullanici));
            kullanicilar.Add(yeniKullanici); // kullanicilar a yeniKullanici yı ekle
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name); 
            }

            Console.WriteLine("kullanicilar listesinde yeni kullanıcı var mı? " + kullanicilar.Contains(yeniKullanici));
            
            Console.WriteLine("Listedeki kayıt sayısı : " + kullanicilar.Count);
            kullanicilar.Insert(0, yeniKullanici);  // yeniKullanici'yi 0. indeksden sonra ekledi. Aşağıda da göreceğiz.
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name);  // alp'i yani yeniKullanici'yi tekrar ekledi.
            }
        }
        class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }

        }
    }
}