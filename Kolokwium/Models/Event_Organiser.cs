using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class Event_Organiser
    {
        public int IdEvent { get; set; }
        public int IdOrganiser { get; set; }
        [JsonIgnore]
        [ForeignKey("IdEvent")]
        public virtual Event Event { get; set; }
        [JsonIgnore]
        [ForeignKey("IdOrganiser")]
        public virtual Organiser Organiser { get; set; }
    }
}
