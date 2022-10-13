using LibraryManager.Models;

namespace LibraryManager.Views
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // Check if a user is logged in
            if (User.LoggedInUser is null)
            {
                MessageBox.Show("You are not allowed to view this data. Please log in to continue.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Shut down the application
                Application.Exit();
                Environment.Exit(0);
            }
            // Check if admin user & hide users button
            if(User.LoggedInUser.role != "admin")
            {
                usersButton.Hide();
            }

            //Set the welcome message and the title fo the form
            usernameLabel.Text = $"{User.LoggedInUser.name}";

            // Load the dashboard form
            Utils.Utils.DisplayAdminForm(new Dashboard(), formHolderPanel);
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            // Load the dashboard form
            Utils.Utils.DisplayAdminForm(new Dashboard(), formHolderPanel);
        }

        private void booksButton_Click(object sender, EventArgs e)
        {
            // Load the books form
            Utils.Utils.DisplayAdminForm(new BooksForm(), formHolderPanel);
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            // Load the users form
            Utils.Utils.DisplayAdminForm(new UsersForm(), formHolderPanel);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Clear logged in user and show login page
            LoginForm loginForm = new();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
            User.LoggedInUser = null;
        }
    }
}
