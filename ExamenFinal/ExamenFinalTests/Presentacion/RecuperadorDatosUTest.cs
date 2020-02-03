using ExamenFinal.DTO;
using ExamenFinal.Interfaces;
using ExamenFinal.Presentacion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalTests.Presentacion
{
    [TestClass]
    public class RecuperadorDatosUTest
    {
        [TestMethod]
        public void RecuperadorDatos_Solicitud_Datos()
        {
            //Arrange
            IRecuperadorDatos objrecuperaDatos = new RecuperadorDatos();
            List<DatosPaqueteria> objdatos;

            //Act
            objdatos = objrecuperaDatos.Recuperadatos();

            //Assert
            Assert.IsNotNull(objdatos);

        }
    }
}
