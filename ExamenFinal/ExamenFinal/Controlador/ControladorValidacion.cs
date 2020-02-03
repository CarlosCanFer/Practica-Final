using ExamenFinal.Interfaces;
using ExamenFinal.Validaciones;

namespace ExamenFinal.Controlador
{
    /// <summary>
    /// 
    /// </summary>
    public class ControladorValidacion : IValidaFecha
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_objDatos"></param>
        /// <returns></returns>
        public string ValidaFecha(string _objDatos)
        {
            ValidaMes objvalidaMes = new ValidaMes();
            ValidaDia objvalidaDia = new ValidaDia();
            ValidaHora objvalidaHora = new ValidaHora();
            ValidaMinutos objvalidaMinuto = new ValidaMinutos();

            objvalidaMes.RecuperaSiguiente(objvalidaDia);
            objvalidaDia.RecuperaSiguiente(objvalidaHora);
            objvalidaHora.RecuperaSiguiente(objvalidaMinuto);
            
            return objvalidaMes.ValidaFecha(_objDatos);            
        }        
    }
}
