namespace StudentManagement.Views;

public interface IMainView
{
    LoginForm LoginForm { get; init; }

    event EventHandler ShowGroupView;
    event EventHandler ShowStudentView;

    void SetLoginFormInfo(LoginForm loginForm);
    void Show();
}
