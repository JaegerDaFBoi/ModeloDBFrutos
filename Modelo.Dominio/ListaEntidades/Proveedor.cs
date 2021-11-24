namespace Modelo.Dominio
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string NombreProveedor { get; set; }
        public int DocumentoProveedor { get; set; }
        public string Ciudad { get; set;}
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }   
    }
}