using StudentManagement.Models;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagement.Repositories;

public class GroupRepository : IGroupRepository
{
    private readonly string _connectionString;

    public GroupRepository(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    public void CreateGroup(Group group)
    {
        using (var connection = new SqlConnection(_connectionString))
        using (var command = new SqlCommand())
        {
            connection.Open();

            command.Connection = connection;
            command.CommandText = "INSERT INTO [Groups] VALUES (@name)";
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = group.Name;

            command.ExecuteNonQuery();
        }
    }

    public void DeleteGroup(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        using (var command = new SqlCommand())
        {
            connection.Open();

            command.Connection = connection;
            command.CommandText = "DELETE FROM [Groups] WHERE Id=@id";
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            command.ExecuteNonQuery();
        }
    }

    public void UpdateGroup(Group group)
    {
        using (var connection = new SqlConnection(_connectionString))
        using (var command = new SqlCommand())
        {
            connection.Open();

            command.Connection = connection;
            command.CommandText = @"UPDATE [Groups] 
                                    SET Name=@name
                                    WHERE Id=@id";

            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = group.Name;
            command.Parameters.Add("@id", SqlDbType.Int).Value = group.Id;

            command.ExecuteNonQuery();
        }
    }

    public IEnumerable<Group> GetAllGroups()
    {
        var groupsList = new List<Group>();
        using (var connection = new SqlConnection(_connectionString))
        using (var command = new SqlCommand())
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM [Groups] ORDER BY Name ASC";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var group = new Group();
                    group.Id = (int)reader[0];
                    group.Name = reader[1].ToString()!;

                    groupsList.Add(group);
                }
            }
        }

        return groupsList;
    }

    public IEnumerable<Group> GetGroupByValue(string value)
    {
        var groupsList = new List<Group>();
        string groupName = value;

        using (var connection = new SqlConnection(_connectionString))
        using (var command = new SqlCommand())
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM [Groups] WHERE Name like '%'+@name+'%' ORDER BY Name ASC";

            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = groupName;

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var group = new Group();
                    group.Id = (int)reader[0];
                    group.Name = reader[1].ToString()!;

                    groupsList.Add(group);
                }
            }
        }

        return groupsList;
    }
}
