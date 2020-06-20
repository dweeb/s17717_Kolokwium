using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.DTOs.Requests
{
    public class ChangePerformanceTimeRequest
    {
        [Required]
        public int IdArtist { get; set; }
        [Required]
        public int IdEvent { get; set; }
        [Required]
        public DateTime PerformanceDate { get; set; }
    }
}
