using FunkyHippo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FunkyHippo.DAL
{
    public class FakeUnitOfWork : IUnitOfWork
    {
         private IFunkyHippoRepo<Album> albumRepo;
        private IFunkyHippoRepo<User> userRepo;
        private IFunkyHippoRepo<Review> reviewRepo;

        private List<Album> albums;
        private List<User> users;
        private List<Review> reviews;

        public FakeUnitOfWork(List<Album> a = null, List<User> b = null, List<Review> e = null)
        {
            if (a == null)
                albums = new List<Album>();
            else
                albums = a;

            if (b == null)
                users = new List<User>();
            else
                users = b;
            if (e == null)
                reviews = new List<Review>();
            else
                reviews = e;
        }

        public IFunkyHippoRepo<Models.Album> AuthorRepo
        {
            get
            {
                if (this.albumRepo == null)
                {
                    this.albumRepo = new FakeFunkyHippoRepo<Album>(albums);
                }
                return albumRepo;
            }
        }

        public IFunkyHippoRepo<Models.User> BookRepo
        {
            get
            {
                if (this.userRepo == null)
                {
                    this.userRepo = new FakeFunkyHippoRepo<User>(users);
                }
                return userRepo;
            }
        }

        public IFunkyHippoRepo<Models.Review> EventRepo
        {
            get
            {
                if (this.reviewRepo == null)
                {
                    this.reviewRepo = new FakeFunkyHippoRepo<Review>(reviews);
                }
                return reviewRepo;
            }
        }

        public void Save()
        {
            // Nothing to do here
        }

        public void Dispose()
        {
            // Nothing to do here
        }



        
    }
}