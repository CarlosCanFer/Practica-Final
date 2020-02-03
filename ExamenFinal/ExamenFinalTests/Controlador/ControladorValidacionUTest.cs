using ExamenFinal.Controlador;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamenFinalTests.Controlador
{
    [TestClass]
    public class ControladorValidacionUTest
    {
        [TestMethod]
        public void ValidadorControlador_fechaPedido_datos()
        {
            //Arrange
            ControladorValidacion objvalidar = new ControladorValidacion();
            string _dfechaPedido = "2/01/2020 11:12";
            string _respuesta;

            //Act
            _respuesta = objvalidar.ValidaFecha(_dfechaPedido);

            //Assert
            Assert.IsNotNull(_respuesta);

        }
    }
}
