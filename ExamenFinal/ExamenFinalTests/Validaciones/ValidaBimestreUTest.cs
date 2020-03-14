using ExamenFinal.Interfaces;
using ExamenFinal.Validaciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamenFinalTests.Validaciones
{
    /// <summary>
    /// Summary description for ValidaBimestreUTest
    /// </summary>
    [TestClass]
    public class ValidaBimestreUTest
    {
        [TestMethod]
        public void ValidaBimestre_FechaPedido_Datos()
        {
            //Arrange
            IValidaFecha objvalidaBimestre = new ValidaBimestre();
            string _dfechaPedido = "17/11/2020 08:12";
            string _respuesta;

            //Act
            _respuesta = objvalidaBimestre.ValidaFecha(_dfechaPedido);

            //Assert
            Assert.IsNotNull(_respuesta);
        }
    }
}