using Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace Modelo.Operaciones
{
    public class CalEndeudamiento
    {
        decimal totalIngresos;
        decimal totalEgresos;

        public CalEndeudamiento()
        {
        }

        public int Total(Ingresos ingreso)
        {
            int respuesta = 0;
            return respuesta;
        }
        public CalEndeudamiento(Ingresos ingresos, Egresos egresos)
        {
            totalIngresos = ingresos.TotalIngresos;
            totalEgresos = egresos.TotalEgresos;
        }

        /*
        public float Capacidad(Ingresos ingresos, Egresos egresos)
        {
            
            float respuesta;
            
            respuesta =
                (ingresos.TotalIngresos -
                egresos.TotalEgresos) * valorPorcentaje;

            respuesta = (float)Math.Round((double)respuesta, 2);
            
            return respuesta;
            
        }

        public bool Aprobado(Ingresos ingresos)
        {
            return Capacidad(ingresos) < totalIngresos;
        }
        */

    }
}
