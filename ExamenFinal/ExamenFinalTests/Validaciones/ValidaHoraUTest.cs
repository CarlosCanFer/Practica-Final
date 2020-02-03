using ExamenFinal.Interfaces;
using ExamenFinal.Validaciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalTests.Validaciones
{
    [TestClass]
    public class ValidaHoraUTest
    {
        [TestMethod]
        public void ValidaHora_FechaPedido_Respuesta()
        {
            //Arrange
            IValidaFecha objvalidaHora = new ValidaHora();
            string _dfechaPedido = "29/01/2020 08:12";
            string _respuesta;

            //Act
            _respuesta = objvalidaHora.ValidaFecha(_dfechaPedido);

            //Assert
            Assert.IsNotNull(_respuesta);

        }
    }
}
