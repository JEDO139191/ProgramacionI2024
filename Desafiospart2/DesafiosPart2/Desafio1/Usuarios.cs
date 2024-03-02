using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Usuarios
    {
      public class GestorUsuarios
    {
        private Dictionary<string, string> usuarios = new Dictionary<string, string>();

        public void RegistrarUsuario(string nombre, string contraseña)
        {
          
            if (usuarios.ContainsKey(nombre))
            {
                Console.WriteLine("El nombre de usuario ya está en uso. Por favor, elija otro.");
            }
            else
            {
                usuarios.Add(nombre, contraseña);
                Console.WriteLine("Usuario registrado exitosamente!");
            }
        }

        public bool IniciarSesion(string nombre, string contraseña)
        {
           
            if (usuarios.TryGetValue(nombre, out string savedPassword) && savedPassword == contraseña)
            {
                Console.WriteLine("Inicio de sesión exitoso. ¡Bienvenido, " + nombre + "!");
                return true;
            }
            else
            {
                Console.WriteLine("Credenciales incorrectas. Por favor, inténtelo de nuevo.");
                return false;
            }
        }
    }

}
}
