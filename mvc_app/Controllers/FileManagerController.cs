using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mvc_app.Controllers
{
    public class FileManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null) return Content("File Not Selected");
            var path =
                Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", file.FileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return RedirectToAction("Files");
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