using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;
using System.Linq;

namespace WebAppSAB.Controllers
{
    public class IngresosController : Controller
    {
        readonly AprobacionBecaDB db;

        public IngresosController(AprobacionBecaDB db)
        {
            this.db = db;
        }

        // Obtiene la lista de Ingresos 
        public IActionResult Index()
        {
            IEnumerable<Ingresos> listaIngresos =
                db.Ingresos
                    .Include(ingresos => ingresos.Usuarios);

            return View(listaIngresos);
        }

        //  Presenta el formulario vacio listo para crearlo
        [HttpGet]
        public IActionResult Create()
        {
            // Lista de Usuarios
            var listaUsuarios = db.Usuarios
                .Select(usuario => new
                {
                    UsuarioId = usuario.UsuarioId,
                    Apellidos = usuario.Apellidos
                }).ToList();

            // Prepara las listas
            var selectListaUsuarios = new SelectList(listaUsuarios, "UsuarioId", "Apellidos");

            // Ingreso a ViewBag
            ViewBag.selectListUsuarios = selectListaUsuarios;

            return View();
        }

        //  Guardar Ingresos
        [HttpPost]
        public IActionResult Create(Ingresos ingresos)
        {
            db.Ingresos.Add(ingresos);
            db.SaveChanges();

            TempData["mensaje"] = $"Nuevo Ingreso creado correctamente";

            return RedirectToAction("Index");
        }

        // Edición de Datos
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Consulta al ingreso por medio del Id
            Ingresos ingresos = db.Ingresos.Find(id);
            // Lista de Usuarios
            var listaUsuarios = db.Usuarios
                .Select(usuario => new
                {
                    UsuarioId = usuario.UsuarioId,
                    Apellidos = usuario.Apellidos
                }).ToList();

            // Prepara las listas
            var selectListaUsuarios = new SelectList(listaUsuarios, "UsuarioId", "Apellidos");

            // Ingreso a ViewBag
            ViewBag.selectListUsuarios = selectListaUsuarios;
            return View(ingresos);
        }

        // Actualiza el registro de los Ingresos
        [HttpPost]
        public IActionResult Edit(Ingresos ingresos)
        {
            // Grabar Datos
            db.Ingresos.Update(ingresos);
            db.SaveChanges();

            TempData["mensaje"] = $"Los datos se actualizaron exitosamente";

            return RedirectToAction("Index");
        }

        // Borrado de Registros de Ingresos
        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Consulta al ingreso por medio del Id
            Ingresos ingresos = db.Ingresos.Find(id);
            // Lista de Usuarios
            var listaUsuarios = db.Usuarios
                .Select(usuario => new
                {
                    UsuarioId = usuario.UsuarioId,
                    Apellidos = usuario.Apellidos
                }).ToList();

            // Prepara las listas
            var selectListaUsuarios = new SelectList(listaUsuarios, "UsuarioId", "Apellidos");

            // Ingreso a ViewBag
            ViewBag.selectListUsuarios = selectListaUsuarios;
            return View(ingresos);
        }

        // Elimina el Registro
        [HttpPost]
        public IActionResult Delete(Ingresos ingresos)
        {

            db.Ingresos.Remove(ingresos);
            db.SaveChanges();

            TempData["mensaje"] = $"El Registro de Ingresos ha sido Eliminado";

            return RedirectToAction("Index");
        }
    }
}
