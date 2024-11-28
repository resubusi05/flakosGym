using flakosGym.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System;

namespace flakosGym.Repositories
{
    public class UserRepository : RepositoryBase, IUserRepository
    {
        public void Add(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public bool AuthenticateUser(NetworkCredential credential)
        {
            bool valiUser;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select 1 from [User] where username=@username and [password]=@password";
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = credential.UserName;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = credential.Password;
                valiUser = command.ExecuteScalar() != null;
            }
            return valiUser;
        }

        public void Edit(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetByAll()
        {
            throw new NotImplementedException();
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel GetByUserName(string username)
        {
            UserModel user = null;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from [User] where username=@Username";
                command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new UserModel()
                        {
                            Id = reader["Id"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = string.Empty, // Seguridad
                            Name = reader["Name"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Obejetivo = reader["Objective"].ToString(),
                            FechaDeNacimiento = reader["BirthDate"].ToString(),
                            Genero = reader["Gender"].ToString(),
                            Telefono = reader["Phone"].ToString(),
                        };
                    }
                }
            }
            return user;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void add(UserModel userModel)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO [User] (Username, Password, Name, LastName, Email, Objetivo, FechaDeNacimiento, Genero, Telefono) " +
                                      "VALUES (@Username, @Password, @Name, @LastName, @Email, @Objective, @BirthDate, @Gender, @Phone)";
                command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = userModel.Username;
                command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = userModel.Password;  
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = userModel.Name;
                command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = userModel.LastName;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = userModel.Email;
                command.Parameters.Add("@Objetivo", SqlDbType.NVarChar).Value = userModel.Obejetivo;
                command.Parameters.Add("@FechaDeNacimiento", SqlDbType.Date).Value = userModel.FechaDeNacimiento;
                command.Parameters.Add("@Genero", SqlDbType.NVarChar).Value = userModel.Genero;
                command.Parameters.Add("@Telefono", SqlDbType.NVarChar).Value = userModel.Telefono;

                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<UserModel> GetAll()
        {
            List<UserModel> users = new List<UserModel>();

            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [User]";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var user = new UserModel()
                        {
                            Id = reader["Id"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = string.Empty, // Seguridad
                            Name = reader["Name"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Obejetivo = reader["Objetivo"].ToString(),
                            FechaDeNacimiento = reader["FechaDeNacimiento"].ToString(),
                            Genero = reader["Genero"].ToString(),
                            Telefono = reader["Telefono"].ToString(),
                        };
                        users.Add(user);
                    }
                }
            }
            return users;
        }


    }
}

