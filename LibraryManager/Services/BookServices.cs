using LibraryManager.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace LibraryManager.Services
{
    public class BookServices
    {

        /// <summary>
        /// Method used to get the nuumber of books in the database
        /// </summary>
        /// <returns></returns>
        public static string CountBooks()
        {
            try
            {
                // Query
                string query = $"SELECT COUNT(*) FROM books";
                // Create command
                MySqlCommand cmd = new MySqlCommand(query, Connection.Connection.OpenConnection());

                // Execute query & return value
                return Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Connection.CloseConnection();
            }
        }

        /// <summary>
        /// Method used to get all books in the database
        /// </summary>
        /// <returns> MySqlDataReader with results</returns>
        public static DataTable GetAllBooks()
        {
            try
            {
                // Query
                string query = $"SELECT * FROM books inner join users on users.id = books.createdBy limit 20";
                // Create command
                MySqlCommand cmd = new MySqlCommand(query, Connection.Connection.OpenConnection());

                // Execute query & return value
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Connection.CloseConnection();
            }
        }

        /// <summary>
        /// Method used to create a book
        /// </summary>
        /// <param name="book"></param>
        public static void CreateBook(Books book)
        {
            try
            {
                //Create the query
                string query = "INSERT INTO books (title, author, pageCount, createdBy) values(@title, @author, @pageCount, @createdBy)";
                // Create command
                MySqlCommand cmd = new MySqlCommand(query, Connection.Connection.OpenConnection());
                // Set params
                cmd.Parameters.AddWithValue("@title", book.title);
                cmd.Parameters.AddWithValue("@author", book.author);
                cmd.Parameters.AddWithValue("@pageCount", book.pageCount);
                cmd.Parameters.AddWithValue("@createdBy", User.LoggedInUser.id);
                //Execute query
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Connection.CloseConnection();
            }
        }

        /// <summary>
        /// Method used to update a book
        /// </summary>
        /// <param name="book"></param>
        public static void UpdateBook(Books book)
        {
            try
            {
                //Create the query
                string query = "UPDATE books SET title=@title, author=@author, pageCount=@pageCount WHERE id=@id";
                // Create command
                MySqlCommand cmd = new MySqlCommand(query, Connection.Connection.OpenConnection());
                // Set params
                cmd.Parameters.AddWithValue("@title", book.title);
                cmd.Parameters.AddWithValue("@author", book.author);
                cmd.Parameters.AddWithValue("@pageCount", book.pageCount);
                cmd.Parameters.AddWithValue("@id", book.id);
                //Execute query
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Connection.CloseConnection();
            }
        }

        /// <summary>
        /// Method used to delete a book
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteBook(int id)
        {
            try
            {
                //Create the query
                string query = "DELETE from books WHERE id=@id";
                // Create command
                MySqlCommand cmd = new MySqlCommand(query, Connection.Connection.OpenConnection());
                // Set params
                cmd.Parameters.AddWithValue("@id", id);
                //Execute query
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Connection.CloseConnection();
            }
        }

        /// <summary>
        /// Method used to search for a book
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public static DataTable SearchBook(string search)
        {
            try
            {
                // Query
                string query = $"SELECT * FROM books inner join users on users.id = books.createdBy WHERE title LIKE @search limit 20";
                // Create command
                MySqlCommand cmd = new MySqlCommand(query, Connection.Connection.OpenConnection());
                //Add params
                cmd.Parameters.AddWithValue("@search", $"%{search}%");
                // Execute query & return value
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Connection.CloseConnection();
            }
        }
    }
}
