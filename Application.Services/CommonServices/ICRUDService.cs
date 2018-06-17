using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CommonServices
{
   public  interface ICRUDService<TEntity> where TEntity : class
    {
        Guid Create(TEntity item);
        TEntity FindById(int id);
        IEnumerable<TEntity> Get();       
        void Remove(TEntity item);
        void Update(TEntity item);
    }
}
