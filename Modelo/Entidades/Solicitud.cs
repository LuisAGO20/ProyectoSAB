using System;
using System.Collections.Generic;


namespace Modelo.Entidades
{
    public enum SolicitudEstado { Pendiente, Aprobada, Rechazada, Anulada }
    public class Solicitud
    {
        public int SolicitudId { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public decimal MontoTotal { get; set; }
        public int TiempoPago { get; set; }
        public decimal CuotaMensual { get; set; }
        public SolicitudEstado Estado { get; set; }

        // RELACION CON USUARIO 1:N
        public int UsuarioId { get; set; }
        public Usuario Usuarios { get; set; }

        // RELACION CON REPORTE 1:N
        public int ReporteId { get; set; }
        public Reporte Reportes { get; set; }

        // RELACION CON TABLA PAGOS 1:N
        public ICollection<TablaPagos> Pagos { get; set; }
    }
}
