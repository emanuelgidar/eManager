using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eManger.Domain;

namespace eManager.Web.Infrastructure
{
    public class DepartmentDB : DbContext, IDepartmentDataStore
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


        public DepartmentDB()
            : base("DefaultConnection")
        { }

        void IDepartmentDataStore.Save()
        {
            SaveChanges();
        }

        IQueryable<Employee> IDepartmentDataStore.Employees
        {
            get { return Employees; }
        }

        IQueryable<Department> IDepartmentDataStore.Departments
        {
            get { return Departments; }
        }
    }
}