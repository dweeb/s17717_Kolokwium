using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class Artist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdArtist { get; set; }
        [Required]
        [MaxLength(30)]
        public string Nickname { get; set; }
        [JsonIgnore]
        public virtual ICollection<Artist_Event> Artist_Events { get; set; }
    }
}
