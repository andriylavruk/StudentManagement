using StudentManagement.Models;
using System.Data.SqlClient;
using System.Data;

namespace StudentManagement.Repositories;

public class UserRepository : IUserRepository
{
    private readonly string _connectionString;

    public UserRepository(string connectionString)
    {
        _connectionString = connectionString;
    }
    public User? GetUserByEmail(string email)
    {
        var users = new List<User>();

        using (var connection = new SqlConnection(_connectionString))
        using (var command = new SqlCommand())
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = @"SELECT * 
                                    FROM [Users] 
                                    INNER JOIN [Roles] ON [Users].Role_Id = [Roles].Id
                                    WHERE Email=@email";

            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var user = new User()
                    {
                        Id = (int)reader[0],
                        Email = reader[1].ToString()!,
                        PasswordHash = reader[2].ToString()!,
                        Role = new Role()
                        {
                            Id = (int)reader[4],
                            Name = reader[5].ToString()!
                        }
                    };

                    users.Add(user);
                }
            }
        }

        return users.FirstOrDefault();
    }
}
