using Microsoft.EntityFrameworkCore;

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
    }       
        
    
}   