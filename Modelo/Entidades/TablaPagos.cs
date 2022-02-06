using System;
using System.Collections.Generic;


namespace Modelo.Entidades
{
    public class TablaPagos
    {
        public int TablaPagosId { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public int PlazoTiempo { get; set; }
        public decimal CuotaMensual { get; set; }
        public decimal SaldoTotal { get; set; }

        // RELACION CON SOLICITUD 1:N
        public int SolicitudId { get; set; }
        public Solicitud Solicitudes { get; set; }
    }
}
