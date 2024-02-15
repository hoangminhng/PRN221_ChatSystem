using BusinessObject.Models;

namespace PRN221ProjectGroup.DataAccessLayer;

public class UserDao : BaseDao<User>
{
    private UserDao()
    {
    }

    private static UserDao instance = null;
    private static readonly object instacelock = new object();


    public static UserDao Instance
    {
        get
        {
            lock (instacelock)
            {
                if (instance == null)
                {
                    instance = new UserDao();
                }

                return instance;
            }
        }
    }
}