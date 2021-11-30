using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bit2C.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DAL
{
    public class Repository<T> : IRepository<T> where T : class 
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ILogger<Repository<T>> _logger;
        public DbSet<T> Table { get; set; }

        public Repository(ApplicationDbContext dbContext, ILogger<Repository<T>> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
            Table = _dbContext.Set<T>();
        }
        public IQueryable<T> Query()
        {
            return Table.AsQueryable();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _dbContext.FindAsync<T>(id);
        }

        public async Task InsertAsync(T entity)
        {
            try
            {
                await Table.AddAsync(entity);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(T entity)
        {
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

    }
}
