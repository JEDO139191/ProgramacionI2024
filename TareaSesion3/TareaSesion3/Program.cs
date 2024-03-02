using static TareaSesion3.clase1;
using static TareaSesion3.clase2;
using static TareaSesion3.clase3;

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de Persona
        Persona persona = new Persona("Juan", "Perez", new DateTime(1990, 5, 15), "123456789", "Calle Principal");

        // Crear una instancia de Alumno
        Alumno alumno = new Alumno("Maria", "Gonzalez", new DateTime(1995, 8, 20), "987654321", "Avenida Central",
                                    "A12345", new DateTime(2020, 9, 1));

        // Crear una instancia de Profesor
        Profesor profesor = new Profesor("Pedro", "Lopez", new DateTime(1980, 3, 10), "456789123", "Avenida Norte",
                                         "Licenciado en Educación", "Matemáticas");

        // Imprimir información de las instancias
        Console.WriteLine("Información de la persona:");
        Console.WriteLine($"Nombre: {persona.Nombre}, Apellido: {persona.Apellido}, Fecha de Nacimiento: {persona.FechaNacimiento}");
        Console.WriteLine();

        Console.WriteLine("Información del alumno:");
        Console.WriteLine($"Nombre: {alumno.Nombre}, Apellido: {alumno.Apellido}, Carnet: {alumno.Carnet}, Fecha de Ingreso: {alumno.FechaIngreso}");
        Console.WriteLine();

        Console.WriteLine("Información del profesor:");
        Console.WriteLine($"Nombre: {profesor.Nombre}, Apellido: {profesor.Apellido}, Título: {profesor.Titulo}, Departamento: {profesor.Departamento}");
    }
}
