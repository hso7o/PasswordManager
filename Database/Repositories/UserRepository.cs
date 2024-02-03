using Database.Context;
using Database.Core.Entities;
using Database.Interfaces;

namespace Database.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(PasswordManagerDBContext context) : base(context)
        {
        }
    }
}
