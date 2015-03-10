using FunkyHippo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FunkyHippo.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private FunkyHippoContext context = new FunkyHippoContext();
        private IFunkyHippoRepo<Album> albumRepo;
        private IFunkyHippoRepo<User> userRepo;
        private IFunkyHippoRepo<Review> reviewRepo;

        IFunkyHippoRepo<Album> IUnitOfWork.AlbumRepo
        {
            get
            {
                if (this.albumRepo == null)
                {
                    this.albumRepo = new FunkyHippoRepo<Album>(context);
                }
                return albumRepo;
            }
        }

        IFunkyHippoRepo<User> IUnitOfWork.UserRepo
        {
            get
            {
                if (this.userRepo == null)
                {
                    this.userRepo = new FunkyHippoRepo<User>(context);
                }
                return userRepo;
            }
        }

        IFunkyHippoRepo<Review> IUnitOfWork.ReviewRepo
        {
            get
            {
                if (this.reviewRepo == null)
                {
                    this.reviewRepo = new FunkyHippoRepo<Review>(context);
                }
                return reviewRepo;
            }
        }

        private bool disposed = false;

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}