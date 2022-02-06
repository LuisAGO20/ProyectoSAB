using System;
using System.Collections.Generic;


namespace Modelo.Entidades
{
    public class Ingresos
    {
        public int IngresosId { get; set; }
        public decimal Sueldo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal AporteSeguro { get; set; }
        public decimal HorasExtra { get; set; }
        public decimal FondoReserva { get; set; }
        public decimal TotalIngresos { get; set; }

        // RELACION CON LA CLASE USUARIOS 1:1
        public int UsuarioId { get; set; }
        public Usuario Usuarios { get; set; }
    }
}
