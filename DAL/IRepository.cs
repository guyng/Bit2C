using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Query();

        Task<T> GetAsync(int id);

        Task InsertAsync(T entity);

        Task UpdateAsync(T entity);

        Task RemoveAsync(T entity);
	}
}
