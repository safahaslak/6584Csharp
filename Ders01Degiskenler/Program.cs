// See https://aka.ms/new-console-template for more information
// c# da yorum satırı
Console.WriteLine("Hello, World!"); //kod açıklaması
// C# ile değişken tanımlama

// tam sayı veri tipleri

byte plaka_kodu; //değişken tanımlama / değişkenin tipi - değişkenin adı
plaka_kodu = 34; //değişkene veri atama

sbyte sbyteTuru = 127; //değişkeni oluşturduğumuz anda veri atayabiliriz

short kisaTamSayi = 123;

ushort ortaTamSayi = 12345;

int TamSayi = 123456;

uint uzunInt = 123456789;

long uzunTamSayi = 1234567899;

ulong enuzunTamSayi = 987654321;

// kesirli veri tipleri

float kesirlisayi = 4.5f;
double kesirlisayi2 = 4.5;

// decimal veri tipi

decimal urunfiyati = 5500;

// char veri tipi
char karakter = 'a'; //char tek karakter taşıyabilir.

// string veri tipi
string metin = "string veri tipi yan yana yazılmış char lardan oluşur";

//boolean veri tipi

bool aktif = false; // true ya da false 2 değerden birini alabilir.

byte? kilo = null; // ? işareti bu tipi boş bırakılabilir (nullable) hale getirir.

kilo = 69;
decimal asgariucret = 8506.80m;

var degisken = 18; //var anahtar kelimesi ile değişken tanımlarsak atanan değere göre veri tipi otomatik belirlenir.

//C# da sabitler.

const int kdvMiktari = 18; //sabit değer.

// kdvMiktari = 8;

Console.Write("String deki metin: ");
Console.Write(metin);
Console.Write("kdv Miktari: ");
Console.Write(kdvMiktari);
Console.WriteLine(); //ekrana console writeline yazdırmanın kısayolu cw yazıp taba basmak.
Console.WriteLine("kdv \n \t Miktari: "); // \n : bir alt satıra yazdırır.   \t : bir tab boyu ileri yazdırır.
Console.WriteLine(kdvMiktari);










