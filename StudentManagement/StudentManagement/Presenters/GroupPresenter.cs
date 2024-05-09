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
        _groupView.IsEdit = false;
    }

    private void LoadSelectedGroupToEdit(object sender, EventArgs e)
    {
        var group = (Group)_groupsBindingSource.Current;
        _groupView.GroupId = group.Id.ToString();
        _groupView.GroupName = group.Name;
        _groupView.IsEdit = true;
    }

    private void SaveGroup(object sender, EventArgs e)
    {
        var model = new Group();
        model.Id = Convert.ToInt32(_groupView.GroupId);
        model.Name = _groupView.GroupName;

        try
        {
            new Common.ModelDataValidation().Validate(model);

            if (_groupView.IsEdit)
            {
                _groupRepository.UpdateGroup(model);
                _groupView.Message = "Group updated successfuly";
            }
            else
            {
                _groupRepository.CreateGroup(model);
                _groupView.Message = "Group created sucessfully";
            }

            _groupView.IsSuccessful = true;
            LoadAllGroupList();
            CleanviewFields();
        }
        catch (Exception ex)
        {
            _groupView.IsSuccessful = false;
            _groupView.Message = ex.Message;
        }
    }
    private void CleanviewFields()
    {
        _groupView.GroupId = "0";
        _groupView.GroupName = string.Empty;
    }

    private void CancelAction(object sender, EventArgs e)
    {
        CleanviewFields();
    }

    private void DeleteSelectedGroup(object sender, EventArgs e)
    {
        try
        {
            var group = (Group)_groupsBindingSource.Current;

            _groupRepository.DeleteGroup(group.Id);
            _groupView.IsSuccessful = true;
            _groupView.Message = "Group deleted successfully";

            LoadAllGroupList();
        }
        catch (Exception)
        {
            _groupView.IsSuccessful = false;
            _groupView.Message = "An error ocurred, could not delete group";
        }

    }
}
