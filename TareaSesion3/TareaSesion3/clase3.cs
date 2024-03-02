using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TareaSesion3.clase1;

namespace TareaSesion3
{
    internal class clase3
    {
        public class Profesor : Persona
        {
            // Atributos adicionales para la clase Profesor
            private string titulo;
            private string departamento;

            // Constructor de la clase Profesor
            public Profesor(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion,
                            string titulo, string departamento)
                            : base(nombre, apellido, fechaNacimiento, telefono, direccion)
            {
                this.titulo = titulo;
                this.departamento = departamento;
            }

            // Métodos adicionales (si es necesario)
        }

    }
}
