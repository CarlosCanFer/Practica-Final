using ExamenFinal.Interfaces;
using System;

namespace ExamenFinal.Presentacion
{
    public class MensajeAmarillo : IVisualizaMensaje
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_cmensaje"></param>
        public void Imprime(string _cmensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(_cmensaje);
        }
    }
}
