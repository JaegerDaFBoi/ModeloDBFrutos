namespace Modelo.Dominio
{
    public class Compra 
    {
        public int Id { get; set; }
        public Inventario Producto { get; set; }
        public Factura IdFactura { get; set; }
        public int CantidadPedido { get; set; }
        public float Precio { get; set; }
    }
}