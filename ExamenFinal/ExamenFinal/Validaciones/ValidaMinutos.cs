using ExamenFinal.Controlador;
using System;

namespace ExamenFinal.Validaciones
{
    /// <summary>
    /// 
    /// </summary>
    public class ValidaMinutos : ControladorAbstracto
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_objDatos"></param>
        /// <returns></returns>
        public override string ValidaFecha(string _objDatos)
        {
            try
            {
                DateTime _dfechaPedido = Convert.ToDateTime(_objDatos);
                DateTime _dfechaHoy = DateTime.Now;
                int _minuto;
                _minuto = (_dfechaHoy.Minute) - (_dfechaPedido.Minute);
                if (_minuto > 0)
                {
                    return _minuto + " Minutos";
                }
                else
                { if (_minuto < 0)
                    {
                        return Math.Abs(_minuto) + " Minutos";
                    }
                    else
                    {
                        return "hace unos momentos";
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            throw new NotImplementedException();
        }
    }
}
