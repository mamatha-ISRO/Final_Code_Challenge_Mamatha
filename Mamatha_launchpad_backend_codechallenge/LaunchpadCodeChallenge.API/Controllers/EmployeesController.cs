using LaunchpadCodeChallenge.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaunchpadCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeManagerContext _context;
        public EmployeesController(EmployeeManagerContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }


        [HttpGet]
        public async Task<IEnumerable<Employees>> GetEmployees()
        {
            var employees = await _context.Employee.ToList();
            return Ok(employees);
        }


        [HttpGet("/department/{departmentId}")]

        public ActionResult<>GetDeptEmployees(int departmentId)  
        {

            var department = _context.Department.Find(departmentId);
        if (Department == null)
            {
             return NotFound();
               }
        return Ok(department);
        }

    

}

