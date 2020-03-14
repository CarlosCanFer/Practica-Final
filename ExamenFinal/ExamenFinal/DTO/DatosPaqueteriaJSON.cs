using System.Collections.Generic;

namespace ExamenFinal.DTO
{
    public class DatosPaqueteriaJSON
    {
        public string Procedencia { get; set; }
        public string Destino { get; set; }
        public double Dist_KM { get; set; }
        public string Empresa { get; set; }
        public string MedioTrans { get; set; }
        public string FechaPedido { get; set; }
    }

    //public class PedidosDTO
    //{
    //    public List<DatosPaqueteriaJSON> ListaDatosJSON { get; set; }
    //}
}
