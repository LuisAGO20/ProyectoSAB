using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModeloDB;
using System.Linq;

namespace WebAppSAB.Controllers
{
    public class SolicitudesController : Controller
    {
        // DbContext
        private readonly AprobacionBecaDB db;

        public SolicitudesController(AprobacionBecaDB db)
        {
            this.db = db;
        }

        // Listado de Solicitudes
        public IActionResult Index()
        {
            var listaSolicitudes = db.Solicitudes
                .Include(solicitud => solicitud.Usuarios)
                .Include(solicitud => solicitud.Reportes)
                ;

            return View(listaSolicitudes);
        }

        // Pantalla para la validación de la matrícula
        public IActionResult Validar(int id)
        {
            var solicitud = db.Solicitudes
                .Include(solicitud => solicitud.Usuarios)
                    .ThenInclude(usuario => usuario.Apellidos)
                .Include(solicitud => solicitud.Reportes)
                    .ThenInclude(reportes => reportes.Observacion)
                .Include(solicitud => solicitud.Pagos)
                    .ThenInclude(pagos => pagos.Capital)
                .Include(solicitud => solicitud.Pagos)
                    .ThenInclude(pagos => pagos.SaldoTotal)
                .Single(solicitud => solicitud.SolicitudId == id)
                ;
            /*
            // Preparar la clase para el cálculo de las calificaciones
            var configuracion = db.configuracion.Single();
            CalcCalificaciones calcCalificaciones = new CalcCalificaciones(configuracion);

            ViewBag.CalcCalificaciones = calcCalificaciones;
            */
            return View(solicitud);
        }
    }
}
