using ExamenFinal.Interfaces;
using System;

namespace ExamenFinal.Calculos
{
    /// <summary>
    /// Clase encargada de  calcular la fecha de entrada del paquete.
    /// </summary>
    public class CalculaFechaEntrega : ICalculaFechaEntrega
    {
        /// <summary>
        /// Metodo que se encarga de calcular la fecha.
        /// </summary>
        /// <param name="_idistancia">Distancia de entrada.</param>
        /// <param name="_ctransporte">Nombre de la Paqueteria.</param>
        /// <param name="_dfechaPedido">Fecha de Pedido.</param>
        /// <returns>Devuelve una fecha de entrega.</returns>
        public DateTime FechaEnrega(int _idistancia, string _ctransporte, DateTime _dfechaPedido)
        {
            try {
                DateTime _dfechaCalculada;
                ICalTiemTranslado objtiempoTranslado = new CalTiemTranslado();

                _dfechaCalculada = _dfechaPedido.AddHours(objtiempoTranslado.CalculaTiempo(_idistancia, _ctransporte));

                return _dfechaCalculada;

            } catch {
                throw new NotImplementedException();
            }
        }
    }
}
