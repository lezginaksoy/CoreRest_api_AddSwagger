using System;
using System.Collections.Generic;
using System.Text;

namespace CoreRest.Model
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Profile Profile { get; set; }
    }
}
