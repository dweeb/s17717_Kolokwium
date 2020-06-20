using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class ArtistDbContext : DbContext
    {
        public ArtistDbContext() { }
        public ArtistDbContext(DbContextOptions opts)
            : base(opts) { }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Organiser> Organisers { get; set; }
        public DbSet<Event_Organiser> Event_Organisers { get; set; }
        public DbSet<Artist_Event> Artist_Events { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);
            mb.Entity<Artist_Event>().HasKey(ae => new { ae.IdArtist, ae.IdEvent });
            mb.Entity<Event_Organiser>().HasKey(eo => new { eo.IdEvent, eo.IdOrganiser });
        }
    }
}
