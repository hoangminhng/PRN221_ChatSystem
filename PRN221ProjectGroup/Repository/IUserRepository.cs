using BusinessObject.Models;

namespace PRN221ProjectGroup.Repository;

public interface IUserRepository
{
    IEnumerable<User> GetUsers();
}