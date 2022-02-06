using System;
using System.Collections.Generic;


namespace Modelo.Entidades
{
    public class Institucion
    {
        public int InstitucionId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Pais { get; set; }
        public string Email { get; set; }


        // RELACION CON OFERTA N:N
        public ICollection<Preoferta> Preofertas { get; set; }
    }
}
