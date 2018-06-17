using Domain.Entities.People;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class UserInitializer : DropCreateDatabaseAlways<TAMGA_DbContext>
    {
        public override void InitializeDatabase(TAMGA_DbContext context)
        {
            
            context.Users.Add(new User() { Name = "Анна", Patronymic = "Петровна", Surname = "Соколова", Employed = false, OrganizationName = " ДеТек", PhoneNumber = "0635478219", StartOnUtc = DateTime.Now });
            context.Users.Add(new User() { Name = "Евгений", Patronymic = "Владимирович", Surname = "Скороходько", Employed = false, OrganizationName = "Интекс", PhoneNumber = "0678548798", StartOnUtc = DateTime.Now });
            context.Users.Add(new User() { Name = "Григорий", Patronymic = "Эдуардович", Surname = "Поляков", Employed = false, OrganizationName = "Спартекс", PhoneNumber = "0658789654", StartOnUtc = DateTime.Now });
            context.Users.Add(new User() { Name = "Светлана", Patronymic = "Анатольевна", Surname = "Белозёрская", Employed = true, OrganizationName = "Incom", PhoneNumber = "0664152587", StartOnUtc = DateTime.Now });

            base.InitializeDatabase(context);
        }

    }
}
