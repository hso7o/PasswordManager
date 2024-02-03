using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Database.Context;
using Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly PasswordManagerDBContext _dbContext;
        private readonly DbSet<T> _entities;

        protected GenericRepository(PasswordManagerDBContext context)
        {
            _dbContext = context ?? throw new ArgumentNullException(nameof(context));
            _entities = _dbContext.Set<T>();
        }

        public async Task<T> GetById(int id) => await _entities.FindAsync(id);

        public async Task<IEnumerable<T>> GetAll() => await _entities.ToListAsync();

        public async Task Add(T entity) => await _entities.AddAsync(entity);

        public async Task Delete(T entity) => await _entities.SingleDeleteAsync(entity);

        public async Task Update(T entity) => await _entities.SingleUpdateAsync(entity);

        public async Task<T> FindByConditionAsync(Expression<Func<T, bool>> predicate) => await _entities.FirstOrDefaultAsync(predicate);
    }
}
