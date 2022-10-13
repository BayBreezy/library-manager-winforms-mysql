using FluentValidation.Results;
using LibraryManager.Models;
using LibraryManager.Services;
using LibraryManager.Utils;
using LibraryManager.Views;

namespace LibraryManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (!AuthService.CheckForAdmin())
            {
                this.Hide();
                CreateFirstAdminForm createFirstAdminForm = new();
                createFirstAdminForm.ShowDialog();
                this.Close();
            }
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            string email = emailInput.Text;
            string password = passwordInput.Text;

            // Create user object that will be stored
            User newUser = new User(email, password);
            //Validate
            LoginValidation validationRules = new LoginValidation();
            ValidationResult result = validationRules.Validate(newUser);

            // stop function and show feedback
            if (!result.IsValid)
            {
                MessageBox.Show(result.Errors[0].ErrorMessage, "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool loggedIn = AuthService.Login(email, password);
            if (loggedIn)
            {
                this.Hide();
                Admin admin = new();
                admin.ShowDialog();
                this.Close();
            }
        }
    }
}