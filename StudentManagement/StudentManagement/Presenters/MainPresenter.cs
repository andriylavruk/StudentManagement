using StudentManagement.Repositories;
using StudentManagement.Views;

namespace StudentManagement.Presenters;

public class MainPresenter
{
    private IMainView _mainView;
    private LoginForm _loginForm;
    private readonly string _sqlConnectionString;

    public MainPresenter(IMainView mainView, LoginForm loginForm, string sqlConnectionString)
    {
        _mainView = mainView;
        _loginForm = loginForm;
        _sqlConnectionString = sqlConnectionString;

        _mainView.ShowGroupView += ShowGroupsView;
        _mainView.ShowStudentView += GetShowStudentsView;

        _mainView.SetLoginFormInfo(loginForm);
    }

    private void ShowGroupsView(object sender, EventArgs e)
    {
        IGroupView view = GroupView.GetInstace((MainView)_mainView);
        IGroupRepository groupRepository = new GroupRepository(_sqlConnectionString);
        new GroupPresenter(view, _loginForm.UserInfo, groupRepository);
    }

    private void GetShowStudentsView(object sender, EventArgs e)
    {
        IStudentView view = StudentView.GetInstace((MainView)_mainView);
        IStudentRepository studentRepository = new StudentRepository(_sqlConnectionString);
        IGroupRepository groupRepository = new GroupRepository(_sqlConnectionString);
        new StudentPresenter(view, studentRepository, groupRepository);
    }
}
