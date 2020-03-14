using ExamenFinal.Interfaces;
using ExamenFinal.Validaciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamenFinalTests.Validaciones
{
    /// <summary>
    /// Summary description for ValidaSemanaUTest
    /// </summary>
    [TestClass]
    public class ValidaSemanaUTest
    {

        [TestMethod]
        public void ValidaSemana_FechaPedido_Datos()
        {
            //Arrange
            IValidaFecha objvalidaSemana = new ValidaSemana();
            string cfechaPedido = "31/03/2020";
            string crespuesta;

            //Act
            crespuesta = objvalidaSemana.ValidaFecha(cfechaPedido);

            //Assert
            Assert.IsNotNull(crespuesta);
        }
    }
}