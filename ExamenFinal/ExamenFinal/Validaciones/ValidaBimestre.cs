using ExamenFinal.Controlador;
using System;

namespace ExamenFinal.Validaciones
{
    public class ValidaBimestre : ControladorAbstracto
    {
        public override string ValidaFecha(string _cDatos)
        {
            try {
                DateTime dtfechaPedido = Convert.ToDateTime(_cDatos);
                DateTime dtfechaHoy = DateTime.Now;
                int imes;
                imes = Math.Abs((dtfechaHoy.Month)-(dtfechaPedido.Month));

                if (imes > 0 && imes%2== 0 && imes <= 12)
                {
                    return imes / 2 + " Bimestre";
                }
                else
                {
                    if (base._SiguienteValidacion != null)
                    {
                        return base._SiguienteValidacion.ValidaFecha(_cDatos);
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
