using FluentValidation.Results;
using LibraryManager.Models;
using LibraryManager.Services;
using LibraryManager.Utils;

namespace LibraryManager.Views.BookModals
{
    public partial class CreateUserForm : Form
    {
        UsersForm parentForm;
        public CreateUserForm(UsersForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }


        private void createUserButton_Click(object sender, EventArgs e)
        {
            // declare values
            string name = nameInput.Text.Trim();
            string password = passwordInput.Text;
            string email = emailInput.Text.Trim();
            string role = rolePicker.Text.Trim();


            //Create user
            User user = new(name: name, password: password, email: email, role: role);
            // Validate book
            UserValidation validationRules = new UserValidation();
            ValidationResult result = validationRules.Validate(user);
            if (!result.IsValid)
            {
                Utils.Utils.ShowMessage(result.Errors[0].ErrorMessage, "Invalid Data", "error");
                return;
            }
            // Create the user
            User? createdUser = UserServices.CreateUser(user);
            if (createdUser == null) return;
            //Reload list
            parentForm.LoadUsers();

            // Close 
            this.Close();
        }
    }
}
