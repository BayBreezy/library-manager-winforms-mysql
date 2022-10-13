using FluentValidation.Results;
using LibraryManager.Models;
using LibraryManager.Services;
using LibraryManager.Utils;

namespace LibraryManager.Views
{
    public partial class CreateFirstAdminForm : Form
    {
        public CreateFirstAdminForm()
        {
            InitializeComponent();
        }

        private void createAdminButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string email = emailInput.Text;
            string password = passwordInput.Text;
            // Create user object that will be stored
            User adminUser = new User(name, email, password, "admin");
            //Validate
            AdminUserValidation validationRules = new AdminUserValidation();
            ValidationResult result = validationRules.Validate(adminUser);

            // stop function and show feedback
            if (!result.IsValid)
            {
                Utils.Utils.ShowMessage(result.Errors[0].ErrorMessage, "Invalid data", "error");
                return;
            }

            //Create admin user
            bool created = AuthService.CreateFirstAdminUser(adminUser);
            // Send the user to admin page
            if (created)
            {
                this.Hide();
                Admin admin = new();
                admin.ShowDialog();
                this.Close();
            }
        }
    }
}
