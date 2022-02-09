using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Egresos
    {
        public int EgresosId { get; set; }
        public decimal Luz { get; set; }
        public decimal Agua { get; set; }
        public decimal Telefono { get; set; }
        public decimal Internet { get; set; }
        public decimal TotalEgresos { get; set; }

        // RELACION CON LA CLASE USUARIOS 1:1
        public int UsuarioId { get; set; }
        public Usuario Usuarios { get; set; }
    }
}
