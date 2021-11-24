namespace Modelo.Dominio
{
    public class Inventario //Relaciona a compra. Relacion 1 a muchos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float PrecioCompra { get; set; }
        public string Peso { get; set; }
        public string Marca { get; set; }
        public float PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public Proveedor IdProveedor { get; set; }
        public Administrador IdAdministrador { get; set; }
    }
}