using Kolokwium.DTOs.Requests;
using Kolokwium.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Services
{
    public interface IArtistsDbService
    {
        public ArtistResponse GetArtist(int id);
        public bool ChangePerformanceDate(ChangePerformanceTimeRequest req);
    }
}
