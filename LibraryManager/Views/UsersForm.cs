using LibraryManager.Models;
using LibraryManager.Services;
using LibraryManager.Views.BookModals;

namespace LibraryManager.Views
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        public void LoadUsers()
        {
            userGrid.AutoGenerateColumns = false;
            userGrid.ClearSelection();
            userGrid.DataSource = UserServices.GetAllUsers();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm(this);
            createUserForm.ShowDialog();
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            string search = searchInput.Text.Trim();
            if (string.IsNullOrEmpty(search))
            {
                LoadUsers();
                return;
            }

            userGrid.ClearSelection();
            userGrid.DataSource = UserServices.SearchUser(search);
        }

        private void userGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the index
            int index = e.RowIndex;
            // Check if index is out of range
            if (index < 0) return;
            // get the selected row
            DataGridViewRow selectedRow = userGrid.Rows[index];
            //store values in variables
            int id = Convert.ToInt32(selectedRow.Cells["id"].Value.ToString());
            string name = selectedRow.Cells["name"].Value.ToString();
            string role = selectedRow.Cells["role"].Value.ToString();
            string email = selectedRow.Cells["email"].Value.ToString();

            // Show edit form
            User user = new User(id: id, name: name, email: email, role: role);
            EditUserForm editUser = new EditUserForm(this, user);
            editUser.ShowDialog();
        }
    }
}
