using ExamenFinal.Interfaces;
using System;

namespace ExamenFinal.Calculos
{
    /// <summary>
    /// Clase que se encarga de calcular el costo de envio dependiendo de la distancia, el transporte y paqueteria.
    /// </summary>
    public class CalculaCostoEnvio : ICalculaCostoEnvio
    {
        /// <summary>
        /// Metodo que calcula el costo del paquete
        /// </summary>
        /// <param name="_ddistancia">Distancia de entrada</param>
        /// <param name="_cpaqueteria">Nombre de la paqueteria</param>
        /// <param name="_ctransporte">Transporte agregado</param>
        /// <returns>Costo del envio dependiendo de datos de entrada</returns>
        public double CalculaCosto(double _ddistancia, string _cpaqueteria, string _ctransporte)
        {
            double _dCosto;
            double _dcxd, _dmargen;

            _dcxd = (VerificarCostoTransporte(_ctransporte) * _ddistancia);
            _dmargen = (1 + Math.Round(((double)VerificarMargenpaqueteria(_cpaqueteria) / 100), 2, MidpointRounding.ToEven));
            _dCosto = _dcxd * _dmargen;

            return _dCosto;

        }

        /// <summary>
        /// Metodo que verifica el costo de dependiendo del transporte de entrada. 
        /// </summary>
        /// <param name="ctranporte">Nombre del transporte.</param>
        /// <returns>Valor del costo dependiendo del transporte.</returns>
        private int VerificarCostoTransporte(string ctranporte)
        {
            switch (ctranporte)
            {
                case "Marítimo":
                    return 1;
                    break;
                case "Terrestre":
                    return 5;
                    break;
                case "Aéreo":
                    return 10;
                    break;
                default:
                    return 0;
                    break;
            }
        }

        /// <summary>
        /// Metodo que se encarga de calcular el margen dependiendo de la paqueteria de entrada.
        /// </summary>
        /// <param name="_cpaqueteria">Nombre de la paqueteria.</param>
        /// <returns>Valor enterio del margen calculado.</returns>
        private int VerificarMargenpaqueteria(string _cpaqueteria)
        {
            switch (_cpaqueteria)
            {
                case "Fedex":
                    return 50;
                    break;
                case "DHL":
                    return 40;
                    break;
                case "Estafeta":
                    return 20;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No existe paqueteria: " + _cpaqueteria);
                    return 0;
                    break;
            }
        }
    }
}
