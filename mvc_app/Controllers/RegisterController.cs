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

        private FileManager FManager;
        private IConfiguration configuration;
        private  readonly string ApiUrl;
        private ApiHandler Handler; 

        public RegisterController(IConfiguration iConfig)
        {
            configuration = iConfig;
            FManager = new FileManager(configuration.GetSection("Manual_Settings").GetSection("FilePath").Value);
            ApiUrl = configuration.GetSection("Manual_Settings").GetSection("ApiUrl").Value;
            Handler = new ApiHandler(new Uri(ApiUrl));
        }

    
        public IActionResult InputView(StudentRegisterationModel M)
        {       
            if (M == null) { return View(); }
            return View(M);
        }
        

        public async Task<IActionResult> OutputView(int id=0, string type="")
        {
            if (id != 0)
            {
                if (type == "Delete")
                  await  DeleteRecord(id);
                
                else if (type =="Edit")
                    await EditRecord(id);
            }
            try
            {
                StudentList = Handler.GetStudents().Result;
            }
            catch (Exception e)
            {
                Content(e.ToString());
            }
            return View(StudentList);
          
        }
      
        [HttpPost]
        public async Task<IActionResult> OutputView(StudentRegisterationModel M)
        {
            if (M.file == null) return Content("files not selected");
            await FManager.UploadFileAsync(M);
           
            try
            {
               
                    await Handler.SaveUser(M);
            }catch (Exception e) { Content(e.ToString()); }
                try
            {
                StudentList = Handler.GetStudents().Result;
            }catch (Exception e)
            {
                Content(e.ToString());
            }
            return View(StudentList);
        }
       
        public IActionResult DownloadFile(string filename)
        {
            if (filename == null) return Content("filename is empty.");
           return FManager.DownloadFileAsync(filename).Result;
        }
        public async Task<IActionResult> DeleteRecord(int id)
        {
            StudentRegisterationModel M = new StudentRegisterationModel();
            M.id = id;
            await Handler.DeleteUser(M);
           return RedirectToAction("OutputView");

        }
        public async void AddRecord(StudentRegisterationModel M)
        {        
            try
            {
                await Handler.UpdateUser(M);
            }
            catch (Exception e) { Content(e.ToString()); }
            
        }
        public async Task<IActionResult> EditRecord(int id)
        {
            StudentRegisterationModel M = new StudentRegisterationModel();
            M.id = id;
            RedirectToAction("InputView", M);
            try
            {
                await Handler.UpdateUser(M);
            }catch (Exception e)
            {
                Content(e.ToString());
            }
            return RedirectToAction("OutputView");
        }
       
    }

}                                                              