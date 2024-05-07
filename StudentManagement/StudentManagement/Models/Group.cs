using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentManagement.Models;

public class Group
{
    [DisplayName("Id")]
    public int Id { get; set; }

    [DisplayName("Name")]
    [Required(ErrorMessage = "Group name is requerid")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Group name must be between 3 and 50 characters")]
    public string Name { get; set; } = string.Empty;
}
