
using FluentValidation.Results;
using LibraryManager.Models;
using LibraryManager.Services;
using LibraryManager.Utils;

namespace LibraryManager.Views.BookModals
{
    public partial class EditBookForm : Form
    {
        BooksForm parentForm;
        int id;
        public EditBookForm(BooksForm parentForm, Books? book)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.id = (int)book.id;

            // Set values in input feild
            titleInput.Text = book.title;
            authorInput.Text = book.author;
            pageCountInput.Text = Convert.ToString(book.pageCount);
        }

        private void updateBookButton_Click(object sender, EventArgs e)
        {
            // declare values
            string title = titleInput.Text;
            int pageCount = Convert.ToInt32(pageCountInput.Text);
            string author = authorInput.Text;

            //Create book
            Books book = new(id, title, pageCount, author);

            // Validate book
            BookValidation validationRules = new BookValidation();
            ValidationResult result = validationRules.Validate(book);
            if (!result.IsValid)
            {
                Utils.Utils.ShowMessage(result.Errors[0].ErrorMessage, "Invalid Data", "error");
                return;
            }

            // Update the book
            BookServices.UpdateBook(book);
            //Reload list
            parentForm.LoadBooks();

            // Close 
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = Utils.Utils.ShowMessage("Are you sure?", "Confirm Delete", "question", "yesno");
            if (result != DialogResult.Yes) return;
            // Update the book
            BookServices.DeleteBook(id);
            //Reload list
            parentForm.LoadBooks();

            // Close 
            this.Close();
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            // Check if user is admin and hide delete button
            if(User.LoggedInUser.role != "admin")
            {
                deleteButton.Hide();
            }
        }
    }
}
