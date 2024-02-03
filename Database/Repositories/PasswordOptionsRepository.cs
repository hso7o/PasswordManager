using Database.Context;
using Database.Core.Entities;
using Database.Interfaces;

namespace Database.Repositories
{
    public class PasswordOptionsRepository : GenericRepository<PasswordOptions>, IPasswordOptionsRepository
    {
        public PasswordOptionsRepository(PasswordManagerDBContext context) : base(context)
        {
        }
    }
}
