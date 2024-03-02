using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TareaSesion3.clase1;

namespace TareaSesion3
{
    internal class clase2
    {
        public class Alumno : Persona
        {
            // Atributos adicionales para la clase Alumno
            private string carnet;
            private DateTime fechaIngreso;

            // Constructor de la clase Alumno
            public Alumno(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion,
                          string carnet, DateTime fechaIngreso)
                          : base(nombre, apellido, fechaNacimiento, telefono, direccion)
            {
                this.carnet = carnet;
                this.fechaIngreso = fechaIngreso;
            }

            // Métodos adicionales (si es necesario)
        }

    }
}
