using DataModels;
using System.Collections.Generic;

namespace DataManager
{
    public class UserDAO : IUserDAO
    {
        public UserDAO()
        {

        }

        private List<User> _users = new List<User>()
        {
            new User("Gilson", "gmoj", "123456"),
            new User("Java", "jdk", "123456"),
            new User("Flutter", "dart", "123456")
        };

        public bool Save(IUser user)
        {
            _users.Add((User)user);

            return true;
        }

        public IList<User> ListAll()
        {
            return _users;
        }
    }
}
