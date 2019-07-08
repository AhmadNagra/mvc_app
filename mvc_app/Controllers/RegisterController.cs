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
        //private  static List<StudentRegisterationModel> StudentList = new List<StudentRegisterationModel>();
        private PaginationModel Pages = new PaginationModel();
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
            try
            {
                Pages.Count = Handler.GetTotalCount().Result;
            }catch(Exception e) { Content(e.ToString()); }

        }
    
        [HttpPost]
        public IActionResult InputView(StudentRegisterationModel M)
        {       
            if (M == null) { return View(); }
            return View(M);
        }     
        public IActionResult InputView(int id)
        {           
            return View(new StudentRegisterationModel(id));
        }
    
        public async Task<IActionResult> OutputView(int id=0, string type="",int pageNo=1,string sortBy="Id")
        {
            if (id != 0)
            {
                if (type == "Delete")
                  await  DeleteRecord(id);                        
            }           
            try
            {               
                Pages.StudentList = Handler.GetStudents(Pages.Currentpage=pageNo, sortBy, Pages.PageSize).Result;
            }
            catch (Exception e)
            {
                Content(e.ToString());
            }
            return View(Pages);       
        }
        [HttpPost]
  

        [HttpPost]
        public async Task<IActionResult> OutputView(StudentRegisterationModel M)
        {
            if (M.file == null) return Content("files not selected");
            await FManager.UploadFileAsync(M);               
            try
            {
                if (M.id != 0)
                    await EditRecord(M);
              
                else
                    await Handler.SaveUser(M);
            }
            catch (Exception e) { Content(e.ToString()); }
            try
            {
                Pages.Currentpage = 1;
                Pages.StudentList = Handler.GetStudents(1, "Id", Pages.PageSize).Result;
            }
            catch (Exception e) { Content(e.ToString()); }
            return View(Pages);
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
            try { await Handler.DeleteUser(M); }
            catch (Exception e) { Content(e.ToString()); }
            return RedirectToAction("OutputView");
        }
    
        public async Task<IActionResult> EditRecord(StudentRegisterationModel M)
        {
            try { await Handler.UpdateUser(M); }
            catch (Exception e) { Content(e.ToString()); }
            return RedirectToAction("OutputView");
        }       
     
    }
}                                                              