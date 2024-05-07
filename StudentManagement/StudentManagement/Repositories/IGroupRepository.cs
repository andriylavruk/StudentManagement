using System.Text.RegularExpressions;

namespace StudentManagement.Repositories;

public interface IGroupRepository
{
    void CreateGroup(Group group);
    void UpdateGroup(Group group);
    void DeleteGroup(int id);
    IEnumerable<Group> GetAllGroups();
    IEnumerable<Group> GetGroupByValue(string value);
}
