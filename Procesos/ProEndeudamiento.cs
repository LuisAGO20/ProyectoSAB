using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System.Linq;


namespace Procesos
{
    public class ProEndeudamiento
    {
        public AprobacionBecaDB db { get; set; }
        public ProEndeudamiento(AprobacionBecaDB db)
        {
            this.db = db;
        }

        public bool Aprobo(Solicitud solicitud)
        {
            var tmpSolicitudes = db.Solicitudes
                    .Include(s => s.Pagos)
                        .ThenInclude(p=> p.SaldoTotal)
                    .Include(s => s.TiempoPago)
                    .Single(s => s.SolicitudId == solicitud.SolicitudId);
            ;

            // Si no tiene Ingreso de pagos, no aproba para el Crédito
            if (tmpSolicitudes.Pagos == null) return false;

            return false;
        }
    }
}
