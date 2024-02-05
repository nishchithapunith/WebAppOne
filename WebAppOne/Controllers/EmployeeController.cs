using Microsoft.AspNetCore.Mvc;
using WebAppOne.Models;

namespace WebAppOne.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> listemployees = new List<Employee>()
        {
            new Employee{Id=1,Name="sam",Designation="Manager",Salary=98000,DOJ=new DateTime(day:12,month:1,year:2021)},
            new Employee{Id=2,Name="Amit",Designation="Developer",Salary=75000,DOJ=new DateTime(day:22,month:11,year:2022)},
            new Employee{Id=3,Name="Raj",Designation="Developer",Salary=76000,DOJ=new DateTime(day:22,month:10,year:2022)},
            new Employee{Id=4,Name="Ravi",Designation="Developer",Salary=74000,DOJ=new DateTime(day:08,month:06,year:2021)},
            new Employee{Id=5,Name="Sonam",Designation="Developer",Salary=73000,DOJ=new DateTime(day:07,month:10,year:2021)},
            new Employee{Id=6,Name="Vini",Designation="Developer",Salary=95000,DOJ=new DateTime(day:01,month:1,year:2022)},
            new Employee{Id=7,Name="Viraj",Designation="Developer",Salary=94000,DOJ=new DateTime(day:01,month:06,year:2020)},

        };
        
        public IActionResult Index()
        {
            return View(listemployees);
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View(new Employee());
        }
        [HttpPost]


        public IActionResult Create(Employee employee)
        {
            if (employee != null)
            {
                if (ModelState.IsValid)
                {
                    listemployees.Add(employee);
                    return RedirectToAction("Index");

                }

            }

            return View(employee);
        }

    } 
}
