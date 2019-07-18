using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using mvc_app.Models;
using Newtonsoft.Json;

namespace mvc_app.Controllers
{
    public class LoginController : Controller
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private FileManager FManager;
        private IConfiguration configuration;
        private readonly string ApiUrl;
        private ApiHandler Handler;

        public LoginController(IConfiguration iConfig)
        {
            this.configuration = iConfig;
            this.FManager = new FileManager(configuration.GetSection("Manual_Settings").GetSection("FilePath").Value);
            this.ApiUrl = configuration.GetSection("Manual_Settings").GetSection("ApiUrl").Value;
            this.Handler = new ApiHandler(new Uri(ApiUrl));
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public async Task<bool> Validate(Login login)
        {
            //Logins?userName=sahar&stringPassword=12345678

            var completeGetString = "Logins?userName="+ login.UserName+"&stringPassword="+login.plainPassword;
            var response = await _httpClient.GetAsync(ApiUrl + completeGetString);
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<bool>(data);
        }

    }
}