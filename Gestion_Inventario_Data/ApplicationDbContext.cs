using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Inventario_Repository
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Articulo> Articulos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Repository Source=localhost;Initial Catalog=gestioninventariodb;Persist Security Info=True;User ID=sa;Password=sa");
                optionsBuilder.UseSqlServer("Data Source=localhost;Database=gestioninventariodb;Integrated Security=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("Id");

                entity.Property(e => e.Codigo).HasColumnName("Codigo");

                entity.Property(e => e.Nombre).HasColumnName("Nombre");


                entity.Property(e => e.Descripcion)
                    .HasColumnName("Descripcion");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("Cantidad");
            });
        }
    }
}
