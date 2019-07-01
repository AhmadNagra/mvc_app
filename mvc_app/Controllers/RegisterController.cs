using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;

namespace mvc_app.Controllers
{
    public class RegisterController : Controller
    {
       
        public IActionResult InputView()
        {
            return View();
        }
        public IActionResult OutputView()
        {
            OutputClass X = new OutputClass();
            StudentRegisterationModel T = new StudentRegisterationModel();
            T.name = "Saad";T.detail = "I am tired of this.";T.program = "BS(CS)";
            X.StudentList.Add(T);
            return View(X);
        }
        public string Hi()
        {
            return "Hello";
        }
    }
}