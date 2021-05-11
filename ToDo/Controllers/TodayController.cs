using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDo.Models;

namespace ToDo.Controllers
{
    public class TodayController : Controller
    {
        // GET: Today
        private Context context = new Context();
        public ActionResult Today()
        {
            var degerler = context.Gorevler.ToList();
            return View(degerler);
        }
    }
}