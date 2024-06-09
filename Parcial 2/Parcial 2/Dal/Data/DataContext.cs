using Microsoft.EntityFrameworkCore;
using Parcial_2.Dal.Data.DataSeed;
using Parcial_2.Dal.Entities;

namespace Parcial_2.Dal.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cancion>()
                .HasOne(c => c.Disco)
                .WithMany(d => d.Canciones)
                .HasForeignKey(c => c.DiscoId);

            modelBuilder.ApplyConfiguration(new CancionSeed());
            modelBuilder.ApplyConfiguration(new DiscoSeed());
            modelBuilder.ApplyConfiguration(new UsuarioSeed());
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Cancion> Canciones { get; set; }
        public virtual DbSet<Disco> Discos { get; set; }
    }
}
