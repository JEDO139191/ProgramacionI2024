using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1Sesion5
{
   
        public class Rectangulo
        {
            // Variables de instancia
            private readonly double alto;
            private readonly double largo;

            // Constructor
            public Rectangulo(double alto, double largo)
            {
                this.alto = alto;
                this.largo = largo;
            }

            // Propiedad de solo lectura para la superficie frontal
            public double SuperficieFrontal
            {
                get { return CalcularSuperficieFrontal(); }
            }

            // Método para calcular la superficie frontal
            private double CalcularSuperficieFrontal()
            {
                return alto * largo;
            }
        }
    
}
