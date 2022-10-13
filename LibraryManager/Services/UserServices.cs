using LibraryManager.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace LibraryManager.Services
{
    public class UserServices
    {

        /// <summary>
        /// Method used to get a user by email
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Returns a user if one exist or null</returns>
        public static User? GetUserByEmail(string email)
        {
            try
            {
                // Query
                string query = $"SELECT * FROM users WHERE email=@email limit 1";
                // Create command
                MySqlCommand cmd = new MySqlCommand(query, Connection.Connection.OpenConnection());
                // Set params
                cmd.Parameters.AddWithValue("@email", email);

                //Variable used to store user found
                User? user = null;
                // Execute reader
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // create the user
                    user = new User(
                        id: Convert.ToInt32(reader["id"].ToString()),
                        name: reader["name"].ToString(),
                        email: reader["email"].ToString(),
                        password: reader["password"].ToString(),
                        role: reader["role"].ToString());
                }
                reader.Close();
                return user;
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
        /// Method used to create a new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns>The created user</returns>
        public static User? CreateUser(User user)
        {
            try
            {
                // Check if the user is taken 
                User? emailTaken = GetUserByEmail(user.email);
                if (emailTaken is not null)
                {
                    Utils.Utils.ShowMessage("This email is already taken", "Email Taken", "error", "ok");
                    return null;
                }
                // Encrypt the password
                string encryptedPassword = Utils.Utils.Encrypt(user.password);

                // Save the user in the database
                string createQuery = $"INSERT INTO users (name, email, password, role) values(@name, @email,@password,@role)";
                MySqlCommand cmdCreate = new MySqlCommand(createQuery, Connection.Connection.OpenConnection());
                // Set params
                cmdCreate.Parameters.AddWithValue("@email", user.email);
                cmdCreate.Parameters.AddWithValue("@name", user.name);
                cmdCreate.Parameters.AddWithValue("@password", encryptedPassword);
                cmdCreate.Parameters.AddWithValue("@role", user.role);

                // Sedn query
                cmdCreate.ExecuteNonQuery();

                User createdUser = GetUserByEmail(user.email);
                return createdUser;
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
        /// Method used to count the number of users in the system
        /// </summary>
        /// <returns></returns>
        public static string CountUsers()
        {
            try
            {
                // Query
                string query = $"SELECT COUNT(*) FROM users";
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

        public static DataTable GetAllUsers()
        {
            try
            {
                // Query
                string query = $"SELECT *, count(books.createdBy) as booksCreated FROM users left join books on users.id = books.createdBy group by users.id limit 20";
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

        public static DataTable SearchUser(string search)
        {
            try
            {
                // Query
                string query = $"SELECT *, count(books.createdBy) as booksCreated FROM users left join books on users.id = books.createdBy WHERE users.name LIKE @search group by users.id limit 20";
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

        public static void UpdateUser(User user)
        {
            try
            {
                //Create the query
                string query = "UPDATE users SET name=@name, email=@email, role=@role WHERE id=@id";
                // Create command
                MySqlCommand cmd = new MySqlCommand(query, Connection.Connection.OpenConnection());
                // Set params
                cmd.Parameters.AddWithValue("@name", user.name);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@role", user.role);
                cmd.Parameters.AddWithValue("@id", user.id);
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

        public static void DeleteUser(int id)
        {
            try
            {
                //Create the query
                string query = "DELETE FROM users WHERE role <> 'admin' and id = @id";
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
    }
}
