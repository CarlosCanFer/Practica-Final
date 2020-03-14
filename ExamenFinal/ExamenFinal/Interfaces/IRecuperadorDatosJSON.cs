using ExamenFinal.DTO;
using System.Collections.Generic;

namespace ExamenFinal.Interfaces
{
    public interface IRecuperadorDatosJSON
    {
        List<DatosPaqueteriaJSON> Recuperadatos();
    }
}
