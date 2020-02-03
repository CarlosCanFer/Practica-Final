using ExamenFinal.Interfaces;
using ExamenFinal.Validaciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamenFinalTests.Validaciones
{
    [TestClass]
    public class ValidaMesUTest
    {
        [TestMethod]
        public void ValidaMes_FechaPedido_Respuestames()
        {
            //Arrange
            IValidaFecha objvalidaMes = new ValidaMes();
            string _dfechaPedido = "26/04/2020 08:12";
            string _respuesta;

            //Act
            _respuesta = objvalidaMes.ValidaFecha(_dfechaPedido);

            //Assert
            Assert.IsNotNull(_respuesta);

        }
    }
}
