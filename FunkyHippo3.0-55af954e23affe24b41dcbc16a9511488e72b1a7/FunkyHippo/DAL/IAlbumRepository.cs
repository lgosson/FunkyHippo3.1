using FunkyHippo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyHippo.DAL
{
    public interface IAlbumRepository : IDisposable
    {
        IEnumerable<Album> GetAlbums();
        Album GetAlbumByID(int albumID);
        void InsertAlbum(Album album);
        void DeleteAlbum(int albumID);
        void UpdateAlbum(Album album);
        void Save();
    }
}
