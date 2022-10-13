using LibraryManager.Services;

namespace LibraryManager.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            userCountLabel.Text = UserServices.CountUsers();
            bookCountLabel.Text = BookServices.CountBooks();
        }
    }
}
