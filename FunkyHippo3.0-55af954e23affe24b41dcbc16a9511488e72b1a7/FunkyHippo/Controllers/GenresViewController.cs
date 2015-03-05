using FunkyHippo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FunkyHippo.Controllers
{
    public class GenresViewController : Controller
    {
        // GET: GenresView
        public ActionResult Index()
        {
            FunkyHippoContext db = new FunkyHippoContext();


           



            var query = (from a in db.Albums
                         group a by a.Genre into g
                         select g);
            //ViewBag.Genres = query;
            return View(query);
        }
    }
}