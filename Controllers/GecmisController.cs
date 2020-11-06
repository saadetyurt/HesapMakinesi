using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HesapMakinesi.Models;

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
        /*public ActionResult Gecmis(int id)
        {
            Context context = new Context();
            Gecmis gecmis = context.Gecmises.Single(emp => emp.tarih == id);
            return View(gecmis);
        } */

    }
}