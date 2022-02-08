using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;


namespace ModeloDB
{
    public class AprobacionBecaDB : DbContext
    {
        public AprobacionBecaDB()
        {
        }

        public AprobacionBecaDB(DbContextOptions<AprobacionBecaDB> options)
            : base(options)
        {
        }

        // Se asegura el borrado y la creación de la base de datos
        public void PreparaDB()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        // DECLARACIÓN DE LAS ENTIDADES DEL MODELO
        public DbSet<Configuracion> Configuraciones { get; set; }
        public DbSet<Ingresos> Ingresos { get; set; }
        public DbSet<Institucion> Instituciones { get; set; }
        public DbSet<Oferta> Ofertas { get; set; }
        public DbSet<Preoferta> Preofertas { get; set; }
        public DbSet<Reporte> Reportes { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }
        public DbSet<TablaPagos> Pagos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        // CONFIGURACIÓN DE LA CONEXIÓN
        override protected void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Si no se ha configurado la conección la configura con SqlServer
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server = LAPTOP-B130UKF6\\SQLEXPRESS; initial catalog=ProyectoSAB; trusted_connection=true;");
                // .LogTo(Console.WriteLine, LogLevel.Information);  // Para activar el modo debug
            }
        }

        // CONFIGURAR EL MODELO DE LAS ENTIDADES
        protected override void OnModelCreating(ModelBuilder model)
        {
            // RELACION DE UNO A UNO
            model.Entity<Usuario>()
                .HasOne(u => u.ResumenIngresos)
                .WithOne(i => i.Usuarios)
                .HasForeignKey<Ingresos>(i => i.UsuarioId);


            // RELACION DE UNO A MUCHOS
            model.Entity<Solicitud>()
              .HasOne(s => s.Usuarios)
              .WithMany(u => u.Solicitudes)
              .OnDelete(DeleteBehavior.NoAction)
              .HasForeignKey(s => s.UsuarioId);


            // RELACION DE UNO A MUCHOS
            model.Entity<Solicitud>()
              .HasOne(s => s.Reportes)
              .WithMany(r => r.Solicitudes)
              .OnDelete(DeleteBehavior.NoAction)
              .HasForeignKey(s => s.ReporteId);


            // RELACION DE UNO A MUCHOS
            model.Entity<TablaPagos>()
              .HasOne(p => p.Solicitudes)
              .WithMany(s => s.Pagos)
              .HasForeignKey(p => p.SolicitudId);


            // RELACION DE N:M OFERTA INSTITUCION
            model.Entity<Preoferta>()
                  .HasOne(po => po.Instituciones)
                  .WithMany(i => i.Preofertas)
                  .OnDelete(DeleteBehavior.NoAction)
                  .HasForeignKey(po => po.InstitucionId);


            model.Entity<Preoferta>()
                  .HasOne(po => po.Ofertas)
                  .WithMany(o => o.Preofertas)
                  .OnDelete(DeleteBehavior.NoAction)
                  .HasForeignKey(po => po.OfertaId);


            model.Entity<Preoferta>()
                .HasKey(po => new
                {
                    po.InstitucionId,
                    po.OfertaId
                });


            // La clase configuración tiene clave primaria de tipo distinta que int
            model.Entity<Configuracion>()
                .HasKey(configuracion => configuracion.NombreInstitucion);
        }
    }
}
