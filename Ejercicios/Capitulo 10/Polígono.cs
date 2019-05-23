using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Capitulo_10
{
    class Polígono
    {

        public int Lados
        {
            get
            {
                return Lados;

            }
            set
            {
                if (value < 0)
                    value = 1;
            }

        }


        public int Vertices
        {
            get
            {
                return Vertices;
            }
            set
            {
                if (value < Lados)
                    value = Lados;
            }
        }
        public float AnguloInterior
        {
            get
            {
                return AnguloInterior;
            }
            set
            {
                if (value < 0)
                    value = 1;
            }
        }
        public float AnguloExterior
        {
            get
            {
                return AnguloExterior;
            }
            set
            {
                if (value < 0)
                    value = 1;
            }

        }

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

        public override string ToString()
        {
            string cadena;

            cadena = "Lados ="+Lados+", Vertices ="+Vertices+"," +
                " Angulo Interior ="+AnguloInterior+", Angulo Exterior ="+AnguloExterior;

            return cadena;

        }
    }
}
