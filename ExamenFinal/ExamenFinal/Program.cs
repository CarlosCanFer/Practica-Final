using ExamenFinal.Calculos;
using ExamenFinal.Controlador;
using ExamenFinal.DTO;
using ExamenFinal.Interfaces;
using ExamenFinal.Presentacion;
using System;
using System.Collections.Generic;

namespace ExamenFinal
{
    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
      public static void Main(string[] args)
        {
            IRecuperadorDatos objrecuperaDatos = new RecuperadorDatos();
            IPintaMensaje objpintarMensaje = new PintaMensaje();
            CalExtencion1 objextencion1 = new CalExtencion1();
            CalExtencion2 objextencion2 = new CalExtencion2();
            CalExtencion3 objextencion3 = new CalExtencion3();
            CalExtencion4 objextencion4 = new CalExtencion4();
            ControladorValidacion objvalidar = new ControladorValidacion();
            CalculaCostoEnvio objcostoEnvio = new CalculaCostoEnvio();

            List<DatosPaqueteria> objdatos;
            string _mensaje, _cext1, _cext2, _cext3, _cext4, _crangoTiempo;
            double _dcostoenvio;

            objdatos = objrecuperaDatos.Recuperadatos();

            foreach (DatosPaqueteria datos in objdatos)
            {
                _cext1 = objextencion1.Calculaextención(Convert.ToInt32(datos.dDistancia), datos.cTransporte, datos.DFechaPedido);
                _cext2= objextencion2.Calculaextención(Convert.ToInt32(datos.dDistancia), datos.cTransporte, datos.DFechaPedido);
                _cext3= objextencion3.Calculaextención(Convert.ToInt32(datos.dDistancia), datos.cTransporte, datos.DFechaPedido);
                _cext4= objextencion4.Calculaextención(Convert.ToInt32(datos.dDistancia), datos.cTransporte, datos.DFechaPedido);
                _crangoTiempo = objvalidar.ValidaFecha(datos.DFechaPedido.ToString());
                _dcostoenvio = objcostoEnvio.CalculaCosto(datos.dDistancia, datos.cPaqueteria, datos.cTransporte );

                _mensaje = (_dcostoenvio != 0) ? "Tu paquete " + _cext1 + " de " + datos.cOrigen + " y " + _cext2 + " a " + datos.cDestino + " " + _cext3 + " " + _crangoTiempo + " un costo de $" + _dcostoenvio + " Pesos(Cualquier reclamación con " + datos.cPaqueteria + ")\n" : "No ofrece el servicio de transporte por: " + datos.cTransporte ;

                int _resultadpDatos = DateTime.Compare(DateTime.Now, datos.DFechaPedido);

                if (_resultadpDatos > 0 && _dcostoenvio!=0)
                {
                    objpintarMensaje.PintarMensaje("Verde", _mensaje);
                }
                else
                {
                    if (_resultadpDatos < 0 && _dcostoenvio != 0)
                    {
                        objpintarMensaje.PintarMensaje("Amarillo", _mensaje);
                    }
                    else
                    {
                        objpintarMensaje.PintarMensaje("Rojo", _mensaje);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
