using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class Artist_Event
    {
        public int IdEvent { get; set; }
        public int IdArtist { get; set; }
        [Required]
        public DateTime PerformanceDate { get; set; }
        [JsonIgnore]
        [ForeignKey("IdEvent")]
        public virtual Event Event { get; set; }
        [JsonIgnore]
        [ForeignKey("IdArtist")]
        public virtual Artist Artist { get; set; }
    }
}
