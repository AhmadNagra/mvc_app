using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;

namespace mvc_app.Controllers
{
    public class Employe_detailController : Controller
    {
        public IActionResult SetEmployeDetail(int Id,string Name,string Employe_Role,string Address)
        {
            User emp = new User();
            emp.Id = Id;
            emp.Address = Address;
            emp.Name = Name;
            emp.Employe_Role = Employe_Role;
            return View(emp);
        }
    }
}