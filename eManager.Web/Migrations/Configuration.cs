using eManger.Domain;
namespace eManager.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;

    internal sealed class Configuration : DbMigrationsConfiguration<eManager.Web.Infrastructure.DepartmentDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(eManager.Web.Infrastructure.DepartmentDB context)
        {
            context.Departments.AddOrUpdate(d => d.Name,
                    new Department() { Name = "Engeneering" },
                    new Department() { Name = "Sales" },
                    new Department() { Name = "Shipping" },
                    new Department() { Name = "Human Resources" }
                 );
            //if (!Roles.RoleExists("Admin"))
            //{
            //    Roles.CreateRole("Admin");
            //}
            //if (Membership.GetUser("gapp") == null)
            //{
            //    Membership.CreateUser("gapp", "Bsketball1");
            //    Roles.AddUserToRole("gapp", "Admin");
            //}
        }
    }
}
