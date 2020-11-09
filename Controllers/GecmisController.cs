using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HesapMakinesi.Models;
using System.Collections;
using myAliasName = System.Collections.Generic.List<int>;

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
            var gecmis = from s in db.Gecmis select s;

            if (!String.IsNullOrEmpty(firstDate))
            {
                gecmis = gecmis.Where(s => s.tarih.GetDateTimeFormats().Contains(firstDate));
                
            }
            Context context = new Context();
            IEnumerable< Gecmis> gecmiss = gecmis.ToList();
            return View(gecmiss);
        } 

    }
}