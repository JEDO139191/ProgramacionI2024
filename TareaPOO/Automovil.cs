using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TareaPOO
{
    internal class Automovil
    {
        private int _id;
        private string _marca;
        private string _modelo;
        private int _km;
        private double _precio;

        public Automovil(int id, string marca, string modelo, int km, double precio)
        {
            this._id = id;
            this._marca = marca;
            this._modelo = modelo;
            this._km = km;
            this._precio = precio;
        }

        public int id { get => _id; set => _id = value; }
        public string marca { get => _marca; set => _marca = value; }
        public string modelo { get => _modelo; set => _modelo = value; }
        public int km { get => _km; set => _km = value; }
        public double precio { get => _precio; set => _precio = value; }

        public override string ToString()
        {
            return "Marca: " + marca + ", Modelo: " + modelo + ", Precio: " + precio;
        }
    }

    internal class AutomovilDeportivo : Automovil
    {
        public AutomovilDeportivo(int id, string marca, string modelo, int km, double precio)
            : base(id, marca, modelo, km, precio)
        {
        }

        public override string ToString()
        {
            return "Automóvil Deportivo - " + base.ToString();
        }
    }
}
