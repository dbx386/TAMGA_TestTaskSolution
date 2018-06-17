using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.GenericRepository
{
    public class EFGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        TAMGA_DbContext _context;
        DbSet<TEntity> _dbSet;

        public EFGenericRepository(TAMGA_DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public async Task<IList<TEntity>> GetAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }
        public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate);
        }
        public TEntity FindById(Guid id)
        {
            return _dbSet.Find(id);
        }
        public TEntity Create(TEntity item)
        {
           var newEntry = _dbSet.Add(item);
            
            return newEntry;
        }
        public void Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            
        }
        public void Remove(Guid id)
        {
            var EntityOnRemoving = _dbSet.Find(id);
            Remove(EntityOnRemoving);
        }

            public void Remove(TEntity item)
        {
            if (_context.Entry(item).State == EntityState.Detached)
            {
                _dbSet.Attach(item);
            }
            _dbSet.Remove(item);
            
        }
    }
}
