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
    public class UserDao : ConnectionToSql
    {
        
        public User Login(string username, string password)
        {

            using (var connection = GetConnection()) 
            {
                connection.Open(); 
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    
                    command.CommandText = "select *from Users where (userName=@username and password=@pass) or (Email=@username and password=@pass)";
                    
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@pass", password);
                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var userObj = new User 
                        {
                            Id = (int)reader[0], 
                            Username = reader[1].ToString(),
                            FirstName = reader[3].ToString(),
                            LastName = reader[4].ToString(),
                            Position = reader[5].ToString(),
                            Email = reader[6].ToString(),
                            Photo = reader[7] != DBNull.Value ? (byte[])reader[7] : null 
                        };
                        ActiveUser.Id = userObj.Id;                      
                        ActiveUser.Position = userObj.Position;
                        ActiveUser.Username = username;

                        return userObj; 
                    }
                    else
                        return null;
                }
            }
        }
        public bool ValidateActiveUser()
        {
            bool validUser = false;
            string activeUserPass = "";
            if (string.IsNullOrWhiteSpace(ActiveUser.Username) == false) 
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select password from Users where id=@id";
                        command.Parameters.AddWithValue("@id", ActiveUser.Id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                                activeUserPass = reader[0].ToString();
                            command.Parameters.Clear();
                        }
                        command.CommandText = "select *from Users where userName=@username or Email=@username and Password=@pass and Id=@id";
                        command.Parameters.AddWithValue("@username", ActiveUser.Username);
                        command.Parameters.AddWithValue("@pass", activeUserPass);
                        command.Parameters.AddWithValue("@id", ActiveUser.Id);

                        command.CommandType = CommandType.Text;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) 
                                validUser = true;
                            else 
                                validUser = false;
                        }
                    }
                }
            }
            return validUser; 
        }
        public int CreateUser(User user)
        {
            int result = -1;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"insert into Users 
	                                        values (@userName,@password, @firstName, @lastName,@position,@email,@photo)";
                    command.Parameters.AddWithValue("@userName", user.Username);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@firstName", user.FirstName);
                    command.Parameters.AddWithValue("@lastName", user.LastName);
                    command.Parameters.AddWithValue("@position", user.Position);
                    command.Parameters.AddWithValue("@email", user.Email);
                    if (user.Photo != null)
                        command.Parameters.Add(new SqlParameter("@photo", user.Photo) { SqlDbType = SqlDbType.VarBinary });
                    else 
                        command.Parameters.Add(new SqlParameter("@photo", DBNull.Value) { SqlDbType = SqlDbType.VarBinary });

                    command.CommandType = CommandType.Text;
                    result = command.ExecuteNonQuery(); 
                }
            }
            return result;
        }
        public int ModifyUser(User user)
        {
            int result = -1;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"update  Users	
	                                        set userName=@userName,password=@password,firstName=@firstName,lastName= @lastName,position= @position,email=@email, profilePicture=@photo  
	                                        where id=@id ";
                    command.Parameters.AddWithValue("@id", user.Id);
                    command.Parameters.AddWithValue("@userName", user.Username);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@firstName", user.FirstName);
                    command.Parameters.AddWithValue("@lastName", user.LastName);
                    command.Parameters.AddWithValue("@position", user.Position);
                    command.Parameters.AddWithValue("@email", user.Email);
                    if (user.Photo != null)
                        command.Parameters.Add(new SqlParameter("@photo", user.Photo) { SqlDbType = SqlDbType.VarBinary });
                    else
                        command.Parameters.Add(new SqlParameter("@photo", DBNull.Value) { SqlDbType = SqlDbType.VarBinary });

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
        public User GetUserById(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Users where id=@id";
                    command.Parameters.AddWithValue("@id", id);
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
        public IEnumerable<User> GetAllUsers()
        {
            var userList = new List<User>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Users ";
                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
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
                            userList.Add(userObj);
                        }
                    }
                }
            }
            return userList; 
        }
    }
}
