using System;
using System.Linq;
using System.Threading.Tasks;
using DIMS_Core.DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    /// <summary>
    ///     TODO: Task #1
    ///     Implement all methods
    ///     Generic Repository
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private readonly DbContext _context;
        protected readonly DbSet<TEntity> Set;

        protected Repository(DbContext context)
        {
            _context = context;
            Set = context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return Set;
        }

        public async Task<TEntity> GetById(int id)
        {
            if (id == 0)
            {
                // TODO: Task #3
                // Create custom exception for invalid arguments
                // based on abstract class BaseException
                // throw new AnyException(string paramName);
            }

            // TODO: type must be adjusted to entity type accordingly
            //object objectFromDB = null;

            var objectFromDB = await Set.FindAsync(id);

            if (objectFromDB is null)
            {
                // TODO: Task #4
                // Create custom exception for non existed object in database
                // based on abstract class BaseException
                // throw new AnyException(string methodName, string message);
            }

            // RECOMMEND: It's better to create a helper static class for errors instead of throwing them
            // Ask us if you stucked and it looks ridiculous for you

            //throw new NotImplementedException();

            return objectFromDB;
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            var entityReturned = await Set.AddAsync(entity);
            return entityReturned.Entity;
        }

        public TEntity Update(TEntity entity)
        {
            var entityUpdated = Set.Update(entity);
            return entityUpdated.Entity;
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            Set.Remove(entity);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        /// <summary>
        ///     In most cases this method is not important because our context will be disposed by IoC automatically.
        ///     But if you don't know where will use your service better to specify this method (example, class library).
        /// </summary>
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}