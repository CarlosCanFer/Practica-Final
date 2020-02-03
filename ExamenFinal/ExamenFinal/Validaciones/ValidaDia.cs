using ExamenFinal.Controlador;
using System;

namespace ExamenFinal.Validaciones
{
    /// <summary>
    /// 
    /// </summary>
    public class ValidaDia : ControladorAbstracto
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_objDatos"></param>
        /// <returns></returns>
        public override string ValidaFecha(string _objDatos)
        {
            try {
                DateTime _dfechaPedido = Convert.ToDateTime(_objDatos);
                DateTime _dfechaHoy = DateTime.Now;
                int _dia;
                _dia = (_dfechaHoy.Day) - (_dfechaPedido.Day);
                if (_dia > 0)
                {
                    return _dia + " dias";
                }
                else
                {
                    if (_dia < 0)
                    {
                        return Math.Abs(_dia) + " dias";
                    }
                    else
                    {
                        if (base._SiguienteValidacion != null)
                        {
                            return base._SiguienteValidacion.ValidaFecha(_objDatos);
                        }
                    }
                }
            } catch (Exception e) {
              Console.WriteLine(e);
            }
            throw new NotImplementedException();
        }
    }
}
