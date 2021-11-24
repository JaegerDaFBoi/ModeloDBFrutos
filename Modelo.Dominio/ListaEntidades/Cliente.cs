namespace Modelo.Dominio
{
    public class Cliente //Relaciona a clase Factura. Relacion de 1 a Muchos 
    {
        public string Id { get; set; }
        public TipoCliente tipoCliente { get; set; }
        public string Nombre { get; set; }
        public int Documento { get; set; }
        public string Ciudad { get; set;}
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }  
    }
}