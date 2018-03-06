using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreRest.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreRest.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/emp")]
    public class EmployeeController : Controller
    {

        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository empRepository)
        {
            this.employeeRepository = empRepository;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var employees = employeeRepository.GetAllEmployee();
            return Json(employees);
        }

        [HttpGet]
        [Route("first")]
        public IActionResult GetFirstEmployee()
        {
            var employees = employeeRepository.GetAllEmployee().FirstOrDefault();
            return Json(employees);
        }


        [HttpGet]
        [Route("{EmployeeId:guid}")]
        public IActionResult GetFirstEmployeeById(Guid EmployeeId)
        {
            if (EmployeeId == Guid.Empty)
            {
                return Json("Not a valid ID");
            }

            var Employee = employeeRepository.GetEmployeerById(EmployeeId);
            return Json(Employee);
            }











        //    // GET: api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
