using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace mvc_app.Models
{
    public class User
    {
        [Required(ErrorMessage="Enter Id") ]
        public int   Id{ get;set; }

        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Select Employe_Role Name")]
        public string Employe_Role { get; set; }

        public string Address { get; set; }

        public IFormFile File { get; set; }

    }
}
