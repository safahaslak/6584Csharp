using MVCEgitim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class MVC04ModelBindingController : Controller
    {
        // GET: MVC04ModelBinding
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult KullaniciBilgi()
        {
            Kullanici kullanici = new Kullanici()
            {
                Ad = "Murat",
                Soyad = "Yılmaz",
                Email = "murat@yilmaz.com",
                Id = 25
            }; 
            // @Model.Ad hata vermesin diye içini doldurduk.
            // yukarıdaki kullanıcıyı aşağıdaki view içerisine yazmazsak sayfada hata alırız.
            return View(kullanici); // kullanici nesnesini parantez içerisidne sayfaya model olarak gönderiyoruz.
        }
        [HttpPost]
        public ActionResult KullaniciBilgi(Kullanici kullanici) /*MVC de view sayfasındaki
         model class ını buradaki gibi parantez içerisinde yakalayıp metot içerisinde kullanabiliriz.
         (veritabanına ekleme vb işlemler için.)*/
        {
            //burada istersek kullanici nesnesini veritabanına ekleyip uygulamayı da farklı bir ekrana yollayabiliriz.
            return View(kullanici); // ekrandan gelen model nesnesini geri ekrana yolladık.
        }
        public ActionResult AdresBilgi()
        {
            var model = new Adres
            {
                Sehir = "İstanbul", Ilce = "Pendik", AcikAdres = "Batı mh. Doğu sk. Vadi apt."
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult AdresBilgi(Adres adres)
        {
            // burada adresi db ye kaydedebiliriz.
            return View(adres);
        }
        public ActionResult KullaniciSayfasi()
        {
            Kullanici kullanici = new Kullanici()
            {
                Ad = "Murat",
                Soyad = "Yılmaz",
                Email = "murat@yilmaz.com",
                Id = 25
            };
            var adres = new Adres
            {
                Sehir = "İstanbul",
                Ilce = "Pendik",
                AcikAdres = "Batı mh. Doğu sk. Vadi apt."
            };
            var model = new KullaniciSayfasiViewModel()
            {
                Kullanici = kullanici,
                Adres = adres
            };

            return View(model);
        }
    }
}