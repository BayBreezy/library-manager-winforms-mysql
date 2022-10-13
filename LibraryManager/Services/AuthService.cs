using LibraryManager.Models;
using MySql.Data.MySqlClient;

namespace LibraryManager.Services
{

    public class AuthService
    {
        /// <summary>
        /// Method used to log a user in
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>Boolean indicating that if the user was logged in or not.</returns>
        /// <exception cref="Exception"></exception>
        public static bool Login(string email, string password)
        {
            try
            {
                // Get the user by email
                User? user = UserServices.GetUserByEmail(email);

                // If passwordFound is null, no user was found
                if (user is null)
                {
                    Utils.Utils.ShowMessage("Invalid Credentials", "Login Failed", "error");
                    return false;
                }
                // Check if password is correct
                // Decrypt the password
                string decryptedPassword = Utils.Utils.Decrypt(user.password);
                if (decryptedPassword != password)
                {
                    Utils.Utils.ShowMessage("Invalid Credentials", "Login Failed", "error");
                    return false;
                }
                // Set the logged in user
                User.LoggedInUser = user;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Method used to check if an admin is in the system
        /// 
        /// </summary>
        /// <returns>
        /// True if there is an admin user in the system
        /// False if there is no admin user
        /// </returns>
        public static bool CheckForAdmin()
        {
            try
            {
                // Query
                string query = "SELECT * FROM users WHERE role='admin' limit 1";
                // Create command
                MySqlCommand cmd = new MySqlCommand(query, Connection.Connection.OpenConnection());
                // variable used to store if an admin is present in db
                bool adminFound = false;
                // Execute reader
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    adminFound = true;
                }
                reader.Close();
                return adminFound;
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
        /// Method used to create the first admin user in the database
        /// </summary>
        /// <param name="adminUser"></param>
        /// <returns>Boolean indicating if the account was created</returns>
        /// <exception cref="Exception"></exception>
        public static bool CreateFirstAdminUser(User adminUser)
        {
            try
            {
                User? emailTaken = UserServices.GetUserByEmail(adminUser.email);
                // If email is taken, show error
                if (emailTaken is not null)
                {
                    Utils.Utils.ShowMessage("This email is already in use", "Invalid Email", "error");
                    return false;
                }

                // Create the user
                User? user = UserServices.CreateUser(adminUser);

                // Check if user was created
                if (user is null)
                {
                    return false;
                }
                User.LoggedInUser = user;
                Utils.Utils.ShowMessage("Admin user created successfully", "Admin Created");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
