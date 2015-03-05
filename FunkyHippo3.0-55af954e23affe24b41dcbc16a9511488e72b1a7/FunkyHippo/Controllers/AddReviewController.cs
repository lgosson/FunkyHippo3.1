using FunkyHippo.DAL;
using FunkyHippo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace FunkyHippo.Controllers
{
    public class AddReviewController : Controller
    {
        private FunkyHippoContext db = new FunkyHippoContext();
        
        // GET: AddReview
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OurLove()
        {
            
            var albumNum = 1;
            
            var reviews = (from b in db.Reviews
                           where b.AlbumID == albumNum
                           select b);

            var sumRating = (from a in db.Reviews
                             where a.AlbumID == albumNum
                             select a.Rating).Sum();

            var countUsers = (from c in db.Reviews
                             where c.AlbumID == albumNum
                             select c.Rating).Count();

            double aggRating = (double)sumRating / (double)countUsers;
            ViewBag.AggRate = aggRating;

            return View(reviews.ToList());
        }

        // GET: Reviews/Create
       public ActionResult CreateOurLove()
        {
            
            ViewBag.AlbumID = new SelectList(db.Albums, "AlbumID", "Title");
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName");
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
       [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,UserID,AlbumID,Rating,Comment")] Review review)
        {
          
            if (ModelState.IsValid)
            {
                db.Reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AlbumID = new SelectList(db.Albums, "AlbumID", "Title", review.AlbumID);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "SurName", review.UserID);
            return View(review);
        }

     

        public ActionResult RTJ2()
        {
            var albumNum = 2;
            
            var reviews = (from b in db.Reviews
                           where b.AlbumID == albumNum
                           select b);

            var sumRating = (from a in db.Reviews
                             where a.AlbumID == albumNum
                             select a.Rating).Sum();

            var countUsers = (from c in db.Reviews
                              where c.AlbumID == albumNum
                              select c.Rating).Count();

            double aggRating = (double)sumRating / (double)countUsers;
            ViewBag.AggRate = aggRating;

            return View(reviews.ToList());
        }
    }
}