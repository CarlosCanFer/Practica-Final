using ExamenFinal.DTO;
using ExamenFinal.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExamenFinal.Presentacion
{
    public class RecuperadorDatos : IRecuperadorDatos
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<DatosPaqueteria> Recuperadatos()
        {
        
            string _cruta = @"..\..\Datos\Paqueteria.csv";
            List<string[]> _filas = RecuperaFilas(_cruta);
            string[] _cencabezados = _filas[0];

            return hacerpaquetes(_cencabezados, _filas);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cencabezados"></param>
        /// <param name="filas"></param>
        /// <returns></returns>
        private List<DatosPaqueteria> hacerpaquetes(string[] cencabezados, List<string[]> filas)
        {
            List<DatosPaqueteria> _lstpaquetes = new List<DatosPaqueteria>();

            for (int i = 1; i < filas.Count; i++)
            {
                string[] fila = filas[i];
                DatosPaqueteria objdatos = new DatosPaqueteria();
                for (int e = 0; e < fila.Length; e++)
                {
                    string encabezado = cencabezados[e];
                    string valor = fila[e];

                    objdatos = EncabezadoPartido(objdatos, encabezado, valor);
                }
                _lstpaquetes.Add(objdatos);
            }
            return _lstpaquetes;           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objdatos"></param>
        /// <param name="encabezado"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        private DatosPaqueteria EncabezadoPartido(DatosPaqueteria objdatos, string encabezado, string valor)
        {
            switch (encabezado)
            {
                case "Procedencia":
                    objdatos.cOrigen = valor;
                    break;
                case "Destino":
                    objdatos.cDestino = valor;
                    break;
                case "Dist_KM":
                    objdatos.dDistancia = Convert.ToDouble(valor);
                    break;
                case "Empresa":
                    objdatos.cPaqueteria = valor;
                    break;
                case "MedioTrans":
                    objdatos.cTransporte = valor;
                    break;
                case "FechaPedido":
                    objdatos.DFechaPedido = DateTime.Parse(valor);
                    break;
                default:
                    break;
            }
            return objdatos;           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cruta"></param>
        /// <returns></returns>
        private List<string[]> RecuperaFilas(string cruta)
        {
            List<DatosPaqueteria> paquetes = new List<DatosPaqueteria>();
            string[] lineas = File.ReadAllLines(cruta);
            var csv = from linea in lineas
                      select (linea.Split(',')).ToArray();
            return csv.ToList();
        }
    }
}
