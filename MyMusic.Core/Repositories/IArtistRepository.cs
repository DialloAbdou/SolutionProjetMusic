using MyMusic.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Core.Repositories
{
    public interface IArtistRepository : IRepository<Artiste>
    {
        Task<IEnumerable<Artiste>> GetAllWithMusicsAsync();
        Task<Artiste> GetAllWithMusicsByIdAsync(int id);

    }
}
