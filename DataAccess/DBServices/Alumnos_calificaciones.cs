using Common;
using DataAccess.DBServices.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBServices
{
    public class Alumnos_calificaciones : ConnectionToSql
    {



        public int CreateCalificacion(string Carnet, string Espanol, string Ingles, string Matematica, string Ciencias_N, string Ciencias_S, string Computacion, string Contabilidad, string Fisica )
        {
            int result = -1;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"insert into Calificaciones_alumnos
	                                        values (@carnet,@espanol, @ingles, @matematica,@ciencias_n,@ciencias_s,@computacion,@contabilidad,@fisica)";
                    command.Parameters.AddWithValue("@carnet", Carnet);
                    command.Parameters.AddWithValue("@espanol", Espanol);
                    command.Parameters.AddWithValue("@ingles", Ingles);
                    command.Parameters.AddWithValue("@matematica", Matematica);
                    command.Parameters.AddWithValue("@ciencias_n", Ciencias_N);
                    command.Parameters.AddWithValue("@ciencias_s", Ciencias_S);
                    command.Parameters.AddWithValue("@computacion", Computacion);
                    command.Parameters.AddWithValue("@contabilidad", Contabilidad);
                    command.Parameters.AddWithValue("@fisica", Fisica);
                    
                    command.CommandType = CommandType.Text;
                    result = command.ExecuteNonQuery();
                }
            }
            return result;
        }
        public int ModifyUser(Alumno alumno)
        {
            int result = -1;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //update para alumnos
                    command.Connection = connection;
                    command.CommandText = @"update  alumnos	
	                                        set Nombre=@nombre,@apellido, @carnet, @fecha_inscripcion,@fecha_nacimiento,@grado,@seccion,@numero_encargado,@nombre_encargado,@check_pago  
	                                        where Numero=@numero ";
                    command.Parameters.AddWithValue("@numero", alumno.Numero);
                    command.Parameters.AddWithValue("@nombre", alumno.Nombre);
                    command.Parameters.AddWithValue("@apellido", alumno.Apellido);
                    command.Parameters.AddWithValue("@carnet", alumno.Carnet);
                    command.Parameters.AddWithValue("@fecha:inscripcion", alumno.Fecha_Inscripcion);
                    command.Parameters.AddWithValue("@fecha_nacimiento", alumno.Fecha_Nacimiento);
                    command.Parameters.AddWithValue("@grado", alumno.Grado);
                    command.Parameters.AddWithValue("@seccion", alumno.Seccion);
                    command.Parameters.AddWithValue("@numero_encargado", alumno.Numero_Encargado);
                    command.Parameters.AddWithValue("@nombre_encargado", alumno.Nombre_Encargado);
                    command.Parameters.AddWithValue("@check_pago", alumno.Pago);



                    command.CommandType = CommandType.Text;
                    result = command.ExecuteNonQuery();
                }
            }
            return result;
        }
        public int RemoveUser(int id)
        {
            int result = -1;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"delete from Users where id=@id ";
                    command.Parameters.AddWithValue("@id", id);

                    command.CommandType = CommandType.Text;
                    result = command.ExecuteNonQuery();
                }
            }
            return result;
        }
        public Alumno GetAlumnoByNum(int Numero)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from alumnos where Numero=@numero";
                    command.Parameters.AddWithValue("@numero", Numero);
                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var AlumnoObj = new Alumno
                        {
                            Numero = (int)reader[0],
                            Nombre = reader[1].ToString(),
                            Apellido = reader[2].ToString(),
                            Carnet = reader[3].ToString(),
                            Fecha_Inscripcion = Convert.ToDateTime(reader[4].ToString()),
                            Fecha_Nacimiento = Convert.ToDateTime(reader[5].ToString()),
                            Grado = reader[6].ToString(),
                            Seccion = reader[7].ToString(),
                            Numero_Encargado = reader[8].ToString(),
                            Nombre_Encargado = reader[9].ToString(),
                            Pago = Convert.ToBoolean(reader[10].ToString())

                        };
                        return AlumnoObj;
                    }
                    else
                        return null;
                }
            }
        }
        public User GetUserByUsername(string user)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Users where username=@user or email=@user";
                    command.Parameters.AddWithValue("@user", user);
                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var userObj = new User
                        {
                            Id = (int)reader[0],
                            Username = reader[1].ToString(),
                            Password = reader[2].ToString(),
                            FirstName = reader[3].ToString(),
                            LastName = reader[4].ToString(),
                            Position = reader[5].ToString(),
                            Email = reader[6].ToString(),
                            Photo = reader[7] != DBNull.Value ? (byte[])reader[7] : null
                        };
                        return userObj;
                    }
                    else
                        return null;
                }
            }
        }
        public DataTable GetAllAlumnos()
        {
            DataTable Alumno = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from alumnos where Carnet=@carnet";
                    command.CommandType = CommandType.Text;

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

                    sqlDataAdapter.Fill(Alumno);
                }
            }
            return Alumno;
        }
        public DataTable GetAllCalificaciones()
        {
            DataTable Calificaciones = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Calificaciones_alumnos";
                    command.CommandType = CommandType.Text;

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

                    sqlDataAdapter.Fill(Calificaciones);
                }
            }
            return Calificaciones;
        }
    }
}

