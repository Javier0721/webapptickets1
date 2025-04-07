using Microsoft.EntityFrameworkCore;
using WebAPITickets.Models;
using wWebAPITickets.Models;

namespace WebAPITickets.Database
{
    public class ContextoDB : DbContext
    {
        private DbSet<Tiquetes> tiquetes;

        public ContextoDB(DbContextOptions<ContextoDB> options) : base(options)
        {

        }

        public DbSet<Roles> Roles { get; set; }
        public DbSet<Tiquetes> Tiquetes { get => tiquetes; set => tiquetes = value; }
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Roles>().HasKey(x => x.ro_identificador);
            modelBuilder.Entity<Tiquetes>().HasKey(x => x.ti_identificador);
            modelBuilder.Entity<Usuarios>().HasKey(x => x.us_identificador);
        }
       
    }
}
