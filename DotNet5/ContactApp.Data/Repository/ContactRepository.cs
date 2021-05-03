using ContactApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BC = BCrypt.Net.BCrypt;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ContactApp.Data.Repository
{
    public class ContactRepository<T> : IContactRepository<T> where T : BaseEntity
    {

        private readonly ContactDBContext _dbContext;

        public ContactRepository(ContactDBContext contactDb)
        {
            _dbContext = contactDb;
        }

        public async Task<T> GetById(Guid id) => await _dbContext.Set<T>().FindAsync(id);

        public Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate)
            => _dbContext.Set<T>().FirstOrDefaultAsync(predicate);

        public async Task Add(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public Task Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return _dbContext.SaveChangesAsync();
        }

        public Task Remove(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            return _dbContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<List<T>> GetAllWithPreload(string include) 
        {
            return await _dbContext.Set<T>().Include(include).ToListAsync();
        }

        public async Task<List<T>> GetAllWithPreloadWhere(Expression<Func<T, bool>> predicate, string include) 
        {
            return await _dbContext.Set<T>().Where(predicate).Include(include).ToListAsync();
        }

        public async Task<List<T>> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public Task<int> CountAll() => _dbContext.Set<T>().CountAsync();

        public Task<int> CountWhere(Expression<Func<T, bool>> predicate)
            => _dbContext.Set<T>().CountAsync(predicate);
    }
}
