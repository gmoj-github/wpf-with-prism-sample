using DataModels;
using System.Collections.Generic;

namespace DataManager
{
    public interface IUserDAO
    {
        bool Save(IUser user);

        IList<User> ListAll();
    }
}