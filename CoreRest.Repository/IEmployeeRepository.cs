using CoreRest.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreRest.Repository
{
    public interface IEmployeeRepository
    {
        IReadOnlyList<Employee> GetAllEmployee();
        Employee GetEmployeerById(Guid EmployeeId);
        List<Profile> GetAllProfile();
    }
}
