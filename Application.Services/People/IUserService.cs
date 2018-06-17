using Application.Services.CommonServices;
using Application.Services.DTOs.People;
using Domain.Entities.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.People
{
    public interface IUserService
    {
        Guid Create(UserDTO item);
        UserDTO FindById(Guid id);
        Task<List<UserDTO>> GetAsync();
        void Remove(UserDTO item);
        void Remove(Guid item);
        void Update(UserDTO item);
    }
}
