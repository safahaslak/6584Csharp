// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operatörler!");
Console.WriteLine("1- Aritmetik Operatörler!");
int a = 50;
int b = 30;
int c = 20;

int toplama = a + b;
Console.WriteLine("a + b: " + toplama);

int cikarma = a - b;

Console.WriteLine("a - b: " + cikarma);

int carpma = b * c;

Console.WriteLine("b * c: " + carpma);

int bolme = b / c;

Console.WriteLine("b / c: " + bolme);

int kalan = b % c;

Console.WriteLine("b % c: " + kalan);

b++; //b'nin değerini 1 arttır.

Console.WriteLine("b++: " + b);

b--; //b'nin değerini 1 azaltır.

Console.WriteLine("b--: " + b);

Console.WriteLine(); //boş satır için.

Console.WriteLine("2- Atama Operatörleri!");


Console.WriteLine("a'nın değeri: " + a );
Console.WriteLine("a'nın değeri: " + b );
Console.WriteLine("a'nın değeri: " + c );

Console.WriteLine("a += b: " + (a += b)); // a'nın değerini b kadar arttır demektir.

Console.WriteLine("a = a + b: " + (a = a + b)); // bu işlem ile a+=b işlemi aynı işlevi görür.


Console.WriteLine("a -= b: " + (a -= b)); // a'nın değerini b kadar azalt demektir.
Console.WriteLine("a *= b: " + (a *= b)); // a'nın değerini b ile çarpar.
Console.WriteLine("a /= b: " + (a /= b)); // a'nın değerini b ile böler.

Console.WriteLine("3- İlişkisel Operatörler!");

Console.WriteLine($"a({a}) == b({b}) : " + (a==b)); // a, b'ye eşit mi?

Console.WriteLine($"a({a}) != b({b}): " + (a!=b)); // a, b'ye eşit değil mi?

Console.WriteLine($"a({a}) > b({b}): " + (a>b)); // a, b'den büyük mü?

Console.WriteLine($"a({a}) < b({b}): " + (a < b)); //a, b'den küçük mü?

Console.WriteLine($"a({a}) <= b({b}): " + (a <= b)); //a, b'den küçük veya eşit mi?

Console.WriteLine($"a({a}) >= b({b}): " + (a >= b)); //a, b'den büyük veya eşit mi? 

// $ işareti string alanları içerisinde yazılımsal değerleri süslü parantez kullanarak yazdırmaya yarıyor. 
// ? işareti ise ternary dir. iki olasılıktan birini yazdırır.

Console.WriteLine("ternary operatörü a == b: " + ((a == b) ? "a, b'ye eşit" : "a, b'ye eşit değil")); //2 olasılıklı durumlarda kullanabileceğimiz ternary operatörü.

Console.WriteLine(); //boşluk bırakalım.
Console.WriteLine("3- Mantıksal Operatörler!");
Console.WriteLine($"a-{a}, b-{b}, c-{c} + ((a > b) && ( b> c)): " + ((a > b) && (b > c))); // && - ve operatörüdür. İki şartın doğruluğunu kontrol eder.

Console.WriteLine($"a-{a}, b-{b}, c-{c} + ((a > b) || ( b> c)): " + ((a > b) || (b < c))); // || - veya operatörüdür. İki şarttan herhangi birinin doğruluğuna bakar.

Console.WriteLine(); //boşluk bırakalım.
Console.WriteLine($"a-{a}, b-{b} (a > b) : " + (a > b));  // burada a, b'den büyük mü bakıyoruz. 
Console.WriteLine($"a-{a}, b-{b} (a > b) : " + !(a > b)); // ! iaşreti ile bir işlem sonucunun tam tersini elde ederiz.





