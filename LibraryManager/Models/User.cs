namespace LibraryManager.Models
{
    public class User
    {
        // Constructor used to set a full user with ID
        public User(int? id, string name, string email, string password, string role = "staff")
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
        }
        // Constructor used to set login User data
        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        // Constructor to set user with no ID
        public User(string name, string email, string password, string role = "staff")
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
        }

        // Constructor to set user with no Password
        public User(int id, string name, string email, string role = "staff")
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.role = role;
        }

        // PROPS
        public int? id { get; set; }
        public string name { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string role { get; set; } = string.Empty;


        // Get & set the logged in user
        public static User? LoggedInUser { get; set; } = null;

    }


}
