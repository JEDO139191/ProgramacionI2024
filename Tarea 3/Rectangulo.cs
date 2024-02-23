using System;

public class Rectangulo
{
    // Propiedades
    public double Longitud { get; set; }
    public double Anchura { get; set; }

    // Constructor
    public Rectangulo(double longitud, double anchura)
    {
        Longitud = longitud;
        Anchura = anchura;
    }

    // Métodos
    public double CalcularArea()
    {
        return Longitud * Anchura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Longitud + Anchura);
    }
}
