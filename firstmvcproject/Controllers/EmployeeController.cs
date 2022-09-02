using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstmvcproject.Models;

namespace firstmvcproject.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmpList()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Id=101,Name="Bhagyashri",Salary=35000},
                new Employee{Id=102,Name="Kartik",Salary=39000},
                new Employee{Id=103,Name="Sagar",Salary=40000},
                new Employee{Id=104,Name="Rutuja",Salary=33000},
                new Employee{Id=105,Name="Sam",Salary=30000},
            };
            ViewData["employeelist"] = employees;

            ViewBag.Employees = employees;

            return View();
        }
    }
}
