using Kolokwium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.DTOs.Responses
{
    public class ArtistResponse
    {
        public Artist Artist { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
