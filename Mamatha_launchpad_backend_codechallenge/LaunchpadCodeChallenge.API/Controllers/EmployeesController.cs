using LaunchpadCodeChallenge.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult> GetEmployees()
        {
            return Ok(await _context.Employee.ToArrayAsync());
        }


        [HttpGet("/department/{departmentId}")]

        public async Task<ActionResult> GetDeptEmployees(int departmentId)
        {

            var department = await _context.Department.FindAsync(departmentId);

            if (department == null)
            {
                return NotFound();
            }
            return Ok(department);
        }


    }



    }

