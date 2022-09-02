using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstmvcproject.Models;


namespace firstmvcproject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudList()
        {
            List<Student> students = new List<Student>()
            {
                new Student{RollNo=1,Name="Bhagyashri",Percentage=35000},
                new Student{RollNo=2,Name="Sushma",Percentage=39000},
                new Student{RollNo=3,Name="Pratiksha",Percentage=40000},
                new Student{RollNo=4,Name="Omkar",Percentage=33000},
                new Student{RollNo=5,Name="Prashant",Percentage=30000},
            };
            ViewData["studentList"] = students;

            ViewBag.Students = students;

            return View();
        }
    }
}
