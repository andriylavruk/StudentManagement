namespace StudentManagement.Views;

public partial class MainView : Form, IMainView
{
    public MainView()
    {
        InitializeComponent();
        mainview_groups_btn.Click += delegate { ShowGroupView?.Invoke(this, EventArgs.Empty); };
        mainview_students_btn.Click += delegate { ShowStudentView?.Invoke(this, EventArgs.Empty); };
    }

    private LoginForm _loginForm;
    private bool _isLogout { get; set; }

    public event EventHandler ShowGroupView;
    public event EventHandler ShowStudentView;

    public LoginForm LoginForm { get => _loginForm; init => _loginForm = value; }


    public void SetLoginFormInfo(LoginForm loginForm)
    {
        _loginForm = loginForm;
    }

    private void MainView_Load(object sender, EventArgs e)
    {
        mainview_toolStripStatusLabel.Text = $"Login: {LoginForm!.UserInfo.Email} Role: {LoginForm.UserInfo.Role!.Name}";
    }

    private void MainView_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (!_isLogout)
        {
            Application.Exit();
        }
    }

    private void mainview_logout_btn_Click(object sender, EventArgs e)
    {
        _isLogout = true;
        Close();
        LoginForm.ClearPasswordTextBox();
        LoginForm.Show();
    }
}
