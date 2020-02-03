using ExamenFinal.Interfaces;

namespace ExamenFinal.Presentacion
{
    /// <summary>
    /// 
    /// </summary>
    public class VisualizaMensaje : IVisualizaMensaje
    {
        /// <summary>
        /// 
        /// </summary>
        protected IVisualizaMensaje _mensaje;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        public VisualizaMensaje(IVisualizaMensaje mensaje)
        {
            this._mensaje = mensaje;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        public void Imprime(string mensaje)
        {
            throw new System.NotImplementedException();
        }
    }
}
