using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSesion3
{
    internal class clase1
    {
        public class Persona
        {
          
                public string Nombre { get; private set; }
                public string Apellido { get; private set; }
                public DateTime FechaNacimiento { get; private set; }
                public string Telefono { get; private set; }
                public string Direccion { get; private set; }

            


            // Constructor de la clase Persona
            public Persona(string Nombre, string Apellido, DateTime fechaNacimiento, string telefono, string direccion)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.fechaNacimiento = fechaNacimiento;
                this.telefono = telefono;
                this.direccion = direccion;
            }

            // Métodos adicionales (si es necesario)
        }
    }
}
