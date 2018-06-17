using Application.Services.DTOs.Common;
using Application.Services.DTOs.EntityValidators;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Application.Services.DTOs.People
{
    public class UserDTO : BaseEntityDTO
    {
        [DisplayName("Трудоустроен")]
        public bool Employed { get; set; }
        [CustomValidator]
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [CustomValidator]
        [DisplayName("Имя")]
        public string Name { get; set; }
        [CustomValidator]
        [DisplayName("Отчество")]
        public string Patronymic { get; set; }
        [CustomValidator]
        [DisplayName("Номер телефона")]
        public string PhoneNumber { get; set; }      
        [CustomValidator]
        [DisplayName("Организация")]
        public string OrganizationName { get; set; }
        [CustomValidator]
        [DisplayName("Дата приема на работу")]
        public DateTime StartOnUtc { get; set; }       
    }
}
