using BusinessObject.Models;
using PRN221ProjectGroup.DataAccessLayer;

namespace PRN221ProjectGroup.Repository;

public class UserRepository : IUserRepository
{
    public IEnumerable<User> GetUsers()
    {
        return UserDao.Instance.GetAll();
    }
}