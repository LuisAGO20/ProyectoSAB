using Modelo.Entidades;
using System;
using System.Collections.Generic;


namespace CargaDatos
{
    public class DatosIniciales
    {
        public enum ListasTipo
        {
            Configuracion, Ingresos, Egresos, Instituciones, Ofertas,
            Preofertas, Reportes, Solicitudes, TablasPagos,
            Usuarios
        }

        public Dictionary<ListasTipo, object> Carga()
        {
            // Configuración Aprobacion Becas

            Configuracion config = new Configuracion()
            {
                NombreInstitucion = "Postulada por el Usuario",
                CreditoMaximo = 10000,
                CompromisoPago = "Obligatorio"
            };

            List<Configuracion> listaConfiguracion = new List<Configuracion>()
            {
                config
            };

            // --------------------------------------------
            // Lista de Personas
            // --------------------------------------------
            #region
            Usuario usuario1 = new Usuario()
            {
                Nombres = "Juan Carlos",
                Apellidos = "Lara Pesantez",
                Cedula = "1724219926",
                Ciudad = "Sangolqui",
                FechaNacimiento = new DateTime(1971, 5, 18),
                Celular = "0986377625",
            };

            Usuario usuario2 = new Usuario()
            {
                Nombres = "Luis Felipe",
                Apellidos = "Carillo Lopez",
                Cedula = "17242178936",
                Ciudad = "El Tingo",
                FechaNacimiento = new DateTime(1991, 2, 18),
                Celular = "0922277625"
            };

            Usuario usuario3 = new Usuario()
            {
                Nombres = "Carlos David",
                Apellidos = "Carillo Ayala",
                Cedula = "172098789",
                Ciudad = "La Armenia",
                FechaNacimiento = new DateTime(1996, 12, 18),
                Celular = "0922277625"
            };

            Usuario usuario4 = new Usuario()
            {
                Nombres = "Hambar Nicole",
                Apellidos = "Ordoñez Noroña",
                Cedula = "1751798750",
                Ciudad = "Sangolqui La Florida",
                FechaNacimiento = new DateTime(2001, 6, 26),
                Celular = "0922277625"
            };

            List<Usuario> listaUsuarios = new List<Usuario>()
            {
                usuario1,usuario2,usuario3,usuario4
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
                Usuarios = usuario1
            };

            Ingresos Ingreso2 = new Ingresos()
            {
                Sueldo = 470,
                FechaIngreso = new DateTime(2022, 2, 01),
                AporteSeguro = 20,
                HorasExtra = 50,
                FondoReserva = 140,
                TotalIngresos = 640,
                Usuarios = usuario2
            };

            Ingresos Ingreso3 = new Ingresos()
            {
                Sueldo = 500,
                FechaIngreso = new DateTime(2022, 1, 31),
                AporteSeguro = 20,
                HorasExtra = 50,
                FondoReserva = 120,
                TotalIngresos = 650,
                Usuarios = usuario3
            };

            Ingresos Ingreso4 = new Ingresos()
            {
                Sueldo = 700,
                FechaIngreso = new DateTime(2022, 2, 4),
                AporteSeguro = 40,
                HorasExtra = 70,
                FondoReserva = 130,
                TotalIngresos = 860,
                Usuarios = usuario4
            };

            List<Ingresos> listaIngresos = new List<Ingresos>()
            {
                Ingreso1, Ingreso2, Ingreso3, Ingreso4
            };
            #endregion

            // --------------------------------------------
            // Lista de Egresos
            // --------------------------------------------
            #region
            Egresos Egreso1 = new Egresos()
            {
                Luz = 100,
                Agua = 50,
                Telefono = 20,
                Internet = 45,
                TotalEgresos = 215,
                Usuarios = usuario1
            };

            Egresos Egreso2 = new Egresos()
            {
                Luz = 80,
                Agua = 60,
                Telefono = 30,
                Internet = 55,
                TotalEgresos = 225,
                Usuarios = usuario2
            };

            Egresos Egreso3 = new Egresos()
            {
                Luz = 150,
                Agua = 70,
                Telefono = 25,
                Internet = 60,
                TotalEgresos = 305,
                Usuarios = usuario3
            };

            Egresos Egreso4 = new Egresos()
            {
                Luz = 100,
                Agua = 30,
                Telefono = 10,
                Internet = 65,
                TotalEgresos = 205,
                Usuarios = usuario4
            };


            List<Egresos> listaEgresos = new List<Egresos>()
            {
                Egreso1, Egreso2, Egreso3, Egreso4
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

            Institucion Inst4 = new Institucion()
            {
                Nombre = "Universidad de California",
                Tipo = "Privada",
                Pais = "Estados Unidos",
                Email = "uecalifornia@gmail.com"
            };

            List<Institucion> listaInstituciones = new List<Institucion>()
            {
                Inst1, Inst2, Inst3, Inst4
            };
            #endregion

            // --------------------------------------------
            // Lista de Ofertas
            // --------------------------------------------
            #region
            Oferta Oferta1 = new Oferta()
            {
                FechaInicio = new DateTime(2022, 6, 10),
                Carrera = "Magister en Finanzas",
                Costo = 10000,
                Duracion = "4 años",
                Modalidad = ModalidadOferta.Presencial
            };

            Oferta Oferta2 = new Oferta()
            {
                FechaInicio = new DateTime(2022, 9, 11),
                Carrera = "Magister en Politica",
                Costo = 10000,
                Duracion = "3 años",
                Modalidad = ModalidadOferta.Presencial
            };

            Oferta Oferta3 = new Oferta()
            {
                FechaInicio = new DateTime(2022, 10, 31),
                Carrera = "Magister en Ciencias",
                Costo = 10000,
                Duracion = "3 años",
                Modalidad = ModalidadOferta.Presencial
            };

            Oferta Oferta4 = new Oferta()
            {
                FechaInicio = new DateTime(2022, 9, 14),
                Carrera = "Postgrado en Seguridad Informatica",
                Costo = 10000,
                Duracion = "3 años",
                Modalidad = ModalidadOferta.Presencial
            };

            Preoferta preoferta1 = new Preoferta()
            {
                Instituciones = Inst3,
                Ofertas = Oferta4
            };

            Preoferta preoferta2 = new Preoferta()
            {
                Instituciones = Inst1,
                Ofertas = Oferta3
            };

            Preoferta preoferta3 = new Preoferta()
            {
                Instituciones = Inst4,
                Ofertas = Oferta2
            };

            Preoferta preoferta4 = new Preoferta()
            {
                Instituciones = Inst2,
                Ofertas = Oferta1
            };

            List<Oferta> listaOfertas = new List<Oferta>()
            {
                Oferta1, Oferta2, Oferta3, Oferta4
            };

            List<Preoferta> listaPreofertas = new List<Preoferta>()
            {
                preoferta1, preoferta2, preoferta3, preoferta4
            };
            #endregion

            // --------------------------------------------
            // Lista de Reporte
            // --------------------------------------------
            #region
            Reporte ReporEnero1 = new Reporte()
            {
                Fecha = new DateTime(2022, 1, 31),
                Observacion = "Estado Pendiente"
            };

            Reporte ReporEnero2 = new Reporte()
            {
                Fecha = new DateTime(2022, 1, 29),
                Observacion = "Estado Pendiente"
            };

            Reporte ReporFebrero3 = new Reporte()
            {
                Fecha = new DateTime(2022, 2, 2),
                Observacion = "Estado Pendiente"
            };

            List<Reporte> listaReportes = new List<Reporte>()
            {
                ReporEnero1, ReporEnero2, ReporFebrero3
            };
            #endregion

            // --------------------------------------------
            // Lista de Solicitudes
            // --------------------------------------------
            #region
            Solicitud Sol1 = new Solicitud()
            {
                FechaSolicitud = new DateTime(2022, 2, 01),
                MontoTotal = 7000,
                TiempoPago = 72,
                CuotaMensual = 350,
                Estado = SolicitudEstado.Pendiente,
                Usuarios = usuario1,
                Reportes = ReporFebrero3,
                Pagos = new List<TablaPagos>()
                {
                    new TablaPagos()
                    {
                        Capital = 10000,
                        Interes = 250,
                        PlazoTiempo = 72,
                        CuotaMensual = 350,
                        SaldoTotal = 9650
                    }
                }
            };

            Solicitud Sol2 = new Solicitud()
            {
                FechaSolicitud = new DateTime(2022, 1, 29),
                MontoTotal = 8000,
                TiempoPago = 72,
                CuotaMensual = 300,
                Estado = SolicitudEstado.Pendiente,
                Usuarios = usuario4,
                Reportes = ReporEnero1,
                Pagos = new List<TablaPagos>()
                {
                    new TablaPagos()
                    {
                        Capital = 10000,
                        Interes = 400,
                        PlazoTiempo = 72,
                        CuotaMensual = 450,
                        SaldoTotal = 9550
                    }
                }
            };

            Solicitud Sol3 = new Solicitud()
            {
                FechaSolicitud = new DateTime(2022, 1, 31),
                MontoTotal = 9000,
                TiempoPago = 48,
                CuotaMensual = 450,
                Estado = SolicitudEstado.Aprobada,
                Usuarios = usuario3,
                Reportes = ReporEnero2,
                Pagos = new List<TablaPagos>()
                {
                    new TablaPagos()
                    {
                        Capital = 10000,
                        Interes = 550,
                        PlazoTiempo = 72,
                        CuotaMensual = 600,
                        SaldoTotal = 9400
                    }
                }
            };

            List<Solicitud> listaSolicitudes = new List<Solicitud>()
            {
                Sol1, Sol2, Sol3
            };
            #endregion

            Dictionary<ListasTipo, object> dicListasDatos = new Dictionary<ListasTipo, object>()
            {
                { ListasTipo.Usuarios, listaUsuarios },
                { ListasTipo.Ingresos, listaIngresos },
                { ListasTipo.Egresos, listaEgresos },
                { ListasTipo.Instituciones, listaInstituciones },
                { ListasTipo.Ofertas,listaOfertas },
                { ListasTipo.Preofertas,listaPreofertas },
                { ListasTipo.Solicitudes, listaSolicitudes },
                { ListasTipo.Reportes, listaReportes},
                { ListasTipo.Configuracion, listaConfiguracion}
            };
            return dicListasDatos;
        }
    }
}
