using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManger.Domain
{
    public interface IDepartmentDataStore
    {
        IQueryable<Employee> Employees { get; }
        IQueryable<Department> Departments { get; }

        void Save();
    }
}
