using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entitiy;

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {

            var degerler = db.TblHakkiimda.ToList();
            return View(degerler);
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyalmedya = db.TblSosyal.Where(x=>x.Durum==true).ToList();
            return PartialView(sosyalmedya);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyimlerim.ToList();
            return PartialView(deneyimler) ;
        }

        public PartialViewResult Egitimlerim()
        {
            var egitimlerim = db.TblEgitimlerim.ToList();
            return PartialView(egitimlerim);
        }

        public PartialViewResult Yeteneklerim()
        {
            var yeteneklerim = db.TblYeteneklerim.ToList();
            return PartialView(yeteneklerim);
        }

        public PartialViewResult Hobilerim()
        {
            var hobilerim = db.TblHobilerim.ToList();
            return PartialView(hobilerim);
        }

        public PartialViewResult Sertifikalar()
        {
            var sertifikalar = db.TblSertifikalarim.ToList();
            return PartialView(sertifikalar);
        }

        [HttpGet]
        public PartialViewResult iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult iletisim(Tbliletisim t)
        {
            t.Tarih =DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tbliletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }


    }
}