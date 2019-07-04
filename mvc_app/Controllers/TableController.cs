using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;
using Newtonsoft.Json;

namespace mvc_app.Controllers
{
    public class TableController : Controller
    {
        public async Task<IActionResult> DeleteRecord(string selectedid)
        {
            var client = new HttpClient();

            UserCollection Coltemp = new UserCollection();
            string baseUrl = "https://localhost:44347/api/RegisteredUsers";// for get
            string Url = "https://localhost:44347/api/RegisteredUsers/" + selectedid;//for delete
            
            try
            {
                var response = await client.DeleteAsync(Url);
                using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        using (HttpContent content = res.Content)
                        {
                            var data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                List<RegisteredUser> test = JsonConvert.DeserializeObject<List<RegisteredUser>>(data);
                                foreach (var item in test)
                                {
                                    Coltemp.Usercol.Add(item);
                                }

                                Console.WriteLine("data------------{0}", data);
                            }
                            else
                            {
                                Console.WriteLine("NO Data----------");
                            }

                        }
                    }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Hit------------");
                Console.WriteLine(exception);
            }

            return View("Validate", Coltemp);
        }

        //public async Task<IActionResult> EditRecord(string selectedid)
        //{
        //    var client = new HttpClient();
        //    string baseUrl = "https://localhost:44347/api/RegisteredUsers";


        //}

        public async Task<IActionResult> RegisterUser()
        {
            return View("Index");
        }
        
    }
}