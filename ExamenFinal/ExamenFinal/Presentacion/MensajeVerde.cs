using ExamenFinal.Interfaces;
using System;

namespace ExamenFinal.Presentacion
{
    public class MensajeVerde : IVisualizaMensaje
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_cmensaje"></param>
        public void Imprime(string _cmensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_cmensaje);            
        }
    }
}
