using System.ComponentModel;

namespace StudentManagement.Models;

public class Role
{
    [DisplayName("Id")]
    public int Id { get; set; }

    [DisplayName("Role name")]
    public string Name { get; set; } = string.Empty;
}
