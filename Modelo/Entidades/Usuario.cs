using System;
using System.Collections.Generic;


namespace Modelo.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Celular { get; set; }

        // RELACION CON INGRESOS 1:1
        public Ingresos ResumenIngresos { get; set; }

        // RELACION CON EGRESOS 1:1
        public Egresos ResumenEgresos { get; set; }

        // RELACION CON SOLICITUD 1:N
        public ICollection<Solicitud> Solicitudes { get; set; }
    }
}
