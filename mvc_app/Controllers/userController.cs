using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;

namespace mvc_app.Controllers
{
    public class UserController : Controller
    {
        private IHostingEnvironment hostingEnvironment;
       
        public UserController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Upload(List<IFormFile> file)
        {
            var ListModel = new FileModel();
            foreach (var files in file)
            {
                var path = Path.Combine(hostingEnvironment.WebRootPath, "images", files.FileName);
                var stream = new FileStream(path, FileMode.Create);
                files.CopyToAsync(stream);
                ViewBag.file = files.FileName;
                var modelData = new FileAttribute();
                modelData.Names = files.FileName;
                modelData.path = path;
              
                ListModel.FilePath.Add(modelData);
            }
            return View(ListModel);
        }

        

        public FileResult Download()
        {
            var path = Path.Combine(hostingEnvironment.WebRootPath, "images","formicon.png");
            var stream = new FileStream(path, FileMode.Open);
            
            return File(stream, "image/jpg","dummy.jpg");
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