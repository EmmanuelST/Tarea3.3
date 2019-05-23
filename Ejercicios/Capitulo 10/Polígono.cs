using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Capitulo_10
{
    class Polígono
    {

        public int Lados { get; set; }
        public int Vertices { get; set; }
        public float AnguloInterior { get; set; }
        public float AnguloExterior { get; set; }

        public Polígono()
        {
            this.Lados = 0;
            this.Vertices = 0;
            this.AnguloInterior = 0.0f;
            this.AnguloExterior = 0.0f;
        }

        public Polígono(int lados,int vertices,float anguloInterior,float anguloExterioro)
        {
            this.Lados = lados;
            this.Vertices = vertices;
            this.AnguloInterior = anguloInterior;
            this.AnguloExterior = anguloExterioro;
        }
    }
}
