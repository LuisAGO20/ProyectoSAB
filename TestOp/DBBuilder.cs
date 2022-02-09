using Consola;
using ModeloDB;

namespace TestOp
{
    public sealed class DBBuilder
    {
        private DBBuilder() { }

        private static AprobacionBecaDB db;

        public static AprobacionBecaDB GetDB()
        {
            if (db == null)
            {
                Grabar grabar = new Grabar();
                grabar.DatosIni();
                db = AprobacionBecaDBBuilder.Crear();
            }
            return db;
        }
    }
}
