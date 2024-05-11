using StudentManagement.Models;
using StudentManagement.Presenters;
using StudentManagement.Repositories;
using System.Security.Cryptography;
using System.Text;
namespace StudentManagement.Views;

public partial class LoginForm : Form
{
    private readonly IUserRepository _userRepository;
    private readonly string _sqlConnectionString;

    public LoginForm()
    {
        InitializeComponent();
    }

    public LoginForm(IUserRepository userRepository, string sqlConnectionString)
    {
        InitializeComponent();
        _userRepository = userRepository;
        _sqlConnectionString = sqlConnectionString;
    }

    public User UserInfo { get; set; }

    private void login_btn_Click(object sender, EventArgs e)
    {
        var user = _userRepository.GetUserByEmail(login_email_textBox.Text.Trim());

        if(user is null)
        {
            MessageBox.Show("Invalid email address.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        if (user is not null)
        {
            UserInfo = user;

            if(user.PasswordHash != ComputeSha256Hash(login_password_textBox.Text.Trim()))
            {
                MessageBox.Show("Invalid password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Hide();

                IMainView view = new MainView();
                new MainPresenter(view, this, _sqlConnectionString);
                view.Show();
            }
        }
    }

    private static string ComputeSha256Hash(string rawData)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }

    public void ClearPasswordTextBox()
    {
        login_password_textBox.Text = string.Empty;
    }
}
