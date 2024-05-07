using StudentManagement.Models;

namespace StudentManagement.Repositories;

public interface IStudentRepository
{
    void CreateStudent(Student student);
    void UpdateStudent(Student student);
    void DeleteStudent(int id);
    IEnumerable<Student> GetAllStudents();
    IEnumerable<Student> GetStudentByValue(string value);
}
