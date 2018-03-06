using System;
using System.Collections.Generic;
using System.Text;
using CoreRest.Model;
using System.Linq;

namespace CoreRest.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IData database;

        public EmployeeRepository(IData database)
        {
            this.database = database;
        }

        public IReadOnlyList<Employee> GetAllEmployee()
        {
            return database.Employees();
        }

        public List<Profile> GetAllProfile()
        {
            return database.Profile();
        }

        public Employee GetEmployeerById(Guid EmployeeId)
        {
            return database.Employees().Where(u=>u.EmployeeId==EmployeeId).FirstOrDefault();             
        }
    }
}
