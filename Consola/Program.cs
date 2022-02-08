using System;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grabar grabar = new Grabar();
            grabar.DatosIni();

            using (var db = AprobacionBecaDBBuilder.Crear())
            {
                var listaUsuarios = db.Usuarios;

                Console.WriteLine("Listado de Usuarios");
                foreach (var usuario in listaUsuarios)
                {
                    Console.WriteLine(
                        usuario.Nombres + " " +
                        usuario.Apellidos + " " +
                        usuario.Cedula + " " +
                        usuario.Ciudad + " " +
                        usuario.FechaNacimiento + " " +
                        usuario.Celular
                    );
                }
            }
        }
    }
}
