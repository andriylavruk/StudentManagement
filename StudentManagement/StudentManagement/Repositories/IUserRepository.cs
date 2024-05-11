using StudentManagement.Models;

namespace StudentManagement.Repositories;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
}
