using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace mvc_app.Models
{
    public class User
    {


        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Select Employe_Role Name")]
        public string Employe_Role { get; set; }

        public string Address { get; set; }

     
        public  string file { get; set; }
        public IFormFile datafile { get; set; }


    }
}
