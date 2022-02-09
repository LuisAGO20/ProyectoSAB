using Microsoft.EntityFrameworkCore;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.Configuration;


namespace Consola
{
    public class AprobacionBecaDBBuilder
    {
        const string DBTipo = "DBTipo";
        enum DBTipoConn { SqlServer, Postgres, Memoria, MySql }
        static AprobacionBecaDB db;

        public static AprobacionBecaDB Crear()
        {
            // Lee la configuración acerca de qué base usar del archivo App.config
            string dbtipo = ConfigurationManager.AppSettings[DBTipo];
            string conn = ConfigurationManager.ConnectionStrings[dbtipo].ConnectionString;

            // Construye la conección acorde con el tipo
            DbContextOptions<AprobacionBecaDB> contextOptions;
            switch (dbtipo)
            {
                case nameof(DBTipoConn.SqlServer):
                    contextOptions = new DbContextOptionsBuilder<AprobacionBecaDB>()
                        .UseSqlServer(conn)
                        .Options;
                    break;
                case nameof(DBTipoConn.Postgres):
                    contextOptions = new DbContextOptionsBuilder<AprobacionBecaDB>()
                        .UseNpgsql(conn)
                        .Options;
                    break;
                case nameof(DBTipoConn.MySql):
                    contextOptions = new DbContextOptionsBuilder<AprobacionBecaDB>()
                        .UseMySQL(conn)
                        .Options;
                    break;
                default: // Por defecto usa la memoria como base de datos
                    contextOptions = new DbContextOptionsBuilder<AprobacionBecaDB>()
                        .UseInMemoryDatabase(conn)
                        .Options;
                    break;
            }

            db = new AprobacionBecaDB(contextOptions);

            return db;
        }
    }
}
