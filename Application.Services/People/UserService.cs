using Application.Services.CommonServices;
using Application.Services.DTOs.People;
using Domain.Entities.People;
using Domain.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.People
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Guid Create(UserDTO item)
        {
           var newUserId = _unitOfWork.UserRepository.Create(new User()
            {
                Name = item.Name,
                Employed = item.Employed,
                OrganizationName = item.OrganizationName,
                Patronymic = item.Patronymic,
                PhoneNumber = item.PhoneNumber,
                StartOnUtc = item.StartOnUtc,
                Surname = item.Surname
            }).Id;
            _unitOfWork.Save();
            return newUserId;
        }

        public UserDTO FindById(Guid id)
        {
            var findResult = _unitOfWork.UserRepository.FindById(id);
            if (findResult != null)
            {
                return new UserDTO()
                {
                    Id = findResult.Id,
                    Name = findResult.Name,
                    Employed = findResult.Employed,
                    OrganizationName = findResult.OrganizationName,
                    Patronymic = findResult.Patronymic,
                    PhoneNumber = findResult.PhoneNumber,
                    StartOnUtc = findResult.StartOnUtc,
                    Surname = findResult.Surname
                };
            }
            else
            {
                return null;
            }
        }

        public async Task<List<UserDTO>> GetAsync()
        {
            List<UserDTO> userDTOs = new List<UserDTO>();

            var allUsers = await _unitOfWork.UserRepository.GetAsync();
            foreach (var item in allUsers)
            {
                userDTOs.Add( new UserDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Employed = item.Employed,
                    OrganizationName = item.OrganizationName,
                    Patronymic = item.Patronymic,
                    PhoneNumber = item.PhoneNumber,
                    StartOnUtc = item.StartOnUtc,
                    Surname = item.Surname
                });
            }
            return await Task.FromResult(userDTOs);
        }

        public void Remove(Guid id)
        {
             _unitOfWork.UserRepository.Remove(id);
            _unitOfWork.Save();
        }

        public void Remove(UserDTO item)
        {
            var userOnDeleting = new User()
            {
                Id = item.Id,
                Name = item.Name,
                Employed = item.Employed,
                OrganizationName = item.OrganizationName,
                Patronymic = item.Patronymic,
                PhoneNumber = item.PhoneNumber,
                StartOnUtc = item.StartOnUtc,
                Surname = item.Surname
            };

            _unitOfWork.UserRepository.Remove(userOnDeleting);
            
        }

        public void Update(UserDTO item)
        {
            var userOnUpdating = new User()
            {
                Id = item.Id,
                Name = item.Name,
                Employed = item.Employed,
                OrganizationName = item.OrganizationName,
                Patronymic = item.Patronymic,
                PhoneNumber = item.PhoneNumber,
                StartOnUtc = item.StartOnUtc,
                Surname = item.Surname
            };
            _unitOfWork.UserRepository.Update(userOnUpdating);
            _unitOfWork.Save();
        }
    }
}
