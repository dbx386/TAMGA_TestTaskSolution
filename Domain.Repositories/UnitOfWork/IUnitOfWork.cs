using Domain.Entities.People;
using Domain.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.UnitOfWork
{   
    public interface IUnitOfWork
    {
        #region People
        IGenericRepository<User> UserRepository { get;}
        #endregion

        void Save();

    }
}
