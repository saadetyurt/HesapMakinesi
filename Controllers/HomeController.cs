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
        public ActionResult Index(FormCollection form , string firstNumber, string secondNumber, string Cal, string txtNumber)
        {
            
            double a = double.Parse(firstNumber);
            double b = double.Parse(secondNumber);
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
            }
            ViewBag.Result = c;
            string  sonuc = d;
            HesapMakinesi.Models.GECMISDBEntities db = new GECMISDBEntities();
            HesapMakinesi.Models.Gecmis model = new Gecmis();

            model.tarih = Convert.ToDateTime(DateTime.Now.ToString());
            model.sayi1 = double.Parse(firstNumber);
            model.sayi2 = double.Parse(secondNumber);
            model.sonuc = sonuc;
            model.islemler = c;
            db.Gecmis.Add(model);
            db.SaveChanges();

            return View();
        }

    }
}


