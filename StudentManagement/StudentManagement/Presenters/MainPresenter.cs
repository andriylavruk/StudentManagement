using StudentManagement.Repositories;
using StudentManagement.Views;

namespace StudentManagement.Presenters;

public class MainPresenter
{
    private IMainView _mainView;
    private readonly string _sqlConnectionString;

    public MainPresenter(IMainView mainView, string sqlConnectionString)
    {
        _mainView = mainView;
        _sqlConnectionString = sqlConnectionString;

        _mainView.ShowGroupView += ShowGroupsView;
        _mainView.ShowStudentView += GetShowStudentsView;
    }

    private void ShowGroupsView(object sender, EventArgs e)
    {
        IGroupView view = GroupView.GetInstace((MainView)_mainView);
        IGroupRepository groupRepository = new GroupRepository(_sqlConnectionString);
        new GroupPresenter(view, groupRepository);
    }

    private void GetShowStudentsView(object sender, EventArgs e)
    {
        IStudentView view = StudentView.GetInstace((MainView)_mainView);
        IStudentRepository studentRepository = new StudentRepository(_sqlConnectionString);
        IGroupRepository groupRepository = new GroupRepository(_sqlConnectionString);
        new StudentPresenter(view, studentRepository, groupRepository);
    }
}
