using ExamenFinal.DTO;
using ExamenFinal.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ExamenFinal.Presentacion
{
    public class RecuperadorDatosJSON : IRecuperadorDatosJSON
    {
        public List<DatosPaqueteriaJSON> Recuperadatos()
        {
            string cruta = File.ReadAllText( @"..\..\json\Pedidos.json");

           var data = JsonConvert.DeserializeObject<List<DatosPaqueteriaJSON>>(cruta);           
              

            return data;
        }
    }
}
