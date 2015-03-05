using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FunkyHippo.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Release { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
        public class MovieDBContext : DbContext
        {
            public DbSet<Album> Albums { get; set; }
        }
    }
}