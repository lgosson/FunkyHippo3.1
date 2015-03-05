using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FunkyHippo.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FunkyHippo.DAL
{
    public class FunkyHippoContext : DbContext
    {
    
        public FunkyHippoContext() : base("FunkyHippoContext")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}