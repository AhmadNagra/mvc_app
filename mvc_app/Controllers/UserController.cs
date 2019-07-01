using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;

namespace mvc_app.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Emp_View()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Emp_View(User model)

        //{
        //    int id = model.Id;
        //    string Name = model.Name;
        //    string Employe_Role = model.Employe_Role;
        //    string Address = model.Address;
        //    string File=model.File;
        //    ModelState.Clear();
        //        return View();
        //}
        
    }
}