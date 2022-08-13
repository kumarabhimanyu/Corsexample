using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CorsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
       
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(new Employee { ID = 1, Name = "Abhimanyu", Address = "Delhi" });
            employeeList.Add(new Employee { ID = 2, Name = "Adarsh", Address = "Mumbai" });
            employeeList.Add(new Employee { ID = 3, Name = "Nishant", Address = "Pune" });
            employeeList.Add(new Employee { ID = 4, Name = "Rajeev", Address = "Noida" });
            employeeList.Add(new Employee { ID = 5, Name = "Manish", Address = "Bangalore" });

            return employeeList.ToArray();

        }
    }
}