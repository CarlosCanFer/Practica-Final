using ExamenFinal.Calculos;
using ExamenFinal.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamenFinalTests.Calculos
{
    [TestClass]
    public class CalTiemTransladoUTest
    {
        [TestMethod]
        public void CalculaTiempo_100kBarco_double()
        {
            //Arrange
            ICalTiemTranslado objcalculatiempo = new CalTiemTranslado();
            int _distancia = 100;
            string _ctransporte = "Barco";
            double _resultado;

            //Act
            _resultado = objcalculatiempo.CalculaTiempo(_distancia, _ctransporte);

            //Assert
            Assert.AreEqual(2.17,_resultado);
        }
    }
}
