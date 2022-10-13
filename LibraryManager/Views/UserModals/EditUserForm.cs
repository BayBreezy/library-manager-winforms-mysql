
using FluentValidation.Results;
using LibraryManager.Models;
using LibraryManager.Services;
using LibraryManager.Utils;

namespace LibraryManager.Views.BookModals
{
    public partial class EditUserForm : Form
    {
        UsersForm parentForm;
        int id;
        public EditUserForm(UsersForm parentForm, User? user)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.id = (int)user.id;

            // Set values in input feild
            nameInput.Text = user.name;
            emailInput.Text = user.email;
            rolePicker.Text = user.role;
        }

        private void updateBookButton_Click(object sender, EventArgs e)
        {
            // declare values
            string name = nameInput.Text.Trim();
            string email = emailInput.Text.Trim();
            string role = rolePicker.Text.Trim();

            //Create user
            //Create user
            User user  = new(id: id, name: name, email: email, role: role);


            // Validate user
            UserUpdateValidation validationRules = new UserUpdateValidation();
            ValidationResult result = validationRules.Validate(user);
            if (!result.IsValid)
            {
                Utils.Utils.ShowMessage(result.Errors[0].ErrorMessage, "Invalid Data", "error");
                return;
            }

            // Update the book
            UserServices.UpdateUser(user);
            //Reload list
            parentForm.LoadUsers();

            // Close 
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = Utils.Utils.ShowMessage("Are you sure?", "Confirm Delete", "question", "yesno");
            if (result != DialogResult.Yes) return;
            // Update the book
            UserServices.DeleteUser(id);
            //Reload list
            parentForm.LoadUsers();

            // Close 
            this.Close();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            // Check if user is admin and hide delete button
            if (User.LoggedInUser.role != "admin")
            {
                deleteButton.Hide();
            }
        }
    }
}
