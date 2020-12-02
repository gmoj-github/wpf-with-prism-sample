namespace DataModels
{
    public class User : IUser
    {
        public string Name { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public User(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
        }
    }
}
