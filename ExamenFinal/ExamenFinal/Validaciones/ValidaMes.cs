using ExamenFinal.Controlador;
using System;

namespace ExamenFinal.Validaciones
{
    /// <summary>
    /// 
    /// </summary>
    public class ValidaMes : ControladorAbstracto
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_objDatos"></param>
        /// <returns></returns>
        public override string ValidaFecha(string _objDatos)
        {
            string _cmensaje ="";
            try {
                DateTime _dfechaPedido = Convert.ToDateTime(_objDatos);
                DateTime _dfechaHoy = DateTime.Now;
                int _mes;
                _mes = (_dfechaHoy.Month) - (_dfechaPedido.Month);
                if (_mes > 0)
                {
                    _cmensaje = _mes + " meses";
                    return _cmensaje;
                }
                else
                { if (_mes < 0)
                    {
                        _cmensaje = Math.Abs(_mes) + " meses";
                        return _cmensaje;
                    }
                    else
                    {
                        if (base._SiguienteValidacion != null)
                        {
                            return base._SiguienteValidacion.ValidaFecha(_objDatos);
                        }
                    }
                }
            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
            throw new NotImplementedException();
        }
    }
}
