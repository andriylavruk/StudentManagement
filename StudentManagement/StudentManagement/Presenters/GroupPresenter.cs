using StudentManagement.Models;
using StudentManagement.Repositories;
using StudentManagement.Views;

namespace StudentManagement.Presenters;

public class GroupPresenter
{
    private IGroupView _groupView;
    private IGroupRepository _groupRepository;
    private BindingSource _groupsBindingSource;
    private IEnumerable<Group> _groupsList;

    public GroupPresenter(IGroupView view, IGroupRepository repository)
    {
        _groupsBindingSource = new BindingSource();
        _groupView = view;
        _groupRepository = repository;
        _groupsList = Enumerable.Empty<Group>();

        _groupView.SearchEvent += SearchGroup;
        _groupView.AddNewEvent += AddNewGroup;
        _groupView.EditEvent += LoadSelectedGroupToEdit;
        _groupView.DeleteEvent += DeleteSelectedGroup;
        _groupView.SaveEvent += SaveGroup;
        _groupView.CancelEvent += CancelAction;
        
        _groupView.SetGroupListBindingSource(_groupsBindingSource);
        
        LoadAllGroupList();
        
        _groupView.Show();
    }

    private void LoadAllGroupList()
    {
        _groupsList = _groupRepository.GetAllGroups();
        _groupsBindingSource.DataSource = _groupsList;
    }
    private void SearchGroup(object sender, EventArgs e)
    {
        bool emptyValue = string.IsNullOrWhiteSpace(_groupView.SearchValue);

        if (emptyValue == false)
        {
            _groupsList = _groupRepository.GetGroupByValue(_groupView.SearchValue);
        }
        else
        {
            _groupsList = _groupRepository.GetAllGroups();
        }

        _groupsBindingSource.DataSource = _groupsList;
    }
    private void AddNewGroup(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void LoadSelectedGroupToEdit(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void SaveGroup(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void CancelAction(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
    private void DeleteSelectedGroup(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}
