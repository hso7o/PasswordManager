using Database.Context;
using Database.Core.Entities;
using Database.Interfaces;

namespace Database.Repositories
{
    public class PasswordRepository : GenericRepository<Password>, IPasswordRepository
    {
        public PasswordRepository(PasswordManagerDBContext context) : base(context)
        {
        }
    }
}
