using System;
using System.Collections.Generic;


namespace Modelo.Entidades
{
    public class Configuracion
    {
        public int EdadMinimaCredito { get; set; }
        public string NombreInstitucion { get; set; }
        public decimal CreditoMaximo { get; set; }
        public string CompromisoPago { get; set; }
    }
}
