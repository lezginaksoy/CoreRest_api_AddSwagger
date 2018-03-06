using System;
using System.Collections.Generic;
using System.Text;
using CoreRest.Model;
using CoreRest.Model.Enums;

namespace CoreRest.Repository
{
    public class DummyData: IData
    {
        public IReadOnlyList<Employee> Employees()
        {

            return new List<Employee> {
                new Employee {
                    EmployeeId = Guid.Parse("1238648F-3DBA-1234-8DF5-B5F0433053F8"),
                    Name = "Bob",
                    LastName = "Marley",
                    Profile = new Profile
                    {
                        ProfileId = Guid.Parse("1236BAE6-E7A1-4C4E-A77A-535CBDDA1234"),
                        ProfileCode = "A1234",
                        Skills = new List<Skills> { Skills.CoreMVC},
                        Department = new Department { DepartmentCode= "SW" ,DepartmentDesc="Software Development"}
                    }
                },
                 new Employee {
                    EmployeeId = Guid.Parse("54321648F-3DBA-1234-8DF5-B5F0433053F8"),
                    Name = "Jack",
                    LastName = "London",
                    Profile = new Profile
                    {
                        ProfileId = Guid.Parse("54321BAE6-E7A1-4C4E-A77A-535CBDDA1234"),
                        ProfileCode = "B1234",
                        Skills = new List<Skills> { Skills.Scala},
                        Department = new Department { DepartmentCode= "PS" ,DepartmentDesc="Professional Services"}
                    }
                },
                 new Employee {
                    EmployeeId = Guid.Parse("64321648F-3DBA-1234-8DF5-B5F0433053F8"),
                    Name = "Mark",
                    LastName = "Twain",
                    Profile = new Profile
                    {
                        ProfileId = Guid.Parse("84321BAE6-E7A1-4C4E-A77A-535CBDDA1234"),
                        ProfileCode = "C1234",
                        Skills = new List<Skills> { Skills.Scala},
                        Department = new Department { DepartmentCode= "SW" ,DepartmentDesc="Software Development "}
                    }
                }

                };
           
        }

        public List<Profile> Profile()
        {
            return new List<Profile>
           {
                new Profile
                {
                    ProfileId = Guid.Parse("1236BAE6-E7A1-4C4E-A77A-535CBDDA9999"),
                        ProfileCode = "D1234",
                        Skills = new List<Skills> { Skills.Go},
                        Department = new Department { DepartmentCode= "SW" ,DepartmentDesc="Software Development"}
                },
                new Profile
                {
                    ProfileId = Guid.Parse("8886BAE6-E7A1-4C4E-A77A-535CBDDA9999"),
                        ProfileCode = "E1234",
                        Skills = new List<Skills> { Skills.SpringMVC},
                        Department = new Department { DepartmentCode= "SW" ,DepartmentDesc="Software Development"}
                },
                new Profile
                {
                    ProfileId = Guid.Parse("7777BAE6-E7A1-4C4E-A77A-535CBDDA9999"),
                        ProfileCode = "D1234",
                        Skills = new List<Skills> { Skills.CoreMVC},
                        Department = new Department { DepartmentCode= "SW" ,DepartmentDesc="Software Development"}
                }
                

           };


        }

       
    }
}
