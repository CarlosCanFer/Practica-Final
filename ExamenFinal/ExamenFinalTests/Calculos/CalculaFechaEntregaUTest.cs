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
    public class CalculaFechaEntregaUTest
    {
        [TestMethod]
        public void FechaEnrega_DatosPaqueteria_Fecha()
        {
            //Arrange
            ICalTiemTranslado objcalculatiempo = new CalTiemTranslado();
            ICalculaFechaEntrega objFechaEntrega = new CalculaFechaEntrega();
            int _distancia = 1356;
            string _ctransporte = "Barco";
            DateTime _dfechaPedido= Convert.ToDateTime("26/01/2020 20:39");
            DateTime _resultado;

            //Act
            _resultado = objFechaEntrega.FechaEnrega(_distancia, _ctransporte, _dfechaPedido);

            //Assert
            Assert.AreEqual(_dfechaPedido.AddHours(objcalculatiempo.CalculaTiempo(_distancia, _ctransporte)), _resultado);

        }
    }
}
