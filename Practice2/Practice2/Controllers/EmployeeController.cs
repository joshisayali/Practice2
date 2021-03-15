using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practice2.Models;

namespace Practice2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Employee emp = new Employee();
            emp.Name = "John Doe";
            emp.Department = "Engineering";
            return View(emp);
        }
    }
}