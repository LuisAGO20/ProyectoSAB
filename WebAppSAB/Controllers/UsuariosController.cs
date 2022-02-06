using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;

namespace WebAppSAB.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AprobacionBecaDB db;
        public UsuariosController(AprobacionBecaDB db)
        {
            this.db = db;
        }

        //Listar Usuarios
        public IActionResult Index()
        {
            IEnumerable<Usuario> listaUsuarios = db.Usuarios;
            return View(listaUsuarios);
        }

        // Creación de Usuarios__________________________________
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            // Grabar al usuario
            db.Usuarios.Add(usuario);
            db.SaveChanges();

            TempData["mensaje"] = $"El usuario {usuario.Nombres} {usuario.Apellidos} ha sido creado exitosamente";

            return RedirectToAction("Index");
        }

        // Para la Edición_________________________________________________________
        // Edicion de los Registros del Usuario__________________________________

        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Consulta al usuario por medio del Id
            Usuario usuario = db.Usuarios.Find(id);
            return View(usuario);
        }

        // Actualiza un registro del usuario
        [HttpPost]
        public IActionResult Edit(Usuario usuario)
        {
            // Grabar al usuario
            db.Usuarios.Update(usuario);
            db.SaveChanges();

            TempData["mensaje"] = $"El usuario {usuario.Nombres} {usuario.Apellidos} ha sido actualizado exitosamente";

            return RedirectToAction("Index");
        }

        // Boorado de Datos_________________________________________________________
        // Borrar de los Registros de la Persona--__________________________________

        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Consulta al usuario por medio del Id
            Usuario usuario = db.Usuarios.Find(id);
            return View(usuario);
        }

        // Elimina un registro de un usuario
        [HttpPost]
        public IActionResult Delete(Usuario usuario)
        {
            // Grabar la persona
            db.Usuarios.Remove(usuario);
            db.SaveChanges();

            TempData["mensaje"] = $"El usuario {usuario.Nombres} {usuario.Apellidos} ha sido eliminado";

            return RedirectToAction("Index");
        }
    }
}
