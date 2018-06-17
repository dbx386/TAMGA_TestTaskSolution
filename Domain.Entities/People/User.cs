using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.People
{
    public class User: BaseEntity
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public bool Employed { get; set; }
        public string OrganizationName { get; set; }
        public DateTime StartOnUtc { get; set; }
    }
}
