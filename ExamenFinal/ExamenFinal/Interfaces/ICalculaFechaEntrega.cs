using System;

namespace ExamenFinal.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICalculaFechaEntrega
    {
        DateTime FechaEnrega( int _idistancia, string _ctransporte, DateTime _dfechaPedido);
    }
}
