namespace StudentManagement.Views;

public partial class MainView : Form, IMainView
{
    public MainView()
    {
        InitializeComponent();
        mainview_groups_btn.Click += delegate { ShowGroupView?.Invoke(this, EventArgs.Empty); };
        mainview_students_btn.Click += delegate { ShowStudentView?.Invoke(this, EventArgs.Empty); };
    }

    public event EventHandler ShowGroupView;
    public event EventHandler ShowStudentView;
}
