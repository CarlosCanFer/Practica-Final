using ExamenFinal.Interfaces;
using System;

namespace ExamenFinal.Calculos
{
    /// <summary>
    /// Clase encargada que crear la entencion 1.
    /// </summary>
    public class CalExtencion1 : IExtenciones
    {
        /// <summary>
        /// Metodo encargada que crear la entencion 1
        /// </summary>
        /// <param name="_idistancia">Distancia de entrada</param>
        /// <param name="_ctransporte">Nombre del transporte</param>
        /// <param name="_dfechaPedido">Fecha de pedido</param>
        /// <returns>Devuelve una cadena con la extención 1</returns>
        public string Calculaextención(int _idistancia, string _ctransporte, DateTime _dfechaPedido)
        {
            ICalculaFechaEntrega objfechaentrega = new CalculaFechaEntrega();
            DateTime _dfechaentrega = objfechaentrega.FechaEnrega(_idistancia, _ctransporte, _dfechaPedido);
            DateTime _dhoy = DateTime.Now;
            if (_dfechaentrega < _dhoy)
            {
                return "salío";
            }
            else
            {
                return "ha Salido";
            }
            throw new NotImplementedException();
        }
    }
}
