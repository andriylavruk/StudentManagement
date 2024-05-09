using System.Data.SqlClient;
using System.Data;
using StudentManagement.Models;

namespace StudentManagement.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly string _connectionString;

    public StudentRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void CreateStudent(Student student)
    {
        throw new NotImplementedException();
    }

    public void DeleteStudent(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateStudent(Student student)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Student> GetAllStudents()
    {
        var studentList = new List<Student>();
        using (var connection = new SqlConnection(_connectionString))
        using (var command = new SqlCommand())
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = @"SELECT * 
                                    FROM [Students]
                                    INNER JOIN [Groups] ON [Students].Group_Id = [Groups].Id
                                    ORDER BY [Students].Name ASC";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    
                    var Id = (int)reader[0];
                    var Name = reader[1].ToString()!;
                    var Surname = reader[2].ToString()!;
                    var GroupId = (int)reader[3];
                     
                    var StudentGroup = new Group()
                    {
                        Id = (int)reader[4],
                        Name = reader[5].ToString()!
                    };

                    var student = new Student(Id, Name, Surname, GroupId, StudentGroup);

                    studentList.Add(student);
                }
            }
        }

        return studentList;
    }

    public IEnumerable<Student> GetStudentByValue(string value)
    {
        var studentList = new List<Student>();
        using (var connection = new SqlConnection(_connectionString))
        using (var command = new SqlCommand())
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM [Groups] WHERE Name like '%'+@name+'%' ORDER BY Name ASC";

            command.CommandText = @"SELECT * 
                                    FROM [Students]
                                    INNER JOIN [Groups] ON [Students].Group_Id = [Groups].Id
                                    WHERE [Students].Name like '%'+@searchvalue+'%' OR [Students].Surname like '%'+@searchvalue+'%' OR [Groups].Name like '%'+@searchvalue+'%'
                                    ORDER BY [Students].Name ASC";

            command.Parameters.Add("@searchvalue", SqlDbType.NVarChar).Value = value;

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var Id = (int)reader[0];
                    var Name = reader[1].ToString()!;
                    var Surname = reader[2].ToString()!;
                    var GroupId = (int)reader[3];

                    var StudentGroup = new Group()
                    {
                        Id = (int)reader[4],
                        Name = reader[5].ToString()!
                    };

                    var student = new Student(Id, Name, Surname, GroupId, StudentGroup);

                    studentList.Add(student);
                }
            }
        }

        return studentList;
    }
}
