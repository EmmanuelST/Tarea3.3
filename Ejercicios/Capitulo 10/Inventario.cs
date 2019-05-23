using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Capitulo_10
{
    public class Inventario
    {
        //TODO: Terminar la clase de Inventario de la tienda (Ejercicio 1 cap 10)
        public int CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public float PrecioProducto { get; set; }
        public int CantidadProducto { get; set; }
        public string Gondola { get; set; }
        public DateTime FechaCaducidad { get; set; }

        public Inventario()
        {
            CodigoProducto = 0;
            NombreProducto = string.Empty;
            DescripcionProducto = string.Empty;
            PrecioProducto = 0.0f;
            CantidadProducto = 0;
            Gondola = string.Empty;
            FechaCaducidad = DateTime.Now;
        }
    }
}
