using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using mvc_app.Models.Home;
using Microsoft.Extensions.FileProviders;
using mvc_app.Models;
using Microsoft.AspNetCore.Http;

namespace mvc_app.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFileProvider fileProvider;

        public HomeController(IFileProvider fileProvider)
        {
            this.fileProvider = fileProvider;
        }

        public IActionResult Index()
        {
            return View();
        }

     


        
        [HttpPost]
        public async Task<IActionResult> Validate(RegisteredUser u)
        {
            UserCollection Coltemp=new UserCollection();
            
            if (ModelState.IsValid)
            {
                var path = Path.Combine(
                    Directory.GetCurrentDirectory(), "wwwroot/Files",
                    u.SelectedFile.GetFilename());
                u.FileName = u.SelectedFile.GetFilename();
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await u.SelectedFile.CopyToAsync(stream);
                }

                Coltemp.Usercol.Add(u);
                return View(Coltemp);
            }

            return View("Index");
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
