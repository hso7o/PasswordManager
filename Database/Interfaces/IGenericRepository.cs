﻿using System.Linq.Expressions;

namespace Database.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        Task Delete(T entity);
        Task Update(T entity);
        Task<T> FindByConditionAsync(Expression<Func<T, bool>> predicate);
    }
}
