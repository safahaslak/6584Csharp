using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//bunları silebiliriz. kullanmadığımız kütüphaneler.

namespace Ders08Classes
{
    internal class SınıftaMetotKullanimi //internal = erişim belirteci.
    {
        string kurucuMetot; //başında erişim belirteci yazmazsak, sadece bulunduğu süslü parantez içinden erişebiliriz.
        public SınıftaMetotKullanimi() // klavyeden ctor yazılıp iki kez tab'a basıldığı zaman burası oluşur.
        {
            kurucuMetot = "Sınıflarda kurucu metot (constructor) sistemi vardır ve sınıftan new ile bir nesne oluşturduğumuzda ilk önce bu metot çalışır!";
            Console.WriteLine(kurucuMetot);
        } //Eğer ihtiyacımız olursa kurucu metot kullanıyoruz.
        internal bool LoginKontrol(string kullanici, string sifre) //bir metot bu şekilde class içinde tanımlanabilir.
        {
            if (kullanici == "admin" && sifre == "123456")
            {
                return true;
            }
            return false;
        }
        internal bool MailGonder(string email)  //bir diğer metot ekledik.
        {
            if (email != "")
            {

                return true;
            }
            return false;
        }
    }
}
