using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using mvc_app.Models;

namespace mvc_app.Controllers
{
    public class RegisterController : Controller
    {
        private  static List<StudentRegisterationModel> StudentList = new List<StudentRegisterationModel>();
        private  string FilePath;
        private IConfiguration configuration;
        public RegisterController(IConfiguration iConfig)
        {
            configuration = iConfig;
            FilePath =configuration.GetSection("Manual_Settings").GetSection("FilePath").Value;
        }

        public IActionResult InputView()
        {          
            return View();
        }
        public IActionResult OutputView()
        {
            return View(StudentList);
        }
        [HttpPost]
        public async Task<IActionResult> OutputView(StudentRegisterationModel M)
        {         
            if (M.file == null )    
                return Content("files not selected");           
                var path = Path.Combine(Directory.GetCurrentDirectory(),FilePath, M.file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await M.file.CopyToAsync(stream);
                }
            M.filename = M.file.FileName;
            StudentList.Add(M);
            return View(StudentList);
        } 
        public async Task<IActionResult> DownloadFile(string filename)
        {
            if (filename == null) return Content("filename is empty.");
            var path =
               Path.Combine(Directory.GetCurrentDirectory(), FilePath, filename);
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
        public void ConnectToApi()
        {
            string ApiUrl = configuration.GetSection("Manual_Settings").GetSection("ApiUrl").Value;
            //Note that this will only get the base point
            //StudentRegisterations will have to entered later. 
            OutputView();
        }
    }

}                                                              