using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBServices.Entities
{
    public class Alumno
    {
        public int Numero { get; set; }
        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public string Carnet { get; set;}
        public DateTime Fecha_Inscripcion { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Grado {  get; set;}
        public string Seccion {  get; set;}
        public string Numero_Encargado { get; set; }
        public string Nombre_Encargado { get; set; }
        public Boolean Pago { get; set;}
    }
}
