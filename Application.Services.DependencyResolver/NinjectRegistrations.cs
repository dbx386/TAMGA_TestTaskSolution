using Application.Services.CommonServices;
using Application.Services.People;
using Domain.Repositories.UnitOfWork;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.DependencyResolver
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>();

            #region UserService
            Bind<IUserService>().To<UserService>();           
            #endregion
        }
    }
}
