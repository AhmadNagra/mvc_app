using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;

namespace mvc_app.Controllers
{
    public class RegisterController : Controller
    {
        private OutputClass X = new OutputClass();
       
   
        public IActionResult InputView()
        {          
            return View();
        }
      
        public IActionResult DecideView()
        {
            return null;
        }
        public IActionResult OutputView(StudentRegisterationModel M)
        {
            X.StudentList.Add(M);
          
            return View(X);
        }
        
    }
}