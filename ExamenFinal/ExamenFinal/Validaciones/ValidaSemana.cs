using ExamenFinal.Controlador;
using System;

namespace ExamenFinal.Validaciones
{
    public class ValidaSemana : ControladorAbstracto
    {
        public override string ValidaFecha(string _cDatos)
        {
            try {
                DateTime dtfechaPedido = Convert.ToDateTime(_cDatos);
                DateTime dtfechaHoy = DateTime.Now;
                int idias;
                idias = Math.Abs((dtfechaHoy.DayOfYear) - (dtfechaPedido.DayOfYear));

                if (idias >= 7 && idias <= 13)
                {
                    return "una semana";
                }
                else
                {
                    if (idias >= 14 && idias <= 20)
                    {
                        return "dos semana";
                    }
                    else
                    {
                        if (idias >= 21 && idias <= 30)
                        {
                            return "tres semana";
                        }
                        else
                        {
                            if (idias > 30)
                            {
                                return base._SiguienteValidacion.ValidaFecha(_cDatos);
                            }
                        }
                    }
                }               

            } catch { }
            throw new NotImplementedException();

        }
    }
}
