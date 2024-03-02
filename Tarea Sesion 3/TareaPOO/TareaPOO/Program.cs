using System;

class Persona
{
    public string Nombre { get; }
    public string Apellido { get; }
    public string FechaNacimiento { get; }
    public string Telefono { get; }
    public string Direccion { get; }

    public Persona(string nombre, string apellido, string fechaNacimiento, string telefono, string direccion)
    {
        
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El nombre no puede estar vacío", nameof(nombre));
        if (string.IsNullOrWhiteSpace(apellido))
            throw new ArgumentException("El apellido no puede estar vacío", nameof(apellido));
        if (string.IsNullOrWhiteSpace(fechaNacimiento))
            throw new ArgumentException("La fecha no puede estar vacio", nameof(fechaNacimiento));
        if (string.IsNullOrWhiteSpace(telefono))
            throw new ArgumentException("El teléfono no puede estar vacío", nameof(telefono));
        if (string.IsNullOrWhiteSpace(direccion))
            throw new ArgumentException("La dirección no puede estar vacía", nameof(direccion));

       
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        Telefono = telefono;
        Direccion = direccion;
    }
}

class Alumno : Persona
{
    public string Carnet { get; }
    public string FechaIngreso { get; }

    public Alumno(string nombre, string apellido, string fechaNacimiento, string telefono, string direccion, string carnet, string fechaIngreso)
        : base(nombre, apellido, fechaNacimiento, telefono, direccion)
    {
        Carnet = carnet;
        FechaIngreso = fechaIngreso;
    }
}

class Profesor : Persona
{
    public string Especialidad { get; }
    public double Salario { get; }

    public Profesor(string nombre, string apellido, string fechaNacimiento, string telefono, string direccion, string especialidad, double salario)
        : base(nombre, apellido, fechaNacimiento, telefono, direccion)
    {
        Especialidad = especialidad;
        Salario = salario;
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Persona persona = new Persona("Juan", "Martinez", "12/5/1995", "5322334", "COLONIA BARRIENTOS");

      
        Alumno alumno = new Alumno("María", "Case", "12/5/1996", "54323221", "Las Aves", "A12345", "12/5/2020");

        
        Profesor profesor = new Profesor("Carlos", "Villagran", "12/5/1997", "34326655", "Calle Americas", "Matemáticas", 2500.23);

        
        Console.WriteLine("Información de la Persona:");
        Console.WriteLine($"Nombre: {persona.Nombre}");
        Console.WriteLine($"Apellido: {persona.Apellido}");
        Console.WriteLine($"Fecha de Nacimiento: {persona.FechaNacimiento}");
        Console.WriteLine($"Teléfono: {persona.Telefono}");
        Console.WriteLine($"Dirección: {persona.Direccion}");

        Console.WriteLine();

        Console.WriteLine("Información del Alumno:");
        Console.WriteLine($"Nombre: {alumno.Nombre}");
        Console.WriteLine($"Apellido: {alumno.Apellido}");
        Console.WriteLine($"Fecha de Nacimiento: {alumno.FechaNacimiento}");
        Console.WriteLine($"Teléfono: {alumno.Telefono}");
        Console.WriteLine($"Dirección: {alumno.Direccion}");
        Console.WriteLine($"Carnet: {alumno.Carnet}");
        Console.WriteLine($"Fecha de Ingreso: {alumno.FechaIngreso}");

        Console.WriteLine();

        Console.WriteLine("Información del Profesor:");
        Console.WriteLine($"Nombre: {profesor.Nombre}");
        Console.WriteLine($"Apellido: {profesor.Apellido}");
        Console.WriteLine($"Fecha de Nacimiento: {profesor.FechaNacimiento}");
        Console.WriteLine($"Teléfono: {profesor.Telefono}");
        Console.WriteLine($"Dirección: {profesor.Direccion}");
        Console.WriteLine($"Especialidad: {profesor.Especialidad}");
        Console.WriteLine($"Salario: {profesor.Salario}");

        Console.ReadKey();
    }
}
