using MyMusic.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Core.Services
{
    public interface IArtistService
    {
        Task<IEnumerable<Artiste>> GetAllArtist();
        Task<Artiste> GetArtisteById(int id);
        Task<Artiste> CreateArtist(Artiste newArtiste);
        Task UpdateArtist(Artiste artisteupdated, Artiste artiste);
        Task DeleteArtist(Artiste artiste);
    }
}
