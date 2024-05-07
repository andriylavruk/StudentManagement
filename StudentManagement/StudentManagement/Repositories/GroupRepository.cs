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
        throw new NotImplementedException();
    }
    public void DeleteGroup(int id)
    {
        throw new NotImplementedException();
    }
    public void UpdateGroup(Group group)
    {
        throw new NotImplementedException();
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
