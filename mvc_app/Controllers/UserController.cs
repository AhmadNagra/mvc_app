using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Employe_Form.Models;
using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;

namespace mvc_app.Controllers
{
    public class UserController : Controller
    {
        List<User> emplist = new List<User>();
      
        public IActionResult Emp_View()
        {
            return View();
        }

        public async Task<IActionResult> UploadFiles(User form)
        {
            if (form.datafile == null || form.datafile.Length == 0)
                return Content("file not selected");

            var path = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot/Files",
                   form.datafile.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await form.datafile.CopyToAsync(stream);
                form.file = form.datafile.FileName;
            }
           
            API_Controller app = new API_Controller(new Uri("https://localhost:44347/api/"));
            emplist = app.GetUsers().Result;
            await app.SaveUser(form);
            emplist.Add(form);
         
            return View(emplist);
        }
      
       
            public async Task<IActionResult> Download(string filename)
            {
                if (filename == null)
                    return Content("filename not present");

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files", filename);

                var memory = new MemoryStream();
                using (var stream = new FileStream(path, FileMode.Open))
                {
                    await stream.CopyToAsync(memory);
                }
                memory.Position = 0;
                return File(memory, GetContentType(path), Path.GetFileName(path));
            }

            private string GetContentType(string path)
            {
                var types = GetMimeTypes();
                var ext = Path.GetExtension(path).ToLowerInvariant();
                return types[ext];
            }
        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"},
                {".cs","text/plain" }
            };
        }
        
    }
}