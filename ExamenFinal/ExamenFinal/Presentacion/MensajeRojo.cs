using ExamenFinal.Interfaces;
using System;

namespace ExamenFinal.Presentacion
{
    public class MensajeRojo : IVisualizaMensaje
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_cmensaje"></param>
        public void Imprime(string _cmensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_cmensaje);
        }
    }
}
