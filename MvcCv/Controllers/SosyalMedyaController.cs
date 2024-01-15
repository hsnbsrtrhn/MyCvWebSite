using MvcCv.Models.Entitiy;
using MvcCv.Repositories;
using System.Web.Mvc;


namespace MvcCv.Controllers
{
    public class SosyalMedyaController : Controller
    {
        // GET: SosyalMedya
        GenericRepository<TblSosyal> repo = new GenericRepository<TblSosyal>();
        public ActionResult Index()
        {
            var veriler =repo.List();
            return View(veriler);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(TblSosyal p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");   
        }

        [HttpGet]
        public ActionResult SayfaGetir(int id)
        {
            var hesap = repo.Find(x=>x.ID == id);   
            return View(hesap);
        }
        [HttpPost]
        public ActionResult SayfaGetir(TblSosyal p)
        {
            var hesap = repo.Find(x => x.ID == p.ID);
            hesap.Ad = p.Ad;
            hesap.Durum = true;
            hesap.Link = p.Link;    
            hesap.ikon = p.ikon;
            repo.TUpdate(hesap);
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var hesap =repo.Find(x=>x.ID == id);    
            hesap.Durum=false;
            repo.TUpdate(hesap);
            return RedirectToAction("Index");
        }

    }
}