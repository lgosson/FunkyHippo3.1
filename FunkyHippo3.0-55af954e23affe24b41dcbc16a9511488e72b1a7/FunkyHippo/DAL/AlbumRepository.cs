using FunkyHippo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FunkyHippo.DAL
{
    public class AlbumRepository : IAlbumRepository, IDisposable
    {
        private FunkyHippoContext db;

        public AlbumRepository(FunkyHippoContext c)
        {
            db = c;
        }

        public IEnumerable<Models.Album> GetAlbums()
        {
            return db.Albums.ToList();
        }

        public Models.Album GetAlbumByID(int albumID)
        {
            return db.Albums.Find(albumID);
        }

        public void InsertAlbum(Models.Album album)
        {
            db.Albums.Add(album);
        }

        public void DeleteAlbum(int albumID)
        {
            Album album = db.Albums.Find(albumID);
            db.Albums.Remove(album);
        }

        public void UpdateAlbum(Models.Album album)
        {
            db.Entry(album).State = EntityState.Modified;

        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}