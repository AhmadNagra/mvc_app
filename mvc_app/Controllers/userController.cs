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
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult userpage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult userpage(UserModel model)
        {
            if (ModelState.IsValid)
            {
                checkInfo(model.Name,model.Email,model.Comments);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        private void checkInfo(string name, string email, string comments)
        {
           
        }
    }
}