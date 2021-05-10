using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDo.Models;

namespace ToDo.Controllers
{
    public class DefaultController : Controller
    {
        private Context context = new Context();
        // GET: Default

        public ActionResult Index()
        {
            var degerler = context.Gorevler.ToList();

            return View(degerler);
        }
        [HttpGet]
        public ActionResult GorevEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GorevEkle(Gorev gorev)
        {
            try
            {
                context.Gorevler.Add(gorev);
                context.SaveChanges();
            }
            catch (Exception)
            {

            }

            return RedirectToAction("Index");
        }
        public ActionResult GorevSil(int id)
        {
            var silinecekId = context.Gorevler.Find(id);
            context.Gorevler.Remove(silinecekId);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GorevGuncelle(Gorev gorev)
        {
            var grv = context.Gorevler.Find(gorev.Id);
            grv.GorevName = gorev.GorevName;
            context.SaveChanges();


            return RedirectToAction("Index");
        }

        public ActionResult GorevGetir(int id)
        {
            var gorev = context.Gorevler.Find(id);
            return View("GorevGetir", gorev);
        }
    }
}