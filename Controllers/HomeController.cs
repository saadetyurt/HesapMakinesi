using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HesapMakinesi.Models; 
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(double firstNumber, double secondNumber, string Cal)
        {

            double a = firstNumber;
            double b = secondNumber;
            double c = 0.0;
            string d = "Toplama";
            switch (Cal)
            {
                case "Add":
                    c = a + b;
                    d = "Toplama";
                    break;
                case "Sub":
                    c = a - b;
                    d = "Çıkarma";
                    break;
                case "Mul":
                    c = a * b;
                    d = "Çarpma";
                    break;
                case "Div":
                    c = a / b;
                    d = "Bölme";
                    break;
            }//viewbag cont dakı result degıskenının vıew de gorunmesını saglar
            ViewBag.Result = c;
            string  sonuc = d;

           //obje olusturma
            HesapMakinesi.Models.GECMISDBEntities db = new GECMISDBEntities();
            HesapMakinesi.Models.Gecmis model = new Gecmis();
            //db ye yazdırma
            model.tarih = Convert.ToDateTime(DateTime.Now.ToString("g"));
            model.sayi1 = firstNumber;
            model.sayi2 = secondNumber;
            model.sonuc = sonuc;
            model.islemler = c;
            db.Gecmis.Add(model);
            db.SaveChanges();

            return View();
        }

    }
}


