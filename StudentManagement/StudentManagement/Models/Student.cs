using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models;

public class Student
{
    [DisplayName("Id")]
    public int Id { get; set; }

    [DisplayName("Name")]
    [Required(ErrorMessage = "Name is requerid")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
    public string Name { get; set; } = string.Empty;

    [DisplayName("Surname")]
    [Required(ErrorMessage = "Surname is requerid")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Surname must be between 3 and 50 characters")]
    public string Surname { get; set; } = string.Empty;

    [DisplayName("GroupId")]
    public int? GroupId { get; set; }

    [DisplayName("Student group")]
    public Group? StudentGroup { get; set; }
}
