using StudentManagement.Models;
using StudentManagement.Repositories;
using StudentManagement.Views;

namespace StudentManagement.Presenters;

public class StudentPresenter
{
    private IStudentView _studentView;
    private IStudentRepository _studentRepository;
    private IGroupRepository _groupRepository;
    private BindingSource _studentsBindingSource;
    private BindingSource _groupsBindingSource;
    private IEnumerable<Student> _studentList;
    private IEnumerable<Group> _groupList;

    public StudentPresenter(IStudentView view, IStudentRepository studentRepository, IGroupRepository groupRepository)
    {
        _studentsBindingSource = new BindingSource();
        _groupsBindingSource = new BindingSource();
        _studentView = view;
        _studentRepository = studentRepository;
        _groupRepository = groupRepository;
        _studentList = Enumerable.Empty<Student>();
        _groupList = Enumerable.Empty<Group>();

        _studentView.SearchEvent += SearchStudent;
        _studentView.AddNewEvent += AddNewStudent;
        _studentView.EditEvent += LoadSelectedStudentToEdit;
        _studentView.DeleteEvent += DeleteSelectedStudent;
        _studentView.SaveEvent += SaveStudent;
        _studentView.CancelEvent += CancelAction;

        _studentView.SetStudentListBindingSource(_studentsBindingSource);

        LoadAllStudentList();

        _studentView.Show();
    }

    private void LoadAllStudentList()
    {
        _studentList = _studentRepository.GetAllStudents();
        _groupList = _groupRepository.GetAllGroups();
        _studentsBindingSource.DataSource = _studentList;
    }
    private void SearchStudent(object sender, EventArgs e)
    {
        bool emptyValue = string.IsNullOrWhiteSpace(_studentView.SearchValue);

        if (emptyValue == false)
        {
            _studentList = _studentRepository.GetStudentByValue(_studentView.SearchValue);
        }
        else
        {
            _studentList = _studentRepository.GetAllStudents();
        }

        _studentsBindingSource.DataSource = _studentList;
    }
    private void AddNewStudent(object sender, EventArgs e)
    {
        _studentView.IsEdit = false;
    }

    private void LoadSelectedStudentToEdit(object sender, EventArgs e)
    {
        var student = (Student)_studentsBindingSource.Current;
        _studentView.StudentId = student.Id.ToString();
        _studentView.StudentName = student.Name;
        _studentView.StudentSurname = student.Surname;
        _studentView.StudentGroupId = student.GroupId.ToString()!;
        _studentView.StudentGroup = student.StudentGroup!;

        var list = _groupList.ToList();
        var index = list.FindIndex(x => x.Id == student.StudentGroup!.Id);

        var item = list[index];
        list[index] = list[0];
        list[0] = item;

        _groupsBindingSource.DataSource = null;
        _groupsBindingSource.DataSource = list;
        _studentView.SetComboBoxData(_groupsBindingSource);

        _studentView.IsEdit = true;
    }

    private void SaveStudent(object sender, EventArgs e)
    {
        var Id = Convert.ToInt32(_studentView.StudentId);
        var Name = _studentView.StudentName;
        var Surname = _studentView.StudentSurname;
        var GroupId = Convert.ToInt32(_studentView.StudentGroupId);
        var StudentGroup = _studentView.StudentGroup;

        var model = new Student(Id, Name, Surname, GroupId, StudentGroup);

        try
        {
            new Common.ModelDataValidation().Validate(model);

            if (_studentView.IsEdit)
            {
                _studentRepository.UpdateStudent(model);
                _studentView.Message = "Student updated successfuly";
            }
            else
            {
                _studentRepository.CreateStudent(model);
                _studentView.Message = "Student created sucessfully";
            }

            _studentView.IsSuccessful = true;
            LoadAllStudentList();
            CleanviewFields();
        }
        catch (Exception ex)
        {
            _studentView.IsSuccessful = false;
            _studentView.Message = ex.Message;
        }
    }
    private void CleanviewFields()
    {
        _studentView.StudentId = "0";
        _studentView.StudentName = string.Empty;
        _studentView.StudentSurname = string.Empty;
        _studentView.StudentGroupId = string.Empty;
        _studentView.StudentGroup = default;
    }

    private void CancelAction(object sender, EventArgs e)
    {
        CleanviewFields();
    }

    private void DeleteSelectedStudent(object sender, EventArgs e)
    {
        try
        {
            var student = (Student)_studentsBindingSource.Current;

            _studentRepository.DeleteStudent(student.Id);
            _studentView.IsSuccessful = true;
            _studentView.Message = "Student deleted successfully";

            LoadAllStudentList();
        }
        catch (Exception)
        {
            _studentView.IsSuccessful = false;
            _studentView.Message = "An error ocurred, could not delete student";
        }

    }
}
