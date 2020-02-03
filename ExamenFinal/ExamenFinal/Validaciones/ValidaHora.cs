using ExamenFinal.Controlador;
using System;

namespace ExamenFinal.Validaciones
{
    /// <summary>
    /// 
    /// </summary>
    public class ValidaHora : ControladorAbstracto
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
                int _hora;
                _hora = (_dfechaHoy.Hour) - (_dfechaPedido.Hour);
                if (_hora > 0)
                {
                    return _hora + " Horas";
                }
                else
                { if (_hora < 0)
                    {
                        return Math.Abs(_hora) + " Horas";
                    }
                    else
                    {
                        if (base._SiguienteValidacion != null)
                        {
                            return base._SiguienteValidacion.ValidaFecha(_objDatos);
                        }
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
