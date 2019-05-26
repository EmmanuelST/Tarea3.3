using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Capitulo_10
{
    class Poligono
    {

        private int lados;
        private float longitud;

        public int Lados
        {
            get
            {
                return lados;
            }
           
            set
            {
                if (value < 0)
                    lados = 1;
                else
                    lados = value;
            }

        }


        public float Longitud
        {
            get
            {
                return longitud;
            }
            
            set
            {
                if (value < 0)
                    longitud = 0;
                else
                    longitud = value;
            }
        }
        

        public Poligono()
        {
            this.Lados = 0;
            this.Longitud = 0;
           
        }

        public Poligono(int lados,float longitud)
        {
            this.Lados = lados;
            this.Longitud = longitud;
          
        }

        public override string ToString()
        {
            string cadena;

            cadena = "Lados ="+Lados+", Vertices ="+Longitud;

            return cadena;

        }

        public float perimetro()
        {
            return (Lados * Longitud);
        }
    }
}
