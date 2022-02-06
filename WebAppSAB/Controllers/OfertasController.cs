using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;

namespace WebAppSAB.Controllers
{
    public class OfertasController : Controller
    {
        private readonly AprobacionBecaDB db;
        public OfertasController(AprobacionBecaDB db)
        {
            this.db = db;
        }

        // Listar Ofertas
        public IActionResult Index()
        {
            IEnumerable<Oferta> listaOfertas = db.Ofertas;
            return View(listaOfertas);
        }


        // Creación de las ofertas
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Oferta oferta)
        {
            // Grabar las Ofertas
            db.Ofertas.Add(oferta);
            db.SaveChanges();

            TempData["mensaje"] = $"La carrera ofertada {oferta.Carrera} ha sido creada exitosamente";

            return RedirectToAction("Index");
        }


        // Edicion de las Carreras Ofertadas
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Consulta a las ofertas por medio del Id
            Oferta oferta = db.Ofertas.Find(id);
            return View(oferta);
        }

        // Actualiza las ofertas
        [HttpPost]
        public IActionResult Edit(Oferta oferta)
        {
            // Grabar la Oferta
            db.Ofertas.Update(oferta);
            db.SaveChanges();

            TempData["mensaje"] = $"La carrera ofertada {oferta.Carrera} ha sido actualizada exitosamente";

            return RedirectToAction("Index");
        }


        // Borrado de las Ofertas
        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Consulta a las Ofertas por medio del Id
            Oferta oferta = db.Ofertas.Find(id);
            return View(oferta);
        }

        // Elimina una Oferta
        [HttpPost]
        public IActionResult Delete(Oferta oferta)
        {
            db.Ofertas.Remove(oferta);
            db.SaveChanges();

            TempData["mensaje"] = $"La carrera ofertada {oferta.Carrera} ha sido eliminada";

            return RedirectToAction("Index");
        }
    }
}
