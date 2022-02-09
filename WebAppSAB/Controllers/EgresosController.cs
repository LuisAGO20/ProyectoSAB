using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;
using System.Linq;

namespace WebAppSAB.Controllers
{
    public class EgresosController : Controller
    {
        readonly AprobacionBecaDB db;

        public EgresosController(AprobacionBecaDB db)
        {
            this.db = db;
        }

        // Obtiene la lista de Egresos 
        public IActionResult Index()
        {
            IEnumerable<Egresos> listaEgresos =
                db.Egresos
                    .Include(egresos => egresos.Usuarios);

            return View(listaEgresos);
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
                    Apellidos = usuario.Apellidos,
                    Nombres = usuario.Nombres
                }).ToList();

            // Prepara las listas
            var selectListaUsuarios = new SelectList(listaUsuarios, "UsuarioId", "Apellidos", "Nombres");

            // Ingreso a ViewBag
            ViewBag.selectListUsuarios = selectListaUsuarios;

            return View();
        }

        //  Guardar Ingresos
        [HttpPost]
        public IActionResult Create(Egresos egresos)
        {
            db.Egresos.Add(egresos);
            db.SaveChanges();

            TempData["mensaje"] = $"Nuevo Egreso creado correctamente";

            return RedirectToAction("Index");
        }


        // Edición de Datos
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Consulta al ingreso por medio del Id
            Egresos egresos = db.Egresos.Find(id);
            // Lista de Usuarios
            var listaUsuarios = db.Usuarios
                .Select(usuario => new
                {
                    UsuarioId = usuario.UsuarioId,
                    Apellidos = usuario.Apellidos,
                    Nombres = usuario.Nombres
                }).ToList();

            // Prepara las listas
            var selectListaUsuarios = new SelectList(listaUsuarios, "UsuarioId", "Apellidos", "Nombres");

            // Ingreso a ViewBag
            ViewBag.selectListUsuarios = selectListaUsuarios;
            return View(egresos);
        }

        // Actualiza el registro de los Ingresos
        [HttpPost]
        public IActionResult Edit(Egresos egresos)
        {
            // Grabar Datos
            db.Egresos.Update(egresos);
            db.SaveChanges();

            TempData["mensaje"] = $"Los datos se actualizaron exitosamente";

            return RedirectToAction("Index");
        }

        // Borrado de Registros de Ingresos
        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Consulta al ingreso por medio del Id
            Egresos egresos = db.Egresos.Find(id);
            // Lista de Usuarios
            var listaUsuarios = db.Usuarios
                .Select(usuario => new
                {
                    UsuarioId = usuario.UsuarioId,
                    Apellidos = usuario.Apellidos,
                    Nombres = usuario.Nombres
                }).ToList();

            // Prepara las listas
            var selectListaUsuarios = new SelectList(listaUsuarios, "UsuarioId", "Apellidos", "Nombres");


            // Ingreso a ViewBag
            ViewBag.selectListUsuarios = selectListaUsuarios;
            return View(egresos);
        }

        // Elimina el Registro
        [HttpPost]
        public IActionResult Delete(Egresos egresos)
        {

            db.Egresos.Remove(egresos);
            db.SaveChanges();

            TempData["mensaje"] = $"El Registro de Ingresos ha sido Eliminado";

            return RedirectToAction("Index");
        }
    }
}
