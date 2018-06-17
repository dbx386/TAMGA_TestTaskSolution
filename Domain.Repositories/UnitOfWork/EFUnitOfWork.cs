using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.People;
using Domain.Repositories.GenericRepository;

namespace Domain.Repositories.UnitOfWork
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly TAMGA_DbContext context;

        public EFUnitOfWork()
        {
            context = new TAMGA_DbContext();
        }

        #region People
        private IGenericRepository<User> _userRepository;
        #endregion      
        
        public IGenericRepository<User> UserRepository  => _userRepository ?? (_userRepository = new EFGenericRepository<User>(context));

        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
