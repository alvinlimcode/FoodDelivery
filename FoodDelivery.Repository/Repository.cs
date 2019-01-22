using FoodDelivery.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private ApplicationDbContext _dbContext;
        private DbSet<T> entities;

        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            entities = _dbContext.Set<T>();
        }

        public async Task DeleteAsync(long id)
        {
            var selectedEntity = await GetAsync(id);

            if (selectedEntity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entities.Remove(selectedEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteMultipleAsync(IList<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }

            foreach (var entity in entities)
            {
                entities.Remove(entity);
            }

            await _dbContext.SaveChangesAsync();
        }

        public async Task<T> GetAsync(long id)
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(q => q.Id == id);
        }

        public IQueryable<T> GetAll()
        {
            return entities.AsQueryable();
        }

        public async Task InsertAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task InsertMultipleAsync(IList<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }

            await _dbContext.AddRangeAsync(entities);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }

            entity.UpdatedDate = DateTime.Now;

            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateMultipleAsync(IList<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }

            foreach (var entity in entities)
            {
                entity.UpdatedDate = DateTime.Now;
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
