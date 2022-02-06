using System;
using System.Collections.Generic;


namespace Modelo.Entidades
{
    public class Reporte
    {
        public int ReporteId { get; set; }
        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public Boolean Estado { get; set; }

        // RELACION CON SOLICITUD 1:N
        public ICollection<Solicitud> Solicitudes { get; set; }
    }
}
