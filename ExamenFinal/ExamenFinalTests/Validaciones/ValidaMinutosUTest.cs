using ExamenFinal.Interfaces;
using ExamenFinal.Validaciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamenFinalTests.Validaciones
{
    [TestClass]
    public class ValidaMinutosUTest
    {
        [TestMethod]
        public void ValidarMinutos_FechaPedido_Respuesta()
        {
            //Arrange
            IValidaFecha objvalidaMinutos = new ValidaMinutos();
            string _dfechaPedido = "29/01/2020 01:58";
            string _respuesta;

            //Act
            _respuesta = objvalidaMinutos.ValidaFecha(_dfechaPedido);

            //Assert
            Assert.IsNotNull(_respuesta);

        }
    }
}
