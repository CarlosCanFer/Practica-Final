using ExamenFinal.Interfaces;
using System;

namespace ExamenFinal.Controlador
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ControladorAbstracto : IValidaFecha
    {
        /// <summary>
        /// 
        /// </summary>
        protected IValidaFecha _SiguienteValidacion;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="siguienteValidacion"></param>
        /// <returns></returns>
        public IValidaFecha RecuperaSiguiente(IValidaFecha siguienteValidacion)
        {
            this._SiguienteValidacion = siguienteValidacion;
            return siguienteValidacion;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_objDatos"></param>
        /// <returns></returns>
        public virtual string ValidaFecha(string _objDatos)
        {
            if (this._SiguienteValidacion != null)
            {
                this._SiguienteValidacion.ValidaFecha(_objDatos);
            }
            throw new NotImplementedException();
        }
    }
}
