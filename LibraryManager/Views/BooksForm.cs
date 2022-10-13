using LibraryManager.Models;
using LibraryManager.Services;
using LibraryManager.Views.BookModals;

namespace LibraryManager.Views
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }

        public void LoadBooks()
        {
            bookGrid.AutoGenerateColumns = false;
            bookGrid.ClearSelection();
            bookGrid.DataSource = BookServices.GetAllBooks();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            CreateBookForm createBookForm = new CreateBookForm(this);
            createBookForm.ShowDialog();
        }


        private void bookGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the index
            int index = e.RowIndex;
            // Check if index is out of range
            if (index < 0) return;
            // get the selected row
            DataGridViewRow selectedRow = bookGrid.Rows[index];
            //store values in variables
            int id = Convert.ToInt32(selectedRow.Cells["id"].Value.ToString());
            int pageCount = Convert.ToInt32(selectedRow.Cells["pageCount"].Value.ToString());
            string title = selectedRow.Cells["title"].Value.ToString();
            string author = selectedRow.Cells["author"].Value.ToString();

            // Show edit form
            Books book = new Books(id: id, title: title, pageCount: pageCount, author: author);
            EditBookForm editBooks = new EditBookForm(this, book);
            editBooks.ShowDialog();


        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            string search = searchInput.Text.Trim();
            if (string.IsNullOrEmpty(search))
            {
                LoadBooks();
                return;
            }

            bookGrid.ClearSelection();
            bookGrid.DataSource = BookServices.SearchBook(search);
        }
    }
}
