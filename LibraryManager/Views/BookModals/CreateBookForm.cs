using FluentValidation.Results;
using LibraryManager.Models;
using LibraryManager.Services;
using LibraryManager.Utils;

namespace LibraryManager.Views.BookModals
{
    public partial class CreateBookForm : Form
    {
        BooksForm parentForm;
        public CreateBookForm(BooksForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void createBookButton_Click(object sender, EventArgs e)
        {
            // declare values
            string title = titleInput.Text;
            int pageCount = Convert.ToInt32(pageCountInput.Text);
            string author = authorInput.Text;

            //Create book
            Books book = new(title, pageCount, author);
            // Validate book
            BookValidation validationRules = new BookValidation();
            ValidationResult result = validationRules.Validate(book);
            if (!result.IsValid)
            {
                Utils.Utils.ShowMessage(result.Errors[0].ErrorMessage, "Invalid Data", "error");
                return;
            }
            // Create the book
            BookServices.CreateBook(book);
            //Reload list
            parentForm.LoadBooks();

            // Close 
            this.Close();
        }
    }
}
