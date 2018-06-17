namespace Domain.Repositories
{
    using Domain.Entities.Common;
    using Domain.Entities.People;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TAMGA_DbContext : DbContext
    {
        
        public TAMGA_DbContext(): base("name=TAMGA_DbContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer(new UserInitializer());                                 
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<User> Users { get; set; }
    }   
}