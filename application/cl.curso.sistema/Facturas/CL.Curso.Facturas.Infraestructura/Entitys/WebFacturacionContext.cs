using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CL.Curso.Facturas.Infraestructure.Entitys
{
    public partial class WebFacturacionContext : DbContext
    {
        public WebFacturacionContext()
        {
        }

        public WebFacturacionContext(DbContextOptions<WebFacturacionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DetalleDte> DetalleDtes { get; set; }
        public virtual DbSet<DocumentoElectronico> DocumentoElectronicos { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=WebFacturacion;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("Cliente");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Rut)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetalleDte>(entity =>
            {
                entity.HasKey(e => e.IdDetalle);

                entity.ToTable("DetalleDTE");

                entity.HasOne(d => d.IdDocTributarioNavigation)
                    .WithMany(p => p.DetalleDtes)
                    .HasForeignKey(d => d.IdDocTributario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleDTE_DocumentoElectronico");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DetalleDtes)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_DetalleDTE_Producto");
            });

            modelBuilder.Entity<DocumentoElectronico>(entity =>
            {
                entity.ToTable("DocumentoElectronico");

                entity.Property(e => e.Impuesto).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.DocumentoElectronicos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_DocumentoElectronico_Cliente");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.DocumentoElectronicos)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .HasConstraintName("FK_DocumentoElectronico_TipoDocumento");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.ToTable("Producto");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.ToTable("TipoDocumento");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
