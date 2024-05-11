using Microsoft.Extensions.Configuration;
using StudentManagement.Presenters;
using StudentManagement.Repositories;
using StudentManagement.Views;

namespace StudentManagement;

internal static class Program
{
    public static IConfiguration? Configuration;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        Configuration = builder.Build();
        var sqlConnectionString = Configuration.GetConnectionString("DefaultConnection")!;

        IUserRepository userRepository = new UserRepository(sqlConnectionString);

        Application.Run(new LoginForm(userRepository, sqlConnectionString));
    }
}