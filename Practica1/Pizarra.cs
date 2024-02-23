using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Pizarra
    {
        //atributos de la clase.
        private string color;
        private double ancho;
        private double largo;

        private string contenido;
        public Pizarra(string color, double ancho, double largo)
        {
            this.color = color;
            this.ancho = ancho;
            this.largo = largo;

        }
        //metodos
        /// <summary>
        /// El metodo escribe el contenido indicado en la pizarra
        /// </summary>
        /// <param name="texto">Contenido que se quiere escribir</param>
       public void Escribir (string texto)
        {
            contenido = texto;
        }
        
        public void Borrar()
        {
            contenido = "";
        }

        public string GetContenido()
        {
            return contenido;   
        }
    }
}
