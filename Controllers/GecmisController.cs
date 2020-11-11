using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HesapMakinesi.Models;
using System.Collections;


namespace HesapMakinesi.Controllers
{
    public class GecmisController : Controller
    {
        public ActionResult Gecmis()
        {
            Context context = new Context();
            List<Gecmis> gecmis = context.Gecmises.ToList();
            return View(gecmis);
        }

        [HttpPost]
        public ViewResult Gecmis(string firstDate, string secondDate, string search)
        {

            HesapMakinesi.Models.GECMISDBEntities db = new GECMISDBEntities();
            HesapMakinesi.Models.Gecmis model = new Gecmis();
            DateTime a = DateTime.Parse(firstDate);
            DateTime b = DateTime.Parse(secondDate);

            var gecmis = db.Gecmis.Where(s => s.tarih >= a && s.tarih =< b);
             
            return View(gecmis);
        } 

    }
}