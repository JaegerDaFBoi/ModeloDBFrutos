using Microsoft.EntityFrameworkCore;
using Modelo.Dominio;

namespace Modelo.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Inventario> Articulos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set;}
        public DbSet<Administrador> Administradores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             if(!optionsBuilder.IsConfigured)
             {
                 optionsBuilder.UseSqlServer("Initial Catalog=DBFrutos; Data Source=DESKTOP-AO7R2KJ\\SQLEXPRESS; Integrated Security=true");
             }
        }
    }
}