using System;
using System.Collections.Generic;


namespace Modelo.Entidades
{
    public class Oferta
    {
        public int OfertaId { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Carrera { get; set; }
        public decimal Costo { get; set; }
        public string Duracion { get; set; }
        public string Modalidad { get; set; }


        // RELACION CON INSTITUCION N:N
        public ICollection<Preoferta> Preofertas { get; set; }
    }
}
