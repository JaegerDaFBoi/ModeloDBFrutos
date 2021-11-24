using System;
using System.Collections.Generic;

namespace Modelo.Dominio
{
    public class Factura //Relaciona a clase Compra. Relacion de 1 a muchos
    {
        public int Id { get; set; }
        public Cliente IdCliente { get; set; }
        public DateTime Fecha { get; set; }

    }
}