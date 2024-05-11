using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentManagement.Models;

public class User
{
    [DisplayName("Id")]
    public int Id { get; set; }

    [DisplayName("Email")]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [DisplayName("Password hash")]
    public string PasswordHash { get; set; } = string.Empty;

    [DisplayName("RoleId")]
    [Browsable(false)]
    public int? RoleId { get; set; }

    [Browsable(false)]
    public Role? Role { get; set; }
}
