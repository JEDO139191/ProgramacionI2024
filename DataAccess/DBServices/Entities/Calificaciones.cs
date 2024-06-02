using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBServices.Entities
{
    public class Calificaciones
    {
        public string Carnet {  get; set; }
        public string Espanol { get; set; }
        public string Ingles { get; set; }
        public string Matematica { get; set; }
        public string Ciencias_N { get; set; }
        public string Ciencias_S { get; set; }
        public string Computacion { get; set; }
        public string Contabilidad { get; set; }
        public string Fisica { get; set; }
    }
}
