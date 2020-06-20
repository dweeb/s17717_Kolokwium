using Kolokwium.DTOs.Requests;
using Kolokwium.DTOs.Responses;
using Kolokwium.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Services
{
    public class EfArtistsDbService : IArtistsDbService
    {
        private readonly ArtistDbContext _context;
        public EfArtistsDbService(ArtistDbContext context)
        {
            _context = context;
        }
        public bool ChangePerformanceDate(ChangePerformanceTimeRequest req)
        {
            throw new NotImplementedException();
        }

        public ArtistResponse GetArtist(int id)
        {
            var artist = _context.Artists.Where(a => a.IdArtist == id).FirstOrDefault();
            if (artist == null)
                return null;
            var events = (from e in _context.Events
                          join ae in _context.Artist_Events on e.IdEvent equals ae.IdEvent
                          where ae.IdArtist == artist.IdArtist
                          select e).ToList();
            var res = new ArtistResponse
            {
                Artist = artist,
                Events = events
            };
            return res;
        }
    }
}
