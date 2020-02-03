using ExamenFinal.Interfaces;
using ExamenFinal.Presentacion;

namespace ExamenFinal
{
    public class PintaMensaje : IPintaMensaje
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_ccolor"></param>
        /// <param name="_cmensaje"></param>
        public void PintarMensaje(string _ccolor, string _cmensaje)
        {
            IVisualizaMensaje objmensajeVerde = new MensajeVerde();
            IVisualizaMensaje objmensajeAmarillo = new MensajeAmarillo();
            IVisualizaMensaje objmensajeRojo = new MensajeRojo();

            switch (_ccolor)
            {
                case "Verde":
                    objmensajeVerde.Imprime(_cmensaje);
                    break;
                case "Amarillo":
                    objmensajeAmarillo.Imprime(_cmensaje);
                    break;
                case "Rojo":
                    objmensajeRojo.Imprime(_cmensaje);
                    break;
                default:
                    break;
            }
        }
    }
}
