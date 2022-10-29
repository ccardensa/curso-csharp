using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CL.Curso.Productos.Infraestructure
{
    public partial class FacturacionCFContext : DbContext
    {
        public FacturacionCFContext()
        {
        }

        public FacturacionCFContext(DbContextOptions<FacturacionCFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ListaPrecio> ListaPrecios { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLExpress;Initial Catalog=FacturacionCF;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ListaPrecio>(entity =>
            {
                entity.HasKey(e => e.IdListaPrecio);

                entity.ToTable("ListaPrecios", "Producto");

                entity.HasIndex(e => e.IdProducto, "IX_ListaPrecios_IdProducto");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.ListaPrecios)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListaPrecios_Productos");
                    
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.ToTable("Productos", "Producto");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
