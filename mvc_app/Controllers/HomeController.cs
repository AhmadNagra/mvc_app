using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
namespace mvc_app.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {

            return View();
        }
        
      

        [HttpGet]
        public IActionResult mypage()
        
        {
            return View();
        }
        [HttpPost]
        public IActionResult mypage( String name)
        {
            return View();
        }
    }
}
