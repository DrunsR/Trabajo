using Microsoft.EntityFrameworkCore;
using Trabajo.Models;

namespace Trabajo.Models
{
    public class ReadyToEatContext : DbContext
    {
        
        public ReadyToEatContext(DbContextOptions<ReadyToEatContext> options)
        : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurante>().HasData(

            );
        }

        public DbSet<Restaurante> Restaurante { get; set; }
        public DbSet<InicioR> InicioR { get; set; }
        public DbSet<Platillo> Platillo{get;set;}
        public DbSet<Sugerencia> Sugerencia {get;set;}
    }       
        
    
}   