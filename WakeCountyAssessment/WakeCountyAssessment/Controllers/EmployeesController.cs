using Microsoft.AspNetCore.Mvc;

namespace WakeCountyAssessment.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private static List<Employees> _employees = new List<Employees>() {
            new Employees(1, "Alberta", "Jackson", "Finance", new DateTime(2007, 6, 5)),
            new Employees(2, "Alicia", "Bennett", "Human Resources", new DateTime(2001, 4, 15)), 
            new Employees(3, "Donna", "Avent", "Revenue", new DateTime(2009, 4, 20)),
            new Employees(4, "Duane", "Holder", "Human Services", new DateTime(2020, 8, 15))
        };


        private readonly ILogger<EmployeesController> _logger;

        public EmployeesController(ILogger<EmployeesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
            return _employees.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).Select(x => new { LastName = x.LastName, FirstName = x.FirstName, Department = x.Department }).ToList();
        }

        [HttpGet("{id}/")]
        public IEnumerable<Employees> Get(int id)
        {
            return _employees.Where(x => x.ID == id);
        }

        [HttpPost]
        public Employees Add(int id, string firstname, string lastname, string department, DateTime hiredate)
        {
            Employees tempEmployee = new Employees(id, firstname, lastname, department, hiredate);

            _employees.Add(tempEmployee);

            return tempEmployee;
        }
    }
}