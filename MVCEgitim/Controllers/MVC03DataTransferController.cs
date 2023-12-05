﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class MVC03DataTransferController : Controller
    {
        // GET: MVC03DataTransfer
        public ActionResult Index(string kelime, string fiyat) /* get metoduyla query string üzerinden gönderilen veriyi bu şekilde parantez içine yazarak yakalayabiliriz.
        Burada önemli nokta form içerisindeki inputlara verdiğimiz name(isim) değeri neyse o isimle dilediğimiz kadar alan ekleyebiliriz. */
        {
            // MVC de 3 temel yöntemle view a veri gönderebiliriz.

            // 1- Viewbag
            ViewBag.UrunKategorisi = "Bilgisayar";
            // 2-Viewdata
            ViewData["UrunAdi"] = "Casper Monitör";
            // 3-TempData
            TempData["UrunFiyati"] = 99.90;

            ViewBag.Kelime = kelime;
            ViewBag.Fiyat = fiyat;

            return View();
        }
        public ActionResult Index(string text1, string )
        {
            return View();
        }
    }
}