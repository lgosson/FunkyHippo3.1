using FunkyHippo.DAL;
using FunkyHippo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FunkyHippo.Controllers
{
    public class EditInfoController : Controller
    {
        IUnitOfWork uow;

        public EditInfoController()
        {
            uow = new UnitOfWork();
        }

        public EditInfoController(IUnitOfWork fakeUow)
        {
            uow = fakeUow;
        }

        // GET: EditInfo
        // This method illustrates using a view model to pass information
        // This example is a bit contrived since we can use List<Author> to do the same thing.
        public ActionResult Index()
        {
            var albums = uow.AlbumRepo.Get(includeProperties: "Reviews");

            // Just copying from the entity models to the view model
            var vmList = new List<ReviewViewModel>();
            foreach (Album a in albums)
            {
                foreach (Review b in a.Reviews)
                {
                    vmList.Add(new ReviewViewModel()
                    {
                        Title = b.Album,
                        Artist = b.Artist,
                        Ra
                        Album = new RViewModel() { UserName = a.Title}
                    });
                }
            }

            return View(vmList);
        }
        
    }
}