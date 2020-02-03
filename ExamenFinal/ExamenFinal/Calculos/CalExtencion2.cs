using ExamenFinal.Interfaces;
using System;

namespace ExamenFinal.Calculos
{
    /// <summary>
    /// Clase encargada de crear la entención 2.
    /// </summary>
    public class CalExtencion2 : IExtenciones
    {
        /// <summary>
        /// Metodo encargada que crear la entencion 2
        /// </summary>
        /// <param name="_idistancia">Distancia de entrada</param>
        /// <param name="_ctransporte">Nombre del transporte</param>
        /// <param name="_dfechaPedido">Fecha de pedido</param>
        /// <returns>Devuelve una cadena con la extención 2</returns>
        public string Calculaextención(int _idistancia, string _ctransporte, DateTime _dfechaPedido)
        {
            ICalculaFechaEntrega objfechaentrega = new CalculaFechaEntrega();
            DateTime _dfechaentrega = objfechaentrega.FechaEnrega(_idistancia, _ctransporte, _dfechaPedido);
            DateTime _dhoy = DateTime.Now;
            if (_dfechaentrega < _dhoy)
            {
                return "llegó";
            }
            else
            {
                return "llegará";
            }
            throw new NotImplementedException();
        }
    }
}
