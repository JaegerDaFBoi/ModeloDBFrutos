namespace Modelo.Dominio
{
    public class Administrador
    {
        public int Id { get; set; }
        public string NombreAdmin { get; set; }
        public int DocumentoAdmin { get; set; }
        public string Ciudad { get; set;}
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; } 
    }
}