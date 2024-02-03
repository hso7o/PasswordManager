using Database.Context;
using Database.Core.Entities;
using Database.Interfaces;

namespace Database.Repositories
{
    public class SettingsRepository : GenericRepository<Settings>, ISettingsRepository
    {
        public SettingsRepository(PasswordManagerDBContext context) : base(context)
        {
        }
    }
}
