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
            ValidaBimestre objvalidaBimestre = new ValidaBimestre();
            ValidaMes objvalidaMes = new ValidaMes();
            ValidaSemana objvalidaSemana = new ValidaSemana();
            ValidaDia objvalidaDia = new ValidaDia();
            ValidaHora objvalidaHora = new ValidaHora();
            ValidaMinutos objvalidaMinuto = new ValidaMinutos();

            objvalidaBimestre.RecuperaSiguiente(objvalidaMes);
            objvalidaMes.RecuperaSiguiente(objvalidaSemana);
            objvalidaSemana.RecuperaSiguiente(objvalidaDia);
            objvalidaDia.RecuperaSiguiente(objvalidaHora);
            objvalidaHora.RecuperaSiguiente(objvalidaMinuto);
            
            return objvalidaBimestre.ValidaFecha(_objDatos);
        }        
    }
}
