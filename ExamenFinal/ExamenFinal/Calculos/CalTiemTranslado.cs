using ExamenFinal.Interfaces;
using System;

namespace ExamenFinal.Calculos
{
    /// <summary>
    /// Clase encargada de realizar el calculo del tiempo de translado del paquete.
    /// </summary>
    public class CalTiemTranslado : ICalTiemTranslado
    {
        /// <summary>
        /// Método encargado de realizar el calculo del tiempo de translado del paquete.
        /// </summary>
        /// <param name="_idistancia">Distancia de entrada.</param>
        /// <param name="_ctranporte">Nombre del transporte.</param>
        /// <returns>Devuelve el tiempo de translado. </returns>
        public double CalculaTiempo(int _idistancia, string _ctranporte)
        {
            int _ivelocidad;
            double _dtiempoTraslado;
            try {
                _ivelocidad = VerificarVelocidadTransporte(_ctranporte);
                if (_ivelocidad != 0)
                    _dtiempoTraslado = Math.Round(((double)_idistancia / _ivelocidad), 2, MidpointRounding.ToEven);
                else
                  _dtiempoTraslado = 0;
                return _dtiempoTraslado;
            } catch {
                throw new NotImplementedException();
            }
           
        }

        /// <summary>
        /// Metodo encargado de verificar la velocidad dependiendo del transporte de entrada.
        /// </summary>
        /// <param name="ctranporte">Nombre del transporte.</param>
        /// <returns>Devuelve la velocidad del transporte.</returns>
        private int VerificarVelocidadTransporte(string ctranporte)
        {
            switch (ctranporte)
            {
                case "Barco":
                    return 46;
                    break;
                case "Tren":
                    return 80;
                    break;
                case "Avión":
                    return 600;
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}
