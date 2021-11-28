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
                 optionsBuilder.UseSqlServer("Initial Catalog=DataBaseFrutos; Data Source=DESKTOP-0LQEFDS\\SQLEXPRESS; Integrated Security=true");
             }
        }
    }
}