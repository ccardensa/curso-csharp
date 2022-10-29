using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.CodeFirstEF
{
    public class DbContextTributario : DbContext
    {
        public DbContextTributario(DbContextOptions<DbContextTributario> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        //{
        //    optionsBuilder.UseSqlServer(@"Server=.\\SQLExpress;Database=FacturacionCF;Trusted_Connection=True;");
        //}


        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
        public DbSet<DocumentoTributario> DocumentoTributarios { get; set; }
        public DbSet<ListaPrecio> ListaPrecios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<TipoDocumento> TipoDocumentos { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Cliente>()
                .HasData(
                    new Cliente()
                    {
                        IdCliente = 1,
                        Nombre = "Cliente Uno",
                        Rut = "1-1"
                    },
                    new Cliente()
                    {
                        IdCliente = 2,
                        Nombre = "Cliente Dos",
                        Rut = "2-2"
                    },
                    new Cliente()
                    {
                        IdCliente = 3,
                        Nombre = "Cliente Tres",
                        Rut = "3-3"
                    }
                );
        }
    }
}
