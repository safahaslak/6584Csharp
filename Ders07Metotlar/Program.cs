// See https://aka.ms/new-console-template for more information
Console.WriteLine("Metotlar!"); //Fonksiyonlar.

/*
void ToplamaYap() //void metotlar geriye değer döndürmez, sadece görevini yapar.
{
    Console.WriteLine(10+8);
}

ToplamaYap();
void ToplamaYapParametreli(int sayi1, int sayi2) //metotlar dışarıdan parametre gönderilerek de kullanılabilir.
{
    Console.WriteLine("Toplama Sonucu : ");
    Console.WriteLine(sayi1 + sayi2);
}
ToplamaYapParametreli(18 , 34); //parametre isimlerini yazmadan değerlerini sırasıyla belirtmemiz gerekiyor.
ToplamaYapParametreli(sayi2: 34, sayi1: 25); //dilersek parametre isimlerini belirterek kullanabiliriz fakat burada sıra farketmiyor. 
int ToplamaParametreli(int sayi1, int sayi2) //metot isminin önüne void yerine herhangi bir veri tipi belirterek geriye bu tipte değer döndürecek metot oluşturulabilir.
{
    //eğer bir metot geriye doğru değer döndürüyorsa metot içerisinde return ifadesiyle bir değer döndürmeliyiz.
    return sayi1 + sayi2; // bu metoda gönderilecek değerleri topla ve bu toplama sonucunu metodun kullanılacağı yere gönder. 
                         // void de return kullanılamaz.
}

Console.WriteLine("Değer döndüren toplama sonucu :");
int islemSonucu = ToplamaParametreli(18,9); // toplama işleminin sonucunu bize getiren metodun getirdiği toplam derğeri "islemSonucu" isimli değişkene aktardık.
Console.WriteLine(islemSonucu); //işlem sonucunu ekrana yazdır.

bool MailGonder(string email)
{
    //burada örnek mail gönderim. 
    //kod alanı 
    if (email!="") //eğer email değişkeni boşsa
    {
        // mail gönderim kodlarını çalıştır.
        // ve maili gönder
        return true; // geriye de mail gönderildiğini anlayabilmemiz için bize true değeri döndür.
    }
    return false; // if bloğu çalışmamışsa metot buraya kadar gelecek ve geriye false değeri döndürecek böylece biz de mail gönderim işleminin başarısız olduğunu anlayabileceğiz.
}
//void ile yapılan işlemlerde başarılı olunup olunmadığının feedback'i gelmez. Ama diğer veri tipleri ile yapılan fonksiyonlarda bu feedback'i alabiliriz.

Console.WriteLine("Mail'i Yazınız: ");

var mail = Console.ReadLine(); // var ile metottan dönen veri tipini (bool) otomatik belirliyoruz.

var sonuc = MailGonder(mail); 

if (sonuc == true)
    Console.WriteLine("Mailiniz Başarıyla Gönderildi!");
else
    Console.WriteLine("Mail Gönderilemedi!");

// ekranda kullanıcı adı ve şifre bilgisi girilsin -- k.adı : admin , şifre : 12345 
// bu verileri bir metot içerisinde kontrol edelim.
// eğer girilen veriler istediğimiz değerlerse geriye true dönsün ve ekrana hoşgeldin "kullanıcı adı" yazsın.

*/

// "/*  -  */" ile çok satırlı yorum satırı yapılabilir. 

Console.WriteLine("Kullanıcı Adınızı Giriniz : ");
var KullaniciAdi = Console.ReadLine();
Console.WriteLine("Şifrenizi Giriniz : ");
var sifre = Console.ReadLine();
bool LoginKontrol (string kullanici, string sifre)
{
    if (kullanici == "admin" && sifre == "123456")
    {
        return true;
    }
    return false;
}

var girisSonuc = LoginKontrol(KullaniciAdi, sifre);

//if (girisSonuc == true) //if kontrolünü bu şekilde açık olarak kullanabiliriz.
//if (LoginKontrol(kullaniciAdi, sifre)) //if in içinde direkt metodu çağırabiliriz.

if (girisSonuc) //girisSonuc değişkeni zaten true veya false olacağı için bu şekilde kontrol edebiliriz.
    Console.WriteLine("Hoşgeldin " + KullaniciAdi);
else Console.WriteLine("Giriş Başarısız!");











