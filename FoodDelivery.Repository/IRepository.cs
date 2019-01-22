using FoodDelivery.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Repository
{
    public interface IRepository<T> where T: BaseEntity
    {
        IQueryable<T> GetAll();

        Task<T> GetAsync(long id);

        Task InsertAsync(T entity);

        Task InsertMultipleAsync(IList<T> entities);

        Task UpdateAsync(T entity);

        Task UpdateMultipleAsync(IList<T> entities);

        Task DeleteAsync(long id);

        Task DeleteMultipleAsync(IList<T> entities);
    }
}
