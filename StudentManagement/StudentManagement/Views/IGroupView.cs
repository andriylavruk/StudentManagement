using StudentManagement.Models;

namespace StudentManagement.Views;

public interface IGroupView
{
    string GroupId { get; set; }
    string GroupName { get; set; }
    string SearchValue { get; set; }
    bool IsEdit { get; set; }
    bool IsSuccessful { get; set; }
    string Message { get; set; }
    User UserInfo { get; init; }

    event EventHandler SearchEvent;
    event EventHandler AddNewEvent;
    event EventHandler EditEvent;
    event EventHandler DeleteEvent;
    event EventHandler SaveEvent;
    event EventHandler CancelEvent;

    void SetUserInfo(User user);
    void SetGroupListBindingSource(BindingSource groupList);
    void Show();
}
