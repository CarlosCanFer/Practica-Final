using ExamenFinal.Calculos;
using ExamenFinal.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalTests.Calculos
{
    [TestClass]
    public class CalculaCostoEnvioUTest
    {
        [TestMethod]
        public void CalculaCosto_DatosSolicitados_Double()
        {
            //Arrange
            ICalculaCostoEnvio objcalculaCosto = new CalculaCostoEnvio();
            double _ddistancia= 12540;
            double _dresultado;
            string _cpaqueteria = "DHL";
            string _ctransporte="Avión";

            //Act
            _dresultado = objcalculaCosto.CalculaCosto(_ddistancia, _cpaqueteria, _ctransporte);

            //Assert
            Assert.AreEqual(175560, _dresultado);
        }
    }
}
