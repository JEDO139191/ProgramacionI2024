using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mantenimiento
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public Producto() { }
        public Producto(int id, string nombre, decimal precio, int existencia)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Existencia = existencia;
        }
    }

  
}
