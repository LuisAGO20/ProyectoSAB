using CargaDatos;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;
using static CargaDatos.DatosIniciales;

namespace Consola
{
    public class Grabar
    {
        public void DatosIni()
        {
            DatosIniciales datos = new DatosIniciales();
            var listas = datos.Carga();

            // Extraer del diccionario las listas
            var listaConfiguracion = (List<Configuracion>)listas[ListasTipo.Configuracion];
            var listaIngresos = (List<Ingresos>)listas[ListasTipo.Ingresos];
            var listaInstituciones = (List<Institucion>)listas[ListasTipo.Instituciones];
            var listaOfertas = (List<Oferta>)listas[ListasTipo.Ofertas];
            var listaReportes = (List<Reporte>)listas[ListasTipo.Reportes];
            var listaSolicitudes = (List<Solicitud>)listas[ListasTipo.Solicitudes];
            var listaUsuarios = (List<Usuario>)listas[ListasTipo.Usuarios];


            // Grabar
            using (AprobacionBecaDB db = AprobacionBecaDBBuilder.Crear())
            {
                // Se asegura que se borre y vuelva a crear la base de datos
                db.PreparaDB();
                // Agrega los listados
                db.Configuraciones.AddRange(listaConfiguracion);
                db.Ingresos.AddRange(listaIngresos);
                db.Instituciones.AddRange(listaInstituciones);
                db.Ofertas.AddRange(listaOfertas);
                db.Reportes.AddRange(listaReportes);
                db.Solicitudes.AddRange(listaSolicitudes);
                db.Usuarios.AddRange(listaUsuarios);

                db.SaveChanges();
            }
        }
    }
}
