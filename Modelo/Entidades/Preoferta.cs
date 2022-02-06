using System;
using System.Collections.Generic;


namespace Modelo.Entidades
{
    public class Preoferta
    {
        public int InstitucionId { get; set; }
        public Institucion Instituciones { get; set; }
        public int OfertaId { get; set; }
        public Oferta Ofertas { get; set; }
    }
}
