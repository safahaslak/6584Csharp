﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] sayi; //dizi tanımlama
int[] ogrenciler = new int[6]; //6 elemandan oluşacak bir dizi

ogrenciler[0] = 100;
ogrenciler[1] = 200;
ogrenciler[2] = 300;
ogrenciler[3] = 400;
ogrenciler[4] = 400;
Console.WriteLine("Ogrenci No: " + ogrenciler[4]);
ogrenciler[5] = 600;
Console.WriteLine("Ogrenci No: " + ogrenciler[5]);
ogrenciler[5] = 700;
Console.WriteLine("Ogrenci No: " + ogrenciler[5]);
//ogrenciler[6] = 800; - dizilerde sayma işlemi 0'dan başladığı için 6 listenin dışına taşar ve hata verir.


string[] isimler = new string[5];

isimler[0] = "talha";
isimler[1] = "murat";
isimler[2] = "gül";
Console.WriteLine(isimler[1]);

int[] ogrenciler2 = { 100, 200, 300, 400, 500 }; //diğer dizi tanımlama yöntemi

Console.WriteLine(ogrenciler2[1]);
ogrenciler2[1] = 118;
Console.WriteLine(ogrenciler2[1]);

string[] kategoriler = { "Bigisayar", "Elektronik", "Telefon" };

Console.WriteLine(kategoriler[0]);
kategoriler[0] = "Bilgisayarlar";
Console.WriteLine(kategoriler[0]);


