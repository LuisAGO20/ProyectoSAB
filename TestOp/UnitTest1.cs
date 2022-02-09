using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Modelo.Operaciones;
using System.Linq;
using Xunit;

namespace TestOp
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 4)]
        [InlineData(2, 4)]
        [InlineData(3, 4)]
        [InlineData(4, 4)]
        [InlineData(5, 4)]
        [InlineData(95, 3)]
        [InlineData(96, 4)]
        [InlineData(106, 3)]
        [InlineData(109, 3)]
        [InlineData(113, 4)]
        [InlineData(180, 3)]
        [InlineData(181, 3)]
        [InlineData(188, 3)]
        [InlineData(191, 4)]
        [InlineData(192, 4)]
        [InlineData(269, 4)]
        [InlineData(270, 4)]
        [InlineData(271, 4)]
        [InlineData(272, 4)]
        [InlineData(273, 4)]

        public void ValidacionIngresos(int ingresosId, int resEsperado)
        {
            int resCalc;
            string usuario;
            string msg;

            //busca el Ingreso dependiendo el id brindado en InlineData
            var db = DBBuilder.GetDB();
            var ingresos = db.Ingresos.Find(ingresosId);

            // mostrar mensaje
            Ingresos ing = db.Ingresos
                .Include(ing => ing.Usuarios)
                .Single(ing => ing.IngresosId == ingresosId);

            var calc = new CalEndeudamiento();

            //mensaje
            usuario = ing.Usuarios.Apellidos;
            msg = $"{usuario} ";

            resCalc = calc.Total(ingresos);
            // verifciar si coincide resultado esperado con el calculado
            Xunit.Assert.True(resEsperado == resCalc,
                " Esperado " + resEsperado + " != " + msg);
        }
    }
}
