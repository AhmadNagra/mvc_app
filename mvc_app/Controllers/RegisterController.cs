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
        [HttpPost]
        public async Task<IActionResult> OutputView(StudentRegisterationModel M)
        {           
            if (M.file == null )
                return Content("files not selected");           
                var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot",
                        M.file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await M.file.CopyToAsync(stream);
                }
            
            //M.file = file;
            X.StudentList.Add(M);
            return View(X);
        } 
        public async Task<IActionResult> DownloadFile(string filename)
        {
            if (filename == null) return Content("filename is empty.");
            var path =
               Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", filename);
            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, filename.Substring(filename.LastIndexOf('.')), Path.GetFileName(path));

        }
    }

}
