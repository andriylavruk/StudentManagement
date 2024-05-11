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
    [Browsable(false)]
    public int? GroupId { get; set; }

    [Browsable(false)]
    public Group? StudentGroup { get; set; }

    [DisplayName("Student group")]
    [Required(ErrorMessage = "Group name is requerid")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Surname must be between 3 and 50 characters")]
    public string Group { get => StudentGroup!.Name; }

    public Student(int id, string name, string surname, int? groupId, Group? studentGroup)
    {
        Id = id;
        Name = name;
        Surname = surname;
        GroupId = groupId;
        StudentGroup = studentGroup;
    }
}
