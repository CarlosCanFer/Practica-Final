using ExamenFinal.Interfaces;
using ExamenFinal.Validaciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamenFinalTests.Validaciones
{
    [TestClass]
    public class ValidaDiaUTest
    {
        [TestMethod]
        public void ValidaDia_FechaPedido_Datos()
        {
            //Arrange
            IValidaFecha objvalidaDia = new ValidaDia();
            string _dfechaPedido = "31/01/2020 08:12";
            string _respuesta;

            //Act
            _respuesta = objvalidaDia.ValidaFecha(_dfechaPedido);

            //Assert
            Assert.IsNotNull(_respuesta);

        }
    }
}
