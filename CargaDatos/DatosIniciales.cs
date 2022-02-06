using Modelo.Entidades;
using System;
using System.Collections.Generic;


namespace CargaDatos
{
    public class DatosIniciales
    {
        public enum ListasTipo
        {
            Configuracion, Ingresos, Instituciones, Ofertas,
            Preofertas, Reportes, Solicitudes, TablasPagos,
            Usuarios
        }

        public Dictionary<ListasTipo, object> Carga()
        {
            // --------------------------------------------
            // Lista de Personas
            // --------------------------------------------
            #region
            Usuario us1 = new Usuario()
            {
                Nombres = "Juan Carlos",
                Apellidos = "Lara Pesantez",
                Cedula = "1724219926",
                Ciudad = "Sangolqui Valle de los Chillos",
                FechaNacimiento = new DateTime(1971, 5, 18),
                Celular = "0986377625",
            };

            Usuario us2 = new Usuario()
            {
                Nombres = "Luis Felipe",
                Apellidos = "Carillo Lopez",
                Cedula = "17242178936",
                Ciudad = "El Tingo Valle de los Chillos",
                FechaNacimiento = new DateTime(1991, 5, 18),
                Celular = "0922277625"
            };

            Usuario us3 = new Usuario()
            {
                Nombres = "Carlos David",
                Apellidos = "Carillo Ayala",
                Cedula = "172098789",
                Ciudad = "Valle de los Chillos",
                FechaNacimiento = new DateTime(1996, 12, 18),
                Celular = "0922277625"
            };

            List<Usuario> listaUsuarios = new List<Usuario>()
            {
                us1,us2,us3
            };
            #endregion

            // --------------------------------------------
            // Lista de Ingresos
            // --------------------------------------------
            #region
            Ingresos Ingreso1 = new Ingresos()
            {
                Sueldo = 470,
                FechaIngreso = new DateTime(2022, 1, 31),
                AporteSeguro = 20,
                HorasExtra = 50,
                FondoReserva = 120,
                TotalIngresos = 620,
                Usuarios = us1
            };

            Ingresos Ingreso2 = new Ingresos()
            {
                Sueldo = 470,
                FechaIngreso = new DateTime(2022, 2, 01),
                AporteSeguro = 20,
                HorasExtra = 50,
                FondoReserva = 140,
                TotalIngresos = 640,
                Usuarios = us2
            };

            Ingresos Ingreso3 = new Ingresos()
            {
                Sueldo = 500,
                FechaIngreso = new DateTime(2022, 1, 31),
                AporteSeguro = 20,
                HorasExtra = 50,
                FondoReserva = 120,
                TotalIngresos = 650,
                Usuarios = us3
            };

            List<Ingresos> listaIngresos = new List<Ingresos>()
            {
                Ingreso1, Ingreso2, Ingreso3
            };
            #endregion

            // --------------------------------------------
            // Lista de Instituciones
            // --------------------------------------------
            #region
            Institucion Inst1 = new Institucion()
            {
                Nombre = "Universidad Regional Mexicana",
                Tipo = "Privada",
                Pais = "México",
                Email = "universidadregional@gmail.com"
            };

            Institucion Inst2 = new Institucion()
            {
                Nombre = "Universidad Estatal de Buenos Aires",
                Tipo = "Privada",
                Pais = "Argentina",
                Email = "universidadestatal@gmail.com"
            };

            Institucion Inst3 = new Institucion()
            {
                Nombre = "Universidad de Barcelona",
                Tipo = "Privada",
                Pais = "España",
                Email = "universidadbarcelona@gmail.com"
            };

            List<Institucion> listaInstituciones = new List<Institucion>()
            {
                Inst1, Inst2, Inst3
            };
            #endregion

            // --------------------------------------------
            // Lista de Ofertas
            // --------------------------------------------
            #region
            Oferta Ofe1 = new Oferta()
            {
                FechaInicio = new DateTime(2022, 6, 10),
                Carrera = "Magister en Finanzas",
                Costo = 10000,
                Duracion = "4 años",
                Modalidad = "Presencial",
            };

            Oferta Ofe2 = new Oferta()
            {
                FechaInicio = new DateTime(2022, 9, 11),
                Carrera = "Magister en Politica",
                Costo = 10000,
                Duracion = "3 años",
                Modalidad = "Presencial",
            };

            Oferta Ofe3 = new Oferta()
            {
                FechaInicio = new DateTime(2022, 10, 31),
                Carrera = "Magister en Ciencias",
                Costo = 10000,
                Duracion = "3 años",
                Modalidad = "Presencial",
            };

            Preoferta preoferta1 = new Preoferta()
            {
                Instituciones = Inst1,
                Ofertas = Ofe3
            };

            Preoferta preoferta2 = new Preoferta()
            {
                Instituciones = Inst3,
                Ofertas = Ofe1
            };

            List<Oferta> listaOfertas = new List<Oferta>()
            {
                Ofe1, Ofe2, Ofe3
            };
            #endregion

            // --------------------------------------------
            // Lista de Reporte
            // --------------------------------------------
            #region
            Reporte Repor1 = new Reporte()
            {
                Fecha = new DateTime(2022, 2, 10),
                Observacion = "Estado Pendiente",
                Estado = false
            };

            Reporte Repor2 = new Reporte()
            {
                Fecha = new DateTime(2022, 3, 10),
                Observacion = "Estado Pendiente",
                Estado = false
            };

            List<Reporte> listaReportes = new List<Reporte>()
            {
                Repor1, Repor2
            };
            #endregion

            // --------------------------------------------
            // Lista Tablas de Pagos
            // --------------------------------------------
            #region
            TablaPagos Pago1 = new TablaPagos()
            {
                Capital = 10000,
                Interes = 250,
                PlazoTiempo = 5,
                CuotaMensual = 350,
                SaldoTotal = 10500
            };

            TablaPagos Pago2 = new TablaPagos()
            {
                Capital = 5000,
                Interes = 250,
                PlazoTiempo = 5,
                CuotaMensual = 350,
                SaldoTotal = 5600
            };

            List<TablaPagos> listaTablasPagos = new List<TablaPagos>()
            {
                Pago1, Pago2
            };
            #endregion


            Configuracion config = new Configuracion()
            {
                NombreInstitucion = "A la que ha sido Aprobado",
                CreditoMaximo = 10000,
                CompromisoPago = "Obligatorio"
            };

            List<Configuracion> listaConfiguracion = new List<Configuracion>()
            {
                config
            };

            // --------------------------------------------
            // Lista de Solicitudes
            // --------------------------------------------
            #region
            Solicitud Sol1 = new Solicitud()
            {
                FechaSolicitud = new DateTime(2022, 2, 01),
                MontoTotal = 7000,
                TiempoPago = 72,
                CuotaMensual = 350
            };

            Solicitud Sol2 = new Solicitud()
            {
                FechaSolicitud = new DateTime(2022, 1, 29),
                MontoTotal = 8000,
                TiempoPago = 72,
                CuotaMensual = 300
            };

            Solicitud Sol3 = new Solicitud()
            {
                FechaSolicitud = new DateTime(2022, 1, 31),
                MontoTotal = 9000,
                TiempoPago = 48,
                CuotaMensual = 450
            };

            List<Solicitud> listaSolicitudes = new List<Solicitud>()
            {
                Sol1, Sol2
            };
            #endregion

            Dictionary<ListasTipo, object> dicListasDatos = new Dictionary<ListasTipo, object>()
            {
                { ListasTipo.Usuarios, listaUsuarios },
                { ListasTipo.Ingresos, listaIngresos },
                { ListasTipo.Instituciones, listaInstituciones },
                { ListasTipo.Ofertas,listaOfertas },
                { ListasTipo.Solicitudes, listaSolicitudes },
                { ListasTipo.Reportes, listaReportes},
                { ListasTipo.TablasPagos, listaTablasPagos},
                { ListasTipo.Configuracion, listaConfiguracion}
            };
            return dicListasDatos;
        }
    }
}
