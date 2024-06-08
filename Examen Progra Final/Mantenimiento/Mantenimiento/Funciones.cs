using PruebaCRUD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantenimiento
{
    public class funciones

    {
        public static int AgregarPersona(Producto producto)
        {
            int retorna = 0;
            using (SqlConnection conn = BDGeneral.BDConectar())
            {
                SqlCommand sqlCommand = conn.CreateCommand();
                string query = "insert into Producto (nombre,precio,existencia) values('" + producto.Id + "', " + producto.Existencia + ",'" +producto.Precio + "')";
                SqlCommand comando = new SqlCommand(query, conn);
                retorna = comando.ExecuteNonQuery();

            }
            return retorna;
        }
        public static List<Producto> PresentarGrid()
        {
            List<Producto> Lista = new List<Producto>();
            using (SqlConnection conec = BDGeneral.BDConectar())
            {
                string query = "select *from Producto";
                SqlCommand sqlCommand = new SqlCommand(query, conec);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Producto producto = new Producto();
                    producto.Id = reader.GetInt32(0);
                    producto.Nombre = reader.GetString(1);
                    producto.Existencia = reader.GetInt32(2);
                    producto.Precio = reader.GetDecimal(3);

                    Lista.Add(producto);

                }
                conec.Close();
                return Lista;
            }
        }
        public static int Modificar(Producto producto)
        {
            int result = 0;
            using (SqlConnection connection = BDGeneral.BDConectar())
            {
                string query = "update Producto set nombre ='" + producto.Id + "',edad = '" + producto.Existencia + "',numero = '" + producto.Precio + "' where id=" + producto.Existencia + " ";
                SqlCommand sqlCommand1 = new SqlCommand(query, connection);
                result = sqlCommand1.ExecuteNonQuery();
                connection.Close();


            }
            return result;
        }
        public static int EliminarProducto(int id)
        {
            int retorna = 0;
            using (SqlConnection conn = BDGeneral.BDConectar())
            {
                SqlCommand sqlCommand = conn.CreateCommand();
                string query = "delete from Producto where id=" + id + "";
                SqlCommand comando = new SqlCommand(query, conn);
                retorna = comando.ExecuteNonQuery();

            }
            return retorna;
        }
    }
}
