using MVCEgitim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class MVC08ViewResultsController : Controller
    {
        // GET: MVC08ViewResults
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FarkliViewDondur() // MVC08ViewResults controller ındaki FarklıViewDondur isimli metot çalıştırılırsa
        {
            return View("Index"); // geriye FarklıViewDondur isimli bir ekran yerine index isimli view ı da gönderebiliriz.
        }
        public ActionResult Yonlendir()
        {
            // Bir action a istek gönderildiğinde farkli bir sayfaya yönlendirme yapabiliriz.

            //return Redirect("/Home"); // uygulamayı anasayfa yönlendir.
            return Redirect("https://www.google.com.tr/"); // uygulamayı google'a yönlendir.
        }
        public ActionResult ActionaYonlendir()
        {
            //return RedirectToAction("Index"); // bu metot çalıştığında RedirectToAction metodu uygulamayı Index action una yönlendirir.
            return RedirectToAction("Index", "Home"); // bu metot çalıştığında uygulama ana sayfasının index metoduna yönlendirilir.
        }
        public ActionResult RouteYonlendir()
        {
            return RedirectToRoute("Default", new { controller = "Home", action = "Index", id = 18 });
        }
        public PartialViewResult KategorileriGetirPartial() // Bir action işlemi sonucunda direkt geri dönüş türünü de belirtebiliriz.
        {
            return PartialView("_PartialMenu"); /*PartialViewResult döneceğimizi belirttiğimiz için geriye PartialView döndürmeliyiz.
                                                 Parantez içine döndürmek istediğimiz partial adını yazıyoruz.*/
        }
        public PartialViewResult KategorileriModelleGetir() 
        {
            List<string> kategoriler = new List<string>() { 
                "Elektronik", "Bilgisayar", "Telefon"
            };
            return PartialView("KategorileriModelleGetir", kategoriler); 
        }
        public JavaScriptResult JsResult()
        {
            return JavaScript("alert('Geriye JavaScript dönebildiğimiz metot çalıştı!')"); // geriye JavaScript dönebildiğimiz metot.
        }
        public JsonResult JsonResult() // evrensel dil diyebiliriz json için, başka bir uygulama veya platform ile haberleşmek için kullanılır.
        {
            Kullanici kullanici = new Kullanici()
            {
                Ad = "Murat",
                Soyad = "Yılmaz",
                Email = "murat@yilmaz.com",
                Id = 25
            };
            return Json(kullanici, JsonRequestBehavior.AllowGet); /* kullanici nesnesini json veri türüne çevirip geriye döndürdük.
                                                                   JsonRequestBehavior.AllowGet ile json u dışarı açmaya izin vermeliyiz
                                                                   yoksa güvenlik hatası alırız!*/
        }
        public ContentResult XmlContentResult()
        {
            var xml = @"<urunler>
                <urun>
                    <Id>1</Id>
                    <UrunAdi>Mouse</UrunAdi>
                    <Fiyati>149</Fiyati>
                </urun>
                <urun>
                    <Id>2</Id>
                    <UrunAdi>Klavye</UrunAdi>
                    <Fiyati>600</Fiyati>
                </urun>
            </urunler>";
            return Content(xml, "application/xml");
        }
    }
}