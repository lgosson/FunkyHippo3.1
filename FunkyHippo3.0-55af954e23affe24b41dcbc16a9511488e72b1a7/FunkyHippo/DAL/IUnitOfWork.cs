using FunkyHippo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyHippo.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IFunkyHippoRepo<Album> AlbumRepo { get; }
        IFunkyHippoRepo<User> UserRepo { get; }
        IFunkyHippoRepo<Review> ReviewRepo { get; }
        void Save();
    }
}
