using StudentManagement.Models;

namespace StudentManagement.Views;

public interface IStudentView
{
    string StudentId { get; set; }
    string StudentName { get; set; }
    string StudentSurname { get; set; }
    string StudentGroupId { get; set; }
    Group? StudentGroup { get; set; }

    string SearchValue { get; set; }
    bool IsEdit { get; set; }
    bool IsSuccessful { get; set; }
    string Message { get; set; }

    event EventHandler SearchEvent;
    event EventHandler AddNewEvent;
    event EventHandler EditEvent;
    event EventHandler DeleteEvent;
    event EventHandler SaveEvent;
    event EventHandler CancelEvent;

    void SetComboBoxData(BindingSource groups);
    void SetStudentListBindingSource(BindingSource studentList);
    void Show();
}
