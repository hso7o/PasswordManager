using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Context;

namespace Database.UnitofWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PasswordManagerDBContext _passwordManagerDBContext;

        public UnitOfWork(PasswordManagerDBContext passwordManagerDBContext)
        {
            _passwordManagerDBContext = passwordManagerDBContext;
        }


        public async Task<int> SaveChangesAsync() => await _passwordManagerDBContext.SaveChangesAsync();

        public async Task BeginTransactionAsync() => await _passwordManagerDBContext.Database.BeginTransactionAsync();

        public async Task CommitTransactionAsync() => await _passwordManagerDBContext.Database.CommitTransactionAsync();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _passwordManagerDBContext.Dispose();
            }
        }
    }
}
