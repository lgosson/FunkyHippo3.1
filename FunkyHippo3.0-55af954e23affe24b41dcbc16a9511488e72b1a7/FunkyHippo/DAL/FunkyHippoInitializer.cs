using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FunkyHippo.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Migrations;

namespace FunkyHippo.DAL
{
    public class FunkyHippoInitializer : System.Data.Entity.DropCreateDatabaseAlways<FunkyHippoContext>
    {
        protected override void Seed(FunkyHippoContext context)
        {
            var users = new List<User>
            {
                new User{UserName="Lgosson", FirstName="Logan", SurName="Gosson"},
                new User{UserName="YogiBear", FirstName="Henry", SurName="WinkleStein"},
                new User{UserName="KillerKitty", FirstName="George", SurName="Diskair"},
                new User{UserName="Satchmo", FirstName="Joe", SurName="Fudgel"}
            };

            users.ForEach(s => context.Users.AddOrUpdate(s));
            context.SaveChanges();

            var albums = new List<Album>
            {
                new Album{Title="Our Love", Artist="Caribou", Release=2014, Genre="Electronic"},
                new Album{Title="Run the Jewels 2", Artist="Run the Jewels", Release=2014, Genre="Hip-Hop"},
                new Album{Title="Immunity", Artist="John Hopkins", Release=2013, Genre="Electronic"}
            };

            albums.ForEach(s => context.Albums.AddOrUpdate(s));
            context.SaveChanges();

            var reviews = new List<Review>
            {
                new Review{UserID=1, AlbumID=1, Rating=10, Comment="This should be on everyoness best of 2014 list."},
                new Review{UserID=2, AlbumID=1, Rating=9, Comment="Wooooooooo!"},
                new Review{UserID=3, AlbumID=1, Rating=7, Comment="Pretty Groovy"},
                new Review{UserID=4, AlbumID=1, Rating=10, Comment="Heres your trance now dance"},
                new Review{UserID=1, AlbumID=2, Rating=9, Comment="Aamzing"},
                new Review{UserID=2, AlbumID=2, Rating=8, Comment="Right on"},
                new Review{UserID=3, AlbumID=2, Rating=9, Comment="Ooodles of Noodles"},
                new Review{UserID=4, AlbumID=2, Rating=9, Comment="I think I'm in Love again"},
                new Review{UserID=1, AlbumID=3, Rating=8, Comment="This should be on everyoness best of 2013 list."},
                new Review{UserID=2, AlbumID=3, Rating=10, Comment="Such a trip"},
                new Review{UserID=3, AlbumID=3, Rating=9, Comment="You rock"},
                new Review{UserID=4, AlbumID=3, Rating=7, Comment="Weird but oddly satisfying"}
            };

            reviews.ForEach(s => context.Reviews.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}